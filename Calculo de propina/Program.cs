//By Nate  :D
namespace CaculoPropina
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    Console.WriteLine("Ingrese el total de su cuenta");
                    Console.Write(">>");
                    double MontoTotal = Convert.ToDouble(Console.ReadLine());


                    Console.WriteLine("Ingrese el porcentaje de propina");
                    Console.Write(">>");
                    int PorcentajeDePropina = Convert.ToInt32(Console.ReadLine());

                    if (PorcentajeDePropina > 100 || PorcentajeDePropina < 1)
                    {
                        Console.WriteLine("Error! debe ingresar una propina dentro del rango de 1 a 100");
                        Console.ReadKey();
                        break;
                    }

                    double Propina = MontoTotal * ((double)PorcentajeDePropina / 100);
                    Console.WriteLine($"Su propina a dejar es de : {Propina}, el total el monto a pagar es de: {MontoTotal + Propina}");
                    Console.ReadKey();
                    break;
                }
            }


            catch (FormatException)
            {
                Console.WriteLine("Error! debe ingresar solamente numeros");
                Console.ReadKey();
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error! debe ingresar una propina dentro del rango de 1 a 100");
                Console.ReadKey();
            }

        }
    }
}