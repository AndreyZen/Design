﻿#pragma checksum "..\..\..\Pages\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0752C713D843C2044E8C1E078853865BDCCC35856760E843A8938BA3FA6D9113"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Design.Pages;
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


namespace Design.Pages {
    
    
    /// <summary>
    /// MainPage
    /// </summary>
    public partial class MainPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 52 "..\..\..\Pages\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBoxSearch;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\Pages\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LViewProperties;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\Pages\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TboxPriceDown;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\Pages\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TboxPriceUp;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\..\Pages\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl SearchTabControl;
        
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
            System.Uri resourceLocater = new System.Uri("/Design;component/pages/mainpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\MainPage.xaml"
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
            this.TBoxSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 52 "..\..\..\Pages\MainPage.xaml"
            this.TBoxSearch.KeyDown += new System.Windows.Input.KeyEventHandler(this.TBoxSearch_KeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.LViewProperties = ((System.Windows.Controls.ListView)(target));
            return;
            case 3:
            
            #line 61 "..\..\..\Pages\MainPage.xaml"
            ((System.Windows.Controls.ListViewItem)(target)).Drop += new System.Windows.DragEventHandler(this.PropertyElement_Drop);
            
            #line default
            #line hidden
            
            #line 61 "..\..\..\Pages\MainPage.xaml"
            ((System.Windows.Controls.ListViewItem)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.PropertyElement_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TboxPriceDown = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TboxPriceUp = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            
            #line 71 "..\..\..\Pages\MainPage.xaml"
            ((System.Windows.Controls.ListViewItem)(target)).Drop += new System.Windows.DragEventHandler(this.PropertyElement_Drop);
            
            #line default
            #line hidden
            
            #line 71 "..\..\..\Pages\MainPage.xaml"
            ((System.Windows.Controls.ListViewItem)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.PropertyElement_MouseDown);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 77 "..\..\..\Pages\MainPage.xaml"
            ((System.Windows.Controls.ListViewItem)(target)).Drop += new System.Windows.DragEventHandler(this.PropertyElement_Drop);
            
            #line default
            #line hidden
            
            #line 77 "..\..\..\Pages\MainPage.xaml"
            ((System.Windows.Controls.ListViewItem)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.PropertyElement_MouseDown);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 83 "..\..\..\Pages\MainPage.xaml"
            ((System.Windows.Controls.ListViewItem)(target)).Drop += new System.Windows.DragEventHandler(this.PropertyElement_Drop);
            
            #line default
            #line hidden
            
            #line 83 "..\..\..\Pages\MainPage.xaml"
            ((System.Windows.Controls.ListViewItem)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.PropertyElement_MouseDown);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 89 "..\..\..\Pages\MainPage.xaml"
            ((System.Windows.Controls.ListViewItem)(target)).Drop += new System.Windows.DragEventHandler(this.PropertyElement_Drop);
            
            #line default
            #line hidden
            
            #line 89 "..\..\..\Pages\MainPage.xaml"
            ((System.Windows.Controls.ListViewItem)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.PropertyElement_MouseDown);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 95 "..\..\..\Pages\MainPage.xaml"
            ((System.Windows.Controls.ListViewItem)(target)).Drop += new System.Windows.DragEventHandler(this.PropertyElement_Drop);
            
            #line default
            #line hidden
            
            #line 95 "..\..\..\Pages\MainPage.xaml"
            ((System.Windows.Controls.ListViewItem)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.PropertyElement_MouseDown);
            
            #line default
            #line hidden
            return;
            case 11:
            this.SearchTabControl = ((System.Windows.Controls.TabControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

