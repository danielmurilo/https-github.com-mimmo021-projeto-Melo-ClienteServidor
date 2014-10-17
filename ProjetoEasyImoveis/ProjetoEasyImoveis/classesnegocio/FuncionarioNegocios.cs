using ProjetoEasyImoveis.classesbasicas;
using ProjetoEasyImoveis.classesdados;
using ProjetoEasyImoveis.classesinterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoEasyImoveis.classesnegocio
{
    public class FuncionarioNegocios
    {
        private InterfaceFuncionario df = new DadosFuncionario();
        //crud Funcionario
        public void cadastrarFuncionario(Funcionario f)
        {
            
            df.cadastrarFuncionario(f);
        }
        public void alterarFuncionario(Funcionario f)
        {
            
            df.alterarFuncionario(f);
        }
        public void deletarFuncionario(Funcionario f)
        {
            
            df.deletarFuncionario(f);
        }
        public List<Funcionario> listarFuncionario()
        {
            
            return df.listarFuncionario();
        }
    }
}