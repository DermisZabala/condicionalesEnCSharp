using System;
using System.Runtime.Serialization;
using System.Timers;

namespace coondicional_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if1(); //metodo video 1

            if2(); //metodo video 2

            if3(); //metodo vide  3

            if4();  // operador ||

            calificacionNL(); //IF ELSE

            uso_switch(); //uso del condicional switch

            Console.ReadKey();
        }

        //Condicional if I 
        static void if1()
        {
            Console.WriteLine("Hola Samel, me gustaria saber si eres mayor de edad \nIngresa tu edad:");
            int edad = int.Parse(Console.ReadLine()); //Pide que ingrese los datos

            if (edad >= 18) //Condicion si edad es mayor que 18
            {
                Console.WriteLine($"Tienes {edad} años, usted es mayor de edad"); //entonces se imprime este resultado
            }
            else
            {
                Console.WriteLine($"Tienes {edad} años, eres menor de edad"); //si no se cumple imprime en pantalla esta opción
            }

        }
        static void if2()
        {
            Console.WriteLine("Evaluar si puedes conducir un auto");

            Console.WriteLine("\nIngresa tu edad");
            int edad = Int32.Parse(Console.ReadLine());

            if (edad < 18)
                Console.WriteLine("Lo siento usted no puede conducir");

            else
            {
                Console.WriteLine("¿Usted tiene licencia de conducir?");
                string carnet = Console.ReadLine();

                int comparar = String.Compare(carnet, "si", true);

                if (comparar == 0)
                    Console.WriteLine("Felicidades, ustedes si puede conducir");
                else
                    Console.WriteLine("Lo siento usted no puede conducir");

            }

        }
        static void if3()
        {

            string carnet = "si";

            Console.WriteLine("Evaluamos si puedes conducir un vehiculo");

            Console.WriteLine("¿Que edad tienes?");
            int edad = Int32.Parse(Console.ReadLine());

            if (edad >= 18)
            {

                Console.WriteLine("¿Tienes carnet?");
                carnet = Console.ReadLine();
            }
            int comparar = String.Compare(carnet, "si", true);
            if (edad >= 18 && comparar == 0)

                Console.WriteLine("Usted tiene permiso para conducir");
            else

                Console.WriteLine("Usted no tiene permiso para conducir");

        }

        static void if4()
        {
            Console.WriteLine("Evaluar si el numero que ingresaste es negativo, positivo o cero");
            Console.WriteLine("Ingresa un numero");
            int num = Int32.Parse(Console.ReadLine());

            if (num < 0 || num>0)
            {
                if(num>0)
                    Console.WriteLine("El numero es positivo");
                else
                    Console.WriteLine("El numero es negativo");
            }
            else
            {
                Console.WriteLine("El numero que ingreso es cero");
            }

        }
        static void calificacionNL()
        {
            Console.WriteLine("Calificacion numerica y literal");

            Console.WriteLine("Ingrese los puntos de asistencia");
            int A = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los puntos de trabajo practico");
            int TP = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los puntos del examen parcial");
            int EP = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los puntos del examen final");
            int EF = Int32.Parse(Console.ReadLine());

            int r = A + TP + EP + EF;

            if (r <= 49 )
            {
                Console.WriteLine("Su calificacion numerica es:" + r);
                Console.WriteLine("Su calificacion literal es F");
            }
            else if (r <= 59)
            {
                Console.WriteLine($"La calificación número es {r}");
                Console.WriteLine("La calificación literal es FI");
            }
            else if (r <= 69)
            {
                Console.WriteLine($"La calificacion numerica es {r}");
                Console.WriteLine("La calificacion literales es FE");
            }
            else if (r <= 74)
            {
                Console.WriteLine($"La calificacion numerica es {r}");
                Console.WriteLine("La calificacion literal es D");
            }
            else if (r <= 79)
            {
                Console.WriteLine($"La calificacion numerica es {r}");
                Console.WriteLine("La calificacion literal es C");
            }
            else if (r <= 89)
            {
                Console.WriteLine($"La calificacion numerica es {r}");
                Console.WriteLine("La calificacion literal es B");
            }
            else if (r <= 100)
            {
                Console.WriteLine($"La calificacion numerica es {r}");
                Console.WriteLine("La calificacion literal es A");
            }
            else Console.WriteLine("Ingresaste mal los puntos");

        }
        static void uso_switch()
        {

            Console.WriteLine("Selecciona una opción: \n1.La suma de dos números. \n2.La multiplicación de dos números \n3.La división de dos números \n4.El residuo de una división");
            int op = Int32.Parse(Console.ReadLine());

            switch (op) 
            {
                case 1:
                    Console.WriteLine("Ingrese el primer numero");
                    int sum1 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero");
                    int sum2 = Int32.Parse(Console.ReadLine());

                    int resultadoSuma = sum1 + sum2;
                    Console.WriteLine($"{sum1} + {sum2} = {resultadoSuma}");
                    break;
                case 2:
                    Console.WriteLine("Ingrese el primer numero");
                    int m1 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero");
                    int m2 = Int32.Parse(Console.ReadLine());

                    int resultadoM = m1 * m2;
                    Console.WriteLine($"{m1} * {m2} = {resultadoM}");
                    break;
                case 3:
                    Console.WriteLine("Ingrese el primer numero");
                    double divi1 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero");
                    double divi2 = Int32.Parse(Console.ReadLine());

                    double resultadoDivi = divi1 / divi2;
                    Console.WriteLine($"{divi1} / {divi2} = {resultadoDivi}");
                    break;
                case 4:
                    Console.WriteLine("Ingrese el primer numero");
                    int res1 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero");
                    int res2 = Int32.Parse(Console.ReadLine());

                    int res = res1 % res2;

                    Console.WriteLine($"{res1} % { res2} = { res}");
                    break;
                default:
                    Console.WriteLine("OPCIÓN NO VALIDA!!!");
                    break;

            }

        }
    }
}
