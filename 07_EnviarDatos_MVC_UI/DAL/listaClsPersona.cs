using _07_Entidades;

namespace _07_DAL
{
    public class clsListadoPersonaDAL
    {

        /// <summary>
        /// Creacion de la lista de clase persona con la inicializacion de 5 personas y se añade las personas en la lista y returna la lista
        /// Precodicion:
        /// Postcondicion: Devolvera 6 personas
        /// </summary>
        /// <returns></returns>
        public static List<clsPersona> obtenerListadoCompletoPersonas()
        {

            List<clsPersona> lista = new List<clsPersona>();

            clsPersona persona1 = new clsPersona();
            clsPersona persona2 = new clsPersona();
            clsPersona persona3 = new clsPersona();
            clsPersona persona4 = new clsPersona();
            clsPersona persona5 = new clsPersona();
            clsPersona persona6 = new clsPersona();

            persona1.nombre = "David";
            persona1.apellidos = "Perea";
            persona2.nombre = "Daniel";
            persona2.apellidos = "Araujo";
            persona3.nombre = "Ruben";
            persona3.apellidos = "Lindes";
            persona4.nombre = "Daniel";
            persona4.apellidos = "Lindes";
            persona5.nombre = "Alejandro";
            persona5.apellidos = "Mulero";
            persona6.nombre = "Javier";
            persona6.apellidos = "Sequera";

            lista.Add(persona1);
            lista.Add(persona2);
            lista.Add(persona3);
            lista.Add(persona4);
            lista.Add(persona5);
            lista.Add(persona6);

            return lista;
        }

    }
   
}
