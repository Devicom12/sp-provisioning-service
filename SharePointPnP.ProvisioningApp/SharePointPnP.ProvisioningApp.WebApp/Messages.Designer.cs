﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Messages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Messages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SharePointPnP.ProvisioningApp.WebApp.Messages", typeof(Messages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The URL provided is already in use and the current package cannot be provisioned onto an already existing site. Please provide a different URL..
        /// </summary>
        public static string CannotProvisionOntoExistingSite {
            get {
                return ResourceManager.GetString("CannotProvisionOntoExistingSite", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Provisioning completed..
        /// </summary>
        public static string ProvisioningCompleted {
            get {
                return ResourceManager.GetString("ProvisioningCompleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unfortunately your site provisioning at least partially failed!.
        /// </summary>
        public static string ProvisioningFailed {
            get {
                return ResourceManager.GetString("ProvisioningFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Provisioning in progress ....
        /// </summary>
        public static string ProvisioningInProgress {
            get {
                return ResourceManager.GetString("ProvisioningInProgress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Provisioning status.
        /// </summary>
        public static string ProvisioningStatusTitle {
            get {
                return ResourceManager.GetString("ProvisioningStatusTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The URL provided is already in use. If you will proceed, the template will be applied on top of the already existing site and its contents might be replaced..
        /// </summary>
        public static string TargetSiteAlreadyExists {
            get {
                return ResourceManager.GetString("TargetSiteAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The URL provided is already in use and the target site is based on a template that is not valid for the current package. Please provide a different URL..
        /// </summary>
        public static string TargetSiteBaseTemplateIdIsInvalid {
            get {
                return ResourceManager.GetString("TargetSiteBaseTemplateIdIsInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Validating prerequisites ....
        /// </summary>
        public static string ValidatingPreRequisites {
            get {
                return ResourceManager.GetString("ValidatingPreRequisites", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Validating site URL....
        /// </summary>
        public static string ValidatingSiteUrl {
            get {
                return ResourceManager.GetString("ValidatingSiteUrl", resourceCulture);
            }
        }
    }
}
