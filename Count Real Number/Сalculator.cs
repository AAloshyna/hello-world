namespace Asya
{
    class Program


    {
        static void Main(string[] args)
        {
            label:
            //Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Select:" + " + " + ";" + " - " + ";" + " / " + ";" + " - " + ";" + " q " + "(q=exit)\n" + "Remember! Dividing on 0 is forbidden");

            string symb = Console.ReadLine();

            if (symb != "q")
            {

                Console.WriteLine("Enter number of elements in the array:");
                while (true)
                {
                    int n;
                    bool isInt = int.TryParse(Console.ReadLine(), out n);
                    if (!isInt)
                    {
                        Console.WriteLine("Number should be an integer!");
                    }
                    else
                    {
                        double[] mass = new double[n];

                        for (int i = 0; i < mass.Length; i++)
                        {

                            Console.WriteLine("Element " + (i + 1) + " is:");
                            mass[i] = double.Parse(Console.ReadLine());
                        }

                        switch (symb)
                        {
                            case "+":
                                Console.WriteLine("Result Sum: ");
                                Sum(mass);
                                goto label;
                            case "-":
                                Console.WriteLine("Result Minus: ");
                                Minus(mass);
                                goto label;

                            case "/":
                                Console.WriteLine("Result Dev: ");
                                Div(mass);
                                goto label;

                            case "*":

                                Console.WriteLine("Result Mult: ");
                                Mult(mass);
                                goto label;

                            default:
                                Console.WriteLine("!!! ");
                                goto label;
                        }


                    }
                }

            }
        }

        public static double Sum(double[] array)
        {
            double summa = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                summa += array[i];
            }
            Console.WriteLine(summa);
            return summa;
        }
        public static double Mult(double[] array)
        {
            double mult = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                mult *= array[i];
            }
            Console.WriteLine(mult);
            return mult;
        }
        public static double Div(double[] array)
        {
            double div = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                div = div / array[i];
            }

            Console.WriteLine(div);
            return div;
        }
        public static double Minus(double[] array)
        {
            double minus = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                minus -= array[i];
            }
            Console.WriteLine(minus);
            return minus;
        }
    }
}
