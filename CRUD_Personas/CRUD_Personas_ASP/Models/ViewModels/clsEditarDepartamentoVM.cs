using CRUD_Personas_BL;
using CRUD_Personas_Entidades;

namespace CRUD_Personas_ASP.Models.ViewModels
{
    public class clsEditarDepartamentoVM
    {
        /// <summary>
        /// Metodo que obtiene un departamento por id, para ello obtiene un listado de departamento completo
        /// itera el listado y si encuentra un departamento que tenga la id igual al que le pasamos por parametro
        /// insertamos el departamento de la lista en un departamento y lo returnamos.
        /// postcondicion: La base de datos tiene que estar disponible.
        /// precondicion: puede returnar null en caso de que la base de datos no este disponible.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static clsDepartamentos obtenerDepartamentoPorId(int id)
        {
            clsDepartamentos departamento = new clsDepartamentos();
            List<clsDepartamentos> lista = clsListadoDepartamentoBL.ListadoCompletoDepartamentos();
        
            for(int i = 0; i < lista.Count; i++)
            {
                if(id== lista[i].Id)
                {
                    departamento= lista[i];
                }
            }
            return departamento;
        }
    }
}
