﻿#pragma checksum "..\..\..\AdminPanelScreen.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8AE5FF85A2A8E784F2F5853FB4520C6B448969BF"
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
using System.Windows.Controls.Ribbon;
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
using finalProjem;


namespace finalProjem {
    
    
    /// <summary>
    /// AdminPanelScreen
    /// </summary>
    public partial class AdminPanelScreen : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\AdminPanelScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid member_datagrid;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\AdminPanelScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid crawled_datagrid;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\AdminPanelScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_delete_member;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\AdminPanelScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_delete_crawled;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\AdminPanelScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_Close;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.11.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/finalProjem;component/adminpanelscreen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AdminPanelScreen.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.11.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.member_datagrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.crawled_datagrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.Btn_delete_member = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\AdminPanelScreen.xaml"
            this.Btn_delete_member.Click += new System.Windows.RoutedEventHandler(this.Btn_delete_member_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Btn_delete_crawled = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\AdminPanelScreen.xaml"
            this.Btn_delete_crawled.Click += new System.Windows.RoutedEventHandler(this.Btn_delete_crawled_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Btn_Close = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\AdminPanelScreen.xaml"
            this.Btn_Close.Click += new System.Windows.RoutedEventHandler(this.Btn_Close_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

