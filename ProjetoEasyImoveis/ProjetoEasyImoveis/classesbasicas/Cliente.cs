using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoEasyImoveis.classesbasicas
{
    public class Cliente
    {
        private int id_Cliente;

        public int Id_Cliente
        {
            get { return id_Cliente; }
            set { id_Cliente = value; }
        }
        private string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private string nomeFantasia;

        public string NomeFantasia
        {
            get { return nomeFantasia; }
            set { nomeFantasia = value; }
        }
        private string razaoSocial;

        public string RazaoSocial
        {
            get { return razaoSocial; }
            set { razaoSocial = value; }
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
        private string cpf;

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        private string cnpj;

        public string Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }
        private string rg;

        public string Rg
        {
            get { return rg; }
            set { rg = value; }
        }

        //construtor
        public Cliente(int Id_cli,
            string tipo,
            string Nome,
            string NomeFantasia,
            string RazaoSocial,
            string Email, 
            string Telefone, 
            DateTime DataCadastro,
            string Rua,
            string Bairro,
            string Cidade,
            string Uf,
            string Complemento,
            string Cpf,
            string Rg,
            string Cnpj)
        {
            this.id_Cliente = Id_cli;
            this.tipo = tipo;
            this.nome = Nome;
            this.nomeFantasia = NomeFantasia;
            this.razaoSocial = RazaoSocial;
            this.email = Email;
            this.telefone = Telefone;
            this.dataCadastro = DataCadastro;
            this.endereco.Rua = Rua;
            this.endereco.Bairro = Bairro;
            this.endereco.Cidade = Cidade;
            this.endereco.Uf = Uf;
            this.endereco.Complemento = Complemento;
            this.cpf = Cpf;
            this.rg = Rg;
            this.cnpj = Cnpj;
        }
        public Cliente()
        {

        }
    }

   


}