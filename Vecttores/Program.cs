using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vecttores
{
    internal class Program
    {


        static float num1=0, num2 = 0, resultado = 0; // variables globales para almacenar los números y el resultado
      
        static void SocilitarDatos()
        {
            Console.WriteLine("Digite el primer numero: ");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite el segundo numero: ");
            num2 = float.Parse (Console.ReadLine());
         
        }

      
        static void suma()
        {
            resultado = num1 + num2;
            Console.WriteLine("El resultado de la suma es: " + resultado);
        }

        static void resta(float n1, float n2)
        {
            resultado = n1 - n2;
            Console.WriteLine("El resultado de la resta es: " + resultado);
        }

        static float multiplicar()
        {
            return num1 * num2;
        }

        static float dividir(float n1, float n2)
        {
            if (n2 != 0)
            {
                return n1 / n2;
            }
            else
            {
                Console.WriteLine("Error: No se puede dividir entre cero.");
                return 0; // Retorna 0 en caso de división por cero
            }
        }

        static void menu()
        {
            int opcion;  // variable local para almacenar la opción seleccionada por el usuario
            Console.WriteLine("1. Suma ");
            Console.WriteLine("2. Resta ");
            Console.WriteLine("3. Multiplicar ");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Salir");
            Console.WriteLine("digite una opcion:");
            int.TryParse(Console.ReadLine(), out  opcion);
            switch (opcion)
            {
                case 1:
                    SocilitarDatos();
                    suma();
                    break;
                case 2:
                    SocilitarDatos();
                    resta(num1, num2);
                    break;
                case 3:
                    SocilitarDatos();
                    Console.WriteLine("El resultado de la multiplicacion es: " + multiplicar());
                    break;
                case 4:
                    SocilitarDatos();
                    Console.WriteLine("Dividir");
                    break;      
                case 5: Console.WriteLine("Salir del sistema");
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
        }

        static void Main(string[] args)
        {
            menu();

        }
        
        

    }
}
