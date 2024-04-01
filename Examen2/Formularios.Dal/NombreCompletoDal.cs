using Formularios.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formularios.Dal
{
    public class NombreCompletoDal
    {
        public DataTable ListaNombreCompletoDal()
        {
            string consulta = "select NOMBRE, APELLIDO from persona";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }


        public void InsertarNombreCompletoDal(NombreCompletoModelos nombreCompletoModelos)
        {
            string consulta = "NOMBRE, APELLIDO";
            conexion.Ejecutar(consulta);
        }

    }
}
