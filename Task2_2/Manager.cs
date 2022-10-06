using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Task2_2
{
    internal class Manager : Worker
    {
        public Manager(string name) : base(name)
        {
            Position = "Менеджер";
        }
        private Random random = new Random();
        public override void FillWorkDay()
        {
            for (int i = 0; i < random.Next(10); i++)
            {
                Call();
            }
            Relax();
            for (int i = 0; i < random.Next(5); i++)
            {
                Call();
            }
        }
    }
}
