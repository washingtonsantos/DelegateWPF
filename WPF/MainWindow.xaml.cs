using Domain;
using System.Windows;

namespace WPF
{
    //custom delegate  
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //custom event  
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var servico = new ServicoDominio();
            servico.add += MainWindow_add;
            servico.ServicoTrabalhando();
        }

        private void MainWindow_add(int num)
        {
            MessageBox.Show("Olha o número ai " + num);
        }
    }
}
