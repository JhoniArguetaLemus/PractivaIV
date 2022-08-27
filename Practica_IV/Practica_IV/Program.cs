using System;
using System.Linq;
namespace Practica_IV
{
    internal class Program
    {
        public static void Main()
        {
            int Id;
            String Codigo;
            String Nombre;
            string Facultad;
            int Edad;
            Console.WriteLine("¿Cuántos estudiantes desea almacenar? ");
            int cantEstudiantes = int.Parse(Console.ReadLine());

            Estudiante[] arregloEstudiantes = new Estudiante[cantEstudiantes];

            for(int i =0; i<cantEstudiantes; i++)
            {
                Id = i + 1;
                Console.Write("Ingrese el código: ");
                Codigo = Console.ReadLine();

                Console.Write("Ingrese el nombre: ");
                Nombre = Console.ReadLine();

                Console.Write("Ingrese la edad: ");
                Edad = int.Parse(Console.ReadLine());


                Console.Write("Ingrese la facultad: ");
                Facultad = Console.ReadLine();

                arregloEstudiantes[i] = new Estudiante(Id, Codigo, Nombre, Edad, Facultad);

                Console.WriteLine();
            }
           


            string opcionBusqueda="si";

            while (opcionBusqueda == "si"  || opcionBusqueda=="SI")
            {


                Console.Write("¿Desea realizar la busqueda por Facultad, Nombre o Edad? \n1.Facultad \n2.Nombre \n3.Edad\n");
                Console.WriteLine("Ingrese su opción: ");
                int opcionB = int.Parse(Console.ReadLine());

                if (opcionB == 1)
                {
                    Console.Write("Ingrese el nombre de la Facultad: ");
                    string nombre = Console.ReadLine();

                    IEnumerable<Estudiante> busquedaPorFacultad = from estudiante in arregloEstudiantes where estudiante.Facultad == nombre select estudiante;

                    int cantidadEncontrados = busquedaPorFacultad.Count();
                    Console.WriteLine();
                    if(cantidadEncontrados != 0)
                    {
                        foreach (Estudiante est in busquedaPorFacultad)
                        {
                            Console.WriteLine(est.mostrar());
                            
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("No hay estudiantes en esa facultad");
                    }

                    

                }

                


                if (opcionB == 2)
                {
                    Console.WriteLine("Ingrese el nombre del estudiante: ");
                    string nombre = Console.ReadLine();

                    IEnumerable<Estudiante> busquedaPorNombre = from estudiante in arregloEstudiantes where estudiante.Nombre == nombre select estudiante;

                    int cantidadEncontrados = busquedaPorNombre.Count();
                    Console.WriteLine();
                    if(cantidadEncontrados != 0)
                    {
                        foreach (Estudiante est in busquedaPorNombre)
                        {
                            Console.WriteLine(est.mostrar());
                        }
                        Console.WriteLine();

                    }
                    else
                    {
                        Console.WriteLine("No existe un estudiante con ese nombre");
                    }

                    Console.WriteLine();

                }
  

                if (opcionB == 3)
                {
                    Console.Write("Ingrese la edad: ");
                    int edad = int.Parse(Console.ReadLine());

                    IEnumerable<Estudiante> busquedaPorEdad = from estudiante in arregloEstudiantes where estudiante.Edad >= edad select estudiante;

                    int cantidadEncontrados = busquedaPorEdad.Count();

                    Console.WriteLine();
                    if (cantidadEncontrados != 0)
                    {
                        foreach (Estudiante est in busquedaPorEdad)
                        {
                            Console.WriteLine(est.mostrar());
                        }

                        Console.WriteLine();

                    }
                    else
                    {
                        Console.WriteLine("No se encontro estudiantes en ese rango de edad");
                    }

                   
                }
                
                Console.WriteLine("\n¿Desea realizar otra busqueda? (si/no): ");
                opcionBusqueda = Console.ReadLine();
             }

        }
    }
}