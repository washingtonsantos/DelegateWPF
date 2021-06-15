namespace Domain
{
    public delegate void DelEventHandler(int num);

    public class ServicoDominio
    {
        public event DelEventHandler add;

        public void ServicoTrabalhando()
        {   
            for (int i = 0; i < 100; i++)
            {
                add?.Invoke(i);
            }
        }
    }
}