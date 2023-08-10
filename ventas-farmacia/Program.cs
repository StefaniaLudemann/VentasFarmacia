using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

              
namespace ventas_farmacia
{
    class Program
    {  
        static void Main(string[] args)
        {
            double descuento = 0;
            double totalFinal = 0;
            double cantidadGalvez = 0;
            double cantidadOsde = 0;
            double cantidadSinOS = 0;
            double precioCompra = 0;
            string obraSocial = string.Empty;
            double totalCompras = 0;
            int i;
            double acum = 0;

            Console.WriteLine("    SERVICIO DE FARMACIA    ");
            Console.WriteLine(" Por favor seleccione una opcion: ");
            Console.WriteLine();
            Console.WriteLine("    G   si ud tiene Galvez    ");
            Console.WriteLine("    O   si ud tiene Osde    ");
            Console.WriteLine("    X   si ud no tiene obra social    ");
            obraSocial = Console.ReadLine();


            switch (obraSocial)
            {
                case "g":
                    Console.WriteLine("cuantas compras realizó? ");
                    cantidadGalvez = double.Parse(Console.ReadLine());
                    for (i = 1; i <= cantidadGalvez; i++)
                    {
                        Console.WriteLine("ingrese precio de la compra: ");
                        precioCompra = double.Parse(Console.ReadLine());
                        acum += precioCompra;
                        descuento = (acum * 20) / 100;
                        totalFinal = acum - descuento;
                    }
                    
                    Console.WriteLine("ud debe pagar con el descuento " + totalFinal);


                    break;
                case "o":
                    Console.WriteLine("cuantas compras realizó? ");
                    cantidadOsde = double.Parse(Console.ReadLine());
                    for (i = 1; i <= cantidadOsde; i++)
                    {
                        Console.WriteLine("ingrese precio de la compra: ");
                        precioCompra = double.Parse(Console.ReadLine());
                        acum += precioCompra;
                        descuento = (acum * 30) / 100;
                        totalFinal = acum - descuento;
                    }

                    Console.WriteLine("ud debe pagar con el descuento " + totalFinal);
                    break;
                case "x":
                    Console.WriteLine("cuantas compras realizó? ");
                    cantidadSinOS = double.Parse(Console.ReadLine());
                    for (i = 1; i <= cantidadSinOS; i++)
                    {
                        Console.WriteLine("ingrese precio de la compra: ");
                        precioCompra = double.Parse(Console.ReadLine());
                        acum += precioCompra;
                        //descuento = (acum * 20) / 100;
                        //totalFinal = acum - descuento;
                    }

                    Console.WriteLine("ud debe pagar sin descuento " + acum);
                    break;
            }

            Console.WriteLine("total de compras realizadas con Galvez: " + cantidadGalvez);
            Console.WriteLine("total de compras realizadas con Osde: " + cantidadOsde);
            Console.WriteLine("total de compras realizadas sin obra social: " + cantidadSinOS);
            Console.ReadKey();

        }
    }
}
