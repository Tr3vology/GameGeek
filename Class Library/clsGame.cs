using System;

namespace Class_Library
{
    public class clsGame
    {
        public string GameName { get; set; }
        public double GamePrice { get; set; }

        public bool Find(string someGame)
        {
            return true;
        }

        public string Valid(string someGame)
        {
            String Error = "";
            if (someGame.Length > 50)
            {
                Error = "The GameName cannot have more than 50 characters!";
            }
            if (someGame.Length == 0)
            {
                Error = "The GameName may not be blank";
            }


            return Error;
        }

        public string Valid(double someGamePrice)
        {
            String Error = "";
            if (someGamePrice < 0)
            {
                Error = "The GamePrice cannot be lower tha zero!";
            }
            if (someGamePrice > 500)
            {
                Error = "The GamePrice canot be greater than 500!";
            }

            return Error;
        }
    }
}