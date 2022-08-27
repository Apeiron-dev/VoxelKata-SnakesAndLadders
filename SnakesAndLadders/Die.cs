using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders
{
    public class Die
    {
        public int Roll()
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());//(DateTime.Now.Millisecond) no da tiempo a cambiar
            return rnd.Next(1,6);
        }
    }
}
