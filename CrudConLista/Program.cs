using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudConLista
{
    class Program
    {

        
        static void Main(string[] args)
        {
            Empleado p = new Empleado();
            while (true)
            {

            int opcion = 0;
                Console.WriteLine("Nomina");
                Console.WriteLine("1- Crear empleado");
                Console.WriteLine("2- Buscar empleado");
                Console.WriteLine("3- Mostrar Registro");
                Console.WriteLine("4- Salir");
    
                Console.WriteLine("");
              
                Console.Write("Elige la opcion: ");
                opcion = int.Parse(Console.ReadLine());
                 Console.WriteLine(" ");

                switch (opcion)
                {
                    case 1:
                        p.Registrar();
                        break;
                    case 2:
                        p.MostrarPorBusqueda();
                        break;
                    case 3:
                        p.Mostrar();
                        break;
    
                default:
                    if(opcion >= 4){Console.WriteLine("Saliste");}
                    break;
                }

            }
        }

        

    }

    public class Empleado
    {
   
        public List<Empleado> empleados = new List<Empleado>();
        public int Codigo { get; set; }
        public string  Nombre { get; set; }
        public string  Apellido { get; set; }
        public string  Direccion { get; set; }
        public string  Cedula { get; set; }
        public string  Sexo { get; set; }
        public string  Telefono { get; set; }
        public string Correo { get; set; }
        public string Departamento { get; set; }
        public double  Sueldo { get; set; }
         
        public void Registrar()
        {
            int opcion = 0;
            while (opcion == 0)
            {

              

                for (int i = 0; i < 1; i++)
                {

                    Empleado R = new Empleado();

                    Console.WriteLine("escribe el Codigo: ");
                    R.Codigo = int.Parse(Console.ReadLine());

                    Console.WriteLine("escribe el Nombre: ");
                    R.Nombre = Console.ReadLine().ToString();

                    Console.WriteLine("escribe el Apellido: ");
                    R.Apellido = Console.ReadLine().ToString();

                    Console.WriteLine("escribe el Direccion: ");
                    R.Direccion = Console.ReadLine().ToString();

                    Console.WriteLine("escribe el Cedula: ");
                    R.Cedula = Console.ReadLine().ToString();

                    Console.WriteLine("escribe el Sexo: ");
                    R.Sexo = Console.ReadLine().ToString();

                    Console.WriteLine("escribe el Telefono: ");
                    R.Telefono = Console.ReadLine().ToString();

                    Console.WriteLine("escribe el Correo: ");
                    R.Correo = Console.ReadLine().ToString();

                    Console.WriteLine("escribe el Departamento: ");
                    R.Departamento = Console.ReadLine().ToString();

                    Console.WriteLine("escribe el Sueldo: ");
                    R.Sueldo = double.Parse(Console.ReadLine().ToString());


                    empleados.Add(R);
                    empleados.Sort((x, y) => string.Compare(x.Nombre, y.Nombre));
                    Console.Write("desea seguir: ");
                    opcion = int.Parse(Console.ReadLine());
                    if (opcion >= 1)
                    {
                        break;
                    }

                }
            }
        }

        public void Mostrar()
        {
            foreach (var item in empleados)
            {
                Console.WriteLine("Codigo {0}", item.Codigo);
                Console.WriteLine("Nombre {0}", item.Nombre);
                Console.WriteLine("Apellido {0}", item.Apellido);
                Console.WriteLine("Direccion{0}", item.Direccion);
                Console.WriteLine("Cedula{0}", item.Cedula);
                Console.WriteLine("Sexo {0}", item.Sexo);
                Console.WriteLine("Telefono {0}", item.Telefono);
                Console.WriteLine("Correo{0}", item.Correo);
                Console.WriteLine("Departamento{0}", item.Departamento);
                Console.WriteLine("Sueldo {0}", item.Sueldo);

                Console.WriteLine("");
                Console.WriteLine("---------------------");
                Console.WriteLine("");
            }
            
        }

        public void MostrarPorBusqueda()
        {
            Console.Write("escriba el nombre: ");
            string buscar = Console.ReadLine().ToString();

            foreach (var item in empleados.ToList())
            {
                if (item.Nombre.ToString() == buscar)
                {
                    Console.WriteLine("Codigo {0}", item.Codigo);
                    Console.WriteLine("Nombre {0}", item.Nombre);
                    Console.WriteLine("Apellido {0}", item.Apellido);
                    Console.WriteLine("Direccion{0}", item.Direccion);
                    Console.WriteLine("Cedula{0}", item.Cedula);
                    Console.WriteLine("Sexo {0}", item.Sexo);
                    Console.WriteLine("Telefono {0}", item.Telefono);
                    Console.WriteLine("Correo{0}", item.Correo);
                    Console.WriteLine("Departamento{0}", item.Departamento);
                    Console.WriteLine("Sueldo {0}", item.Sueldo);

                    Console.WriteLine("");
                    Console.WriteLine("---------------------");
                    Console.WriteLine("");
                }
            
                else
                {
                    Console.WriteLine("no existe este usuario");
                }


            }

        }




    }
}
