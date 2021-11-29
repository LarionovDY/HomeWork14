using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork14
{
    class Cat : Animal
    {
        protected internal string title;
        protected internal override string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        protected internal Cat()
        {
            Title = "Кошка";
        }
        protected internal override void Say()
        {
            Console.WriteLine("Мяу-Мяу!");
        }
    }
}
