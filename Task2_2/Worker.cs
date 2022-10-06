using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2
{
    internal abstract class Worker
    {
        protected string Name;
        protected string Position;
        protected string WorkDay;
        public Worker(string name)
        {
            Name = name;
            Position = "";
            WorkDay = "";
        }
        public string GetName() => Name;
        public void Call() => WorkDay += "Телефонує";
        public void Relax() => WorkDay += "Відпочиває";
        public void WriteCode() => WorkDay += "Програмує";
        public string GetInfo() => $"{Name}-{Position}-{WorkDay}";
        abstract public void FillWorkDay();
    }
}
