using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverProject
{
    public class Service : IService
    {
        public Position LeftRotation(Position position)
        {
            switch (position.Direction)
            {
                case Directions.N:
                    position.Direction = Directions.W;
                    break;
                case Directions.S:
                    position.Direction = Directions.E;
                    break;
                case Directions.E:
                    position.Direction = Directions.N;
                    break;
                case Directions.W:
                    position.Direction = Directions.S;
                    break;
                default:
                    break;
            }
            return position;
        }
        public Position RightRotation(Position position)
        {
            switch (position.Direction)
            {
                case Directions.N:
                    position.Direction = Directions.E;
                    break;
                case Directions.S:
                    position.Direction = Directions.W;
                    break;
                case Directions.E:
                    position.Direction = Directions.S;
                    break;
                case Directions.W:
                    position.Direction = Directions.N;
                    break;
                default:
                    break;
            }
            return position;
        }

        public Position GoOnSameDirection(Position position)
        {
            switch (position.Direction)
            {
                case Directions.N:
                    position.Y += 1;
                    break;
                case Directions.S:
                    position.Y -= 1;
                    break;
                case Directions.E:
                    position.X += 1;
                    break;
                case Directions.W:
                    position.X -= 1;
                    break;
                default:
                    break;
            }
            return position;
        }

        public Position StartMoving(Position position, List<string> maxPoints, string moves)
        {
            char[] array = moves.ToCharArray();
            foreach (char move in array)
            {
                switch (move)
                {
                    case 'M':
                        position = this.GoOnSameDirection(position);
                        break;
                    case 'L':
                        position = this.LeftRotation(position);
                        break;
                    case 'R':
                        position = this.RightRotation(position);
                        break;
                    default:
                        Console.WriteLine($"Invalid Character {move}");
                        break;
                }

                if (position.X < 0 || position.X > Convert.ToInt32(maxPoints[0]) || position.Y < 0 || position.Y > Convert.ToInt32(maxPoints[1]))
                {
                    throw new Exception($"Oops! Position can not be beyond bounderies (0 , 0) and ({maxPoints[0]} , {maxPoints[1]})");
                }
            }
            return position;
        }
    }
}
