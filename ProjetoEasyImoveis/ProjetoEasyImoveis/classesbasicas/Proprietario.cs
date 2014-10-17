using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoEasyImoveis.classesbasicas
{
    public class Proprietario
    {
        private int id_Proprietario;

        public int Id_Proprietario
        {
            get { return id_Proprietario; }
            set { id_Proprietario = value; }
        }
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
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
        private Endereco endereco;

        public Endereco Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
    }
}