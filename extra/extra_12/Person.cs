using System;
using System.Collections.Generic;

namespace extra_12
{
    class Person
    {
        private string name;
        private int age;
        public Person(string name)
        {
            this.name = name;
            this.age = 0;
        }

        public int GrowOlder(int howMuch)
        {
            return this.age = this.age + howMuch;
        }

        public override string ToString()
        {
            return this.name + ", age " + this.age;
        }
    }
}