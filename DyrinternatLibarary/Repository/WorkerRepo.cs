﻿using System.Xml.Linq;
using Dyreinternatet.Model;

namespace Dyreinternatet.Repository
{
    public class WorkerRepo:IWorkerRepo
    {
        List<Worker> _workers;
        public WorkerRepo()
        {
            _workers = new List<Worker>();
            seed();
        }
        

        public List<Worker> GetAll()
        {
            return _workers;
        }

        public void Add(Worker woker)
        {
            _workers.Add(woker);
        }

        public void Remove(int id)
        {
            _workers.RemoveAt(id);
        }
        void seed()
        {
            _workers.Add(new Worker("John Doe", 0, "123456", "johndoe@gmail.com", "Dyrlæge"));
            _workers.Add(new Worker("Kim Kardashian", 2, "123456", "KimK@gmail.com", "Frivillig"));
        }
        public void Edit(int place, Worker editworker)
        {
            _workers[place] = editworker;
        }
    }
}
