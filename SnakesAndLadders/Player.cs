using System;

namespace SnakesAndLadders
{
    public class Player
    {
        public string Name { get; set; }
        public int Token { get; set; }
        public bool IsWinner { get; set; }

        public Player()
        {
            IsWinner = false;
        }
        public void Win()
        {
            IsWinner = true;
            //Do winner stuff: gloat 
            Console.WriteLine("\t" + this.Name + " WINS!\n\tI'm the winner, you losers!! \\m/>.<\\m/");
        }

        public int RollDie(int result = 0)
        {
            int roll = 0;
            if (result > 0)
                roll = result;
            else
            {
                Die die = new Die();
                roll = die.Roll();
            }
           
            int box = this.Token + roll > 100 ? this.Token : this.Token + roll;
            Console.WriteLine("\t" + this.Name + " rolls the die: " + roll);
          
            return box;
        }

        public void SetToken(int token)
        {
            this.Token = token;
            if (Token == 100) Win();
        }

        public void PlayerStatus()
        {
            Console.WriteLine(String.Format("Player {0} has token in box {1}", this.Name, this.Token));
        }
       


    }
}
