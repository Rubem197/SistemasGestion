using ExamenRubenLindes_BL;
using ExamenRubenLindes_Entidades;

namespace ExamenRubenLindes_ASP.Models.ViewModels
{
    public class clsBorrarDepartamentosVM
    {
        clsDepartamento departamento;
        int personasABorrar;
        string personasBorradas;

        public clsDepartamento Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }
        public int PersonasABorrar
        {
            get { return personasABorrar; }
            set { personasABorrar = value; }
        }
        public string PersonasBorradas
        {
            get { return personasBorradas; }
            set { personasBorradas = value; }
        }
        public clsBorrarDepartamentosVM(int id)
        {
            departamento = obtenerDepartamentoPorId(id);
            personasABorrar = obtenerPersonasABorrar(id);
            personasBorradas = obtenerPersonasBorradas();
        }
        /// <summary>
        /// Metodo que obtiene un departamento por la id, para ello
        /// se obtiene el listado de departamentos y se itera en cada iteracion
        /// se comprueba si la id es igual al id del departamento del listado si es asi
        /// guardara en departamento el departamento del listado
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private clsDepartamento obtenerDepartamentoPorId(int id)
        {
            List<clsDepartamento> listadoDepartamento = clsListadoDepartamentoBL.ListadoCompletoDepartamentos();

            for (int i = 0; i < listadoDepartamento.Count; i++)
            {
                if (listadoDepartamento[i].Id == id)
                {
                    departamento = listadoDepartamento[i];
                }
            }

            return departamento;
        }
        /// <summary>
        /// Metodo que compara las id de departamento de las personas de la lista personas,
        /// con la id que enviamos al seleccionar el departamento y si son iguales aumenta el contador
        /// y devolvera el numberos de personas con ese departamento
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private int obtenerPersonasABorrar(int id)
        {
            int contador = 0;
            List<clsPersona> listadoPersonas = clsListadoPersonaBL.ListadoCompletoPersonas();
            for (int i = 0; i < listadoPersonas.Count; i++)
            {
                if (listadoPersonas[i].IdDepartamento == id)
                {
                    contador++;
                }
            }
            return contador;
        }
        /// <summary>
        /// Metodo que devulve un string con un mensaje de las personas que se han borrado
        /// y el numero lo recoge de la variable personasABorrar
        /// Precondicion: No se controla la variable por lo que puede ser 0.
        /// </summary>
        /// <returns></returns>
        private string obtenerPersonasBorradas()
        {
            return ("Se han borrado " + personasABorrar + " personas");
        }
    }
}
