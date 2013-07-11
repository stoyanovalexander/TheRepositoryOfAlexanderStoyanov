using System;

namespace AcademyPopcorn
{
    public class UnstoppableBall : Ball
    {
        //UnstoppableBall inherits Ball and changes CollisionGroupString
        public const char Symbol = 'Q';
        public new const string CollisionGroupString = "unstoppableBall";
        public UnstoppableBall(MatrixCoords topLeft, MatrixCoords speed)
            : base(topLeft, speed)
        {
        }

        //unstoppable ball should respond to collision only if it collides with IndestructibleBlock, UnpassableBlock or Racket
        public override void RespondToCollision(CollisionData collisionData)
        {
            if (collisionData.hitObjectsCollisionGroupStrings.Contains(IndestructibleBlock.CollisionGroupString) ||
                collisionData.hitObjectsCollisionGroupStrings.Contains(UnpassableBlock.CollisionGroupString) ||
                collisionData.hitObjectsCollisionGroupStrings.Contains(Racket.CollisionGroupString))
            {
                base.RespondToCollision(collisionData);
            }
        }
    }
}
