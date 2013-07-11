using System;

namespace AcademyPopcorn
{
    //UnpassableBlock inherits IndestructibleBlock and changes the symbol of the block
    public class UnpassableBlock : IndestructibleBlock
    {
        public const char Symbol = ']';
        public new const string CollisionGroupString = "unpassableBlock";
        public UnpassableBlock (MatrixCoords upperLeft)
            : base(upperLeft)
        {
        }
        //also we will override the GetCollisionGroupString()
        public override string GetCollisionGroupString()
        {
            return UnpassableBlock.CollisionGroupString;
        }
    }
}
