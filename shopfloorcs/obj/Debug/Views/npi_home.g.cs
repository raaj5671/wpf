﻿#pragma checksum "..\..\..\Views\npi_home.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B3A416C544942D3307DAA9BDBA0F521B5A3AF9C9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using shopfloorcs;


namespace shopfloorcs {
    
    
    /// <summary>
    /// npi_home
    /// </summary>
    public partial class npi_home : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\Views\npi_home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelLoginName;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Views\npi_home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnProductionLineConfig;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Views\npi_home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDefectCodeConfig;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Views\npi_home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnProcessConfig;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Views\npi_home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPartConfig;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Views\npi_home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnWorkShiftConfig;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\Views\npi_home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnProductConfig;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\Views\npi_home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBack;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/shopfloorcs;component/views/npi_home.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\npi_home.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.labelLoginName = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.btnProductionLineConfig = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\Views\npi_home.xaml"
            this.btnProductionLineConfig.Click += new System.Windows.RoutedEventHandler(this.btnProductionLineConfig_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnDefectCodeConfig = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.btnProcessConfig = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.btnPartConfig = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.btnWorkShiftConfig = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.btnProductConfig = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.btnBack = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\..\Views\npi_home.xaml"
            this.btnBack.Click += new System.Windows.RoutedEventHandler(this.btnExit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

