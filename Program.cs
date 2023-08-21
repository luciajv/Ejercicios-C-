namespace Lab1Ej1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba el primer número");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el otro número");
            int n2 = int.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                int aux = n1;
                n1 = n2;
                n2 = aux;
            }

            bool encontrado = false;

            for (int i = n1; i < n2 && !encontrado; i++)
            {
                if (i % 33 == 0)
                {
                    //Es multiplo de 33
                    Console.WriteLine(i);
                    encontrado= true;
               
                }
               
            }
            if (!encontrado)
            {
                Console.WriteLine("No hay multiplos de 33");
            }





            Console.ReadKey();
        }
    }
}