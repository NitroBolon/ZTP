﻿#pragma checksum "..\..\Hard.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E1CD47AD1A10927AA2EBA3A49A33FA7DFB9ADC4471879DFA8A4445B7188384E1"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using Fiszki;
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


namespace Fiszki {
    
    
    /// <summary>
    /// Hard
    /// </summary>
    public partial class Hard : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\Hard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label que;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Hard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button1;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Hard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button2;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Hard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button3;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Hard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button4;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Hard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button next;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Hard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label score;
        
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
            System.Uri resourceLocater = new System.Uri("/Fiszki;component/hard.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Hard.xaml"
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
            this.que = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.button1 = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\Hard.xaml"
            this.button1.Click += new System.Windows.RoutedEventHandler(this.Button_Click_false);
            
            #line default
            #line hidden
            return;
            case 3:
            this.button2 = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\Hard.xaml"
            this.button2.Click += new System.Windows.RoutedEventHandler(this.Button_Click_true);
            
            #line default
            #line hidden
            return;
            case 4:
            this.button3 = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\Hard.xaml"
            this.button3.Click += new System.Windows.RoutedEventHandler(this.Button_Click_false);
            
            #line default
            #line hidden
            return;
            case 5:
            this.button4 = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\Hard.xaml"
            this.button4.Click += new System.Windows.RoutedEventHandler(this.Button_Click_false);
            
            #line default
            #line hidden
            return;
            case 6:
            this.next = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\Hard.xaml"
            this.next.Click += new System.Windows.RoutedEventHandler(this.Button_Click_close);
            
            #line default
            #line hidden
            return;
            case 7:
            this.score = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

