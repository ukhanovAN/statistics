﻿#pragma checksum "..\..\..\Karkina.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7AE284B0B4BA3BF5274A2AE214E8C85A81DEBF52"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ScottPlot;
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
using gitt;


namespace gitt {
    
    
    /// <summary>
    /// Karkina
    /// </summary>
    public partial class Karkina : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\Karkina.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ScottPlot.WpfPlot WpfPlot1;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Karkina.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttton_One;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Karkina.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttton_Two;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Karkina.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock_one;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Karkina.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGrid_Table;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/gitt;component/karkina.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Karkina.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.WpfPlot1 = ((ScottPlot.WpfPlot)(target));
            return;
            case 2:
            this.buttton_One = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\Karkina.xaml"
            this.buttton_One.Click += new System.Windows.RoutedEventHandler(this.buttton_One_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.buttton_Two = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\Karkina.xaml"
            this.buttton_Two.Click += new System.Windows.RoutedEventHandler(this.buttton_Two_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.textBlock_one = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.dataGrid_Table = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

