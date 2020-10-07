namespace MathExercise
{

    class Maths
    {
        public static Solutions calculateRoot(double a, double b, double c)
        {
            double d;
            Solutions result = new Solutions();


            d = System.Math.Pow(b, 2) - 4 * a * c; //discriminante

            result.solution1 = -b + System.Math.Sqrt(d) / 2 * a;

            result.solution2 = -b - System.Math.Sqrt(d) / 2 * a;

            return result;






        }


        public static double secondCalcRoot(double a, double b)
        {

            return -b / a;

        }

        public static bool IsPrime(int number)
        {
            int i = 2;
            {
                if (number % i == 0)
                {
                    return true;
                }
                else return false;
              
            }
            
        }




    }
}


