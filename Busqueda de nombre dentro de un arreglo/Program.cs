//By Nate  :D

namespace BuscadorDeNombres
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ListaDeNombres =
            {
                "Marcos",
                "Maria",
                "JUan",
                "Carlos",
                "Jose",
                "Luis",
                "Norvin",
                "Antonio",
                "Leonard",
                "Reyna",
                "Alexander",
                "Alex",
                "David",
                "Samuel",
                "Victor",
                "Alejandro", 
                "Javier",
                "Miguel",
                "Manuel",
                "Anna",
                "Michael",
                "Lucia",
                "Angel",
                "Cristopher",
                "Cristel",
                "Diego",
                "Pablo",
                "Oscar",
                "Marlon",
                "Cesar",
                "Michael",
                "Lucas",
                "Daniel",
                "Fernando",
                "Nicolas",
                "Gabriel",
                "Ismael",
            };
            try
            {
                Console.WriteLine("Ingrese el nombre que desea buscar dentro del arreglo");
                Console.WriteLine("(Recuerda que un nombre empieza con mayuscula)");
                Console.Write(">>");
                string Nombre = Console.ReadLine();

                Console.WriteLine(Buscar(ListaDeNombres, Nombre));


            }
            catch (Exception)
            {
                Console.WriteLine("si");
            }

        }
        public static string Buscar(string[]ListaDeNombres, string Elemento)
        {
            for(int i = 0; i < ListaDeNombres.Length; i++)
            {
                if (ListaDeNombres[i] == Elemento)
                {
                    //suma de +1 para que el usuario pueda visualizar el arreglo de 1 a mayor y no de 0 a mayor
                    return "Nombre encontrado en la posicion: " + (i + 1);
                }
            }
            return  -1 + " : " + "Nombre no encontrado" ;
        }
    }
}