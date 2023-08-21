namespace Lab1Ej5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op = -1;

            while (op != 0)
            {
                Console.Clear();
                Console.WriteLine("Seleccione una opción");
                Console.WriteLine("1 - Primera opción");
                Console.WriteLine("2 - Segunda opción");
                Console.WriteLine("0 - Salir");

                op = int.Parse(Console.ReadLine());
                if (op != 0)
                {
                    switch (op)
                    {
                        case 1:
                            Console.WriteLine("Eligió la opción 1");
                            break;
                        case 2:
                            Console.WriteLine("Eligió la opción 2");
                            break;
                        default:
                            Console.WriteLine("Seleccionó una opción no válida");
                            break;
                    }
                }
                

                Console.ReadKey();
            }
        }
    }
}