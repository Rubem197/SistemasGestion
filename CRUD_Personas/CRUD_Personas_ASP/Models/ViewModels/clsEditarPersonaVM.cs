using CRUD_Personas_BL;
using CRUD_Personas_Entidades;

namespace CRUD_Personas_ASP.Models.ViewModels
{
    public class clsEditarPersonaVM
    {










        public static clsPersonas obtenerPersonaPorId(int id)
        {
            clsPersonas persona = new clsPersonaNombreDept();
            List<clsPersonas> lista = clsListadoPersonaBL.ListadoCompletoPersonas();

            for (int i = 0; i<lista.Count; i++)
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
