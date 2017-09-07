namespace Figlut.Desktop.Data
{
    #region Using Directives

    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text;
    using System.Collections;
    using System.IO;
    using System.Reflection;
    using System.Data;
    using Figlut.Desktop.Utilities;
    using Figlut.CsvHelper;

    #endregion //Using Directives

    public abstract class EntityCache<E> : IEnumerable<E> where E : class
    {
        #region Constructors

        public EntityCache()
        {
            _entities = new Dictionary<Guid, E>();
            _addedEntities = new Dictionary<Guid, E>();
            _deletedEntities = new Dictionary<Guid, E>();
        }

        #endregion //Constructors

        #region Fields

        protected Dictionary<Guid, E> _entities;
        protected Dictionary<Guid, E> _addedEntities;
        protected Dictionary<Guid, E> _deletedEntities;

        #endregion //Fields

        #region Properties

        public List<E> AddedEntities
        {
            get { return _addedEntities.Values.ToList(); }
        }

        public List<E> DeletedEntities
        {
            get { return _deletedEntities.Values.ToList(); }
        }

        public int Count
        {
            get { return _entities.Count; }
        }

        #endregion //Properties

        #region Indexers Region

        public E this[Guid id]
        {
            get
            {
                if (_entities.ContainsKey(id))
                {
                    return _entities[id];
                }
                return null;
            }
        }

        #endregion //Indexers Region

        #region Methods

        public virtual void OverrideFromList(List<E> entities)
        {
            Dictionary<Guid, E> result = new Dictionary<Guid, E>();
            entities.ForEach(e => result.Add(GetSurrogateKeyValue(e), e));
            Clear();
            _entities = null;
            _entities = result;
        }

        public virtual Guid GetSurrogateKeyValue(E e)
        {
            Type type = e.GetType();
            foreach (PropertyInfo p in type.GetProperties())
            {
                if (p.PropertyType == typeof(Guid))
                {
                    return (Guid)p.GetValue(e, null);
                }
            }
            throw new Exception(string.Format("Could not find surrogate key for entity {0}.", type.FullName));
        }

        public virtual void Add(E e)
        {
            Guid id = GetSurrogateKeyValue(e);
            if (_entities.ContainsKey(id))
            {
                throw new ArgumentException(string.Format(
                    "An entity with the ID {0} already exists in this collection.",
                    id));
            }
            _entities.Add(id, e);
            _addedEntities.Add(id, e);
        }

        public virtual void Delete(Guid id)
        {
            if (!_entities.ContainsKey(id))
            {
                throw new NullReferenceException(string.Format(
                    "Could not find entity with ID {0} in this collection to be deleted.",
                    id));
            }
            E e = _entities[id];
            _entities.Remove(id);
            if (_addedEntities.ContainsKey(id))
            {
                _addedEntities.Remove(id);
            }
            else
            {
                _deletedEntities.Add(id, e);
            }
        }

        public virtual void Clear()
        {
            _entities.Clear();
            _addedEntities.Clear();
            _deletedEntities.Clear();
            GC.Collect();
        }

        public virtual void ClearAddedEntities()
        {
            _addedEntities.Clear();
        }

        public virtual void ClearDeletedEntities()
        {
            _deletedEntities.Clear();
        }

        public virtual List<E> GetEntitiesByProperties(Dictionary<string, object> properties, bool exactMatch)
        {
            Type t = typeof(E);
            List<E> result = new List<E>();
            if (properties == null) //Return all the items.
            {
                _entities.Values.ToList().ForEach(p => result.Add(p));
                return result;
            }
            List<PropertyInfo> propertyList = new List<PropertyInfo>();
            foreach (string propertyName in properties.Keys)
            {
                PropertyInfo p = t.GetProperty(propertyName);
                if (p == null)
                {
                    throw new NullReferenceException(string.Format(
                        "Could not find property with name {0} on entity type {1}.",
                        propertyName,
                        t.FullName));
                }
                propertyList.Add(p);
            }
            if (exactMatch)
            {
                foreach (E e in _entities.Values)
                {
                    bool include = true;
                    foreach (PropertyInfo p in propertyList)
                    {
                        object entityProvidedValue = p.GetValue(e, null);
                        object providedPropertyValue = properties[p.Name];
                        if (!entityProvidedValue.Equals(providedPropertyValue))
                        {
                            include = false;
                            break;
                        }
                    }
                    if (include)
                    {
                        result.Add(e);
                    }
                }
            }
            else
            {
                foreach (E e in _entities.Values)
                {
                    bool include = true;
                    foreach (PropertyInfo p in propertyList)
                    {
                        object entityValue = p.GetValue(e, null);
                        string entityValueStr = entityValue == null ? string.Empty : entityValue.ToString().ToLower();
                        string providedPropertyValue = properties[p.Name].ToString().ToLower();
                        if (!entityValueStr.Contains(providedPropertyValue))
                        {
                            include = false;
                            break;
                        }
                    }
                    if (include)
                    {
                        result.Add(e);
                    }
                }
            }
            return result;
        }

        public virtual bool PropertyValueExists(string propertyName, object propertyValue)
        {
            Type t = typeof(E);
            PropertyInfo p = t.GetProperty(propertyName);
            if (p == null)
            {
                throw new NullReferenceException(string.Format(
                    "Could not find property with name {0} on entity type {1}.",
                    propertyName,
                    t.FullName));
            }
            foreach (E e in _entities.Values)
            {
                object value = p.GetValue(e, null);
                if (propertyValue.Equals(value))
                {
                    return true;
                }
            }
            return false;
        }

        public virtual DataTable GetDataTable(Dictionary<string, object> properties, bool exactMatch, bool shapeColumnNames)
        {
            DataTable result = EntityReader<E>.GetDataTable(shapeColumnNames);
            List<E> entities = GetEntitiesByProperties(properties, exactMatch);
            foreach (E e in entities)
            {
                DataRow row = EntityReader<E>.PopulateDataRow(e, result.NewRow(), shapeColumnNames);
                result.Rows.Add(row);
            }
            return result;
        }

        public virtual Dictionary<Guid, E> DataTableToDictionary(DataTable table)
        {
            Dictionary<Guid, E> result = new Dictionary<Guid, E>();
            foreach (DataRow row in table.Rows)
            {
                E e = EntityReader<E>.PopulateFromDataRow(Activator.CreateInstance<E>(), row);
                Guid surrogateKey = GetSurrogateKeyValue(e);
                if (_entities.ContainsKey(surrogateKey))
                {
                    throw new Exception(string.Format(
                        "May not load more than one {0} with the same Id {1}.", 
                        typeof(E).FullName,
                        surrogateKey.ToString()));
                }
                result.Add(surrogateKey, e);
            }
            return result;
        }

        public virtual void ExportToCsv(
            string filePath, 
            Dictionary<string, object> properties,
            bool exactMatch, 
            bool shapeColumnNames)
        {
            CsvWriter.WriteToFile(
                GetDataTable(properties, exactMatch, shapeColumnNames),
                true, 
                true, 
                filePath, 
                null);
        }

        public virtual StringWriter ExportToStringWriter(
            Dictionary<string, object> properties,
            bool exactMatch,
            bool shapeColumnNames)
        {
            StringWriter result = new StringWriter();
            CsvWriter.WriteToStream(
                result,
                GetDataTable(properties, exactMatch, shapeColumnNames),
                true, 
                true, 
                null);
            return result;
        }

        public virtual MemoryStream ExportToStream(
            Dictionary<string, object> properties,
            bool exactMatch,
            bool shapeColumnNames)
        {
            return new MemoryStream((new ASCIIEncoding()).GetBytes(
                ExportToStringWriter(properties, exactMatch, shapeColumnNames).GetStringBuilder().ToString()));
        }

        public virtual void ImportFromCsv(string filePath, bool shapeColumnNames)
        {
            _entities = DataTableToDictionary(
                CsvParser.ParseFromFile(filePath, true, EntityReader<E>.GetDataTable(shapeColumnNames).Columns.Count));
        }

        public abstract bool RefreshFromServer();

        public abstract bool SaveToServer();

        public virtual void LoadFromFile(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                throw new ArgumentException("File path not specified for entity cache.");
            }
            if (!File.Exists(filePath))
            {
                SaveToFile(filePath);
            }
            EntityCache<E> entities = (EntityCache<E>)Serializer.DeserializeFromFile(typeof(EntityCache<E>), filePath);
            Clear();
            foreach (E e in entities)
            {
                _entities.Add(GetSurrogateKeyValue(e), e);
            }
        }

        public virtual void SaveToFile(string filePath)
        {
            Serializer.SerializeToFile(this, filePath);
        }

        public IEnumerator<E> GetEnumerator()
        {
            return _entities.Values.GetEnumerator();
        }

        IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion //Methods
    }
}
