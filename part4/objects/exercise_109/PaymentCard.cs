using System;

namespace exercise_109
{
    class PaymentCard
    {
        private double balance;
        public PaymentCard(double openingBalance)
        {
            this.balance = openingBalance;
        }
        public override string ToString()
        {
            return "The card has a balance of " + this.balance + " euros";
        }
        public void EatLunch()
        {
            if (this.balance >= 10.60)
            {
                this.balance = this.balance - 10.60;
            }
        }
        public void DrinkCoffee()
        {
            if (this.balance >= 2.00)
            {
                this.balance = this.balance - 2.00;
            }
        }
        public void AddMoney(double amount)
        {
            if (amount >= 0)
            {
                this.balance = this.balance + amount;
                if (this.balance > 150.00)
                {
                this.balance = 150.00;
                }
            }
        }
    }
}