namespace RPGCharacter.Api.Services
{
    public class StatRoller
    {
        private List<int>[] Rolls = new List<int>[6];
        public int[] stats = new int[6];
        public StatRoller()
        {
            Roll();
            StoreStats();
        }

        public void Roll()
        {
            Random random = new Random();
            for (int diceCount = 0; diceCount <= 5; diceCount++)
            {
                List<int> roll = new List<int>();
                for (int rollCount = 0; rollCount <= 3; rollCount++)
                {
                    int dice = random.Next(1, 7);
                    roll.Add(dice);
                }
                Rolls[diceCount] = roll;
            }
        }

        private void StoreStats()
        {
            int rollsIndex = -1;
            foreach (List<int> dice in Rolls)
            {
                stats[++rollsIndex] = AddTopThree(dice);
            }
        }

        private int AddTopThree(List<int> roll)
        {
            int minRoll = roll.Min();
            int output = roll.Sum() - minRoll;
            return output;
        }
    }
}
