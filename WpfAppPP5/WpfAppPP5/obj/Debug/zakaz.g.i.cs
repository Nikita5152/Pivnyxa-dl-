﻿#pragma checksum "..\..\zakaz.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "21B0AE0D557D4C66CE8C21A12A164D267515DC2D4128F2FA940E74DEE50FD63A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using WpfAppPP5;


namespace WpfAppPP5 {
    
    
    /// <summary>
    /// zakaz
    /// </summary>
    public partial class zakaz : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\zakaz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Aqw;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\zakaz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameTbx;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\zakaz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameTbx1;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\zakaz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\zakaz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cb_zakachik;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\zakaz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_nazad;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\zakaz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cb_prodavec;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfAppPP5;component/zakaz.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\zakaz.xaml"
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
            this.Aqw = ((System.Windows.Controls.DataGrid)(target));
            
            #line 33 "..\..\zakaz.xaml"
            this.Aqw.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Aqw_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.NameTbx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.NameTbx1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.bt = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\zakaz.xaml"
            this.bt.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 38 "..\..\zakaz.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 39 "..\..\zakaz.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_3);
            
            #line default
            #line hidden
            return;
            case 7:
            this.cb_zakachik = ((System.Windows.Controls.ComboBox)(target));
            
            #line 40 "..\..\zakaz.xaml"
            this.cb_zakachik.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cb_zakachik_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.bt_nazad = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\zakaz.xaml"
            this.bt_nazad.Click += new System.Windows.RoutedEventHandler(this.Button_Click_4);
            
            #line default
            #line hidden
            return;
            case 9:
            this.cb_prodavec = ((System.Windows.Controls.ComboBox)(target));
            
            #line 42 "..\..\zakaz.xaml"
            this.cb_prodavec.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cb_prodavec_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
