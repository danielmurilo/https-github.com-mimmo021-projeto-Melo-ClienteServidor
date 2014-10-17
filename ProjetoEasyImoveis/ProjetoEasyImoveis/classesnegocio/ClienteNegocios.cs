using ProjetoEasyImoveis.classesbasicas;
using ProjetoEasyImoveis.classesconexao;
using ProjetoEasyImoveis.classesdados;
using ProjetoEasyImoveis.classesinterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoEasyImoveis.classesnegocio
{
    public class ClienteNegocios
    {

        private InterfaceCliente dc = new DadosCliente();
        //crud cliente
        public void cadastrarCliente(Cliente c)
        {


         
           dc.cadastrarCliente(c);
        }
        public void alterarCliente(Cliente c)
        {

           
            dc.alterarCliente(c);
        }
        public void deletarCliente(Cliente c)
        {
           
            dc.deletarCliente(c);
        }
        public List<Cliente> listarCliente()
        {
           
            return dc.listarCliente();
        }
    }
}