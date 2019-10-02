using ChucksNorriesLibrary;
using System;
using System.Threading.Tasks;

namespace ChucksNorriesJokes.ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {

            GetCatagories getCatagories = new GetCatagories();
            string[] catagories = await getCatagories.GetCatagories();

            Console.WriteLine(catagories[5]);
            for (int index = catagories.Length - 1; index >= 0; index--)
            {
                Console.WriteLine(catagories[index]);
            }

            
        }
    }
}
