using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverProject
{
    public class Position
    {
        /// <summary>
        ///  define constructor
        /// </summary>
        public Position()
        {
            X = 0;
            Y = 0;
            Direction = Directions.N;
        }

        // apsis
        public int X { get; set; }

        // ordinat
        public int Y { get; set; }

        public Directions Direction { get; set; }
    }
}
