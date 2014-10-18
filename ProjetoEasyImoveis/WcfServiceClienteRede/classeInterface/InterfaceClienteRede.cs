using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfServiceClienteRede.classebasica;
using System.Threading.Tasks;
using System.Text;

namespace WcfServiceClienteRede.classeInterface
{
        interface InterfaceClienteRede
        {
            void cadastrarClienteRede(ClienteRede cr);
            void alterarClienteRede(ClienteRede cr);
            void deletarClienteRede(ClienteRede cr);
            List<ClienteRede> listarClienteRede();

        }
    
}