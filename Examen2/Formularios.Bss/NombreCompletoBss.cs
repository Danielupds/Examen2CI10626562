using Formularios.Dal;
using Formularios.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formularios.Bss
{
    public class NombreCompletoBss
    {
        NombreCompletoDal dal = new NombreCompletoDal();
        public DataTable ListaNombreCompletoBss()
        {
            return dal.ListaNombreCompletoDal();
        }
    }
}
