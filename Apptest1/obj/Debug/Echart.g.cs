﻿#pragma checksum "..\..\Echart.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C8F760215744D6E6D0C795C20E30FDA620450A88"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using Apptest1;
using C1.Silverlight.Resources;
using C1.WPF;
using C1.WPF.Chart;
using C1.WPF.Chart.Annotation;
using C1.WPF.Chart.Interaction;
using C1.WPF.DateTimeEditors;
using C1.WPF.Docking;
using C1.WPF.Theming;
using C1.WPF.Theming.C1Blue;
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


namespace Apptest1 {
    
    
    /// <summary>
    /// Echart
    /// </summary>
    public partial class Echart : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\Echart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl LeftTabControl;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\Echart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer scrollViewer;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\Echart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame pageContainer;
        
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
            System.Uri resourceLocater = new System.Uri("/Apptest1;component/echart.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Echart.xaml"
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
            this.LeftTabControl = ((System.Windows.Controls.TabControl)(target));
            
            #line 20 "..\..\Echart.xaml"
            this.LeftTabControl.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.LeftTabControl_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 21 "..\..\Echart.xaml"
            ((System.Windows.Controls.TabItem)(target)).MouseMove += new System.Windows.Input.MouseEventHandler(this.TabItem_MouseMove_1);
            
            #line default
            #line hidden
            return;
            case 3:
            this.scrollViewer = ((System.Windows.Controls.ScrollViewer)(target));
            
            #line 49 "..\..\Echart.xaml"
            this.scrollViewer.PreviewMouseWheel += new System.Windows.Input.MouseWheelEventHandler(this.ScrollViewer_PreviewMouseWheel);
            
            #line default
            #line hidden
            return;
            case 4:
            this.pageContainer = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
