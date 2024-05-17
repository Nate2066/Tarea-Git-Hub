//By Nate :D

namespace ConvertorIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite su peso (Kilogramos)");
                Console.Write(">>");
                double Peso = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite su altura (Metros)");
                Console.Write(">>");
                double Altura = Convert.ToDouble(Console.ReadLine());

                double IMC = Peso / (Altura * Altura);

                Console.WriteLine("Su Indice de masa corporal es de : " + IMC);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error! Valor invalido");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error! Valor demasiado grande");
            }
        }
    }
}

