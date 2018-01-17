using System.Windows;

namespace WpfApp.ViewModel
{
    /// <summary>
    /// Lógica interna para ViewListagem.xaml
    /// </summary>
    public partial class ViewListagem : Window
    {
        private ClientTypeViewModel _viewModel;

        public ViewListagem()
        {
            InitializeComponent();
            _viewModel = new ClientTypeViewModel();
            this.DataContext = _viewModel;
        }

        private void btnNovo_Click(object sender, RoutedEventArgs e)
        {
            ViewFormulario viewAdicionar = new ViewFormulario();
            _viewModel.atual = new Model.ClientTypeModel();
            viewAdicionar.DataContext = _viewModel.atual;
            if (viewAdicionar.ShowDialog() == true)
            {
                _viewModel.AdicionarAtual();
            }
        }

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            if (_viewModel.atual != null)
            {
                ViewFormulario viewEditar = new ViewFormulario();
                viewEditar.DataContext = _viewModel.atual;
                if (viewEditar.ShowDialog() == true)
                {
                    _viewModel.EditarAtual();
                }
                else
                {
                    _viewModel.RestaurarAtual();
                }
            }
        }

        private void btnExcluir_Click(object sender, RoutedEventArgs e)
        {
            if (_viewModel.atual != null)
            {
                _viewModel.RemoverAtual();
            }
        }
    }
}
