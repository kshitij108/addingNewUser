﻿#pragma checksum "..\..\..\InfoForm.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CB38D9E2F6FE83DCE8269ABF542D52C7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17379
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


namespace WpfApplication1 {
    
    
    /// <summary>
    /// InfoForm
    /// </summary>
    public partial class InfoForm : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\..\InfoForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbFirstName;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\InfoForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbLastName;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\InfoForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox pswType;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\InfoForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox birthMonthDefault;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\InfoForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label monthLabel;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\InfoForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label pswdLable;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\InfoForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox pswdTextbox;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\InfoForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox birthMonth;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\InfoForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label monthLabel2;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\..\InfoForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox birthDate;
        
        #line default
        #line hidden
        
        
        #line 183 "..\..\..\InfoForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label dateLable1;
        
        #line default
        #line hidden
        
        
        #line 187 "..\..\..\InfoForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddUser;
        
        #line default
        #line hidden
        
        
        #line 190 "..\..\..\InfoForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancel;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApplication1;component/infoform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\InfoForm.xaml"
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
            
            #line 8 "..\..\..\InfoForm.xaml"
            ((WpfApplication1.InfoForm)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TbFirstName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TbLastName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.pswType = ((System.Windows.Controls.ComboBox)(target));
            
            #line 41 "..\..\..\InfoForm.xaml"
            this.pswType.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.pswType_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.birthMonthDefault = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.monthLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.pswdLable = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.pswdTextbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.birthMonth = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            this.monthLabel2 = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.birthDate = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 12:
            this.dateLable1 = ((System.Windows.Controls.Label)(target));
            return;
            case 13:
            this.AddUser = ((System.Windows.Controls.Button)(target));
            
            #line 187 "..\..\..\InfoForm.xaml"
            this.AddUser.Click += new System.Windows.RoutedEventHandler(this.AddUSerValue);
            
            #line default
            #line hidden
            return;
            case 14:
            this.cancel = ((System.Windows.Controls.Button)(target));
            
            #line 190 "..\..\..\InfoForm.xaml"
            this.cancel.Click += new System.Windows.RoutedEventHandler(this.cancelButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

