// Updated by XamlIntelliSenseFileGenerator 31.05.2023 13:38:37
#pragma checksum "..\..\..\Okna\Avtorizatia.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B5B269AAC7B60DF39500C529B88FB06CB3A0A15F6A80CFE33DBB3EF32060BB91"
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


namespace LegistOS.Okna
{


    /// <summary>
    /// Avtorizatia
    /// </summary>
    public partial class Avtorizatia : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 13 "..\..\..\Okna\Avtorizatia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImgLogo;

#line default
#line hidden


#line 17 "..\..\..\Okna\Avtorizatia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TBlZagolovok;

#line default
#line hidden


#line 19 "..\..\..\Okna\Avtorizatia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TBlPochta;

#line default
#line hidden


#line 21 "..\..\..\Okna\Avtorizatia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBPochta;

#line default
#line hidden


#line 24 "..\..\..\Okna\Avtorizatia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TBlParol;

#line default
#line hidden


#line 26 "..\..\..\Okna\Avtorizatia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PBParol;

#line default
#line hidden


#line 29 "..\..\..\Okna\Avtorizatia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnVhod;

#line default
#line hidden


#line 31 "..\..\..\Okna\Avtorizatia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnRegistratia;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/LegistOS;component/okna/avtorizatia.xaml", System.UriKind.Relative);

#line 1 "..\..\..\Okna\Avtorizatia.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.ImgLogo = ((System.Windows.Controls.Image)(target));
                    return;
                case 2:
                    this.TBlZagolovok = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 3:
                    this.TBlPochta = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 4:
                    this.TBPochta = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 5:
                    this.TBlParol = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 6:
                    this.PBParol = ((System.Windows.Controls.PasswordBox)(target));
                    return;
                case 7:
                    this.BtnVhod = ((System.Windows.Controls.Button)(target));

#line 30 "..\..\..\Okna\Avtorizatia.xaml"
                    this.BtnVhod.Click += new System.Windows.RoutedEventHandler(this.BtnVhod_Click);

#line default
#line hidden
                    return;
                case 8:
                    this.BtnRegistratia = ((System.Windows.Controls.Button)(target));

#line 32 "..\..\..\Okna\Avtorizatia.xaml"
                    this.BtnRegistratia.Click += new System.Windows.RoutedEventHandler(this.BtnRegistratia_Click);

#line default
#line hidden
                    return;
                case 9:
                    this.BtnZapolnenie = ((System.Windows.Controls.Button)(target));

#line 36 "..\..\..\Okna\Avtorizatia.xaml"
                    this.BtnZapolnenie.Click += new System.Windows.RoutedEventHandler(this.BtnZapolnenie_Click);

#line default
#line hidden
                    return;
                case 10:
                    this.BtnAdminZapolnenie = ((System.Windows.Controls.Button)(target));

#line 40 "..\..\..\Okna\Avtorizatia.xaml"
                    this.BtnAdminZapolnenie.Click += new System.Windows.RoutedEventHandler(this.BtnAdminZapolnenie_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }
    }
}

