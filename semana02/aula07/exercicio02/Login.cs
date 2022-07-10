using System;

namespace exercicio02
{
    internal class Login
    {
        private string _userName;
        private string _password;
        public bool LoggedIn { get; set; }

        public Login()
        {
            LoggedIn = false;
        }

        public string SignIn(string user, string password)
        {
            if (LoggedIn)
            {
                return "Você já está logado.";
            }
            
            if (_userName == user)
            {
                if (_password == password)
                {
                    LoggedIn = true;
                    return "Bem-vindo ao sistema!";
                }
                return "Senha incorreta!";
            }

                return "Este usuário não existe!";
        }

        public string SignUp(string user, string password)
        {
            if (LoggedIn)
            {
                return "Você já está logado.";
            }

            _userName = user;
            _password = password;

            return "Usuário cadastrado com sucesso";
        }

        public string ChangePassword(string password)
        {
            if (!LoggedIn)
            {
                return "É preciso estar logado para trocar a senha.";
            }

            _password = password;

            return "Senha atualizada com sucesso.";
        }

    }
}
