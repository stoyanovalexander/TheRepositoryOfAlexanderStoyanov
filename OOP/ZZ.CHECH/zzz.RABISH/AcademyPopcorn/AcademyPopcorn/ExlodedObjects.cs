using System;

namespace AcademyPopcorn
{
    class ExlodedObjects: MovingObject
    {
        //create constructor for this exloped objects
        public ExlodedObjects (MatrixCoords topLeft, MatrixCoords speed)
            : base(topLeft, new char[,] { { '*' } }, speed)
        {
        }

        public override void Update()
        {
            this.IsDestroyed = true;
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == Block.CollisionGroupString;
        }
    }
}
