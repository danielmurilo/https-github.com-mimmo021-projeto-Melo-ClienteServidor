using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoEasyImoveis.classesexeption
{
    public class SExeption: Exception
    {
        public SExeption(string message): base(message)
        {

        }
    }
}