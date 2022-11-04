using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaDeBarrios
{
    public class Pedido
    {
        //Atributos
        public string barrio;
        public int cantidadGalletas;

        //Constructor
        public Pedido()
        {
            barrio = "";
            cantidadGalletas = 0;
        }

        //Propiedades
        public string Barrio
        {
            get { return barrio; }
            set { barrio = value; }
        }

        public int CantidadGalletas
        {
            get { return cantidadGalletas; }
            set { cantidadGalletas = value; }
        }
    }
}
