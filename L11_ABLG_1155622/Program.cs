using System;

namespace L11_ABLG_1155622
{
    class Program
    {
        static void Main(string[] args)
        {
            double inicial;
            string tipo;
            double convertido = 0;

            Console.WriteLine("Bienvenid@, escribe una cantidad de dinero que este en yenes, dolares o libras que quieras convertir a euros");
            Console.WriteLine("Primero escribe la cantidad que quieres convertir a euros");
            inicial = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ahora escribe el tipo moneda que quieres convertir a euros (el tipo de moneda escribelo de esta forma: yenes, dolares,libras )");
            tipo = Console.ReadLine();

            Console.WriteLine("La cantidad ingresada en "+ tipo +" equivale a: " + conversionMoneda(inicial,tipo, convertido) +" en euros" ); 
        }

        static double conversionMoneda (double inicial, string tipo, double convertido) 
        {
            if (tipo == "yenes")
            {
                return (inicial*0.009) ; 
            }else
            {
                if (tipo=="libras")
                {
                    return (inicial * 1.22);
                }
                else
                {
                    return (inicial*0.75);
                }
            }
        }
     } 
           

}



