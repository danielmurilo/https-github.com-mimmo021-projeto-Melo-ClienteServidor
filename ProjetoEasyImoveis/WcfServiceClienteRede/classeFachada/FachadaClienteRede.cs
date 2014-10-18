using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfServiceClienteRede.classebasica;
using WcfServiceClienteRede.classeNegocio;

namespace WcfServiceClienteRede.classeFachada
{
    public class FachadaClienteRede
    {
        public void cadastrarClienteRede()
        {

        }
        public void alterarClienteRede()
        {

        }
        public void deletarClienteRede()
        {

        }
        public List<ClienteRede> listarClienteRede()
        {
            NegocioClienteRede crn = new NegocioClienteRede();
            return crn.listarClienteRede();
        }
    }
}