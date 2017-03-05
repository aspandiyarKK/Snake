using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainSnake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point(int x,int y,char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }
        public void Clear()
        {
            sym = ' ';
            Draw();
        }
        public void Move(int offset,Direction direction)
        {
            if (direction == Direction.RIGHT) x = x + 1;
            if (direction == Direction.LEFT)  x = x - 1;
            if (direction == Direction.DOWN)  y = y + 1;
            if (direction == Direction.UP)    y = y - 1;
        }
        public void Draw()
        {

            Console.SetCursorPosition(x, y);
            Console.Write(sym);
    
        }
        public bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }

    }
}
