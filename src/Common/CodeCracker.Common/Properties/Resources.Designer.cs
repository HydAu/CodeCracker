﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CodeCracker.Properties {
    using System;
    using System.Reflection;
    
    
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
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CodeCracker.Properties.Resources", typeof(Resources).GetTypeInfo().Assembly);
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
        ///   Looks up a localized string similar to Toggle between safe cast (&apos;as&apos;) and direct cast..
        /// </summary>
        public static string ChangeAsToCastAnalyzer_MessageFormat {
            get {
                return ResourceManager.GetString("ChangeAsToCastAnalyzer_MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Toggle between safe cast (&apos;as&apos;) and direct cast..
        /// </summary>
        public static string ChangeAsToCastAnalyzer_Title {
            get {
                return ResourceManager.GetString("ChangeAsToCastAnalyzer_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Change safe cast (&apos;as&apos;) to direct cast.
        /// </summary>
        public static string ChangeAsToCastCodeFixProvider_AsToCast {
            get {
                return ResourceManager.GetString("ChangeAsToCastCodeFixProvider_AsToCast", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Change direct cast to safe cast (&apos;as&apos;).
        /// </summary>
        public static string ChangeAsToCastCodeFixProvider_CastToAs {
            get {
                return ResourceManager.GetString("ChangeAsToCastCodeFixProvider_CastToAs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Change method Count() to property Count. .
        /// </summary>
        public static string ChangeCountMethodToPropertyAnalyzer_Description {
            get {
                return ResourceManager.GetString("ChangeCountMethodToPropertyAnalyzer_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Change method Count() to property Count..
        /// </summary>
        public static string ChangeCountMethodToPropertyAnalyzer_MessageFormat {
            get {
                return ResourceManager.GetString("ChangeCountMethodToPropertyAnalyzer_MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Change Count() to Count..
        /// </summary>
        public static string ChangeCountMethodToPropertyAnalyzer_Title {
            get {
                return ResourceManager.GetString("ChangeCountMethodToPropertyAnalyzer_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to String interpolation allows for better reading of the resulting string when compared to Console.WriteLine arguments. You should use Console.WriteLine with arguments only when another method is supplying the format string..
        /// </summary>
        public static string ConsoleWriteLineAnalyzer_Description {
            get {
                return ResourceManager.GetString("ConsoleWriteLineAnalyzer_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use string interpolation.
        /// </summary>
        public static string ConsoleWriteLineAnalyzer_MessageFormat {
            get {
                return ResourceManager.GetString("ConsoleWriteLineAnalyzer_MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use string interpolation instead of arguments on Console.WriteLine.
        /// </summary>
        public static string ConsoleWriteLineAnalyzer_Title {
            get {
                return ResourceManager.GetString("ConsoleWriteLineAnalyzer_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Change to string interpolation.
        /// </summary>
        public static string ConsoleWriteLineCodeFixProvider_Title {
            get {
                return ResourceManager.GetString("ConsoleWriteLineCodeFixProvider_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to none.
        /// </summary>
        public static string DefaultValue_None {
            get {
                return ResourceManager.GetString("DefaultValue_None", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An empty catch block suppress all errors and shouldn&apos;t be used.\r\nIf the error is expected consider logging it or changing the control flow such that it is explicit..
        /// </summary>
        public static string EmptyCatchBlockAnalyzer_Description {
            get {
                return ResourceManager.GetString("EmptyCatchBlockAnalyzer_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Empty Catch Block..
        /// </summary>
        public static string EmptyCatchBlockAnalyzer_Message {
            get {
                return ResourceManager.GetString("EmptyCatchBlockAnalyzer_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Catch block cannot be empty.
        /// </summary>
        public static string EmptyCatchBlockAnalyzer_Title {
            get {
                return ResourceManager.GetString("EmptyCatchBlockAnalyzer_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Insert Exception class to Catch.
        /// </summary>
        public static string EmptyCatchBlockCodeFixProvider_InsertException {
            get {
                return ResourceManager.GetString("EmptyCatchBlockCodeFixProvider_InsertException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove Empty Catch Block.
        /// </summary>
        public static string EmptyCatchBlockCodeFixProvider_Remove {
            get {
                return ResourceManager.GetString("EmptyCatchBlockCodeFixProvider_Remove", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove Empty Catch Block and Put a Documentation Link about Try...Catch use.
        /// </summary>
        public static string EmptyCatchBlockCodeFixProvider_RemoveAndDocumentation {
            get {
                return ResourceManager.GetString("EmptyCatchBlockCodeFixProvider_RemoveAndDocumentation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Change class &apos;{0}&apos; accessibility to be as accessible as class &apos;{1}&apos;.
        /// </summary>
        public static string InconsistentAccessibilityInBaseClass_Title {
            get {
                return ResourceManager.GetString("InconsistentAccessibilityInBaseClass_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Change interface &apos;{0}&apos; accessibility to be as accessible as interface &apos;{1}&apos;.
        /// </summary>
        public static string InconsistentAccessibilityInBaseInterface_Title {
            get {
                return ResourceManager.GetString("InconsistentAccessibilityInBaseInterface_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Change parameter type &apos;{0}&apos; accessibility to be as accessible as delegate &apos;{1}&apos;.
        /// </summary>
        public static string InconsistentAccessibilityInDelegateParameter_Title {
            get {
                return ResourceManager.GetString("InconsistentAccessibilityInDelegateParameter_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Change delegate return type &apos;{0}&apos; accessibility to be as accessible as delegate &apos;{1}&apos;.
        /// </summary>
        public static string InconsistentAccessibilityInDelegateReturnType_Title {
            get {
                return ResourceManager.GetString("InconsistentAccessibilityInDelegateReturnType_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Change field type &apos;{0}&apos; accessibility to be as accessible as field &apos;{1}&apos;.
        /// </summary>
        public static string InconsistentAccessibilityInFieldType_Title {
            get {
                return ResourceManager.GetString("InconsistentAccessibilityInFieldType_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Change parameter type &apos;{0}&apos; accessibility to be as accessible as indexer &apos;this[{1}]&apos;.
        /// </summary>
        public static string InconsistentAccessibilityInIndexerParameter_Title {
            get {
                return ResourceManager.GetString("InconsistentAccessibilityInIndexerParameter_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Change indexer return type &apos;{0}&apos; accessibility to be as accessible as indexer &apos;this[{1}]&apos;.
        /// </summary>
        public static string InconsistentAccessibilityInIndexerReturnType_Title {
            get {
                return ResourceManager.GetString("InconsistentAccessibilityInIndexerReturnType_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Change parameter type &apos;{0}&apos; accessibility to be as accessible as method &apos;{1}&apos;.
        /// </summary>
        public static string InconsistentAccessibilityInMethodParameter_Title {
            get {
                return ResourceManager.GetString("InconsistentAccessibilityInMethodParameter_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Change return type &apos;{0}&apos; accessibility to be as accessible as method &apos;{1}&apos;.
        /// </summary>
        public static string InconsistentAccessibilityInMethodReturnType_Title {
            get {
                return ResourceManager.GetString("InconsistentAccessibilityInMethodReturnType_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Change parameter type &apos;{0}&apos; accessibility to be as accessible as operator &apos;{1}&apos;.
        /// </summary>
        public static string InconsistentAccessibilityInOperatorParameter_Title {
            get {
                return ResourceManager.GetString("InconsistentAccessibilityInOperatorParameter_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Change return type &apos;{0}&apos; accessibility to be as accessible as operator &apos;{1}&apos;.
        /// </summary>
        public static string InconsistentAccessibilityInOperatorReturnType_Title {
            get {
                return ResourceManager.GetString("InconsistentAccessibilityInOperatorReturnType_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Change property type &apos;{0}&apos; accessibility to be as accessible as property &apos;{1}&apos;.
        /// </summary>
        public static string InconsistentAccessibilityInPropertyType_Title {
            get {
                return ResourceManager.GetString("InconsistentAccessibilityInPropertyType_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The default value &apos;{0}&apos; of parameter &apos;{1}&apos; doesn&apos;t match the default value &apos;{2}&apos; from the base definition &apos;{3}&apos;..
        /// </summary>
        public static string InconsistentParameterDefaultValueAnalyzer_MessageFormat {
            get {
                return ResourceManager.GetString("InconsistentParameterDefaultValueAnalyzer_MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Inconsistent parameter default value..
        /// </summary>
        public static string InconsistentParameterDefaultValueAnalyzer_Title {
            get {
                return ResourceManager.GetString("InconsistentParameterDefaultValueAnalyzer_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove the default value.
        /// </summary>
        public static string InconsistentParameterDefaultValueCodeFix_RemoveDefaultValue {
            get {
                return ResourceManager.GetString("InconsistentParameterDefaultValueCodeFix_RemoveDefaultValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use the value from the base definition.
        /// </summary>
        public static string InconsistentParameterDefaultValueCodeFix_UseValueFromBaseDefinition {
            get {
                return ResourceManager.GetString("InconsistentParameterDefaultValueCodeFix_UseValueFromBaseDefinition", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You may change this foreach loop to an equivalent Linq Expression..
        /// </summary>
        public static string LoopToLinq_Description {
            get {
                return ResourceManager.GetString("LoopToLinq_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Change foreach loop to a Linq expression.
        /// </summary>
        public static string LoopToLinq_MessageFormat {
            get {
                return ResourceManager.GetString("LoopToLinq_MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Change foreach loop to a Linq expression.
        /// </summary>
        public static string LoopToLinq_Title {
            get {
                return ResourceManager.GetString("LoopToLinq_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Make method non async.
        /// </summary>
        public static string MakeMethodNonAsyncCodeFixProvider_Title {
            get {
                return ResourceManager.GetString("MakeMethodNonAsyncCodeFixProvider_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to In C#6 the nameof() operator should be used to specify the name of a program element instead of a string literal as it produce code that is easier to refactor..
        /// </summary>
        public static string NameOfAnalyzer_Description {
            get {
                return ResourceManager.GetString("NameOfAnalyzer_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use &apos;nameof({0})&apos; instead of specifying the program element name..
        /// </summary>
        public static string NameOfAnalyzer_MessageFormat {
            get {
                return ResourceManager.GetString("NameOfAnalyzer_MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use nameof.
        /// </summary>
        public static string NameOfAnalyzer_Title {
            get {
                return ResourceManager.GetString("NameOfAnalyzer_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use nameof().
        /// </summary>
        public static string NameOfCodeFixProvider_Title {
            get {
                return ResourceManager.GetString("NameOfCodeFixProvider_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A call to &apos;Count({0}) &gt; 0&apos; can be changed to &apos;Any({0})&apos;.
        /// </summary>
        public static string PreferAnyToCountGreaterThanZeroAnalyzer_MessageFormat {
            get {
                return ResourceManager.GetString("PreferAnyToCountGreaterThanZeroAnalyzer_MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Prefer &apos;Any()&apos; to &apos;Count() &gt; 0&apos;.
        /// </summary>
        public static string PreferAnyToCountGreaterThanZeroAnalyzer_Title {
            get {
                return ResourceManager.GetString("PreferAnyToCountGreaterThanZeroAnalyzer_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove async and return task directly..
        /// </summary>
        public static string ReturnTaskInsteadOfAwait_Description {
            get {
                return ResourceManager.GetString("ReturnTaskInsteadOfAwait_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} can directly return a task..
        /// </summary>
        public static string ReturnTaskInsteadOfAwait_MessageFormat {
            get {
                return ResourceManager.GetString("ReturnTaskInsteadOfAwait_MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Return task instead of await..
        /// </summary>
        public static string ReturnTaskInsteadOfAwait_Title {
            get {
                return ResourceManager.GetString("ReturnTaskInsteadOfAwait_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove &apos;async&apos; and return directly..
        /// </summary>
        public static string ReturnTaskInsteadOfAwaitCodeFixProvider_Title {
            get {
                return ResourceManager.GetString("ReturnTaskInsteadOfAwaitCodeFixProvider_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Seal members of class &apos;{0}&apos;.
        /// </summary>
        public static string SealMemberAnalyzer_ClassMessageFormat {
            get {
                return ResourceManager.GetString("SealMemberAnalyzer_ClassMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If a member is overriding a base member, it could gain in performance by being sealed (not overridable)..
        /// </summary>
        public static string SealMemberAnalyzer_Description {
            get {
                return ResourceManager.GetString("SealMemberAnalyzer_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Seal member &apos;{0}&apos;.
        /// </summary>
        public static string SealMemberAnalyzer_MemberMessageFormat {
            get {
                return ResourceManager.GetString("SealMemberAnalyzer_MemberMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Seal class members.
        /// </summary>
        public static string SealMemberAnalyzer_Title {
            get {
                return ResourceManager.GetString("SealMemberAnalyzer_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Seal members of class &apos;{0}&apos;.
        /// </summary>
        public static string SealMemberCodeFixProvider_ClassTitle {
            get {
                return ResourceManager.GetString("SealMemberCodeFixProvider_ClassTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Seal member &apos;{0}&apos;.
        /// </summary>
        public static string SealMemberCodeFixProvider_MemberTitle {
            get {
                return ResourceManager.GetString("SealMemberCodeFixProvider_MemberTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to String interpolation allows for better reading of the resulting string when compared to String.Format. You should use String.Format only when another method is supplying the format string..
        /// </summary>
        public static string StringFormatAnalyzer_Description {
            get {
                return ResourceManager.GetString("StringFormatAnalyzer_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use string interpolation.
        /// </summary>
        public static string StringFormatAnalyzer_MessageFormat {
            get {
                return ResourceManager.GetString("StringFormatAnalyzer_MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use string interpolation instead of String.Format.
        /// </summary>
        public static string StringFormatAnalyzer_Title {
            get {
                return ResourceManager.GetString("StringFormatAnalyzer_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Change to string interpolation.
        /// </summary>
        public static string StringFormatCodeFixProvider_Title {
            get {
                return ResourceManager.GetString("StringFormatCodeFixProvider_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Auto properties offer a more concise way of defining a property. If you are using simple getters and setters you are able to simplify your code with autoproperties..
        /// </summary>
        public static string SwitchToAutoPropAnalyzer_Description {
            get {
                return ResourceManager.GetString("SwitchToAutoPropAnalyzer_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Change {0} to an auto property.
        /// </summary>
        public static string SwitchToAutoPropAnalyzer_MessageFormat {
            get {
                return ResourceManager.GetString("SwitchToAutoPropAnalyzer_MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use auto property.
        /// </summary>
        public static string SwitchToAutoPropAnalyzer_Title {
            get {
                return ResourceManager.GetString("SwitchToAutoPropAnalyzer_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Change to auto property.
        /// </summary>
        public static string SwitchToAutoPropCodeFixProvider_Title {
            get {
                return ResourceManager.GetString("SwitchToAutoPropCodeFixProvider_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This diagnostic checks the htmlColor value and triggers if the parsing fail by throwing an exception.
        /// </summary>
        public static string ValidateColorAnalyzer_Description {
            get {
                return ResourceManager.GetString("ValidateColorAnalyzer_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your htmlColor value doesn&apos;t exist.
        /// </summary>
        public static string ValidateColorAnalyzer_Message {
            get {
                return ResourceManager.GetString("ValidateColorAnalyzer_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Validate color.
        /// </summary>
        public static string ValidateColorAnalyzer_Title {
            get {
                return ResourceManager.GetString("ValidateColorAnalyzer_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You have missing/unexistent parameters in Xml Docs.
        /// </summary>
        public static string XmlDocumentationAnalyzer_Title {
            get {
                return ResourceManager.GetString("XmlDocumentationAnalyzer_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create missing parameters in xml docs.
        /// </summary>
        public static string XmlDocumentationCreateMissingParametersCodeFixProvider_Title {
            get {
                return ResourceManager.GetString("XmlDocumentationCreateMissingParametersCodeFixProvider_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove unexistent parameters in xml docs.
        /// </summary>
        public static string XmlDocumentationRemoveNonExistentParametersCodeFixProvider_Title {
            get {
                return ResourceManager.GetString("XmlDocumentationRemoveNonExistentParametersCodeFixProvider_Title", resourceCulture);
            }
        }
    }
}
