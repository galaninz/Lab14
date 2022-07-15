using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    class Cat : Animal
    {
        private string voice;
        string name;
        public override string Name 
        { 
            get => name;
            set => name = value; 
        }
        public Cat(string voice, string name)
            :base(name)
        {
            this.voice = voice;
        }

        public override string Say()
        {
            return voice;
        }
    }
}
