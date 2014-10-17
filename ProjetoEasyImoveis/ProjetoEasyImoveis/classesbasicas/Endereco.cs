using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoEasyImoveis.classesbasicas
{
    public class Endereco
    {
        private string rua;

        public string Rua
        {
            get { return rua; }
            set { rua = value; }
        }
        private string bairro;

        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }
        private string cidade;

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
        private string uf;

        public string Uf
        {
            get { return uf; }
            set { uf = value; }
        }
        private string complemento;

        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }
    }
}