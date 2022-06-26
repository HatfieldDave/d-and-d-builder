using System;
namespace d_and_d_builder
{
    public class Dice
    {
        public Dice(int diceSides)
        {
            this.DiceSides = diceSides;
        }


        private int DiceSides { get; set; }


        private Random random = new Random();
        public int RollDice()
        {
            return random.Next(1, DiceSides + 1);
        }

        public int RollDice(int amountOfDice)
        {
            int sum = 0;
            for (int i = 0; i < amountOfDice; i++)
            {
                sum += RollDice();
            }
            return sum;
        }
    }
}

