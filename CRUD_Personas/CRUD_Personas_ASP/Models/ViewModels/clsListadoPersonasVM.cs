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
        /// <summary>
        /// Metodo que crea un listado de persona mas nombre departamento e iguala los listados y añade
        /// el nombre de departamento llamando a un metodo.
        /// Precondicion: 
        /// Postcondicion: 
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Metodo que recibe una clsPersonaNombreDept e iguala el nombre iterando el listado de departamento y cuando
        /// la id sea igual se le inserta el nombre y lo returna
        /// Precondicion: La bbdd debe estar disponible
        /// </summary>
        /// <param name="personaSeleccionada"></param>
        /// <returns></returns>
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
