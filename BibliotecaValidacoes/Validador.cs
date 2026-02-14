namespace BibliotecaValidacoes
{
    public class Validador
    {
        public bool ValidadorCPF(string cpf)
        {
            return cpf.Length == 11;
        }

        public bool ValidadorEmail(string email)
        {
            return email.Contains("@");
        }

        public bool ValidadorSenha(string senha)
        {
            return senha.Length >= 6;
        }
    }
}

//o console ainda estava usando o metodo antigo

//breaking change e quando uma alteracao na dll quebra a compatibilidade com o codigo que ja existe, exigindo mudanças nos projetos 