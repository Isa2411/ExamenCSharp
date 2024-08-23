using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjerciciosCsharp.EjercicioEmpleado;
using static EjerciciosCsharp.Persona;

namespace EjerciciosCsharp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Persona persona = new Persona("Antonella", 2, "Campoalegre");
            //Await
            await persona.LeerDatosAsync();


            Empleado empleado = new Empleado("Juan", 30, "Rivera", 3000.0);
            empleado.MostrarInformacion();
            empleado.CalcularSalario();


            // Usando el principio DIP (Dependency Inversion Principle)
            IPersona Persona = new PersonaConLecturaAsincronica();

            // Realizando la lectura de datos de manera asíncrona
            await ((PersonaConLecturaAsincronica)persona).LeerDatosAsync();

        }
    }
}