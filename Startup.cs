using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsRoverProject
{
    public class Startup
    {
        private readonly IService service;
        public Startup(IService service)
        {
            this.service = service;
        }
        public void Start()
        {
            var maxPoints = new List<string>();
            Console.WriteLine("Enter max points:");
            do
            {
                maxPoints = Console.ReadLine().Trim().Split(' ').ToList();
                if (maxPoints.Count != 2)
                {
                  Console.WriteLine("Please enter max points correctly. Example: 5 5");
                }
            }
            while (maxPoints.Count != 2);
            var exit = "0";
            do
            {
                var currentPositon = new List<string>();
                Console.WriteLine("Enter position:");
                do
                {
                    currentPositon = Console.ReadLine().Trim().Split(' ').ToList();
                    if (currentPositon.Count != 3)
                    {
                        Console.WriteLine("Please enter position correctly. Example: 1 2 N");
                    }
                }
                while (currentPositon.Count != 3);
                Position position = new Position()
                {
                    X = Convert.ToInt32(currentPositon[0]),
                    Y = Convert.ToInt32(currentPositon[1]),
                    Direction = (Directions)Enum.Parse(typeof(Directions), currentPositon[2].ToString().ToUpper())
                };
                Console.WriteLine("Enter moves");
                var roverMoves = Console.ReadLine().ToUpper(); // set toUpper case
                var nextPosition = this.service.StartMoving(position, maxPoints, roverMoves);
                Console.WriteLine($"{nextPosition.X} {nextPosition.Y} {nextPosition.Direction.ToString()}");
                Console.WriteLine("Continue: Enter, Exit = 0");
                exit = Console.ReadLine();
            }
            while (exit != "0");
           
        }
    }
}
