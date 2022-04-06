using PW3_2022_1C_Clase_1.Entidades;
using System;

namespace bolaOchoConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cerrarApp = false;
            while (!cerrarApp)
            {
                Console.WriteLine("Ingrese su pregunta:");
                string pregunta = Console.ReadLine();
                Console.WriteLine(BolaOcho.getRespuesta());



                Console.WriteLine("Desea hace una nueva pregunta?");
                Console.WriteLine("1) Si 2)No");
                string opcion = Console.ReadLine();

                if(opcion == "2")
                {
                    cerrarApp = true;
                }
            }
        }
    }
}
