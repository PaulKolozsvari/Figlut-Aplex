namespace Figlut.Aplex.Desktop.Data
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Figlut.Desktop.Utilities;
    using Figlut.Aplex.Desktop.Data.WebService;

    #endregion //Using Directives

    public class GlobalServerVariables
    {
        #region Constructors

        public GlobalServerVariables()
        {
            _globalVariables = new Dictionary<string, GlobalVariable>();
        }

        #endregion //Constructors

        #region Fields

        private Dictionary<string, GlobalVariable> _globalVariables;

        #endregion //Fields

        #region Indexers Region

        public string this[GlobalVariableName variableName]
        {
            get
            {
                ValidateVariableCache(variableName);
                return _globalVariables[variableName.ToString()].VariableValue;
            }
            set
            {
                ValidateVariableCache(variableName);
                _globalVariables[variableName.ToString()].VariableValue = value;
            }
        }

        #endregion //Indexers Region

        #region Methods

        public bool RefreshFromServer()
        {
            ServiceFunctionResultOfListOfGlobalVariable result = GlobalDataCache.Instance.Service.GetAllGlobalVariable(false, GlobalDataCache.Instance.CurrentUser);
            if (ServiceResultHandler.HandleServiceResult(result))
            {
                return true;
            }
            _globalVariables.Clear();
            result.Contents.OrderBy(p => p.VariableName).ToList().ForEach(p => _globalVariables.Add(p.VariableName, p));
            return false;
        }

        public bool SaveToServer()
        {
            ServiceProcedureResult result = GlobalDataCache.Instance.Service.SaveGlobalVariable(
                _globalVariables.Values.ToArray(),
                GlobalDataCache.Instance.CurrentUser,
                false);
            if (ServiceResultHandler.HandleServiceResult(result))
            {
                return true;
            }
            return false;
        }

        private void ValidateVariableCache(GlobalVariableName variableName)
        {
            if (_globalVariables.Count < 1)
            {
                throw new UserThrownException(
                    "Variables have not been downloaded from the server yet, global server variable chache is empty.",
                    true,
                    true,
                    false);
            }
            if (!_globalVariables.ContainsKey(variableName.ToString()))
            {
                throw new UserThrownException(
                    string.Format("No variablle exists with the name {0} in the global server variable cache.", variableName.ToString()),
                    true,
                    true,
                    false);
            }
        }

        #endregion //Methods
    }
}