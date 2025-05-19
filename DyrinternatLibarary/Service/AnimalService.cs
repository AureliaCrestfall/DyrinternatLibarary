﻿using DyrinternatLibarary.Repository;
using DyrinternatLibarary.Model;
using System.Diagnostics;
namespace DyrinternatLibarary.Service
{
    public class AnimalService
    {

        IAnimalRepo _animalRepo;

        public AnimalService(IAnimalRepo repo)
        {
            _animalRepo = repo;
        }

        public void Add(Animal animals)
        {

            _animalRepo.Add(animals);
        }
        public void Remove(int chipNumber)
        {
            _animalRepo.Remove(chipNumber);
        }
        public List<Animal> GetAll()
        {
            return _animalRepo.GetAll();
        }

        public void AddVisits(int chipNumber, string visits)
        {
            _animalRepo.AddVisits(chipNumber, visits);
        }
    }
}
