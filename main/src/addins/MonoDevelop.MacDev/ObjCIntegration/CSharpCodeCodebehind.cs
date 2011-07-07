﻿// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.MacDev.ObjCIntegration {
    using MonoDevelop.MacDev.ObjCIntegration;
    using System.Collections.Generic;
    using System.Linq;
    using System;
    
    
    public partial class CSharpCodeCodebehind : CodebehindTemplateBase {
        
        
        #line 45 "/Users/michael/Mono/monodevelop/main/src/addins/MonoDevelop.MacDev/ObjCIntegration/CSharpCodeCodebehind.tt"
        
void AddParameters (IBAction action)
{
	bool isFirst = true;
	foreach (var p in action.Parameters) {
		if (!isFirst) {
			Write (", ");
		} else {
			isFirst = false;
		}
		Write (p.CliType);
		Write (" ");
		Write (EscapeIdentifier (p.Name));
	}
}

        #line default
        #line hidden
        
        public override string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 5 "/Users/michael/Mono/monodevelop/main/src/addins/MonoDevelop.MacDev/ObjCIntegration/CSharpCodeCodebehind.tt"
            this.Write("// WARNING\n//\n// This file has been generated automatically by MonoDevelop to store outlets and\n// actions made in the Xcode designer. If it is removed, they will be lost.\n// Manual changes to this file may not be handled correctly.\n//\nusing ");
            
            #line default
            #line hidden
            
            #line 11 "/Users/michael/Mono/monodevelop/main/src/addins/MonoDevelop.MacDev/ObjCIntegration/CSharpCodeCodebehind.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( WrapperNamespace ));
            
            #line default
            #line hidden
            
            #line 11 "/Users/michael/Mono/monodevelop/main/src/addins/MonoDevelop.MacDev/ObjCIntegration/CSharpCodeCodebehind.tt"
            this.Write(".Foundation;\n\nnamespace ");
            
            #line default
            #line hidden
            
            #line 13 "/Users/michael/Mono/monodevelop/main/src/addins/MonoDevelop.MacDev/ObjCIntegration/CSharpCodeCodebehind.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( GetNs (Types.First().CliName) ));
            
            #line default
            #line hidden
            
            #line 13 "/Users/michael/Mono/monodevelop/main/src/addins/MonoDevelop.MacDev/ObjCIntegration/CSharpCodeCodebehind.tt"
            this.Write("\n{\n");
            
            #line default
            #line hidden
            
            #line 15 "/Users/michael/Mono/monodevelop/main/src/addins/MonoDevelop.MacDev/ObjCIntegration/CSharpCodeCodebehind.tt"

bool firstClass = true;
foreach (var nso in Types) {
	string name = GetName (nso.CliName);
	BlankLine (ref firstClass);
	if (nso.IsRegisteredInDesigner) {

            
            #line default
            #line hidden
            
            #line 22 "/Users/michael/Mono/monodevelop/main/src/addins/MonoDevelop.MacDev/ObjCIntegration/CSharpCodeCodebehind.tt"
            this.Write("\t[Register (\"");
            
            #line default
            #line hidden
            
            #line 22 "/Users/michael/Mono/monodevelop/main/src/addins/MonoDevelop.MacDev/ObjCIntegration/CSharpCodeCodebehind.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(nso.ObjCName ));
            
            #line default
            #line hidden
            
            #line 22 "/Users/michael/Mono/monodevelop/main/src/addins/MonoDevelop.MacDev/ObjCIntegration/CSharpCodeCodebehind.tt"
            this.Write("\")]\n");
            
            #line default
            #line hidden
            
            #line 23 "/Users/michael/Mono/monodevelop/main/src/addins/MonoDevelop.MacDev/ObjCIntegration/CSharpCodeCodebehind.tt"
	} 
            
            #line default
            #line hidden
            
            #line 24 "/Users/michael/Mono/monodevelop/main/src/addins/MonoDevelop.MacDev/ObjCIntegration/CSharpCodeCodebehind.tt"
            this.Write("\tpartial class ");
            
            #line default
            #line hidden
            
            #line 24 "/Users/michael/Mono/monodevelop/main/src/addins/MonoDevelop.MacDev/ObjCIntegration/CSharpCodeCodebehind.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(name ));
            
            #line default
            #line hidden
            
            #line 24 "/Users/michael/Mono/monodevelop/main/src/addins/MonoDevelop.MacDev/ObjCIntegration/CSharpCodeCodebehind.tt"
            this.Write("\n\t{\n");
            
            #line default
            #line hidden
            
            #line 26 "/Users/michael/Mono/monodevelop/main/src/addins/MonoDevelop.MacDev/ObjCIntegration/CSharpCodeCodebehind.tt"
	bool firstMember = true;
	foreach (var outlet in nso.Outlets.Where (o => o.IsDesigner)) {
		BlankLine (ref firstMember);
		if (outlet.CliName == outlet.ObjCName) { 
            
            #line default
            #line hidden
            
            #line 30 "/Users/michael/Mono/monodevelop/main/src/addins/MonoDevelop.MacDev/ObjCIntegration/CSharpCodeCodebehind.tt"
            this.Write("\t\t[Outlet]\n");
            
            #line default
            #line hidden
            
            #line 31 "/Users/michael/Mono/monodevelop/main/src/addins/MonoDevelop.MacDev/ObjCIntegration/CSharpCodeCodebehind.tt"
		} else { 
            
            #line default
            #line hidden
            
            #line 32 "/Users/michael/Mono/monodevelop/main/src/addins/MonoDevelop.MacDev/ObjCIntegration/CSharpCodeCodebehind.tt"
            this.Write("\t\t[Outlet (\"");
            
            #line default
            #line hidden
            
            #line 32 "/Users/michael/Mono/monodevelop/main/src/addins/MonoDevelop.MacDev/ObjCIntegration/CSharpCodeCodebehind.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(outlet.ObjCName));
            
            #line default
            #line hidden
            
            #line 32 "/Users/michael/Mono/monodevelop/main/src/addins/MonoDevelop.MacDev/ObjCIntegration/CSharpCodeCodebehind.tt"
            this.Write("\")]\n");
            
            #line default
            #line hidden
            
            #line 33 "/Users/michael/Mono/monodevelop/main/src/addins/MonoDevelop.MacDev/ObjCIntegration/CSharpCodeCodebehind.tt"
		} 
            
            #line default
            #line hidden
            
            #line 34 "/Users/michael/Mono/monodevelop/main/src/addins/MonoDevelop.MacDev/ObjCIntegration/CSharpCodeCodebehind.tt"
            this.Write("\t\t");
            
            #line default
            #line hidden
            
            #line 34 "/Users/michael/Mono/monodevelop/main/src/addins/MonoDevelop.MacDev/ObjCIntegration/CSharpCodeCodebehind.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(outlet.CliType));
            
            #line default
            #line hidden
            
            #line 34 "/Users/michael/Mono/monodevelop/main/src/addins/MonoDevelop.MacDev/ObjCIntegration/CSharpCodeCodebehind.tt"
            this.Write(" ");
            
            #line default
            #line hidden
            
            #line 34 "/Users/michael/Mono/monodevelop/main/src/addins/MonoDevelop.MacDev/ObjCIntegration/CSharpCodeCodebehind.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(EscapeIdentifier (outlet.CliName)));
            
            #line default
            #line hidden
            
            #line 34 "/Users/michael/Mono/monodevelop/main/src/addins/MonoDevelop.MacDev/ObjCIntegration/CSharpCodeCodebehind.tt"
            this.Write(" { get; set; }\n");
            
            #line default
            #line hidden
            
            #line 35 "/Users/michael/Mono/monodevelop/main/src/addins/MonoDevelop.MacDev/ObjCIntegration/CSharpCodeCodebehind.tt"
	}
	foreach (var action in nso.Actions.Where (a => a.IsDesigner)) {
   		BlankLine (ref firstMember); 
            
            #line default
            #line hidden
            
            #line 38 "/Users/michael/Mono/monodevelop/main/src/addins/MonoDevelop.MacDev/ObjCIntegration/CSharpCodeCodebehind.tt"
            this.Write("\t\t[Action (\"");
            
            #line default
            #line hidden
            
            #line 38 "/Users/michael/Mono/monodevelop/main/src/addins/MonoDevelop.MacDev/ObjCIntegration/CSharpCodeCodebehind.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(action.GetObjcFullName ()));
            
            #line default
            #line hidden
            
            #line 38 "/Users/michael/Mono/monodevelop/main/src/addins/MonoDevelop.MacDev/ObjCIntegration/CSharpCodeCodebehind.tt"
            this.Write("\")]\n\t\tpartial void ");
            
            #line default
            #line hidden
            
            #line 39 "/Users/michael/Mono/monodevelop/main/src/addins/MonoDevelop.MacDev/ObjCIntegration/CSharpCodeCodebehind.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(EscapeIdentifier (action.CliName)));
            
            #line default
            #line hidden
            
            #line 39 "/Users/michael/Mono/monodevelop/main/src/addins/MonoDevelop.MacDev/ObjCIntegration/CSharpCodeCodebehind.tt"
            this.Write(" (");
            
            #line default
            #line hidden
            
            #line 39 "/Users/michael/Mono/monodevelop/main/src/addins/MonoDevelop.MacDev/ObjCIntegration/CSharpCodeCodebehind.tt"
 AddParameters (action); 
            
            #line default
            #line hidden
            
            #line 40 "/Users/michael/Mono/monodevelop/main/src/addins/MonoDevelop.MacDev/ObjCIntegration/CSharpCodeCodebehind.tt"
            this.Write(");\n");
            
            #line default
            #line hidden
            
            #line 41 "/Users/michael/Mono/monodevelop/main/src/addins/MonoDevelop.MacDev/ObjCIntegration/CSharpCodeCodebehind.tt"
	} 
            
            #line default
            #line hidden
            
            #line 42 "/Users/michael/Mono/monodevelop/main/src/addins/MonoDevelop.MacDev/ObjCIntegration/CSharpCodeCodebehind.tt"
            this.Write("\t}\n");
            
            #line default
            #line hidden
            
            #line 43 "/Users/michael/Mono/monodevelop/main/src/addins/MonoDevelop.MacDev/ObjCIntegration/CSharpCodeCodebehind.tt"
} 
            
            #line default
            #line hidden
            
            #line 44 "/Users/michael/Mono/monodevelop/main/src/addins/MonoDevelop.MacDev/ObjCIntegration/CSharpCodeCodebehind.tt"
            this.Write("}\n");
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        protected override void Initialize() {
            base.Initialize();
        }
    }
}
