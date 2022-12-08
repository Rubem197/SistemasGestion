using CRUD_Personas_BL;
using CRUD_Personas_Entidades;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CRUD_Personas_ASP.Models.ViewModels
{
    public class clsEditarPersonaVM
    {
        private clsPersonas persona;
        private List<clsDepartamentos> listadoCompletoDepartamentos;

        public clsPersonas Persona
        {
            get { return persona; }
            set { persona = value; }
        }
        public List<clsDepartamentos> ListadoCompletoDepartamentos
        {
            get { return listadoCompletoDepartamentos; }
            set { listadoCompletoDepartamentos = value; }
        }
        public clsEditarPersonaVM(int id)
        {
            persona = obtenerPersonaPorId(id);
            listadoCompletoDepartamentos = clsListadoDepartamentoBL.ListadoCompletoDepartamentos();
        }

        /// <summary>
        /// Metodo que obtiene una persona por id, para ello obtiene un listado de personas completo
        /// itera el listado y si encuentra una persona que tenga la id igual al que le pasamos por parametro
        /// insertamos la persona de la lista en una persona y lo returnamos.
        /// postcondicion: La base de datos tiene que estar disponible.
        /// precondicion: puede returnar null en caso de que la base de datos no este disponible.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public clsPersonas obtenerPersonaPorId(int id)
        {
            List<clsPersonas> lista = clsListadoPersonaBL.ListadoCompletoPersonas();

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Id == id)
                {
                    persona = lista[i];
                }
            }
            return persona;
        }

    }
}
