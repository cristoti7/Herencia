using System;

namespace Herencia
{
	public class Yaca:FrutasExoticas
	{

		public Yaca (string nombreDeLaFruta,double precioDelaFruta)
			:base(nombreDeLaFruta,precioDelaFruta)
		{






		}
		public override string imprimirFrutas()
		{
			return "Fruta: " + nombreDeLaFruta + " Precio: " + precioDeLaFruta;
		}


	}


}

