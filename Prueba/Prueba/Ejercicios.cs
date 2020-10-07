

namespace Prueba
{
    class Ejercicios
    {
        // ejecicico: hacer una funcion que imprima por pantalla los numeros del 0 al 99

        public static void Ejercicio1()
        {
            int count = 0;
            while(count < 100)
            {
                System.Console.WriteLine(count);
                count++;

            }
        }

        //ej2: hacer l funcion que imprima todos los numeros pares desde 0 hasta n

        public static void Ejercicio2 (int n)
        {
            int i = 0;
            while(i < n)
            {
                if (i % 2 == 0)
                {
                    System.Console.WriteLine(i);
                }                   

                i++;
            }
            
        }

        public static void Ejercicios3(int num)
        {
            if (MathExercise.Maths.IsPrime(num))
            {
                System.Console.WriteLine("Prime");

            }
        }

        public static void Ejercicio4()
        {
            for(int i = 0; i < 90; i++)
            {

                if (i % 2 == 0)
                {
                    System.Console.WriteLine(-i);
                }
                else System.Console.WriteLine( i);
            }
        }

        public static void Fibonachi(int n)
        {
            int a = 0;
            int b = 1;
            int i = 0;

            while( i < n)
            {
                System.Console.WriteLine(a);
                System.Console.WriteLine(b);
                System.Console.WriteLine(a + b);
                b = a + b;
                a = b - a;
                if (b > 25) break;
            }

            /*for (int i = 0; i < n; i++)
            {
                temp = a;
                a = b;
                b += temp;
            }
            return a;*/
            
        }





    }
}
