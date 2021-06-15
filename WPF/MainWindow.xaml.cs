using Domain;
using System;
using System.Windows;
using System.Windows.Threading;

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
            ClientesQuantidade.Content = 100;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var servico = new ServicoDominio(100);
            servico.add += MainWindow_add;
            servico.ServicoTrabalhando();
        }

        private void MainWindow_add(int num, int qtdTotal)
        {
            MyProgress.Dispatcher.Invoke(() => MyProgress.Value = (num * qtdTotal) / 100, DispatcherPriority.Background);
            ClientesProcessadosLabel.Content = num + 1;
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
        }
    }
}
