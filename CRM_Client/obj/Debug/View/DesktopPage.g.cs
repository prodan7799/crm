﻿#pragma checksum "..\..\..\View\DesktopPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B5E4942FFC387029931A058763D04E73"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.Controls;
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


namespace CRM_Client.View {
    
    
    /// <summary>
    /// DesktopPage
    /// </summary>
    public partial class DesktopPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 44 "..\..\..\View\DesktopPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.Flyout flyoutTask;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\View\DesktopPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.Flyout flyoutClient;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\View\DesktopPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.Flyout flyoutStaff;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\View\DesktopPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.Flyout flyoutAnalytics;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\View\DesktopPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.Flyout flyoutDeal;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\View\DesktopPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.Flyout flyoutSettings;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\View\DesktopPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.Flyout flyoutGoods;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\View\DesktopPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.Flyout flyoutReminder;
        
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
            System.Uri resourceLocater = new System.Uri("/CRM_Client;component/view/desktoppage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\DesktopPage.xaml"
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
            
            #line 11 "..\..\..\View\DesktopPage.xaml"
            ((MahApps.Metro.Controls.Tile)(target)).Click += new System.Windows.RoutedEventHandler(this.Tile_Task_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 15 "..\..\..\View\DesktopPage.xaml"
            ((MahApps.Metro.Controls.Tile)(target)).Click += new System.Windows.RoutedEventHandler(this.Tile_Client_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 19 "..\..\..\View\DesktopPage.xaml"
            ((MahApps.Metro.Controls.Tile)(target)).Click += new System.Windows.RoutedEventHandler(this.Tile_Staff_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 23 "..\..\..\View\DesktopPage.xaml"
            ((MahApps.Metro.Controls.Tile)(target)).Click += new System.Windows.RoutedEventHandler(this.Tile_Analytics_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 27 "..\..\..\View\DesktopPage.xaml"
            ((MahApps.Metro.Controls.Tile)(target)).Click += new System.Windows.RoutedEventHandler(this.Tile_Deal_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 31 "..\..\..\View\DesktopPage.xaml"
            ((MahApps.Metro.Controls.Tile)(target)).Click += new System.Windows.RoutedEventHandler(this.Tile_Setting_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 35 "..\..\..\View\DesktopPage.xaml"
            ((MahApps.Metro.Controls.Tile)(target)).Click += new System.Windows.RoutedEventHandler(this.Tile_Goods_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 39 "..\..\..\View\DesktopPage.xaml"
            ((MahApps.Metro.Controls.Tile)(target)).Click += new System.Windows.RoutedEventHandler(this.Tile_Reminder_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.flyoutTask = ((MahApps.Metro.Controls.Flyout)(target));
            
            #line 44 "..\..\..\View\DesktopPage.xaml"
            this.flyoutTask.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Flyout_Close_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 45 "..\..\..\View\DesktopPage.xaml"
            ((System.Windows.Controls.ListBox)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Flyout_ListBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.flyoutClient = ((MahApps.Metro.Controls.Flyout)(target));
            
            #line 53 "..\..\..\View\DesktopPage.xaml"
            this.flyoutClient.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Flyout_Close_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 54 "..\..\..\View\DesktopPage.xaml"
            ((System.Windows.Controls.ListBox)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Flyout_ListBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 13:
            this.flyoutStaff = ((MahApps.Metro.Controls.Flyout)(target));
            
            #line 60 "..\..\..\View\DesktopPage.xaml"
            this.flyoutStaff.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Flyout_Close_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 61 "..\..\..\View\DesktopPage.xaml"
            ((System.Windows.Controls.ListBox)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Flyout_ListBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 15:
            this.flyoutAnalytics = ((MahApps.Metro.Controls.Flyout)(target));
            
            #line 68 "..\..\..\View\DesktopPage.xaml"
            this.flyoutAnalytics.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Flyout_Close_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 69 "..\..\..\View\DesktopPage.xaml"
            ((System.Windows.Controls.ListBox)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Flyout_ListBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 17:
            this.flyoutDeal = ((MahApps.Metro.Controls.Flyout)(target));
            
            #line 76 "..\..\..\View\DesktopPage.xaml"
            this.flyoutDeal.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Flyout_Close_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 77 "..\..\..\View\DesktopPage.xaml"
            ((System.Windows.Controls.ListBox)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Flyout_ListBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 19:
            this.flyoutSettings = ((MahApps.Metro.Controls.Flyout)(target));
            
            #line 84 "..\..\..\View\DesktopPage.xaml"
            this.flyoutSettings.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Flyout_Close_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 20:
            
            #line 85 "..\..\..\View\DesktopPage.xaml"
            ((System.Windows.Controls.ListBox)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Flyout_ListBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 21:
            this.flyoutGoods = ((MahApps.Metro.Controls.Flyout)(target));
            
            #line 91 "..\..\..\View\DesktopPage.xaml"
            this.flyoutGoods.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Flyout_Close_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 22:
            
            #line 92 "..\..\..\View\DesktopPage.xaml"
            ((System.Windows.Controls.ListBox)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Flyout_ListBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 23:
            this.flyoutReminder = ((MahApps.Metro.Controls.Flyout)(target));
            
            #line 99 "..\..\..\View\DesktopPage.xaml"
            this.flyoutReminder.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Flyout_Close_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 24:
            
            #line 100 "..\..\..\View\DesktopPage.xaml"
            ((System.Windows.Controls.ListBox)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Flyout_ListBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

