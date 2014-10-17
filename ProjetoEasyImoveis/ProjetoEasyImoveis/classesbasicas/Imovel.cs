using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoEasyImoveis.classesbasicas
{
    public class Imovel
    {
        private int id_Imovel;
        public int Id_Imovel
        {
            get { return id_Imovel; }
            set { id_Imovel = value; }
        }

        private int id_Funcionario;
        public int Id_Funcionario
        {
            get { return id_Funcionario; }
            set { id_Funcionario = value; }
        }

        private int id_Proprietario;
        public int Id_Proprietario
        {
            get { return id_Proprietario; }
            set { id_Proprietario = value; }
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

        private int n_quartos;
        public int N_quartos
        {
            get { return n_quartos; }
            set { n_quartos = value; }
        }

        private int n_banheiros;
        public int N_banheiros
        {
            get { return n_banheiros; }
            set { n_banheiros = value; }
        }

        private int n_garagens;
        public int N_garagens
        {
            get { return n_garagens; }
            set { n_garagens = value; }
        }

        private double valor;
        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        private double valor_sugerido;
        public double Valor_sugerido
        {
            get { return valor_sugerido; }
            set { valor_sugerido = value; }
        }

        
       // construtor
        public Imovel(
            int Id_Imovel,
            int Id_Funcionario,
            int Id_Proprietario,
            DateTime DataCadastro,
            string Rua,
            string Bairro,
            string Cidade,
            string Uf,
            string Complemento,
            int N_Quartos,
            int N_Garagens,
            int N_Banheiros,
            double Valor,
            double ValorSugerido
            )
           {
               this.Id_Imovel = Id_Imovel;
               this.Id_Funcionario = Id_Funcionario;
               this.Id_Proprietario = Id_Proprietario;
               this.DataCadastro = DataCadastro;
               this.endereco.Rua = Rua ;
               this.endereco.Bairro = Bairro;
               this.endereco.Cidade =Cidade ;
               this.endereco.Uf = Uf ;
               this.endereco.Complemento = Complemento ;
               this.n_quartos = N_Quartos;
               this.n_garagens = N_Garagens;
               this.n_banheiros = N_Banheiros ;
               this.Valor = Valor;
               this.valor_sugerido = ValorSugerido;
           }
    }
}