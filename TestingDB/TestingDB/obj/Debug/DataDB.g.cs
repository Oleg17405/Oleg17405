﻿#pragma checksum "..\..\DataDB.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CD4130C87AF31C025265848E182880B3F46CF3E8F8122FB31BA3E8EB6684287E"
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
using TestingDB;


namespace TestingDB {
    
    
    /// <summary>
    /// DataDB
    /// </summary>
    public partial class DataDB : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\DataDB.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox filterTextBox;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\DataDB.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button filterButton;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\DataDB.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddBtn;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\DataDB.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditBtn;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\DataDB.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteBtn;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\DataDB.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid ProdDG;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\DataDB.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button previousPageButton;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\DataDB.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock pageNumberTextBlock;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\DataDB.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button nextPageButton;
        
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
            System.Uri resourceLocater = new System.Uri("/TestingDB;component/datadb.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DataDB.xaml"
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
            this.filterTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.filterButton = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\DataDB.xaml"
            this.filterButton.Click += new System.Windows.RoutedEventHandler(this.FilterButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.AddBtn = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\DataDB.xaml"
            this.AddBtn.Click += new System.Windows.RoutedEventHandler(this.AddBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.EditBtn = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\DataDB.xaml"
            this.EditBtn.Click += new System.Windows.RoutedEventHandler(this.EditBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.DeleteBtn = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\DataDB.xaml"
            this.DeleteBtn.Click += new System.Windows.RoutedEventHandler(this.DeleteBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ProdDG = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.previousPageButton = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\DataDB.xaml"
            this.previousPageButton.Click += new System.Windows.RoutedEventHandler(this.PreviousPageButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.pageNumberTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.nextPageButton = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\DataDB.xaml"
            this.nextPageButton.Click += new System.Windows.RoutedEventHandler(this.NextPageButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

