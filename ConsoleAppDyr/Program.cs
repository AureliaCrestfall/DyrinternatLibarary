using DyrinternatLibarary.Model;
using DyrinternatLibarary.Service;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleAppDyr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnimalService _aniser;

            Animal dwedw = new Animal();
            Animal edwdw = new Animal();
            Animal fefe = new Animal();

            List<Animal> anis = new List<Animal>();
            anis.Add(dwedw);
            anis.Add(edwdw);
            anis.Add(fefe);
            
           


            foreach (Animal animal in anis)
            {
                Console.WriteLine(animal.ChipNumber);
            }


        }
        
    }
}
