using System; 

namespace uppgift5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in hur många heltal du vill skriv in"); 
            int index = int.Parse(Console.ReadLine());
            int[] array = new int[index];
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Skriv in tal: " + i);
                array[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

        }
    }
}