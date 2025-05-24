using DyrinternatLibarary.Model;
using DyrinternatLibarary.Repository;
using DyrinternatLibarary.Service;



namespace ConsoleAppDyr
{
    internal class Program
    {
        static void Main(string[] args)
        {

            AnimalRepo _aniro = new AnimalRepo();

            AnimalService _aniser = new AnimalService(_aniro);

          

            List<Animal> anis = new List<Animal>();
            Animal dwedw = new Animal();

            _aniser.Add(dwedw);

            anis = _aniser.GetAll();
            foreach (Animal animal in anis)
            {
                Console.WriteLine("list anis2 " + animal.ChipNumber);
            }











            Animal edwdw = new Animal();
            Animal fefe = new Animal();

        }


    }
}
