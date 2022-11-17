using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class clsManejadoraDepartamento
    {
        /// <summary>
        /// Metodo que recibe una id y la comparara con la lista de departamento y cuando sea igual
        /// devolvera un departamento 
        /// Postcondicion: la lista tiene que existir
        /// Precondicion: devolvera un departamento
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static clsDepartamento obtenerDepartamentoPorId(int id)
        {
            List<clsDepartamento> listaDepartamento = clsListaDepartamento.listadoDepartamento();
            clsDepartamento departamentoPersona = new clsDepartamento();

            foreach (clsDepartamento departamento in listaDepartamento)
            {
                if (id == departamento.Id)
                {
                    departamentoPersona = departamento;
                }
            }
            return departamentoPersona;
        }
    }
}
