﻿#pragma checksum "..\..\..\Vue\TypeLogement.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A9C08CC3BD9716000D92F78339598CA2212C7E0E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using BADAIA_BackOffice.Vue;
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


namespace BADAIA_BackOffice.Vue {
    
    
    /// <summary>
    /// TypeLogement
    /// </summary>
    public partial class TypeLogement : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\Vue\TypeLogement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button newTL;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Vue\TypeLogement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button showOneTL;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Vue\TypeLogement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button showAllTL;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Vue\TypeLogement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button modifyTL;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Vue\TypeLogement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deleteTL;
        
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
            System.Uri resourceLocater = new System.Uri("/BADAIA_BackOffice;component/vue/typelogement.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Vue\TypeLogement.xaml"
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
            this.newTL = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\Vue\TypeLogement.xaml"
            this.newTL.Click += new System.Windows.RoutedEventHandler(this.newTL_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.showOneTL = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\Vue\TypeLogement.xaml"
            this.showOneTL.Click += new System.Windows.RoutedEventHandler(this.showOneTL_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.showAllTL = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\Vue\TypeLogement.xaml"
            this.showAllTL.Click += new System.Windows.RoutedEventHandler(this.showAllTL_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.modifyTL = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\Vue\TypeLogement.xaml"
            this.modifyTL.Click += new System.Windows.RoutedEventHandler(this.modifyTL_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.deleteTL = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\Vue\TypeLogement.xaml"
            this.deleteTL.Click += new System.Windows.RoutedEventHandler(this.deleteTL_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

