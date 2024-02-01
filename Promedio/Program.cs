using System;
using System.Linq.Expressions;

class Calcular
{
    static void Main(string[] args)
    {
        try
        {
            //Aqui estoy declrando los variables//
            double Primero;
            double Segundo;
            double Tercero;
            double Cuarto;
            double suma;
            double promedio;


            //Ahora los voy a llamar//
            Console.WriteLine("Ingre el Primer numero");
            Primero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            Segundo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el Tercer numero");
            Tercero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingre el Cuarto numero");
            Cuarto = Convert.ToDouble(Console.ReadLine());

            suma = Primero + Segundo + Tercero + Cuarto;
            Console.WriteLine($"Ël resultado de la suma es:{suma}");
            promedio = suma / 4;
            Console.WriteLine($"El promedrio es:{promedio}");

        }
        catch (FormatException)

        {
            Console.WriteLine("Error. El numero no es valido, presione enter");

        }
         catch (Exception ex)
        { Console.WriteLine(ex.Message); }




    }
}