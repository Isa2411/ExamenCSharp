using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjerciciosCsharp.Interface;

namespace EjerciciosCsharp.EjercicioEmpleado
{
    public class Empleado : Persona, ICalculable
    {
        public double Salario { get; set; }

        public Empleado(string nombre, int edad, string direccion, double salario)
            : base(nombre, edad, direccion)
        {
            Salario = salario;
        }

        //Metodo para calcular el salario
        public void CalcularSalario()
        {
            Salario *= 1.10;
        }


        // Sobrescribir el método para mostrar la información, incluyendo el salario
        public void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Salario: {Salario}");
        }

    }

}
