namespace Lab1Ej4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int numeroSecreto = rnd.Next(1,10000);

            bool gano = false;

            while (!gano) {
                Console.Clear();
                Console.WriteLine( "Adivine un número" );
                int numeroSeleccionado = int.Parse(Console.ReadLine());

                if (numeroSeleccionado > numeroSecreto)
                {
                    Console.WriteLine("Menos!");
                }
                else if (numeroSeleccionado < numeroSecreto)
                {
                    Console.WriteLine("Más!");
                }
                else { 
                gano = true;
                    Console.WriteLine("Ganaste!!!!!");
                }

                Console.ReadKey();
            
            
            }


        }
    }
}