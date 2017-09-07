namespace Figlut.Aplex.Web.Data
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Figlut.Web.Utilities;
    using Figlut.Aplex.Web.Data;

    #endregion //Using Directives

    public class GlobalVariableContext : EntityContext
    {
        #region Methods

        public ServiceFunctionResult<GlobalVariable> GetGlobalVariable(GlobalVariableName globalVariableName, User user)
        {
            try
            {
                ValidateUser(user);
                List<GlobalVariable> query = (from g in DB.GetTable<GlobalVariable>()
                                              where g.VariableName == globalVariableName.ToString()
                                              select g).ToList();
                GlobalVariable result = query.Count < 1 ? null : query[0];
                return new ServiceFunctionResult<GlobalVariable>() { Contents = result };
            }
            catch (Exception ex)
            {
                return new ServiceFunctionResult<GlobalVariable>(HandleException(ex, user));
            }
        }

        #endregion //Methods
    }
}
