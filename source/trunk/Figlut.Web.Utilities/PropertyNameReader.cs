namespace Figlut.Web.Utilities
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Linq.Expressions;

    #endregion //Using Directives

    public class PropertyNameReader<T>
    {
        public static string Property<TProp>(Expression<Func<T, TProp>> expression)
        {
            var body = expression.Body as MemberExpression;
            if (body == null) throw new ArgumentException("'expression' should be a member expression");
            return body.Member.Name;
        }
    }
}