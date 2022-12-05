using CRUD_Personas_Entidades;

namespace CRUD_Personas_ASP.Models
{
    public class clsPersonaNombreDept: clsPersonas
    {
        private string nombreDept;

        public string NombreDept
        {
            get { return nombreDept; }
            set { nombreDept = value; }
        }

        public clsPersonaNombreDept()
        {

        }
    }
}
