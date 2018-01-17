using System.Windows;

namespace WpfApp.ViewModel
{
    /// <summary>
    /// Lógica interna para ViewFormulario.xaml
    /// </summary>
    public partial class ViewFormulario : Window
    {
        public ViewFormulario()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void btnCanclar_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
