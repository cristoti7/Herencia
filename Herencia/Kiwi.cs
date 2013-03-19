using System;

namespace Herencia
{
	public class Kiwi:FrutasExoticas
	{
		public Kiwi (string nombreDeLaFruta,double precioDelaFruta)
			:base(nombreDeLaFruta,precioDelaFruta)
		{



		}

		public override string imprimirFrutas()
		{
			return "Fruta: " + nombreDeLaFruta + " Precio: " + precioDeLaFruta;
		}





	}
}

