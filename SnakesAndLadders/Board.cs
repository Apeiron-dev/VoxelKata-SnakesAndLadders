using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders
{
    public class Board
    {
        public List<(int, int)> Snakes { get; private set; }
        public List<(int, int)> Ladders { get; private set; }

        public Board()
        {
            Snakes = new List<(int, int)>()
            {
                (16, 6),
                (49, 11),
                (62, 19),
                (64, 60),
                (74, 53),
                (89, 68),
                (92, 88),
                (95, 75),
                (99, 80)
            };

            Ladders = new List<(int, int)>()
            {
               (2,38),
               (7,14),
               (8,31),
               (15,26),
               (21,42),
               (28,84),
               (36,44),
               (51,67),
               (71,91),
               (78,98),
               (87,94)
            };
        }

        public int MoveToken(int init)
        {
            if (CheckIfLadderIsInBox(init))
            {
                int endPosition = Ladders.Find(s => s.Item1 == init).Item2;
                Console.WriteLine("\tThere is a LADDER BOTTOM in the box " + init + "! So goes to LADDER TOP on box " + endPosition);
                return endPosition;
            }
            else if (CheckIfSnakeIsInBox(init))
            {
                int endPosition = Snakes.Find(s => s.Item1 == init).Item2;
                Console.WriteLine("\tThere is a SNAKE HEAD in the box " + init + "! So goes to SNAKE END on box " + endPosition);
                return endPosition;
            }
            else
                return init;
        }

        public bool CheckIfSnakeIsInBox(int box)
        {
            return Snakes.Any(s => s.Item1 == box);
        }

        public bool CheckIfLadderIsInBox(int box)
        {
            return Ladders.Any(s => s.Item1 == box);
        }
    }

}
