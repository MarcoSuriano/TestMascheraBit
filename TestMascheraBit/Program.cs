using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMascheraBit
{
    public class Program
    {
        public static void Main(string[] args)
        {

            bool exit = false;

            while (!exit)
            {

                Console.WriteLine("Inserisci l'intero da convertire");
                int intToCheck = int.Parse(Console.ReadLine());
                var byteArray = BitConverter.GetBytes(intToCheck);
                if (BitConverter.IsLittleEndian)
                {
                    Array.Reverse(byteArray);
                }

                BitArray b = new BitArray(byteArray);
                int[] bits = b.Cast<bool>().Select(bit => bit ? 1 : 0).ToArray();

                Console.WriteLine("Intero convertito in: \n");

                for (int i = 0; i < bits.Length; i++)
                {
                    Console.WriteLine(bits[i]+"\n");
                }
                

                string exitChar = Console.ReadLine();
                exit = exitChar == "y";
            }

        }
    }
}
