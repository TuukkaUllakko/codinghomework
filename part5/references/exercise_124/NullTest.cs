using System;

namespace exercise_124
{
    class NullTest
    {
        private string name;
        private int value;

        public NullTest(string name, int value)
        {
            this.name = name;
            this.value = 0;
        }
        public void IncreaseBy(int number)
        {
            this.value = this.value + number;
        }
        public override string ToString()
        {
            return this.name;
        }
    }
}