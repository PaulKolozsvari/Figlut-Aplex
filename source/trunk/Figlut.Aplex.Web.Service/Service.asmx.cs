namespace Figlut.Aplex.Web.Service
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Services;
    using System.Xml.Serialization;
    using Figlut.Web.Utilities;
    using Figlut.Aplex.Web.Data;

    #endregion //Using Directives

    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service : System.Web.Services.WebService
    {
        #region Generic

        [WebMethod]
        [XmlInclude(typeof(UserRoleId))]
        public ServiceResult ConnectionTest()
        {
            return new ServiceProcedureResult();
        }

        [WebMethod]
        public ServiceFunctionResult<DateTime> GetCurrentServerDateTime()
        {
            return new ServiceFunctionResult<DateTime>() { Contents = DateTime.Now };
        }

        [WebMethod]
        public UserPermissionName GetDefaultPermission()
        {
            return UserPermissionName.UserManagement;
        }

        #endregion //Generic

        #region Global Variable Context

        [WebMethod]
        public ServiceFunctionResult<GlobalVariable> GetGlobalVariable(GlobalVariableName globalVariableName, User user)
        {
            return (new GlobalVariableContext()).GetGlobalVariable(globalVariableName, user);
        }

        #endregion //Global Variable Context

        #region Aplex Database Manager

        [WebMethod]
        public ServiceFunctionResult<AplexTableQueryResult> QueryTableByNames(
            string databaseName,
            string tableName,
            List<string> columnNamesToInclude,
            List<AplexColumnFilter> columnNamesToFilterBy,
            User user)
        {
            return (new AplexDatabaseManager()).QueryTableByNames(
                databaseName,
                tableName,
                columnNamesToInclude,
                columnNamesToFilterBy,
                user);
        }

        [WebMethod]
        public ServiceFunctionResult<AplexTableQueryResult> QueryTable(
            AplexDataTable table,
            List<AplexColumnQueryResult> columnsToInclude,
            List<AplexColumnFilter> filterColumns,
            User user)
        {
            return (new AplexDatabaseManager()).QueryTable(
                table,
                columnsToInclude,
                filterColumns,
                user);
        }

        [WebMethod]
        public ServiceFunctionResult<AplexDataSchemaQueryResult> QueryAplexDataSchema(User user)
        {
            return (new AplexDatabaseManager()).QueryAplexDataSchema(user);
        }

        #endregion //Aplex Database Manager

        #region User Context

        [WebMethod]
        public ServiceFunctionResult<User> Login(string userName, string password, UserRoleId roleId)
        {
            return (new UserContext()).Login(userName, password, roleId);
        }

        #endregion //User Context

        #region User Permission Context

        [WebMethod]
        public ServiceFunctionResult<List<UserPermission>> GetUserPermissionsForUser(User targetUser, User user)
        {
            return (new UserPermissionContext()).GetUserPermissionsForUser(targetUser, user);
        }

        [WebMethod]
        public ServiceProcedureResult SaveUserWithPermissions(
            List<User> usersToSave,
            List<User> usersToDelete,
            List<UserPermission> permissionsToSave,
            List<UserPermission> permissionsToDelete,
            User user)
        {
            return (new UserContext()).SaveUserWithPermissions(
                usersToSave,
                usersToDelete,
                permissionsToSave,
                permissionsToDelete,
                user);
        }

        #endregion //User Permission Context

        #region Customer Context

        [WebMethod]
        public ServiceFunctionResult<List<Customer>> GetAllCustomerWithStats(User user)
        {
            return (new CustomerContext()).GetAllCustomerWithStats(user);
        }

        #endregion //Customer Context

        #region Device Config Context

        [WebMethod]
        public ServiceFunctionResult<List<DeviceConfig>> GetAllDeviceConfigWithCustomerInfo(User user)
        {
            return (new DeviceConfigContext()).GetAllDeviceConfigWithCustomerInfo(user);
        }

        [WebMethod]
        public ServiceFunctionResult<DeviceConfig> GetDeviceConfig(string deviceId, string applicationName)
        {
            return (new DeviceConfigContext()).GetDeviceConfig(deviceId, applicationName);
        }

        [WebMethod]
        public ServiceFunctionResult<DeviceConfigAction> LogDeviceConfigAction(
            string function,
            string deviceId,
            string applicationName,
            string tag)
        {
            return (new DeviceConfigContext()).LogDeviceConfigAction(
                function, 
                deviceId, 
                applicationName, 
                tag);
        }

        [WebMethod]
        public ServiceProcedureResult ApproveDevicePendingApproval(
            string deviceId,
            string applicationName,
            string applicationWebServiceURL,
            string applicationReplicationWebServiceURL,
            string clientConfigWebServiceURL,
            int daysToActivate,
            Customer customer,
            User user)
        {
            return (new DeviceConfigContext()).ApproveDevicePendingApproval(
                deviceId,
                applicationName,
                applicationWebServiceURL,
                applicationReplicationWebServiceURL,
                clientConfigWebServiceURL,
                daysToActivate,
                customer,
                user);
        }

        [WebMethod]
        public ServiceProcedureResult UpdateDeviceConfig(
            string deviceId,
            string applicationName,
            string applicationWebServiceURL,
            string applicationReplicationWebServiceURL,
            string FiglutWebServiceURL,
            DateTime licenseExpiryDate,
            User user)
        {
            return (new DeviceConfigContext()).UpdateDeviceConfig(
                deviceId,
                applicationName,
                applicationWebServiceURL,
                applicationReplicationWebServiceURL,
                FiglutWebServiceURL,
                licenseExpiryDate,
                user);
        }

        #endregion //Device Config Context

        #region Device Config Action Context

        [WebMethod]
        public ServiceFunctionResult<List<DeviceConfigAction>> GetDeviceConfigActionByFilters(
            string deviceId,
            string applicationName,
            DateTime startDate,
            DateTime endDate,
            User user)
        {
            return (new DeviceConfigActionContext()).GetDeviceConfigActionByFilters(
                deviceId,
                applicationName,
                startDate,
                endDate,
                user);
        }

        #endregion //Device Config Action Context

        #region Server Action Context

        [WebMethod]
        public ServiceFunctionResult<List<ServerAction>> GetServerActionByFilters(
            DateTime startDate,
            DateTime endDate,
            User user)
        {
            return (new ServerActionContext()).GetServerActionByFilters(
                startDate,
                endDate,
                user);
        }

        #endregion //Server Action Context

        #region Email Action Context

        [WebMethod]
        public ServiceFunctionResult<List<EmailAction>> GetEmailActionByFilters(
            DateTime startDate,
            DateTime endDate,
            User user)
        {
            return (new EmailActionContext()).GetEmailActionByFilters(
                startDate,
                endDate,
                user);
        }

        #endregion //Email Action Context

        #region Server Error Context

        [WebMethod]
        public ServiceFunctionResult<List<ServerError>> GetServerErrorByFilters(
            DateTime startDate,
            DateTime endDate,
            User user)
        {
            return (new ServerErrorContext()).GetServerErrorByFilters(
                startDate,
                endDate,
                user);
        }

        #endregion //Server Error Context

        #region Basic Data Manipulation

        #region User

        [WebMethod]
        public ServiceProcedureResult SaveUser(List<User> x, User user, bool saveChildren)
        {
            return (new EntityContext()).Save<User>(x, user, saveChildren);
        }

        [WebMethod]
        public ServiceProcedureResult DeleteUser(List<User> x, User user)
        {
            foreach (User u in x)
            {
                if (u.UserId == user.UserId)
                {
                    return new ServiceProcedureResult()
                    {
                        Code = ServiceResultCode.OperationError,
                        Message = "User performing the delete may not also be a user being deleted."
                    };
                }
            }
            return (new EntityContext()).Delete<User>(x, user);
        }

        [WebMethod]
        public ServiceProcedureResult DeleteAllUser(User user)
        {
            return (new EntityContext()).DeleteAll<User>(user);
        }

        [WebMethod]
        public ServiceFunctionResult<User> GetUserBySurrogateKey(object keyValue, bool loadChildren, User user)
        {
            return (new EntityContext()).GetEntityBySurrogateKey<User>(keyValue, loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<List<User>> GetUserByField(string fieldName, object fieldValue, bool loadChildren, User user)
        {
            return (new EntityContext()).GetEntitiesByField<User>(fieldName, fieldValue, loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<List<User>> GetAllUser(bool loadChildren, User user)
        {
            return (new EntityContext()).GetAllEntities<User>(loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<int> GetTotalUserCount(User user)
        {
            return (new EntityContext()).GetTotalCount<User>(user);
        }

        #endregion //User

        #region User Permission

        [WebMethod]
        public ServiceProcedureResult SaveUserPermission(List<UserPermission> x, User user, bool saveChildren)
        {
            return (new EntityContext()).Save<UserPermission>(x, user, saveChildren);
        }

        [WebMethod]
        public ServiceProcedureResult DeleteUserPermission(List<UserPermission> x, User user)
        {
            return (new EntityContext()).Delete<UserPermission>(x, user);
        }

        [WebMethod]
        public ServiceProcedureResult DeleteAllUserPermission(User user)
        {
            return (new EntityContext()).DeleteAll<UserPermission>(user);
        }

        [WebMethod]
        public ServiceFunctionResult<UserPermission> GetUserPermissionBySurrogateKey(object keyValue, bool loadChildren, User user)
        {
            return (new EntityContext()).GetEntityBySurrogateKey<UserPermission>(keyValue, loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<List<UserPermission>> GetUserPermissionByField(string fieldName, object fieldValue, bool loadChildren, User user)
        {
            return (new EntityContext()).GetEntitiesByField<UserPermission>(fieldName, fieldValue, loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<List<UserPermission>> GetAllUserPermission(bool loadChildren, User user)
        {
            return (new EntityContext()).GetAllEntities<UserPermission>(loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<int> GetTotalUserPermissionCount(User user)
        {
            return (new EntityContext()).GetTotalCount<UserPermission>(user);
        }

        #endregion //User Permission

        #region Customer

        [WebMethod]
        public ServiceProcedureResult SaveCustomer(List<Customer> x, User user, bool saveChildren)
        {
            return (new EntityContext()).Save<Customer>(x, user, saveChildren);
        }

        [WebMethod]
        public ServiceProcedureResult DeleteCustomer(List<Customer> x, User user)
        {
            return (new EntityContext()).Delete<Customer>(x, user);
        }

        [WebMethod]
        public ServiceProcedureResult DeleteAllCustomer(User user)
        {
            return (new EntityContext()).DeleteAll<Customer>(user);
        }

        [WebMethod]
        public ServiceFunctionResult<Customer> GetCustomerBySurrogateKey(object keyValue, bool loadChildren, User user)
        {
            return (new EntityContext()).GetEntityBySurrogateKey<Customer>(keyValue, loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<List<Customer>> GetCustomerByField(string fieldName, object fieldValue, bool loadChildren, User user)
        {
            return (new EntityContext()).GetEntitiesByField<Customer>(fieldName, fieldValue, loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<List<Customer>> GetAllCustomer(bool loadChildren, User user)
        {
            return (new EntityContext()).GetAllEntities<Customer>(loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<int> GetTotalCustomerCount(User user)
        {
            return (new EntityContext()).GetTotalCount<Customer>(user);
        }        

        #endregion //Customer

        #region Device Config

        [WebMethod]
        public ServiceProcedureResult SaveDeviceConfig(List<DeviceConfig> x, User user, bool saveChildren)
        {
            return (new EntityContext()).Save<DeviceConfig>(x, user, saveChildren);
        }

        [WebMethod]
        public ServiceProcedureResult DeleteDeviceConfig(List<DeviceConfig> x, User user)
        {
            return (new EntityContext()).Delete<DeviceConfig>(x, user);
        }

        [WebMethod]
        public ServiceProcedureResult DeleteAllDeviceConfig(User user)
        {
            return (new EntityContext()).DeleteAll<DeviceConfig>(user);
        }

        [WebMethod]
        public ServiceFunctionResult<DeviceConfig> GetDeviceConfigBySurrogateKey(object keyValue, bool loadChildren, User user)
        {
            return (new EntityContext()).GetEntityBySurrogateKey<DeviceConfig>(keyValue, loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<List<DeviceConfig>> GetDeviceConfigByField(string fieldName, object fieldValue, bool loadChildren, User user)
        {
            return (new EntityContext()).GetEntitiesByField<DeviceConfig>(fieldName, fieldValue, loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<List<DeviceConfig>> GetAllDeviceConfig(bool loadChildren, User user)
        {
            return (new EntityContext()).GetAllEntities<DeviceConfig>(loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<int> GetTotalDeviceConfigCount(User user)
        {
            return (new EntityContext()).GetTotalCount<DeviceConfig>(user);
        }

        #endregion //Device Config

        #region Device Config Action

        [WebMethod]
        public ServiceProcedureResult SaveDeviceConfigAction(List<DeviceConfigAction> x, User user, bool saveChildren)
        {
            return (new EntityContext()).Save<DeviceConfigAction>(x, user, saveChildren);
        }

        [WebMethod]
        public ServiceProcedureResult DeleteDeviceConfigAction(List<DeviceConfigAction> x, User user)
        {
            return (new EntityContext()).Delete<DeviceConfigAction>(x, user);
        }

        [WebMethod]
        public ServiceProcedureResult DeleteAllDeviceConfigAction(User user)
        {
            return (new EntityContext()).DeleteAll<DeviceConfigAction>(user);
        }

        [WebMethod]
        public ServiceFunctionResult<DeviceConfigAction> GetDeviceConfigActionBySurrogateKey(object keyValue, bool loadChildren, User user)
        {
            return (new EntityContext()).GetEntityBySurrogateKey<DeviceConfigAction>(keyValue, loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<List<DeviceConfigAction>> GetDeviceConfigActionByField(string fieldName, object fieldValue, bool loadChildren, User user)
        {
            return (new EntityContext()).GetEntitiesByField<DeviceConfigAction>(fieldName, fieldValue, loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<List<DeviceConfigAction>> GetAllDeviceConfigAction(bool loadChildren, User user)
        {
            return (new EntityContext()).GetAllEntities<DeviceConfigAction>(loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<int> GetTotalDeviceConfigActionCount(User user)
        {
            return (new EntityContext()).GetTotalCount<DeviceConfigAction>(user);
        }

        #endregion //Device Config Action

        #region Device Pending Approval

        [WebMethod]
        public ServiceProcedureResult SaveDevicePendingApproval(List<DevicePendingApproval> x, User user, bool saveChildren)
        {
            return (new EntityContext()).Save<DevicePendingApproval>(x, user, saveChildren);
        }

        [WebMethod]
        public ServiceProcedureResult DeleteDevicePendingApproval(List<DevicePendingApproval> x, User user)
        {
            return (new EntityContext()).Delete<DevicePendingApproval>(x, user);
        }

        [WebMethod]
        public ServiceProcedureResult DeleteAllDevicePendingApproval(User user)
        {
            return (new EntityContext()).DeleteAll<DevicePendingApproval>(user);
        }

        [WebMethod]
        public ServiceFunctionResult<DevicePendingApproval> GetDevicePendingApprovalBySurrogateKey(object keyValue, bool loadChildren, User user)
        {
            return (new EntityContext()).GetEntityBySurrogateKey<DevicePendingApproval>(keyValue, loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<List<DevicePendingApproval>> GetDevicePendingApprovalByField(string fieldName, object fieldValue, bool loadChildren, User user)
        {
            return (new EntityContext()).GetEntitiesByField<DevicePendingApproval>(fieldName, fieldValue, loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<List<DevicePendingApproval>> GetAllDevicePendingApproval(bool loadChildren, User user)
        {
            return (new EntityContext()).GetAllEntities<DevicePendingApproval>(loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<int> GetTotalDevicePendingApprovalCount(User user)
        {
            return (new EntityContext()).GetTotalCount<DevicePendingApproval>(user);
        }

        #endregion //Device Pending Approval

        #region Global Variable

        [WebMethod]
        public ServiceProcedureResult SaveGlobalVariable(List<GlobalVariable> x, User user, bool saveChildren)
        {
            return (new EntityContext()).Save<GlobalVariable>(x, user, saveChildren);
        }

        [WebMethod]
        public ServiceProcedureResult DeleteGlobalVariable(List<GlobalVariable> x, User user)
        {
            return (new EntityContext()).Delete<GlobalVariable>(x, user);
        }

        [WebMethod]
        public ServiceProcedureResult DeleteAllGlobalVariable(User user)
        {
            return (new EntityContext()).DeleteAll<GlobalVariable>(user);
        }

        [WebMethod]
        public ServiceFunctionResult<GlobalVariable> GetGlobalVariableBySurrogateKey(object keyValue, bool loadChildren, User user)
        {
            return (new EntityContext()).GetEntityBySurrogateKey<GlobalVariable>(keyValue, loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<List<GlobalVariable>> GetGlobalVariableByField(string fieldName, object fieldValue, bool loadChildren, User user)
        {
            return (new EntityContext()).GetEntitiesByField<GlobalVariable>(fieldName, fieldValue, loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<List<GlobalVariable>> GetAllGlobalVariable(bool loadChildren, User user)
        {
            return (new EntityContext()).GetAllEntities<GlobalVariable>(loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<int> GetTotalGlobalVariableCount(User user)
        {
            return (new EntityContext()).GetTotalCount<GlobalVariable>(user);
        }

        #endregion //Global Variable

        #region Server Action

        [WebMethod]
        public ServiceProcedureResult SaveServerAction(List<ServerAction> x, User user, bool saveChildren)
        {
            return (new EntityContext()).Save<ServerAction>(x, user, saveChildren);
        }

        [WebMethod]
        public ServiceProcedureResult DeleteServerAction(List<ServerAction> x, User user)
        {
            return (new EntityContext()).Delete<ServerAction>(x, user);
        }

        [WebMethod]
        public ServiceProcedureResult DeleteAllServerAction(User user)
        {
            return (new EntityContext()).DeleteAll<ServerAction>(user);
        }

        [WebMethod]
        public ServiceFunctionResult<ServerAction> GetServerActionBySurrogateKey(object keyValue, bool loadChildren, User user)
        {
            return (new EntityContext()).GetEntityBySurrogateKey<ServerAction>(keyValue, loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<List<ServerAction>> GetServerActionByField(string fieldName, object fieldValue, bool loadChildren, User user)
        {
            return (new EntityContext()).GetEntitiesByField<ServerAction>(fieldName, fieldValue, loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<List<ServerAction>> GetAllServerAction(bool loadChildren, User user)
        {
            return (new EntityContext()).GetAllEntities<ServerAction>(loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<int> GetTotalServerActionCount(User user)
        {
            return (new EntityContext()).GetTotalCount<ServerAction>(user);
        }

        #endregion //Server Action

        #region Server Error

        [WebMethod]
        public ServiceProcedureResult SaveServerError(List<ServerError> x, User user, bool saveChildren)
        {
            return (new EntityContext()).Save<ServerError>(x, user, saveChildren);
        }

        [WebMethod]
        public ServiceProcedureResult DeleteServerError(List<ServerError> x, User user)
        {
            return (new EntityContext()).Delete<ServerError>(x, user);
        }

        [WebMethod]
        public ServiceProcedureResult DeleteAllServerError(User user)
        {
            return (new EntityContext()).DeleteAll<ServerError>(user);
        }

        [WebMethod]
        public ServiceFunctionResult<ServerError> GetServerErrorBySurrogateKey(object keyValue, bool loadChildren, User user)
        {
            return (new EntityContext()).GetEntityBySurrogateKey<ServerError>(keyValue, loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<List<ServerError>> GetServerErrorByField(string fieldName, object fieldValue, bool loadChildren, User user)
        {
            return (new EntityContext()).GetEntitiesByField<ServerError>(fieldName, fieldValue, loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<List<ServerError>> GetAllServerError(bool loadChildren, User user)
        {
            return (new EntityContext()).GetAllEntities<ServerError>(loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<int> GetTotalServerErrorCount(User user)
        {
            return (new EntityContext()).GetTotalCount<ServerError>(user);
        }

        #endregion //Server Error

        #region Email Action

        [WebMethod]
        public ServiceProcedureResult SaveEmailAction(List<EmailAction> x, User user, bool saveChildren)
        {
            return (new EntityContext()).Save<EmailAction>(x, user, saveChildren);
        }

        [WebMethod]
        public ServiceProcedureResult DeleteEmailAction(List<EmailAction> x, User user)
        {
            return (new EntityContext()).Delete<EmailAction>(x, user);
        }

        [WebMethod]
        public ServiceProcedureResult DeleteAllEmailAction(User user)
        {
            return (new EntityContext()).DeleteAll<EmailAction>(user);
        }

        [WebMethod]
        public ServiceFunctionResult<EmailAction> GetEmailActionBySurrogateKey(object keyValue, bool loadChildren, User user)
        {
            return (new EntityContext()).GetEntityBySurrogateKey<EmailAction>(keyValue, loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<List<EmailAction>> GetEmailActionByField(string fieldName, object fieldValue, bool loadChildren, User user)
        {
            return (new EntityContext()).GetEntitiesByField<EmailAction>(fieldName, fieldValue, loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<List<EmailAction>> GetAllEmailAction(bool loadChildren, User user)
        {
            return (new EntityContext()).GetAllEntities<EmailAction>(loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<int> GetTotalEmailActionCount(User user)
        {
            return (new EntityContext()).GetTotalCount<EmailAction>(user);
        }

        #endregion //Email Action

        #region Aplex

        [WebMethod]
        public ServiceProcedureResult SaveAplex(List<Aplex> x, User user, bool saveChildren)
        {
            return (new EntityContext()).Save<Aplex>(x, user, saveChildren);
        }

        [WebMethod]
        public ServiceProcedureResult DeleteAplex(List<Aplex> x, User user)
        {
            return (new EntityContext()).Delete<Aplex>(x, user);
        }

        [WebMethod]
        public ServiceProcedureResult DeleteAllAplex(User user)
        {
            return (new EntityContext()).DeleteAll<Aplex>(user);
        }

        [WebMethod]
        public ServiceFunctionResult<Aplex> GetAplexBySurrogateKey(object keyValue, bool loadChildren, User user)
        {
            return (new EntityContext()).GetEntityBySurrogateKey<Aplex>(keyValue, loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<List<Aplex>> GetAplexByField(string fieldName, object fieldValue, bool loadChildren, User user)
        {
            return (new EntityContext()).GetEntitiesByField<Aplex>(fieldName, fieldValue, loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<List<Aplex>> GetAllAplex(bool loadChildren, User user)
        {
            return (new EntityContext()).GetAllEntities<Aplex>(loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<int> GetTotalAplexCount(User user)
        {
            return (new EntityContext()).GetTotalCount<Aplex>(user);
        }

        #endregion //Customer

        #region Aplex Screen

        [WebMethod]
        public ServiceProcedureResult SaveAplexScreen(List<AplexScreen> x, User user, bool saveChildren)
        {
            return (new EntityContext()).Save<AplexScreen>(x, user, saveChildren);
        }

        [WebMethod]
        public ServiceProcedureResult DeleteAplexScreen(List<AplexScreen> x, User user)
        {
            return (new EntityContext()).Delete<AplexScreen>(x, user);
        }

        [WebMethod]
        public ServiceProcedureResult DeleteAllAplexScreen(User user)
        {
            return (new EntityContext()).DeleteAll<AplexScreen>(user);
        }

        [WebMethod]
        public ServiceFunctionResult<AplexScreen> GetAplexScreenBySurrogateKey(object keyValue, bool loadChildren, User user)
        {
            return (new EntityContext()).GetEntityBySurrogateKey<AplexScreen>(keyValue, loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<List<AplexScreen>> GetAplexScreenByField(string fieldName, object fieldValue, bool loadChildren, User user)
        {
            return (new EntityContext()).GetEntitiesByField<AplexScreen>(fieldName, fieldValue, loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<List<AplexScreen>> GetAllAplexScreen(bool loadChildren, User user)
        {
            return (new EntityContext()).GetAllEntities<AplexScreen>(loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<int> GetTotalAplexScreenCount(User user)
        {
            return (new EntityContext()).GetTotalCount<AplexScreen>(user);
        }

        #endregion //Aplex Screen

        #region Aplex Screen Field

        [WebMethod]
        public ServiceProcedureResult SaveAplexScreenField(List<AplexScreenField> x, User user, bool saveChildren)
        {
            return (new EntityContext()).Save<AplexScreenField>(x, user, saveChildren);
        }

        [WebMethod]
        public ServiceProcedureResult DeleteAplexScreenField(List<AplexScreenField> x, User user)
        {
            return (new EntityContext()).Delete<AplexScreenField>(x, user);
        }

        [WebMethod]
        public ServiceProcedureResult DeleteAllAplexScreenField(User user)
        {
            return (new EntityContext()).DeleteAll<AplexScreenField>(user);
        }

        [WebMethod]
        public ServiceFunctionResult<AplexScreenField> GetAplexScreenFieldBySurrogateKey(object keyValue, bool loadChildren, User user)
        {
            return (new EntityContext()).GetEntityBySurrogateKey<AplexScreenField>(keyValue, loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<List<AplexScreenField>> GetAplexScreenFieldByField(string fieldName, object fieldValue, bool loadChildren, User user)
        {
            return (new EntityContext()).GetEntitiesByField<AplexScreenField>(fieldName, fieldValue, loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<List<AplexScreenField>> GetAllAplexScreenField(bool loadChildren, User user)
        {
            return (new EntityContext()).GetAllEntities<AplexScreenField>(loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<int> GetTotalAplexScreenFieldCount(User user)
        {
            return (new EntityContext()).GetTotalCount<AplexScreenField>(user);
        }

        #endregion //Aplex Screen Field

        #region Aplex Database

        [WebMethod]
        public ServiceProcedureResult SaveAplexDatabase(List<AplexDatabase> x, User user, bool saveChildren)
        {
            return (new EntityContext()).Save<AplexDatabase>(x, user, saveChildren);
        }

        [WebMethod]
        public ServiceProcedureResult DeleteAplexDatabase(List<AplexDatabase> x, User user)
        {
            return (new EntityContext()).Delete<AplexDatabase>(x, user);
        }

        [WebMethod]
        public ServiceProcedureResult DeleteAllAplexDatabase(User user)
        {
            return (new EntityContext()).DeleteAll<AplexDatabase>(user);
        }

        [WebMethod]
        public ServiceFunctionResult<AplexDatabase> GetAplexDatabaseBySurrogateKey(object keyValue, bool loadChildren, User user)
        {
            return (new EntityContext()).GetEntityBySurrogateKey<AplexDatabase>(keyValue, loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<List<AplexDatabase>> GetAplexDatabaseByField(string fieldName, object fieldValue, bool loadChildren, User user)
        {
            return (new EntityContext()).GetEntitiesByField<AplexDatabase>(fieldName, fieldValue, loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<List<AplexDatabase>> GetAllAplexDatabase(bool loadChildren, User user)
        {
            return (new EntityContext()).GetAllEntities<AplexDatabase>(loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<int> GetTotalAplexDatabaseCount(User user)
        {
            return (new EntityContext()).GetTotalCount<AplexDatabase>(user);
        }

        #endregion //Customer

        #region Aplex Data Table

        [WebMethod]
        public ServiceProcedureResult SaveAplexDataTable(List<AplexDataTable> x, User user, bool saveChildren)
        {
            return (new EntityContext()).Save<AplexDataTable>(x, user, saveChildren);
        }

        [WebMethod]
        public ServiceProcedureResult DeleteAplexDataTable(List<AplexDataTable> x, User user)
        {
            return (new EntityContext()).Delete<AplexDataTable>(x, user);
        }

        [WebMethod]
        public ServiceProcedureResult DeleteAllAplexDataTable(User user)
        {
            return (new EntityContext()).DeleteAll<AplexDataTable>(user);
        }

        [WebMethod]
        public ServiceFunctionResult<AplexDataTable> GetAplexDataTableBySurrogateKey(object keyValue, bool loadChildren, User user)
        {
            return (new EntityContext()).GetEntityBySurrogateKey<AplexDataTable>(keyValue, loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<List<AplexDataTable>> GetAplexDataTableByField(string fieldName, object fieldValue, bool loadChildren, User user)
        {
            return (new EntityContext()).GetEntitiesByField<AplexDataTable>(fieldName, fieldValue, loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<List<AplexDataTable>> GetAllAplexDataTable(bool loadChildren, User user)
        {
            return (new EntityContext()).GetAllEntities<AplexDataTable>(loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<int> GetTotalAplexDataTableCount(User user)
        {
            return (new EntityContext()).GetTotalCount<AplexDataTable>(user);
        }

        #endregion //Aplex Data Table

        #region Aplex Data Column

        [WebMethod]
        public ServiceProcedureResult SaveAplexDataColumn(List<AplexDataColumn> x, User user, bool saveChildren)
        {
            return (new EntityContext()).Save<AplexDataColumn>(x, user, saveChildren);
        }

        [WebMethod]
        public ServiceProcedureResult DeleteAplexDataColumn(List<AplexDataColumn> x, User user)
        {
            return (new EntityContext()).Delete<AplexDataColumn>(x, user);
        }

        [WebMethod]
        public ServiceProcedureResult DeleteAllAplexDataColumn(User user)
        {
            return (new EntityContext()).DeleteAll<AplexDataColumn>(user);
        }

        [WebMethod]
        public ServiceFunctionResult<AplexDataColumn> GetAplexDataColumnBySurrogateKey(object keyValue, bool loadChildren, User user)
        {
            return (new EntityContext()).GetEntityBySurrogateKey<AplexDataColumn>(keyValue, loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<List<AplexDataColumn>> GetAplexDataColumnByField(string fieldName, object fieldValue, bool loadChildren, User user)
        {
            return (new EntityContext()).GetEntitiesByField<AplexDataColumn>(fieldName, fieldValue, loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<List<AplexDataColumn>> GetAllAplexDataColumn(bool loadChildren, User user)
        {
            return (new EntityContext()).GetAllEntities<AplexDataColumn>(loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<int> GetTotalAplexDataColumnCount(User user)
        {
            return (new EntityContext()).GetTotalCount<AplexDataColumn>(user);
        }

        #endregion //Aplex Data Column

        #region Aplex Data Row

        [WebMethod]
        public ServiceProcedureResult SaveAplexDataRow(List<AplexDataRow> x, User user, bool saveChildren)
        {
            return (new EntityContext()).Save<AplexDataRow>(x, user, saveChildren);
        }

        [WebMethod]
        public ServiceProcedureResult DeleteAplexDataRow(List<AplexDataRow> x, User user)
        {
            return (new EntityContext()).Delete<AplexDataRow>(x, user);
        }

        [WebMethod]
        public ServiceProcedureResult DeleteAllAplexDataRow(User user)
        {
            return (new EntityContext()).DeleteAll<AplexDataRow>(user);
        }

        [WebMethod]
        public ServiceFunctionResult<AplexDataRow> GetAplexDataRowBySurrogateKey(object keyValue, bool loadChildren, User user)
        {
            return (new EntityContext()).GetEntityBySurrogateKey<AplexDataRow>(keyValue, loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<List<AplexDataRow>> GetAplexDataRowByField(string fieldName, object fieldValue, bool loadChildren, User user)
        {
            return (new EntityContext()).GetEntitiesByField<AplexDataRow>(fieldName, fieldValue, loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<List<AplexDataRow>> GetAllAplexDataRow(bool loadChildren, User user)
        {
            return (new EntityContext()).GetAllEntities<AplexDataRow>(loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<int> GetTotalAplexDataRowCount(User user)
        {
            return (new EntityContext()).GetTotalCount<AplexDataRow>(user);
        }

        #endregion //Aplex Data Row

        #region Aplex Data Cell

        [WebMethod]
        public ServiceProcedureResult SaveAplexDataCell(List<AplexDataCell> x, User user, bool saveChildren)
        {
            return (new EntityContext()).Save<AplexDataCell>(x, user, saveChildren);
        }

        [WebMethod]
        public ServiceProcedureResult DeleteAplexDataCell(List<AplexDataCell> x, User user)
        {
            return (new EntityContext()).Delete<AplexDataCell>(x, user);
        }

        [WebMethod]
        public ServiceProcedureResult DeleteAllAplexDataCell(User user)
        {
            return (new EntityContext()).DeleteAll<AplexDataCell>(user);
        }

        [WebMethod]
        public ServiceFunctionResult<AplexDataCell> GetAplexDataCellBySurrogateKey(object keyValue, bool loadChildren, User user)
        {
            return (new EntityContext()).GetEntityBySurrogateKey<AplexDataCell>(keyValue, loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<List<AplexDataCell>> GetAplexDataCellByField(string fieldName, object fieldValue, bool loadChildren, User user)
        {
            return (new EntityContext()).GetEntitiesByField<AplexDataCell>(fieldName, fieldValue, loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<List<AplexDataCell>> GetAllAplexDataCell(bool loadChildren, User user)
        {
            return (new EntityContext()).GetAllEntities<AplexDataCell>(loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<int> GetTotalAplexDataCellCount(User user)
        {
            return (new EntityContext()).GetTotalCount<AplexDataCell>(user);
        }

        #endregion //Aplex Data Cell

        #region Aplex Control Mapping

        [WebMethod]
        public ServiceProcedureResult SaveAplexControlMapping(List<AplexControlMapping> x, User user, bool saveChildren)
        {
            return (new EntityContext()).Save<AplexControlMapping>(x, user, saveChildren);
        }

        [WebMethod]
        public ServiceProcedureResult DeleteAplexControlMapping(List<AplexControlMapping> x, User user)
        {
            return (new EntityContext()).Delete<AplexControlMapping>(x, user);
        }

        [WebMethod]
        public ServiceProcedureResult DeleteAllAplexControlMapping(User user)
        {
            return (new EntityContext()).DeleteAll<AplexControlMapping>(user);
        }

        [WebMethod]
        public ServiceFunctionResult<AplexControlMapping> GetAplexControlMappingBySurrogateKey(object keyValue, bool loadChildren, User user)
        {
            return (new EntityContext()).GetEntityBySurrogateKey<AplexControlMapping>(keyValue, loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<List<AplexControlMapping>> GetAplexControlMappingByField(string fieldName, object fieldValue, bool loadChildren, User user)
        {
            return (new EntityContext()).GetEntitiesByField<AplexControlMapping>(fieldName, fieldValue, loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<List<AplexControlMapping>> GetAllAplexControlMapping(bool loadChildren, User user)
        {
            return (new EntityContext()).GetAllEntities<AplexControlMapping>(loadChildren, user);
        }

        [WebMethod]
        public ServiceFunctionResult<int> GetTotalAplexControlMappingCount(User user)
        {
            return (new EntityContext()).GetTotalCount<AplexControlMapping>(user);
        }

        #endregion //Aplex Control Mapping

        #endregion //Basic Data Manipulation
    }
}