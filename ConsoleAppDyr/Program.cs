using DyrinternatLibarary.Model;
using DyrinternatLibarary.Repository;
using DyrinternatLibarary.Service;


using System.Security.Cryptography.X509Certificates;

namespace ConsoleAppDyr
{
    internal class Program
    {
        static void Main(string[] args)
        {


           // AnimalService _aniser = new AnimalService();

            AnimalRepo _aniro = new AnimalRepo();
            Animal dwedw = new Animal();
            Animal edwdw = new Animal();
            Animal fefe = new Animal();

            List<Animal> anis = new List<Animal>();
            
            

            anis = _aniro.GetAll();
            anis.Add(dwedw);
            anis.Add(edwdw);
            anis.Add(fefe);

           

            foreach (Animal animal in anis)
            {
                Console.WriteLine("list anis2 "+animal.ChipNumber);
            }


        }
        
        
    }
}
