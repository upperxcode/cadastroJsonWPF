#pragma checksum "..\..\PedidoWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "44EC5ABD61E1241A9D94394649C2D5806B96DBEC8FDEAC125B11122CD3835FDB"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
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
using _CadastroJson;


namespace _CadastroJson {
    
    
    /// <summary>
    /// PedidoWindow
    /// </summary>
    public partial class PedidoWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 49 "..\..\PedidoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFilterNome;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\PedidoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFilterCpf;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\PedidoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BntFilter;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\PedidoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid PessoaGrid;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\PedidoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPessoa;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\PedidoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid ProdtuosGrid;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\PedidoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddProduto;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\PedidoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbBudgetYear;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\PedidoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/CadastroJson;component/pedidowindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PedidoWindow.xaml"
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
            this.txtFilterNome = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtFilterCpf = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.BntFilter = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\PedidoWindow.xaml"
            this.BntFilter.Click += new System.Windows.RoutedEventHandler(this.BntFilter_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.PessoaGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 57 "..\..\PedidoWindow.xaml"
            this.PessoaGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.PedidoGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtPessoa = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.ProdtuosGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 88 "..\..\PedidoWindow.xaml"
            this.ProdtuosGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.PedidoGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnAddProduto = ((System.Windows.Controls.Button)(target));
            
            #line 101 "..\..\PedidoWindow.xaml"
            this.btnAddProduto.Click += new System.Windows.RoutedEventHandler(this.AddProduto);
            
            #line default
            #line hidden
            return;
            case 10:
            this.cmbBudgetYear = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 11:
            
            #line 111 "..\..\PedidoWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnInsert);
            
            #line default
            #line hidden
            return;
            case 12:
            this.SaveBtn = ((System.Windows.Controls.Button)(target));
            
            #line 112 "..\..\PedidoWindow.xaml"
            this.SaveBtn.Click += new System.Windows.RoutedEventHandler(this.BtnSave);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 5:
            
            #line 68 "..\..\PedidoWindow.xaml"
            ((System.Windows.Controls.Primitives.ToggleButton)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnUpdate);
            
            #line default
            #line hidden
            break;
            case 6:
            
            #line 75 "..\..\PedidoWindow.xaml"
            ((System.Windows.Controls.Primitives.ToggleButton)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnRemove);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

