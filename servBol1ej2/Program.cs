namespace servBol1ej2
{
    internal class Program
    {

        delegate double Figura(double d);
        static void Main(string[] args)
        {
            Figura f = (d) => Math.Pow(d, 3);
            string res;
            Console.WriteLine("Dame un numero");
            double numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Quieres hacer un cuadrado o un cubo?(A/S)");
            res= Console.ReadLine().Trim().ToUpper();
            if (res == "A") 
            {
                f = (d) => Math.Pow(d, 2);
            }

            Console.WriteLine("Resultado: "+f(numero));

            
        }
    }
}
