﻿#pragma checksum "..\..\..\Okna\PolzovatelskoeSoglashenie.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7973DFC255D50CF04CDB7E3CC2EB1D90BE9795DE65D487FD2113E1416A72DB23"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using LegistOS.Okna;
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


namespace LegistOS.Okna {
    
    
    /// <summary>
    /// PolzovatelskoeSoglashenie
    /// </summary>
    public partial class PolzovatelskoeSoglashenie : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\Okna\PolzovatelskoeSoglashenie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImgLogoMal;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Okna\PolzovatelskoeSoglashenie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSoglObrPersonDann;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Okna\PolzovatelskoeSoglashenie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImgObrPersDann;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Okna\PolzovatelskoeSoglashenie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnPolzovatelSoglashen;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Okna\PolzovatelskoeSoglashenie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImgPolzSoglas;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Okna\PolzovatelskoeSoglashenie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame FUrSoglDoc;
        
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
            System.Uri resourceLocater = new System.Uri("/LegistOS;component/okna/polzovatelskoesoglashenie.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Okna\PolzovatelskoeSoglashenie.xaml"
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
            
            #line 10 "..\..\..\Okna\PolzovatelskoeSoglashenie.xaml"
            ((LegistOS.Okna.PolzovatelskoeSoglashenie)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ImgLogoMal = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.BtnSoglObrPersonDann = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\Okna\PolzovatelskoeSoglashenie.xaml"
            this.BtnSoglObrPersonDann.Click += new System.Windows.RoutedEventHandler(this.BtnSoglObrPersonDann_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ImgObrPersDann = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.BtnPolzovatelSoglashen = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\Okna\PolzovatelskoeSoglashenie.xaml"
            this.BtnPolzovatelSoglashen.Click += new System.Windows.RoutedEventHandler(this.BtnPolzovatelSoglashen_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ImgPolzSoglas = ((System.Windows.Controls.Image)(target));
            return;
            case 7:
            this.FUrSoglDoc = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
