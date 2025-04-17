using System;
using System.Collections.Generic;

namespace MTD
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Ejercicio 7
			Pila pila = new Pila();
			Cola cola = new Cola();
			//llenar(pila);
			//llenar(cola);
			//informar(pila);
			//informar(cola);
			
			//ejercicio 9
			ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);
			llenarAlumno(pila);
			llenarAlumno(cola);
			informar(multiple);
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		//Ejercicio 5
		public static void llenar(Coleccionable c){
			Random rn = new Random();
			
			for (int i = 0; i < 20; i++) {
				Comparable com = new Numero(rn.Next());
				c.agregar(com);
			}
		}
		
		//Ejercicio 6
		public static void informar(Coleccionable col){
			Console.WriteLine("La cantidad total de elementos del coleccionable es: {0}", col.cuantos());
			Console.WriteLine("El minimo elemento del coleccionable es: {0}", ((Alumno)col.minimo()).toString());
			Console.WriteLine("El maximo elemento del coleccionable es: {0}", ((Alumno)col.maximo()).toString());
			
			Console.WriteLine("Escriba el numero que desea buscar: ");
			//Comparable com = new Alumno("",int.Parse(Console.ReadLine()), 0, 0);
			Comparable com = new Alumno("", 0, int.Parse(Console.ReadLine()), 0);
			if (col.contiene(com)) {
				Console.WriteLine("El elemento leido esta en la coleccion");
			}
			else
				Console.WriteLine("El elemento leido no esta en la coleccion");
		}
		
		//Ejercicio 13
		public static void llenarAlumno(Coleccionable col){
			List<string> nom = new List<string>{"Cristian", "Gabriel", "Juan", "Marisa", "Lujan", "Alfredo", "Florencia"};
			
			Random n = new Random();
			Random d = new Random();
			Random l = new Random();
			Random p = new Random();
			
			for (int i = 0; i < 20; i++) {
				Comparable c = new Alumno(nom[n.Next(0,7)], d.Next(4000000,4500000), l.Next(0,1000), p.Next(0,11));
				col.agregar(c);
			}
		}
	}
}