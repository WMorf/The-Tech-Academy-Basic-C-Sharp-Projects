using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChain
{
    public class Person
    {

        string name;
        int HP;

        //neither varible supplied at instantiation :O
        public Person() : this("Hero")
        {

        }

        //Only name provided
        public Person(string name) : this(name, 10)
        {

        }

        //name and HP provided
        public Person(string name, int HP)
        {
            this.name = name;
            this.HP = HP;
        }

        //Each constructor will chain into the next with the start point determined by which variables supplied
    }
}
