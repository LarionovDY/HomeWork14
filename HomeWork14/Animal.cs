using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork14
{
    abstract class Animal
    {
        protected internal abstract string Title { get; set; }
        protected internal Animal()
        {
            Title = "Животное";
        }
        protected internal abstract void Say();
        protected internal void Showinfo()
        {
            Console.WriteLine($"Привет! Я {Title}, я делаю:");
            Say();
        }
    }
}
