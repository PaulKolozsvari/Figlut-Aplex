﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5420
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Figlut.Aplex.Web.Data.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=ZAPKOLOZ\\SQL2008STANDARD;Initial Catalog=Figlut;Persist Security Info" +
            "=True;User ID=FiglutUser;Password=(L!3nT")]
        public string FiglutConnectionString {
            get {
                return ((string)(this["FiglutConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=ZAPKOLOZ\\SQL2008STANDARD;Persist Security Info=True;User ID=FiglutUse" +
            "r;Password=(L!3nT")]
        public string DataSourceConnectionString {
            get {
                return ((string)(this["DataSourceConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=PAULKOLOZSVD2AE\\SQL2008STANDARD;Initial Catalog=Figlut;Persist Securi" +
            "ty Info=True;User ID=FiglutUser;Password=password")]
        public string FiglutConnectionString1 {
            get {
                return ((string)(this["FiglutConnectionString1"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=PAULKOLOZSVD2AE\\SQL2008STANDARD;Initial Catalog=FiglutFiglut;Persist " +
            "Security Info=True;User ID=FiglutFiglutUser;Password=password")]
        public string FiglutFiglutConnectionString {
            get {
                return ((string)(this["FiglutFiglutConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=localhost\\SQL2008STANDARD;Initial Catalog=FiglutFiglut;Persist Securi" +
            "ty Info=True;User ID=FiglutFiglutUser;Password=password")]
        public string FiglutFiglutConnectionString1 {
            get {
                return ((string)(this["FiglutFiglutConnectionString1"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=PAULKOLOZSVD2AE\\SQL2008STANDARD;Initial Catalog=FiglutFiglut;Persist " +
            "Security Info=True;User ID=FiglutFiglutUser;Password=password")]
        public string FiglutFiglutConnectionString2 {
            get {
                return ((string)(this["FiglutFiglutConnectionString2"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=PAULKOLOZSVD2AE\\SQL2008STANDARD;Initial Catalog=FiglutAplex;Persist S" +
            "ecurity Info=True;User ID=FiglutAplexUser;Password=password")]
        public string FiglutAplexConnectionString {
            get {
                return ((string)(this["FiglutAplexConnectionString"]));
            }
        }
    }
}
