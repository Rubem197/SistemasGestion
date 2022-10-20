using Entidades;

namespace DAL
{
    public class clsManejadoraPersonaDAL
    {   
        /// <summary>
        /// Accedemos a la base de datos y devolvemos a la persona cuyo id corresponda con el parametro de entrada
        /// Precondiciones: el id introducido existe en la base de datos
        /// Postcondiciones: la persona nuna estara vacia
        /// </summary>
        /// <param name="id"></param>
        /// <returns>clsPersona</returns>
        public clsPersona ObternerPersonaPorId(int id) {


            return new clsPersona();
        }

        /// <summary>
        /// Actualiza o inserta una persona en la base de datos
        /// Precondiciones: que en la base de datps este accesible 
        /// Postcondiciones: Las filas afectadas seran mayor o igual a 0 
        /// </summary>
        /// <param name="persona"></param>
        /// <returns></returns>
        public int guardarPersonas(clsPersona persona) {
            int numFilasAfectadas =0;
            //...
            return numFilasAfectadas;
        }
    }
}
