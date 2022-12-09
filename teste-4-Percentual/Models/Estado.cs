namespace teste_4_Percentual.Models
{
    public class Estado
    {
        public Estado(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }
        public string Nome { get; set; }

        public double Valor { get; set; }
    }
}