#pragma checksum "..\..\..\..\..\UI\ShopUI\IPhone.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "677306D28148AC4D828A76981516444F79F05E17"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using KursovoiProject2kurs.UI.ShopUI;
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


namespace KursovoiProject2kurs.UI.ShopUI {
    
    
    /// <summary>
    /// IPhone
    /// </summary>
    public partial class IPhone : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 58 "..\..\..\..\..\UI\ShopUI\IPhone.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OutPutGoods;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\..\UI\ShopUI\IPhone.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChangeGoods;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\..\..\UI\ShopUI\IPhone.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddGoods;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\..\..\UI\ShopUI\IPhone.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Welcome;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/KursovoiProject2kurs;component/ui/shopui/iphone.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\UI\ShopUI\IPhone.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 55 "..\..\..\..\..\UI\ShopUI\IPhone.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Back_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.OutPutGoods = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\..\..\..\UI\ShopUI\IPhone.xaml"
            this.OutPutGoods.Click += new System.Windows.RoutedEventHandler(this.OutPutGoods_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ChangeGoods = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\..\..\..\UI\ShopUI\IPhone.xaml"
            this.ChangeGoods.Click += new System.Windows.RoutedEventHandler(this.ChangeGoods_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.AddGoods = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\..\..\..\UI\ShopUI\IPhone.xaml"
            this.AddGoods.Click += new System.Windows.RoutedEventHandler(this.AddGoods_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Welcome = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

