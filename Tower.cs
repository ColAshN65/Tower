using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tower
{
    public class Tower
    {
        public int Element { get; private set; }
        public int PreviousSQSum { get; private set; }
        public int CurrentSquare { get; private set; }
        public int ElementPosition { get; private set; }
        public int ElementFloor { get; private set; }
        public Tower(int element)
        {
            Element = element;

            FindSquare();

            FindPosition();

            FindFloor();
        } 
        private void FindSquare()
        {
            int square = 0, currentSQSum = 0, previousSQSum = 0;

            while (currentSQSum < Element)
            {
                previousSQSum += (int)Math.Pow(square, 2); 

                square++;

                currentSQSum += (int)Math.Pow(square, 2);
            }

            CurrentSquare = square;
            PreviousSQSum = previousSQSum;
        }
        private void FindPosition()
        {
            int position = Element - PreviousSQSum;

            while (position > CurrentSquare)
            {
                position -= CurrentSquare;
            }
            ElementPosition = position;
        }
        private void FindFloor()
        {
            int floor = 0;

            for (int i = 0; i < CurrentSquare; i++) floor += i;

            int element = Element - PreviousSQSum;

            while (element > 0)
            {
                element -= CurrentSquare;
                floor++;
            }
            ElementFloor = floor;
        }
        public int GetPosition()
        {
            return ElementPosition;
        }
        public int GetFloor()
        {
            return ElementFloor;
        }

    }
}
