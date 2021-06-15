namespace Domain
{
    public delegate void DelEventHandler(int num, int qtdTotal);

    public class ServicoDominio
    {
        int totalCliente;
        public event DelEventHandler add;

        public ServicoDominio(int qtdClientes)
        {
            totalCliente = qtdClientes;
        }

        public void ServicoTrabalhando()
        {   
            for (int i = 0; i < totalCliente; i++)
            {
                add?.Invoke(i, totalCliente);
            }
        }
    }
}