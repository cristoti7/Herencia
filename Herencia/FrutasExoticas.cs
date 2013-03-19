using System;

namespace Herencia
{
	public abstract class FrutasExoticas
	{
		protected double precioDeLaFruta;
		protected string nombreDeLaFruta;

		public FrutasExoticas (string nombreDeLaFruta,double precioDeLaFruta)
		{
			this.precioDeLaFruta=precioDeLaFruta;
			this.nombreDeLaFruta=nombreDeLaFruta;
		
		}
		public abstract string imprimirFrutas();
	}
}

