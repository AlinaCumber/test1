

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
            while(1 < n)
            {
                if(Everithing.IsEven(i) < n) System.Console.WriteLine(i);

                i++;

            }
        }




    }
}
