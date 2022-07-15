namespace Domain
{
    public class Usuario : AbsUsuario 
    {
        public Usuario(string nome, double rendaAnual, double impostoRenda)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
            ImpostoRenda = impostoRenda;
        }

        public Usuario() { }

    }
}