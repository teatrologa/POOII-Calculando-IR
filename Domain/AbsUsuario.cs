namespace Domain
{
    public abstract class AbsUsuario
    {
        public string Nome;
        public double RendaAnual;
        public double ImpostoRenda;

        public AbsUsuario(string nome, double rendaAnual, double impostoRenda)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
            ImpostoRenda = impostoRenda;
        }

        public AbsUsuario()
        {

        }
    }
}