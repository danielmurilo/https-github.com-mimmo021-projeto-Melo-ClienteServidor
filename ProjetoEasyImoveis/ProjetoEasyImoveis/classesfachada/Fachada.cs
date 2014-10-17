using ProjetoEasyImoveis.classesbasicas;
using ProjetoEasyImoveis.classesnegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoEasyImoveis.classesfachada
{
    public class Fachada
    {
        ClienteNegocios cn = new ClienteNegocios();
        //crud cliente
        public void cadastrarCliente()
        {

        }
        public void alterarCliente()
        {

        }
        public void deletarCliente()
        {

        }
        public List<Cliente> listarCliente()
        {
            ClienteNegocios cn = new ClienteNegocios();
            return cn.listarCliente();
        }

        //crud Funcionario
        public void cadastrarFuncionario()
        {

        }
        public void alterarFuncionario()
        {

        }
        public void deletarFuncionario()
        {

        }
        public List<Funcionario> listarFuncionario()
        {
            FuncionarioNegocios cn = new FuncionarioNegocios();
            return cn.listarFuncionario();
        }

        //crud Proprietario
        public void cadastrarProprietario()
        {

        }
        public void alterarProprietario()
        {

        }
        public void deletarProprietario()
        {

        }
        public List<Proprietario> listarProprietario()
        {
            ProprietarioNegocios cn = new ProprietarioNegocios();
            return cn.listarProprietario();
        }

        //crud Imovel
        public void cadastrarImovel()
        {

        }
        public void alterarImovel()
        {

        }
        public void deletarImovel()
        {

        }
        public List<Imovel> listarImovel()
        {
            ImovelNegocios cn = new ImovelNegocios();
            return cn.listarImovel();
        }

        //crud Venda
        public void cadastrarVenda()
        {

        }
        public void alterarVenda()
        {

        }
        public void deletarVenda()
        {

        }
        public List<Venda> listarVenda()
        {
            VendaNegocios cn = new VendaNegocios();
            return cn.listarVenda();
        }

    }
}