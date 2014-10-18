using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfServiceClienteRede.classebasica;
using WcfServiceClienteRede.classeDados;
using WcfServiceClienteRede.classeInterface;

namespace WcfServiceClienteRede.classeNegocio
{
    public class NegocioClienteRede
    {
        private InterfaceClienteRede dcr = new DadosClienteRede();
        public void cadastrarClienteRede(ClienteRede cr)
        {
            dcr.cadastrarClienteRede(cr);
        }
        public void alterarClienteRede(ClienteRede cr)
        {
            dcr.alterarClienteRede(cr);
        }
        public void deletarClienteRede(ClienteRede cr)
        {
            dcr.deletarClienteRede(cr);
        }
        public List<ClienteRede> listarClienteRede()
        {
            return dcr.listarClienteRede();
        }
    }
}