﻿#pragma checksum "..\..\sotrudnik.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1A8625A30A0C085C17443596A3DEBF57BDB87B95EB1038FFF0F48F7D11BCFD79"
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
    /// sotrudnik
    /// </summary>
    public partial class sotrudnik : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\sotrudnik.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Aqw;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\sotrudnik.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameTbx;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\sotrudnik.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameTbx1;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\sotrudnik.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameTbx2;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\sotrudnik.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\sotrudnik.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_nazad;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\sotrudnik.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cb_sotrudnik;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfAppPP5;component/sotrudnik.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\sotrudnik.xaml"
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
            
            #line 33 "..\..\sotrudnik.xaml"
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
            this.NameTbx2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.bt = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\sotrudnik.xaml"
            this.bt.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 40 "..\..\sotrudnik.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 41 "..\..\sotrudnik.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_3);
            
            #line default
            #line hidden
            return;
            case 8:
            this.bt_nazad = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\sotrudnik.xaml"
            this.bt_nazad.Click += new System.Windows.RoutedEventHandler(this.Button_Click_4);
            
            #line default
            #line hidden
            return;
            case 9:
            this.cb_sotrudnik = ((System.Windows.Controls.ComboBox)(target));
            
            #line 43 "..\..\sotrudnik.xaml"
            this.cb_sotrudnik.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cb_sotrudnik_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

