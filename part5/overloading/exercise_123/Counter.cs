using System;

namespace exercise_123
{
    class Counter
    {
        public int value { get; set; }
        public Counter(int startValue) //Constructors
        {
            this.value = startValue;
        }
        public Counter()
        {
            this.value = 0;
        }
        //Methods
        public void Increase()
        {
            this.value++;
        }
        public void Decrease()
        {
            this.value--;
        }
        public void Increase(int increaseBy)
        {
            if (increaseBy >= 0)
            {
                this.value = this.value + increaseBy;
            }
        }
        public void Decrease(int decreaseBy)
        {
            if (decreaseBy >= 0)
            {
                this.value = this.value - decreaseBy;
            }
        }
        public override string ToString() //I know this doesn't have to be here, just wanted to test out the printing.
        {                                 //It kept printing: "exercise_123.Counter" without this ToString().
            return Convert.ToString(this.value);
        }
    }
}