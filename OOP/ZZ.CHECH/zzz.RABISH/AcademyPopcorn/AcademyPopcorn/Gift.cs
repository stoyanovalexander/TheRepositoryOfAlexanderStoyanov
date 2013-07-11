//Implement a Gift class. It should be a moving object, which always falls down.
//The gift shouldn't collide with any ball, but should collide (and be destroyed) with the racket. You must NOT edit any existing .cs file. 

using System;

namespace AcademyPopcorn
{
    public class Gift : MovingObject
    {
        //create constructor
        public Gift(MatrixCoords topLeft)
            : base(topLeft, new char[,] { { '~' } }, new MatrixCoords(1, 0))
        {
        }

        //we need to override CanCollideWith in order to make the Gift to be able to be destroyed by the racket
        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "racket";
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
        }
    }
}
