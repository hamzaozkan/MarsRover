using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverProject
{
    public interface IService
    {
        Position LeftRotation(Position position);

        Position RightRotation(Position position);

        Position GoOnSameDirection(Position position);

        Position StartMoving(Position position, List<string> maxPoints, string moves);
    }
}
