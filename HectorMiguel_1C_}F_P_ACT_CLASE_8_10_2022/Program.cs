using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace HectorMiguel_1C__F_P_ACT_CLASE_8_10_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //aqui va a cambiar el color de la consola
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Gray;
            //variables estas son los datos del alumno
            string nameUser, lastName, matricula, seccion, grado;
  
            byte calificacion = 0;

            //aqui se guardaran los datos de las variables que se utilizaran para pedir lo0s datos del estudiante
            Console.WriteLine("ingresa tu nombre y al finalizar presiona ENTER");
            nameUser = Console.ReadLine();
            Console.WriteLine("ingresa tu apellido y al finalizar presiona ENTER");
            lastName = Console.ReadLine();
            Console.WriteLine("ingresa tu matricula y al finalizar presiona ENTER");
            matricula= Console.ReadLine();
            Console.WriteLine("ingresa tu seccion finalizar presiona ENTER");
            seccion = Console.ReadLine();
            Console.WriteLine("ingresa tu grado que cursasy al finalizar presiona ENTER");
            grado = Console.ReadLine();
            Console.WriteLine("ingresa tu calificacion obtenidqa y al finalizar presiona ENTER");
            calificacion = Convert.ToByte(Console.ReadLine());


            //if, aqui se va a comparar si es mayor a 70 acreditas y si es menor no acreditas
            if (calificacion >= 70)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Gray;

                Console.WriteLine("Acreditaste el curso");
                Thread.Sleep(5000);


            }
            //sino acreditaste el curso te dira esto:
            else
            {
                Console.WriteLine("No acreditaste el curso, debes de volver a acreditar la asignatura");
                Thread.Sleep(5000);
            }
        }
    }
}
