﻿#pragma checksum "..\..\Platform.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E03A295A0EC324CCEAC595BAA8D800FBB2FA9821"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using R6GUI;
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


namespace R6GUI {
    
    
    /// <summary>
    /// Platform
    /// </summary>
    public partial class Platform : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 56 "..\..\Platform.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button setPlatformPC;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\Platform.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button setPlatformXBOX;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\Platform.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button setPlatformPS;
        
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
            System.Uri resourceLocater = new System.Uri("/R6GUI;component/platform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Platform.xaml"
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
            this.setPlatformPC = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\Platform.xaml"
            this.setPlatformPC.Click += new System.Windows.RoutedEventHandler(this.PCButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.setPlatformXBOX = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\Platform.xaml"
            this.setPlatformXBOX.Click += new System.Windows.RoutedEventHandler(this.XBOXButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.setPlatformPS = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\Platform.xaml"
            this.setPlatformPS.Click += new System.Windows.RoutedEventHandler(this.PSXButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
