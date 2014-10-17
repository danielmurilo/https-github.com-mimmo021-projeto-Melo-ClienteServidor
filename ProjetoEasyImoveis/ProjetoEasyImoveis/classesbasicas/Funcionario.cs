using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoEasyImoveis.classesbasicas
{
    public class Funcionario
    {
        private int id_Funcionario;
        public int Id_Funcionario
        {
            get { return id_Funcionario; }
            set { id_Funcionario = value; }
        }
       
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
       
        private string login;
        public string Login
        {
            get { return login; }
            set { login = value; }
        }
       
        private string senha;
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
       
        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
       
        private string telefone;
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
       
        private DateTime dataCadastro;
        public DateTime DataCadastro
        {
            get { return dataCadastro; }
            set { dataCadastro = value; }
        }
        
        
        //construtor
        public Funcionario(int Id_Funcionario, string Nome, string Login, string Senha, string Email, DateTime DataCadastro,string Telefone )
        {
            this.id_Funcionario = Id_Funcionario;
            this.nome = Nome;
            this.login = Login;
            this.senha = Senha;
            this.email = Email;
            this.dataCadastro = DataCadastro;
            this.telefone = Telefone;
          
        }
       
    }
}