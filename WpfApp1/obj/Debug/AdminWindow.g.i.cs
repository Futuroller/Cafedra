﻿#pragma checksum "..\..\AdminWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "67EAAC42439B60F70289CD4A5A69E48F48FD431795FB9FA2BAE4F2256179E0EB"
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
using WpfApp1;


namespace WpfApp1 {
    
    
    /// <summary>
    /// AdminWindow
    /// </summary>
    public partial class AdminWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button tb_Users;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button tb_Courses;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button tb_Prof;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button tb_Depart;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b_Shedule;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button But_Exit;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/adminwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AdminWindow.xaml"
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
            this.tb_Users = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\AdminWindow.xaml"
            this.tb_Users.Click += new System.Windows.RoutedEventHandler(this.tb_Users_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tb_Courses = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\AdminWindow.xaml"
            this.tb_Courses.Click += new System.Windows.RoutedEventHandler(this.tb_Courses_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tb_Prof = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\AdminWindow.xaml"
            this.tb_Prof.Click += new System.Windows.RoutedEventHandler(this.tb_Prof_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tb_Depart = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\AdminWindow.xaml"
            this.tb_Depart.Click += new System.Windows.RoutedEventHandler(this.tb_Depart_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.b_Shedule = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\AdminWindow.xaml"
            this.b_Shedule.Click += new System.Windows.RoutedEventHandler(this.b_Shedule_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.But_Exit = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\AdminWindow.xaml"
            this.But_Exit.Click += new System.Windows.RoutedEventHandler(this.But_Exit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

