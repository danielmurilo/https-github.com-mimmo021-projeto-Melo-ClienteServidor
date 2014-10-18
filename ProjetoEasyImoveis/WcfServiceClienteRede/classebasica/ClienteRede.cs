using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfServiceClienteRede.classebasica
{
    public class ClienteRede
    {
        private int id_cli_rede;

        public int Id_cli_rede
        {
            get { return id_cli_rede; }
            set { id_cli_rede = value; }
        }
        private string nome_cli_rede;

        public string Nome_cli_rede
        {
            get { return nome_cli_rede; }
            set { nome_cli_rede = value; }
        }
        private string login_cli_rede;

        public string Login_cli_rede
        {
            get { return login_cli_rede; }
            set { login_cli_rede = value; }
        }
        private string senha_cli_rede;

        public string Senha_cli_rede
        {
            get { return senha_cli_rede; }
            set { senha_cli_rede = value; }
        }
        private string email_cli_rede;

        public string Email_cli_rede
        {
            get { return email_cli_rede; }
            set { email_cli_rede = value; }
        }
        private string telefone_cli_rede;

        public string Telefone_cli_rede
        {
            get { return telefone_cli_rede; }
            set { telefone_cli_rede = value; }
        }

        //construtor
        public ClienteRede(int Id_cli_rede, string Nome_cli_rede, string Login_cli_rede, string Senha_cli_rede, string Email_cli_rede, string Telefone_cli_rede)
        {
            this.Id_cli_rede = Id_cli_rede;
            this.Nome_cli_rede = Nome_cli_rede;
            this.Login_cli_rede = Login_cli_rede;
            this.Senha_cli_rede = Senha_cli_rede;
            this.Email_cli_rede = Email_cli_rede;
            this.Telefone_cli_rede = Telefone_cli_rede;
        }
    }
}