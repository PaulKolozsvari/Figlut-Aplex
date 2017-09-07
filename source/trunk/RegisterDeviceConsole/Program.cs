namespace RegisterDeviceConsole
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Figlut.Desktop.Utilities;
    using Figlut.Aplex.Desktop.Data.WebService;
    using Figlut.Aplex.Desktop.Data;

    #endregion //Using Directives

    class Program
    {
        #region Methods

        static void Main(string[] args)
        {
            try
            {
                Login();
                //SaveUser();
                //CreateCustomer("Eco Park");
                //ApproveDevicePendingApproval("RV2WJB270311-RV1WJB270515", "CarTracker.Mobile.exe", "Monagham Farm");
                //ApproveDevicePendingApproval("RV2WJB140290-RV1WJB180013", "CarTracker.Mobile.exe", "Monagham Farm");

                //ApproveDevicePendingApprovalVisitUs("RV2WJB221162-RV1WJB270285", "CarTracker.Mobile.exe", "Managed Living");
                //ApproveDevicePendingApprovalVisitUs("RV2WJB220800-RV1WJB240474", "CarTracker.Mobile.exe", "Managed Living");
                //ApproveDevicePendingApprovalVisitUs("RV2WJB281257-RV1WJB300237", "CarTracker.Mobile.exe", "Managed Living");
                //ApproveDevicePendingApprovalVisitUs("RV2WJB281536-RV1WJB300106", "CarTracker.Mobile.exe", "Managed Living");
                //ApproveDevicePendingApprovalVisitUs("RV2WJB221162-RV1WJB270285", "CarTracker.Mobile.exe", "MobiScan Demo");
                //ApproveDevicePendingApprovalVisitUs("RV2WJB391284-RV1WJB410516", "CarTracker.Mobile.exe", "Agrinet");
                //ApproveDevicePendingApprovalVisitUs("RV2WJB361773-RV1WJB380477", "CarTracker.Mobile.exe", "Agrinet");
                //ApproveDevicePendingApprovalVisitUs("RV2WJB220822-RV1WJB250194", "CarTracker.Mobile.exe", "Dev");
                //ApproveDevicePendingApprovalVisitUs("RV2WJB390479-RV1WJB410525", "CarTracker.Mobile.exe", "PebbleRock");
                //ApproveDevicePendingApprovalVisitUs("RV2WJB391285-RV1WJB410519", "CarTracker.Mobile.exe", "PebbleRock");
                //ApproveDevicePendingApprovalVisitUs("RV2WJB360902-RV1WJB380467", "CarTracker.Mobile.exe", "CaribbeanBeach");
                //ApproveDevicePendingApprovalVisitUs("RV2WJB371260-RV1WJB391753", "CarTracker.Mobile.exe", "CaribbeanBeach");
                //ApproveDevicePendingApprovalVisitUs("RV2WJB360968-RV1WJB370029", "CarTracker.Mobile.exe", "CaribbeanBeach");
                //ApproveDevicePendingApprovalVisitUs("RV2WJB361788-RV1WJB380475", "CarTracker.Mobile.exe", "Dainfern");
                //ApproveDevicePendingApprovalVisitUs("CH1CUB260053-CH0CUB271376", "CarTracker.Mobile.exe", "Dainfern");

                //ApproveDevicePendingApprovalVisitUs("RV2WJB371819-RV1WJB391895", "CarTracker.Mobile.exe", "Dainfern");
                //ApproveDevicePendingApprovalVisitUs("RV2WJB371451-RV1WJB391612", "CarTracker.Mobile.exe", "Dainfern");
                //ApproveDevicePendingApprovalVisitUs("RV2WJB200139-RV1WJB240344", "CarTracker.Mobile.exe", "Dainfern");
                //ApproveDevicePendingApprovalVisitUs("RV2WJB220139-RV1WJB270281", "CarTracker.Mobile.exe", "Eco Park");
                //ApproveDevicePendingApprovalVisitUs("XZFvp0SpOuJHTxuMfWygSXdJNYQ=", "CarTracker.Mobile.exe", "Dainfern");
                //ApproveDevicePendingApprovalVisitUs("sLShzxpuLQixKgGSTk2QnJLAnXY=", "VisitUs.Mobile.exe", "Monagham Farm");
                //ApproveDevicePendingApprovalVisitUs("1epvFYxB3YLE0U3HzQHks+PCijA=", "VisitUs.Mobile.exe", "Monagham Farm");

                ApproveDevicePendingApprovalVisitUs("fLs17dyO9M342j9OuhUuevk+rE0=", "CarTracker.Mobile.exe", "Dainfern");
                ApproveDevicePendingApprovalVisitUs("1jyGm/OXbaAy+vt9XyqKnViqs2o=", "CarTracker.Mobile.exe", "Dainfern");


                //ApproveDevicePendingApprovalCabster("VG7WJ-RYB63-JMR42-PDTD9-MQGKY", "Figlut.Cabster.exe", "Figlut Africa");
                //ApproveDevicePendingApprovalCabster("P22P6-7JVMV-WBM7P-XTRXP-BT8G9", "Figlut.Cabster.exe", "Figlut Africa");
                //ApproveDevicePendingApprovalCabster("2QBP3-289MF-9364X-37XGX-24W6P", "Figlut.Cabster.exe", "Figlut Africa");
                //ApproveDevicePendingApprovalCabster("MQRP7-QCPT7-TH6DJ-TK7C7-9GGX7", "Figlut.Cabster.exe", "Figlut Africa"); //My MAC Windows 7
                //ApproveDevicePendingApprovalCabster("32KD2-K9CTF-M3DJT-4J3WC-733WD", "Figlut.Cabster.exe", "Figlut Africa"); //Pablo (in Argentina)
                //ApproveDevicePendingApprovalCabster("D63MH-FDMP2-RJGQT-T3F33-WP3YD", "Figlut.Cabster.exe", "Figlut Africa"); //Ernst (Figlut)

                //ApproveDevicePendingApprovalTripInspection("RV2WJB221162-RV1WJB270285", "Figlut.TripInspection.exe", "SuperGroup");
                //ApproveDevicePendingApprovalTripInspection("RV2WJB281229-RV1WJB300144", "Figlut.TripInspection.exe", "UTI");

                //SaveDeviceConfig();
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        private static void Login()
        {
            Console.Write("Attempting to login ... ");
            ServiceFunctionResultOfUser result = GlobalDataCache.Instance.Service.Login(
                "FiglutSystemUser",
                "(L!3nT", 
                UserRoleId.System);
            if (result.Code != ServiceResultCode.Success)
            {
                throw new Exception("Invalid user name /password.");
            }
            GlobalDataCache.Instance.CurrentUser = result.Contents;
            Console.WriteLine("done.");
        }

        private static void SaveUser()
        {
            Console.Write("Saving user ... ");
            User user = new User()
            {
                UserId = Guid.NewGuid(),
                UserName = "paulk",
                Password = "123456",
                RoleId = 7,
                Name = "Paul",
                Surname = "Kolozsvari",
                Email = "paulkolo@gmail.com",
                DateCreated = DateTime.Now,
                Phone = "0833958283"
            };
            ServiceProcedureResult result = GlobalDataCache.Instance.Service.SaveUser(new User[] { user }, GlobalDataCache.Instance.CurrentUser, false);
            if (result.Code != ServiceResultCode.Success)
            {
                throw new Exception(result.Message);
            }
            Console.WriteLine("done.");
        }

        private static void CreateCustomer(string customerName)
        {
            Console.Write("Saving customer ... ");
            Customer customer = new Customer()
            {
                CustomerId = Guid.NewGuid(),
                CompanyName = customerName,
                DateCreated = DateTime.Now
            };
            ServiceProcedureResult result = GlobalDataCache.Instance.Service.SaveCustomer(new Customer[] { customer }, GlobalDataCache.Instance.CurrentUser, false);
            if (result.Code != ServiceResultCode.Success)
            {
                throw new Exception(result.Message);
            }
            Console.WriteLine("done.");
        }

        private static void ApproveDevicePendingApprovalTripInspection(string deviceId, string applicationName, string companyName)
        {
            Console.Write("Approving device pending approval for Trip Inspection... ");
            string applicationWebServiceURL = "http://www.r2mslive.co.za/R2MSWebService/BulkUpload.asmx";
            string applicationReplicationWebServiceURL = "http://41.86.108.77/CarTrackerMobileSync/sqlcesa35.dll";
            string FiglutWebServiceURL = "http://184.22.83.112/Figlut.Web.Service/Service.asmx";
            ServiceFunctionResultOfListOfCustomer resultCustomer = GlobalDataCache.Instance.Service.GetCustomerByField(
                EntityReader<Customer>.GetPropertyName(p => p.CompanyName, false),
                companyName,
                false,
                GlobalDataCache.Instance.CurrentUser);
            if (resultCustomer.Code != ServiceResultCode.Success)
            {
                throw new Exception(resultCustomer.Message);
            }
            Customer customer = resultCustomer.Contents[0];
            ServiceProcedureResult approvalResult = GlobalDataCache.Instance.Service.ApproveDevicePendingApproval(
                deviceId,
                applicationName,
                applicationWebServiceURL,
                applicationReplicationWebServiceURL,
                FiglutWebServiceURL,
                30,
                customer,
                GlobalDataCache.Instance.CurrentUser);
            if (approvalResult.Code != ServiceResultCode.Success)
            {
                throw new Exception(approvalResult.Message);
            }
            Console.WriteLine("done");
        }

        private static void ApproveDevicePendingApprovalVisitUs(string deviceId, string applicationName, string companyName)
        {
            Console.Write("Approving device pending approval for Visit Us... ");
            //string applicationWebServiceURL = "http://41.86.108.77/PebbleRock.CarTracker.Web.Service/Service.asmx";
            //string applicationReplicationWebServiceURL = "http://41.86.108.77/PebbleRockMobileSync/sqlcesa35.dll";
            //string applicationWebServiceURL = "http://41.86.108.77/Caribbean.CarTracker.Web.Service/Service.asmx";
            //string applicationReplicationWebServiceURL = "http://41.86.108.77/CaribbeanRockMobileSync/sqlcesa35.dll";

            //string applicationWebServiceURL = "http://41.86.108.77/Monaghan.VisitUs.Web.Service/Service.asmx";
            //string applicationReplicationWebServiceURL = null;
            //string FiglutWebServiceURL = "http://41.76.214.230/Figlut.Web.Service/Service.asmx";

            //string applicationWebServiceURL = "http://41.86.108.77/EcoPark.CarTracker.Web.Service/Service.asmx";
            //string applicationReplicationWebServiceURL = "http://41.86.108.77/EcoPark.CarTracker.Web.Service/SyncService.svc";
            //string FiglutWebServiceURL = "http://184.22.83.112/Figlut.Web.Service/Service.asmx";

            string applicationWebServiceURL = "http://41.86.108.77/Dainfern.CarTracker.Web.Service/Service.asmx";
            string applicationReplicationWebServiceURL = "http://41.86.108.77/Dainfern.CarTracker.Web.Service/SyncService.svc";
            string FiglutWebServiceURL = "http://41.76.214.230/Figlut.Web.Service/Service.asmx";

            ServiceFunctionResultOfListOfCustomer resultCustomer = GlobalDataCache.Instance.Service.GetCustomerByField(
                EntityReader<Customer>.GetPropertyName(p => p.CompanyName, false),
                companyName,
                false,
                GlobalDataCache.Instance.CurrentUser);
            if (resultCustomer.Code != ServiceResultCode.Success)
            {
                throw new Exception(resultCustomer.Message);
            }
            Customer customer = resultCustomer.Contents[0];
            ServiceProcedureResult approvalResult = GlobalDataCache.Instance.Service.ApproveDevicePendingApproval(
                deviceId,
                applicationName,
                applicationWebServiceURL,
                applicationReplicationWebServiceURL,
                FiglutWebServiceURL,
                730,
                customer,
                GlobalDataCache.Instance.CurrentUser);
            if (approvalResult.Code != ServiceResultCode.Success)
            {
                throw new Exception(approvalResult.Message);
            }
            Console.WriteLine("done");
        }

        private static void ApproveDevicePendingApprovalCabster(string deviceId, string applicationName, string companyName)
        {
            Console.Write("Approving device pending approval for Figlut Cabster... ");
            DateTime licenseExpiryDate = DateTime.Now.Add(new TimeSpan(365, 0, 0, 0));
            string FiglutWebServiceURL = "http://184.22.83.112/Figlut.Web.Service/Service.asmx";
            ServiceFunctionResultOfListOfCustomer resultCustomer = GlobalDataCache.Instance.Service.GetCustomerByField(
                EntityReader<Customer>.GetPropertyName(p => p.CompanyName, false),
                companyName,
                false,
                GlobalDataCache.Instance.CurrentUser);
            if (resultCustomer.Code != ServiceResultCode.Success)
            {
                throw new Exception(resultCustomer.Message);
            }
            Customer customer = resultCustomer.Contents[0];
            ServiceProcedureResult approvalResult = GlobalDataCache.Instance.Service.ApproveDevicePendingApproval(
                deviceId,
                applicationName,
                null,
                null,
                FiglutWebServiceURL,
                365,
                customer,
                GlobalDataCache.Instance.CurrentUser);
            if (approvalResult.Code != ServiceResultCode.Success)
            {
                throw new Exception(approvalResult.Message);
            }
            Console.WriteLine("done");
        }

        private static void SaveDeviceConfig()
        {
            Console.Write("Saving device config ... ");

            string companyName = "Monagham Farm";
            string deviceId = "RV2WJB270311-RV1WJB270515";
            DateTime licenseExpiryDate = DateTime.Now.Add(new TimeSpan(30, 0, 0, 0));
            ServiceFunctionResultOfListOfCustomer resultCustomer = GlobalDataCache.Instance.Service.GetCustomerByField(
                EntityReader<Customer>.GetPropertyName(p => p.CompanyName, false),
                companyName,
                false,
                GlobalDataCache.Instance.CurrentUser);
            if (resultCustomer.Code != ServiceResultCode.Success)
            {
                throw new Exception(resultCustomer.Message);
            }
            Customer customer = resultCustomer.Contents[0];

            ServiceFunctionResultOfListOfDeviceConfig resultDeviceConfigQuery = GlobalDataCache.Instance.Service.GetDeviceConfigByField(
                EntityReader<DeviceConfig>.GetPropertyName(p => p.DeviceId, false),
                deviceId,
                false,
                GlobalDataCache.Instance.CurrentUser);
            if (resultDeviceConfigQuery.Code != ServiceResultCode.Success)
            {
                throw new Exception(resultDeviceConfigQuery.Message);
            }
            DeviceConfig deviceConfig = null;
            if (resultDeviceConfigQuery.Contents == null || resultDeviceConfigQuery.Contents.Length < 1)
            {
                deviceConfig = new DeviceConfig() { DeviceConfigId = Guid.NewGuid(), DeviceId = deviceId, DateCreated = DateTime.Now };
            }
            else
            {
                deviceConfig = resultDeviceConfigQuery.Contents[0];
            }
            deviceConfig.ApplicationName = "CarTracker.Mobile.exe";
            deviceConfig.ApplicationWebServiceURL = "http://169.254.2.2/CarTracker.Web.Service/Service.asmx";
            deviceConfig.ApplicationReplicationWebServiceURL = "http://169.254.2.2/CarTrackerMobileSync/sqlcesa35.dll";
            deviceConfig.ClientConfigWebServiceURL = "http://169.254.2.2/Figlut.Web.Service/Service.asmx";
            deviceConfig.LicenseExpiryDate = licenseExpiryDate;
            deviceConfig.CustomerId = customer.CustomerId;

            ServiceProcedureResult resultDeviceConfig = GlobalDataCache.Instance.Service.SaveDeviceConfig(
                new DeviceConfig[] { deviceConfig },
                GlobalDataCache.Instance.CurrentUser,
                false);
            if (resultDeviceConfig.Code != ServiceResultCode.Success)
            {
                throw new Exception(resultDeviceConfig.Message);
            }
            Console.WriteLine("done.");
        }

        #endregion //Methods
    }
}