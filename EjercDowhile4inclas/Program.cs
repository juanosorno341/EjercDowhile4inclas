using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercDowhile4inclas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numerodecuenta = 0;
            float saldoactual = 0;
            float suma = 0;

            do
            {

                Console.WriteLine(" ingrese numero de cuenta corriente ");
                numerodecuenta = int.Parse(Console.ReadLine());

                Console.WriteLine(" ingrese saldo actual ");
                saldoactual = float.Parse(Console.ReadLine());



                if (saldoactual > 0)
                {
                    suma += saldoactual;
                    Console.WriteLine($" estado de la cuenta: Activo. acrededor con saldo de cuenta : $ " +  saldoactual);
                    
                    
                }
                else if (saldoactual < 0)

                {
                    Console.WriteLine(" cliente deudor y su mora acutual es de : $ " + saldoactual + " ;  para mas informacion comuniquese con la linea 01800000000.  ");
                }
                else

                {
                    Console.WriteLine(" saldo nulo ");
                }
            }

            while (numerodecuenta > 0);
            {
                Console.WriteLine(" Total suma saldos acrededores. $" + suma);
                


                Console.ReadKey();
            }

        }
    }
}
