using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuesNumber
{
    class GuestControll
    {
        Random random = new Random();
        public int Count { get; set; }
        public int Guess { get; set; }
        

        public GuestControll(int startCount = 0, int startGuess = 0)
        {
            Count = startCount ;
            Guess = startGuess;
        }

        public int GenerateGuess(int indexComboBox)
        {
            if (indexComboBox == 0)
            {
                Guess = random.Next(0, 6);
                return Guess;
            }
            if (indexComboBox == 1)
            {
                Guess = random.Next(0, 11);
                return Guess;
            }
            if (indexComboBox == 2)
            {
                Guess = random.Next(0, 16);
                return Guess;
            }
            if (indexComboBox == 3)
            {
                Guess = random.Next(0, 21);
                return Guess;
            }
            else
            {
                return 999;
            }

        }

        public string GuessNumber(int userGuess)
        {
            
            if(userGuess == Guess)
            {
                Count++;
                return "WIN";
            }
            if (userGuess > Guess)
            {
                Count++;
                return "Hledané číslo je menší";
            }
             if (userGuess < Guess)
            {
                Count++;
                return "Hledané číslo je vysší";
            }
            return null;
        }




    }
}
