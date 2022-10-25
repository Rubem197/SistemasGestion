namespace Entidades
{
    public class clsDepartamento
    {
        public int nDepartamento { get; set; }
        public string nombredepartamento { get; set; }



        public clsDepartamento()
        {

        }

        public clsDepartamento(int nDepartamento, string nombreDepartamento)
        {
            this.nDepartamento = nDepartamento;
            this.nombredepartamento = nombreDepartamento;   
        }
    }
}
