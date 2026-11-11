using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

namespace servBol1
{
    internal class Program
    {

        public static void listarContenido(string path)
        {

            DirectoryInfo info = null;

            try
            {

                info = new DirectoryInfo(path);

                DirectoryInfo[] arrayDirectories = info.GetDirectories();


                for (int i = 0; i < arrayDirectories.Length; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(arrayDirectories[i]);

                    FileInfo[] arrayFiles = arrayDirectories[i].GetFiles();

                    for (int j = 0; j < arrayFiles.Length; j++)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(arrayFiles[i] + "tamaño: " + arrayFiles[i].Length);

                    }
                }
            }
            catch (ArgumentNullException ex)
            {

                Console.WriteLine("No se encontro el path");
            }


        }

        public static void leerArchivo(string path, int nLineas = 0)
        {

            //StreamReader sr = null;
            try
            {


                //sr = new StreamReader(path);


                using (StreamReader sr = new StreamReader(path))
                {
                    string line="";
                    //line = sr.ReadLine();
                    int cont = 0;


                    if (nLineas == 0)
                    {


                        string textoCompleto = sr.ReadToEnd();
                        Console.WriteLine(textoCompleto);


                    }
                    else
                    {

                        while ((line = sr.ReadLine()) != null && cont < nLineas) //TODO Podemos asignar dentro dunha condicion?
                        {
                            
                            Console.WriteLine(line);
                            cont++;
                        }

                    }
                }


            }
            catch (IOException ex)
            {
                Console.WriteLine("Error al leer el archivo");
            }

        }

       

        public static void anhadirTexto(string path, string texto, string a = "")
        {
            try
            {

                if (a == "")
                {

                    using (StreamWriter s = new StreamWriter(path, false))
                    {
                        s.WriteLine(texto);
                    }

                }
                else
                {
                    using (StreamWriter s = new StreamWriter(path, true))
                    {
                        s.WriteLine(texto);
                    }
                }

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Datos invalidos.");
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Directorio: ");
            string path = Console.ReadLine();

        }
    }
}
