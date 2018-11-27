using System;

namespace BowlingGame
{
    public class Game
    {
        int[] pinFalls = new int[21];
        int rollCounter;

        static void Main(string[] args)
        {
            Console.WriteLine("Bowling Kata!");
        }

        public void Roll(int pins)
        {
            pinFalls[rollCounter] = pins;
            rollCounter++;
        }

        public int Score()
        {
            int i = 0;
            int score = 0;

            score = Frames(i, score);
            return score;
        }

        private int Frames(int i, int score)
        {
            for (int frame = 0; frame < 10; frame++)
            {
                if (pinFalls[i] + pinFalls[i + 1] == 10)
                {
                    score += 10 + pinFalls[i + 2];
                    i += 2;
                }
                else
                {
                    score += pinFalls[i] + pinFalls[i + 1];
                    i += 1;
                }
            }

            return score;
        }
    }
}
