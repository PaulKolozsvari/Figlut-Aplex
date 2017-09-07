namespace Figlut.Desktop.Utilities
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Linq.Expressions;
    using System.Reflection;
using System.Data;

    #endregion //Using Directives

    public class EntityReader<E>
    {
        #region Methods

        public static DataTable GetDataTable(bool shapeColumnNames)
        {
            DataTable result = new DataTable();
            Type t = typeof(E);
            foreach (PropertyInfo p in t.GetProperties())
            {
                Type propertyType = p.PropertyType;
                if (p.PropertyType.IsGenericType && p.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                {
                    propertyType = p.PropertyType.GetGenericArguments()[0];
                }
                if (propertyType == typeof(Boolean))
                {
                    propertyType = typeof(String);
                }
                string columnName = shapeColumnNames ? DataShaper.FormatEntityColumnName(p.Name) : p.Name;
                result.Columns.Add(new DataColumn(columnName)
                {
                    Caption = p.Name,
                    DataType = propertyType
                });
            }
            return result;
        }

        public static string GetPropertyName<TProp>(Expression<Func<E, TProp>> expression, bool shapePropertyName)
        {
            var body = expression.Body as MemberExpression;
            if (body == null) throw new ArgumentException("'expression' should be a member expression");
            if (shapePropertyName)
            {
                return DataShaper.FormatEntityColumnName(body.Member.Name);
            }
            return body.Member.Name;
        }

        public static object GetPropertyValue(string propertyName, E entity, bool useDBNull)
        {
            PropertyInfo p = typeof(E).GetProperty(propertyName);
            object result = p.GetValue(entity, null);
            if (useDBNull && (result == null))
            {
                result = DBNull.Value;
            }
            return result;
        }

        public static Type GetPropertyType<TProp>(Expression<Func<E, TProp>> expression)
        {
            var body = expression.Body as MemberExpression;
            if (body == null) throw new ArgumentException("'expression' should be a member expression");
            return typeof(E).GetProperty(body.Member.Name).PropertyType;
        }

        public static E PopulateFromDataRow(E entity, DataRow row)
        {
            Type entityType = typeof(E);
            foreach (DataColumn c in row.Table.Columns)
            {
                PropertyInfo p = entityType.GetProperty(c.Caption);
                if (p == null)
                {
                    continue;
                }
                object value = null;
                if (p.PropertyType == typeof(string))
                {
                    value = row[c.ColumnName];
                }
                if (p.PropertyType == typeof(Guid))
                {
                    value = new Guid(row[c.ColumnName].ToString());
                }
                else if (p.PropertyType == typeof(Boolean))
                {
                    value = Convert.ToBoolean(row[c.ColumnName]);
                }
                else if (p.PropertyType == typeof(Byte))
                {
                    value = Convert.ToByte(row[c.ColumnName]);
                }
                else if (p.PropertyType == typeof(Byte[]))
                {
                    value = Convert.FromBase64String(row[c.ColumnName].ToString());
                }
                else if (p.PropertyType == typeof(Char))
                {
                    value = Convert.ToChar(row[c.ColumnName]);
                }
                else if (p.PropertyType == typeof(Int16))
                {
                    value = Convert.ToInt16(row[c.ColumnName]);
                }
                else if (p.PropertyType == typeof(Int32))
                {
                    value = Convert.ToInt32(row[c.ColumnName]);
                }
                else if (p.PropertyType == typeof(Int64))
                {
                    value = Convert.ToInt64(row[c.ColumnName]);
                }
                else if (p.PropertyType == typeof(UInt16))
                {
                    value = Convert.ToUInt16(row[c.ColumnName]);
                }
                else if (p.PropertyType == typeof(UInt32))
                {
                    value = Convert.ToUInt32(row[c.ColumnName]);
                }
                else if (p.PropertyType == typeof(UInt64))
                {
                    value = Convert.ToUInt64(row[c.ColumnName]);
                }
                else if (p.PropertyType == typeof(Single))
                {
                    value = Convert.ToSingle(row[c.ColumnName]);
                }
                else if (p.PropertyType == typeof(Double))
                {
                    value = Convert.ToDouble(row[c.ColumnName]);
                }
                else if (p.PropertyType == typeof(Decimal))
                {
                    value = Convert.ToDecimal(row[c.ColumnName]);
                }
                else if (p.PropertyType == typeof(DateTime))
                {
                    value = Convert.ToDateTime(row[c.ColumnName]);
                }
                else if ((p.PropertyType == typeof(Enum)) || (p.PropertyType.BaseType == typeof(Enum)))
                {
                    value = Enum.Parse(p.PropertyType, row[c.ColumnName].ToString());
                }
                else
                {
                    value = row[c.ColumnName];
                }
                p.SetValue(entity, value, null);
            }
            return entity;
        }

        public static DataRow PopulateDataRow(E entity, DataRow row, bool shapePropertyNames)
        {
            Type entityType = typeof(E);
            foreach (PropertyInfo p in entityType.GetProperties())
            {
                object propertyValue = GetPropertyValue(p.Name, entity, true);
                string propertyName = shapePropertyNames ? DataShaper.FormatEntityColumnName(p.Name) : p.Name;
                row[propertyName] = propertyValue;
            }
            return row;
        }

        #endregion //Methods
    }
}