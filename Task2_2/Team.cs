using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2
{
    internal class Team
    {
        private string Name;
        private List<Worker> workers = new List<Worker>();
        public Team(string name) => Name = name;
        public void AddWorker(Worker worker)
        {
            workers.Add(worker);
        }
        public void PrintInfo()
        {
            Console.WriteLine(Name);
            foreach (Worker worker in workers)
            {
                Console.WriteLine(worker.GetName());
            }
        }
        public void PrintFullInfo()
        {
            Console.WriteLine(Name);
            foreach (Worker worker in workers)
            {
                Console.WriteLine(worker.GetInfo());
            }
        }
        public string GetName() => Name;
    }
}

