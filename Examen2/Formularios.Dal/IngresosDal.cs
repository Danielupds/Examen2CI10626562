using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formularios.Dal
{
    public class IngresosDal
    {
        public DataTable ListaIngresosDal()
        {
            string consulta = "select IDPROVEEDOR, TOTAL from ingreso";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
    }
}
