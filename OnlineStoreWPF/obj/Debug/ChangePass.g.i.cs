﻿#pragma checksum "..\..\ChangePass.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DEB9648E997E44B84B9DE8394023A0FCD44D02CA728EEE448752776EE5EC278C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using OnlineStoreWPF;
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


namespace OnlineStoreWPF {
    
    
    /// <summary>
    /// ChangePass
    /// </summary>
    public partial class ChangePass : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\ChangePass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox History;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\ChangePass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox CurrentPass;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\ChangePass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox NewPass;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\ChangePass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox RNPass;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\ChangePass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backbtn;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\ChangePass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button confirmbtn;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\ChangePass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button New;
        
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
            System.Uri resourceLocater = new System.Uri("/OnlineStoreWPF;component/changepass.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ChangePass.xaml"
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
            this.History = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.CurrentPass = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 3:
            this.NewPass = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 15 "..\..\ChangePass.xaml"
            this.NewPass.PasswordChanged += new System.Windows.RoutedEventHandler(this.NPassCheck);
            
            #line default
            #line hidden
            return;
            case 4:
            this.RNPass = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 16 "..\..\ChangePass.xaml"
            this.RNPass.PasswordChanged += new System.Windows.RoutedEventHandler(this.RNPassCheck);
            
            #line default
            #line hidden
            return;
            case 5:
            this.backbtn = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\ChangePass.xaml"
            this.backbtn.Click += new System.Windows.RoutedEventHandler(this.backbtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.confirmbtn = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\ChangePass.xaml"
            this.confirmbtn.Click += new System.Windows.RoutedEventHandler(this.confirmbtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.New = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\ChangePass.xaml"
            this.New.Click += new System.Windows.RoutedEventHandler(this.New_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

