using CRUD_Personas_BL;
using CRUD_Personas_Entidades;

namespace CRUD_Personas_ASP.Models.ViewModels
{
    public class clsListadoPersonasVM
    {
        private List<clsPersonas> listadoCompletoPersonas;

        private List<clsPersonaNombreDept> listadoCompletoPersonasMasDept;

        public List<clsPersonas> ListadoCompletoPersonas
        {
            get { return listadoCompletoPersonas; }
            set { listadoCompletoPersonas = value; }
        }

        public List<clsPersonaNombreDept> ListadoCompletoPersonasMasDept
        {
            get { return obtenerListadoPersonasMasDept(); }
            set { listadoCompletoPersonasMasDept = value; }
        }

        public clsListadoPersonasVM()
        {
            listadoCompletoPersonas = clsListadoPersonaBL.ListadoCompletoPersonas();
            listadoCompletoPersonasMasDept = new List<clsPersonaNombreDept>();
        }

        public List<clsPersonaNombreDept> obtenerListadoPersonasMasDept()
        {
            for (int i = 0; i < listadoCompletoPersonas.Count(); i++)
            {
                listadoCompletoPersonasMasDept.Add(new clsPersonaNombreDept());
            }
            for (int i = 0; i < listadoCompletoPersonas.Count(); i++)
            {
                listadoCompletoPersonasMasDept[i].Id = listadoCompletoPersonas[i].Id;
                listadoCompletoPersonasMasDept[i].Nombre = listadoCompletoPersonas[i].Nombre;
                listadoCompletoPersonasMasDept[i].Apellidos = listadoCompletoPersonas[i].Apellidos;
                listadoCompletoPersonasMasDept[i].Telefono = listadoCompletoPersonas[i].Telefono;
                listadoCompletoPersonasMasDept[i].Direccion = listadoCompletoPersonas[i].Direccion;
                listadoCompletoPersonasMasDept[i].Foto = listadoCompletoPersonas[i].Foto;
                listadoCompletoPersonasMasDept[i].FechaNacimiento = listadoCompletoPersonas[i].FechaNacimiento;
                listadoCompletoPersonasMasDept[i].IdDepartamento = listadoCompletoPersonas[i].IdDepartamento;
                listadoCompletoPersonasMasDept[i].NombreDept = obtenerNombrePorId(listadoCompletoPersonasMasDept[i]).NombreDept;
            }

            return listadoCompletoPersonasMasDept;
        }

        public clsPersonaNombreDept obtenerNombrePorId(clsPersonaNombreDept personaSeleccionada)
        {
            List<clsDepartamentos> departamentoSeleccionado = clsListadoDepartamentoBL.ListadoCompletoDepartamentos();
            for (int i = 0; i < departamentoSeleccionado.Count; i++)
            {
                if (personaSeleccionada.IdDepartamento+1 == departamentoSeleccionado[i].Id)
                {
                    personaSeleccionada.NombreDept = departamentoSeleccionado[i].Nombre;
                }
            }
            return personaSeleccionada;
        }

    }
}
