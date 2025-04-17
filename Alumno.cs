using System;

namespace MTD
{
	//Ejercicio 12
	public class Alumno : Persona, Comparable
	{
		private int legajo;
		private int promedio;
		
		public Alumno(string n, int d, int l, int p): base(n, d){
			this.nombre = n;
			this.dni = d;
			this.legajo = l;
			this.promedio = p;
		}
		
		public override string getNombre()
		{
			return this.nombre;
		}
		
		public override int getDni(){
			return this.dni;
		}
		
		public int getLegajo(){
			return this.legajo;
		}
		
		public int getPromedio(){
			return this.promedio;
		}
		
		public override bool sosIgual(Comparable c)
        {
            return this.legajo == ((Alumno)c).legajo;
        }

        public override bool sosMenor(Comparable c)
        {
            return this.legajo < ((Alumno)c).legajo;
        }

        public override bool sosMayor(Comparable c)
        {
            return this.legajo > ((Alumno)c).legajo;
        }
        
		public override string toString()
		{
			return base.toString() + string.Format(" Legajo: {0}, Promedio: {1}", legajo, promedio);
		}
	}
}
