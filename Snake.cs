using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnhancedSnake
{
    class Snake
    {
        public Point snake { get; set; }
        public Point[] snakePositions { get; set; }

        public Snake(Point snake, Point[] snakePositions)
        {
            this.snake = snake;
            this.snakePositions = snakePositions;
        }

        public void draw(Graphics g)
        {
            Brush b = new SolidBrush(Color.Red);
            g.FillRectangle(b, 1, 1, 1, 1);
            b.Dispose();
        }
        public void Move(Point p)
        {
                    snake = p;
        }

    }
}
