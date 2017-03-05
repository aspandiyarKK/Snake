using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainSnake
{
    class Score
    {
        int k;
        public Score(int k)
        {
            this.k = k;
        }
        public void Draw()
        {

            Console.SetCursorPosition(34, 10);
            Console.WriteLine("Score:{0}",k);
            k = k + 1;
 
        }
        public void Draw2()
        {
            Console.SetCursorPosition(9, 12);
            Console.WriteLine("Your score: {0}",k-1);
        }
    }
}
