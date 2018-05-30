using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superhero_oop
{
    class Superhero
    {   //De
        private int strengthLevel;
        private bool hasCape;
        private bool hasSuperpowers;
        private string secretIdentity;



        public int StrengthLevel
        {
            get { return this.strengthLevel; }
            set { this.strengthLevel = value; }
        }
        public bool HasCape
        {
            get { return this.hasCape; }
            set { this.hasCape = value; }
        }
        public bool HasSuperpowers
        {
            get { return this.hasSuperpowers; }
            set { this.hasSuperpowers = value; }
        }
        public string SecretIdentity
        {
            get { return this.secretIdentity; }
            set { this.secretIdentity = value; }
        }
        public Superhero()
        {

        }



        public Superhero(int strengthLevel, bool hasCape, bool hasSuperpower, string secretIdentity)
        {
            this.strengthLevel = strengthLevel;
            this.hasCape = hasCape;
            this.hasSuperpowers = hasSuperpower;
            this.secretIdentity = secretIdentity;
        }

        public void Run(string secretIdentity)
        {
            this.secretIdentity = secretIdentity;
            Console.WriteLine("Your Secret Identity is {0} ", secretIdentity);

        }
    }
}








