using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class clsListaDepartamento
    {
        /// <summary>
        /// Creaccion e inicializacion de la lista de la clase departamentos 
        /// Precondicion: La clase clsDepartamento tiene que estar creada
        /// Postcondicion: Returnara la lista de departamento
        /// </summary>
        /// <returns></returns>
        public static List<clsDepartamento> listadoDepartamento()
        {
            List<clsDepartamento> listaDepartamento = new List<clsDepartamento>();

            listaDepartamento.Add(new clsDepartamento(1, "Marketing y Ventas"));
            listaDepartamento.Add(new clsDepartamento(2, "Contabilidad y finanzas"));
            listaDepartamento.Add(new clsDepartamento(3, "Cadena de suministro"));
            listaDepartamento.Add(new clsDepartamento(4, "Recursos Humanos"));

            return listaDepartamento;
        }
    }
}
