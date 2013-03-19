using System;

namespace Herencia
{
	class Principal
	{
		public static void Main (string[] args)
		{
			//metodos virtuales  
			Manzana miManzana= new Manzana();
			Fresa miFresa= new Fresa();
			miManzana.CortarFruta();
			Console.WriteLine("");
			miFresa.CortarFruta();
			//clases abstractas
			Yaca miYaca= new Yaca("yaca de jalisco",38.14 );
			Kiwi miKiwi= new Kiwi("kiwi de la india",25.50);
			Console.WriteLine("\n INFORMACION DE MIS FRUTAS \n ");

			Console.WriteLine(miYaca.imprimirFrutas());
			Console.WriteLine(" \n ");
			Console.WriteLine(miKiwi.imprimirFrutas());
			Console.WriteLine("");
		
		}
	}
}
