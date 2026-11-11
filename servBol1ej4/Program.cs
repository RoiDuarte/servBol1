namespace servBol1ej4
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string directory;
            string separator;
            string fullName;


            directory = @"C:\Users\roilo";
            /*Environment.GetEnvironmentVariable("homepath");*/
            separator = "\\";
            fullName = directory + separator + "ejercicio4.txt";

            using (StreamWriter s = new StreamWriter(fullName))
            {

                s.WriteLine("5,2,-8,1,20,-4");
                s.WriteLine("Sol,Luna,Estrella,Cielo,La,Si,Do");

            }

            int[] numbers = new int[6];
            string[] words = new string[7];

            using (StreamReader sr = new StreamReader(fullName))
            {



                String primeraLinea = sr.ReadLine();
                String[] primeraLineaV = primeraLinea.Split(',');
                for (int i = 0; i < primeraLineaV.Length; i++)
                {
                    numbers[i] = int.Parse(primeraLineaV[i]);
                }
                String segundaLinea = sr.ReadLine();
                words = segundaLinea.Split(',');


            }


            Console.WriteLine("---Vector: numbers---");
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("1.-Saber si hay algún número negativo");
            Console.WriteLine(Array.Exists(numbers, (numero) => numero < 0));

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("2.-Mostrar los impares.");
            Array.ForEach(numbers, (numero) =>
            {
                if (numero % 2 != 0)
                {
                    Console.Write(numero + " ");
                }

            });
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("3.-Indicar la posición en el array del último número mayor que 10.");

            Console.WriteLine(Array.FindLast(numbers, (numero) => numero > 10));



            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("4.-Mostrar el valor del último positivo.");

            Console.WriteLine(Array.FindLastIndex(numbers, (numero) => numero > 0));

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("5.-Cuantos son positivos y divisibles entre 5.");
            int cont = 0;
            Array.ForEach(numbers, (numero) =>
            {
                if (numero % 5 == 0 && numero > 0)
                {
                    cont++;
                }
            });
            Console.WriteLine(cont);
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("---Vector: words---");
            Console.WriteLine();
            Console.WriteLine("1.-Cuál es la primera palabra de más de 4 caracteres.");
            Console.WriteLine(Array.Find(words, (word) => word.Length > 4));
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("2.-Mostrar todas las palabras en mayúsculas.");
            Array.ForEach(words, (word) => Console.WriteLine(word.ToUpper()));
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("3.-Indica si existe alguna palabra de dos caracteres y que el segundo sea una A.");

            Console.WriteLine(Array.Exists(words, (word) => word.Length == 2 && word[1] == 'a'));

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("4.-Indica la posición de la primera palabra que empiece por E.");

            Console.WriteLine(Array.FindIndex(words, (word) => word[0] == 'E'));
            Console.WriteLine("---------------------------------------------------");



        }
    }
}
