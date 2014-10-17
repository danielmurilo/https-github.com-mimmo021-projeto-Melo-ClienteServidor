using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoEasyImoveis.classesbasicas
{
    public class Venda
    {
        private int id_Venda;

        public int Id_Venda
        {
            get { return id_Venda; }
            set { id_Venda = value; }
        }
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
        private int id_Cliente;

        public int Id_Cliente
        {
            get { return id_Cliente; }
            set { id_Cliente = value; }
        }
    }
}