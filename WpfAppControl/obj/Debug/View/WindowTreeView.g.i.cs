﻿#pragma checksum "..\..\..\View\WindowTreeView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "990E4371A8BBCDF341D8A0F67D49E5D11C16513995072E8E9EB727ACC7B0250C"
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
using WpfAppControl.View;


namespace WpfAppControl.View {
    
    
    /// <summary>
    /// WindowTreeView
    /// </summary>
    public partial class WindowTreeView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\View\WindowTreeView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid baseGrid;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\View\WindowTreeView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image colorImage;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\View\WindowTreeView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image JavaScript;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\View\WindowTreeView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.StatusBar statusBarTime;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\View\WindowTreeView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlockTime;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\View\WindowTreeView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Calendar calendarExample;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\View\WindowTreeView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker datePicker1;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfAppControl;component/view/windowtreeview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\WindowTreeView.xaml"
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
            this.baseGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            
            #line 17 "..\..\..\View\WindowTreeView.xaml"
            ((System.Windows.Controls.TreeViewItem)(target)).Expanded += new System.Windows.RoutedEventHandler(this.TreeViewItem_Expanded);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 24 "..\..\..\View\WindowTreeView.xaml"
            ((System.Windows.Controls.TreeViewItem)(target)).Expanded += new System.Windows.RoutedEventHandler(this.TreeViewItem_Expanded);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 26 "..\..\..\View\WindowTreeView.xaml"
            ((System.Windows.Controls.TreeViewItem)(target)).Expanded += new System.Windows.RoutedEventHandler(this.TreeViewItem_Expanded);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 28 "..\..\..\View\WindowTreeView.xaml"
            ((System.Windows.Controls.TreeViewItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.TreeViewItem_Selected);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 29 "..\..\..\View\WindowTreeView.xaml"
            ((System.Windows.Controls.TreeViewItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.TreeViewItem_Selected_1);
            
            #line default
            #line hidden
            return;
            case 7:
            this.colorImage = ((System.Windows.Controls.Image)(target));
            return;
            case 8:
            
            #line 40 "..\..\..\View\WindowTreeView.xaml"
            ((System.Windows.Controls.TreeViewItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.TreeViewItem_Selected_2);
            
            #line default
            #line hidden
            return;
            case 9:
            this.JavaScript = ((System.Windows.Controls.Image)(target));
            return;
            case 10:
            
            #line 49 "..\..\..\View\WindowTreeView.xaml"
            ((System.Windows.Controls.TreeViewItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.TreeViewItem_Selected);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 51 "..\..\..\View\WindowTreeView.xaml"
            ((System.Windows.Controls.TreeViewItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.TreeViewItem_Selected);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 54 "..\..\..\View\WindowTreeView.xaml"
            ((System.Windows.Controls.TreeViewItem)(target)).Expanded += new System.Windows.RoutedEventHandler(this.TreeViewItem_Expanded);
            
            #line default
            #line hidden
            return;
            case 13:
            this.statusBarTime = ((System.Windows.Controls.Primitives.StatusBar)(target));
            return;
            case 14:
            this.textBlockTime = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 15:
            this.calendarExample = ((System.Windows.Controls.Calendar)(target));
            
            #line 70 "..\..\..\View\WindowTreeView.xaml"
            this.calendarExample.SelectedDatesChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.calendarExample_SelectedDatesChanged);
            
            #line default
            #line hidden
            return;
            case 16:
            this.datePicker1 = ((System.Windows.Controls.DatePicker)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

