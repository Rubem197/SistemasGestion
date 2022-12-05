using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class clsListadoCartasDAL
    {
        /// <summary>
        /// Metodo que genera 7 cartas y los guarda en una lista
        /// Postcondicion: returna una lista de la clsCartas
        /// </summary>
        /// <returns></returns>
        public static List<clsCartas> ListadoCompletoCartas()
        {
            List<clsCartas> listaCartas = new List<clsCartas>();

            listaCartas.Add(new clsCartas(1,"babyJoda", "babyjoda.jpg",true));
            listaCartas.Add(new clsCartas(2, "mandaloriano", "mandalorian.jpg", true));
            listaCartas.Add(new clsCartas(3, "ATST", "atst.jpg", false));
            listaCartas.Add(new clsCartas(4, "kraytDragon", "kraytdragon.jpg", false));
            listaCartas.Add(new clsCartas(5, "moffgideon", "moffgideon.jpg", false));
            listaCartas.Add(new clsCartas(6, "spider", "spider.jpg", false));
            listaCartas.Add(new clsCartas(3, "Tradoshan", "tradoshan.jpg", false));


            return listaCartas;
        }
    }
}
