﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CoreInteractionFramework.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CoreInteractionFramework.Properties.Resources", typeof(Resources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The method SetCapturedHitTestInformation was called on a HitTestResult which was not captured. Call SetUncapturedHitTestInformation instead..
        /// </summary>
        internal static string CalledCapturedHitTestInformationForReleasedElement {
            get {
                return ResourceManager.GetString("CalledCapturedHitTestInformationForReleasedElement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The method SetUncapturedHitTestInformation was called on a HitTestResult which was captured. Call SetCapturedHitTestInformation instead..
        /// </summary>
        internal static string CalledReleaseHitTestInformationForCapturedElement {
            get {
                return ResourceManager.GetString("CalledReleaseHitTestInformationForCapturedElement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Controller property on IInputElementStateMachine {0} is set to a different UIController then it was hit tested to..
        /// </summary>
        internal static string ControllerSetToADifferentController {
            get {
                return ResourceManager.GetString("ControllerSetToADifferentController", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The IHitTestDetails supplied: {0} were not of type {1} as is required by {2}..
        /// </summary>
        internal static string HitTestDetailsMustBeTypeofException {
            get {
                return ResourceManager.GetString("HitTestDetailsMustBeTypeofException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The orientation {0} is not valid for property {1}..
        /// </summary>
        internal static string InvalidOrientationArgumentException {
            get {
                return ResourceManager.GetString("InvalidOrientationArgumentException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The item is already in this collection or another collection.
        /// </summary>
        internal static string ItemIsAlreadyInCollection {
            get {
                return ResourceManager.GetString("ItemIsAlreadyInCollection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The item provided is not in the ListBoxStateMachine&apos;s {0} collection..
        /// </summary>
        internal static string ItemNotInCollection {
            get {
                return ResourceManager.GetString("ItemNotInCollection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The maximum size for the controller queue {0} touch events was reached..
        /// </summary>
        internal static string MaximumQueueSizeReached {
            get {
                return ResourceManager.GetString("MaximumQueueSizeReached", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to X={0}, Y={1}.
        /// </summary>
        internal static string PointFToStringFormat {
            get {
                return ResourceManager.GetString("PointFToStringFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Width={0}, Height={1}.
        /// </summary>
        internal static string SizeFToStringFormat {
            get {
                return ResourceManager.GetString("SizeFToStringFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The StateMachine provided was of type {0}, but must be of type {0}.  This could be because the touch is already captured to type {1}..
        /// </summary>
        internal static string StateMachineMustBeOfType {
            get {
                return ResourceManager.GetString("StateMachineMustBeOfType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Update cannot be called while Update is executing..
        /// </summary>
        internal static string UpdateCannotBeCalledDuringUpdate {
            get {
                return ResourceManager.GetString("UpdateCannotBeCalledDuringUpdate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to X={0}, Y={1}.
        /// </summary>
        internal static string VectorToStringFormat {
            get {
                return ResourceManager.GetString("VectorToStringFormat", resourceCulture);
            }
        }
    }
}
