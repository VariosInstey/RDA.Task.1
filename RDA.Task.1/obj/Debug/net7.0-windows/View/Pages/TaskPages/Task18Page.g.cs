﻿#pragma checksum "..\..\..\..\..\..\View\Pages\TaskPages\Task18Page.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "924FE9CF877BD3EC9A2CEB5B9DE1B5808CD06AEA"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using RDA.Task._1.View.Pages.TaskPages;
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


namespace RDA.Task._1.View.Pages.TaskPages {
    
    
    /// <summary>
    /// Task18Page
    /// </summary>
    public partial class Task18Page : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 41 "..\..\..\..\..\..\View\Pages\TaskPages\Task18Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbY;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\..\..\View\Pages\TaskPages\Task18Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbQ;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\..\..\View\Pages\TaskPages\Task18Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnTask19;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\..\..\..\View\Pages\TaskPages\Task18Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnMainPage;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/RDA.Task.1;component/view/pages/taskpages/task18page.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\View\Pages\TaskPages\Task18Page.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.TbY = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TbQ = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.BtnTask19 = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\..\..\..\..\View\Pages\TaskPages\Task18Page.xaml"
            this.BtnTask19.Click += new System.Windows.RoutedEventHandler(this.BtnTask19_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnMainPage = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\..\..\..\..\View\Pages\TaskPages\Task18Page.xaml"
            this.BtnMainPage.Click += new System.Windows.RoutedEventHandler(this.BtnMainPage_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

