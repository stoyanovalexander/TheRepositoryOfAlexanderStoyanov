//Implement a GiftBlock class. It should be a block, which "drops" a Gift object when it is destroyed. 
//You must NOT edit any existing .cs file. Test the Gift and GiftBlock classes by adding them through the AcademyPopcornMain.cs file.


using System;
using System.Collections.Generic;
using System.Linq;

namespace AcademyPopcorn
{
    public class GiftBlock : Block
    {
        //constructor
        public GiftBlock(MatrixCoords topLeft)
            : base(topLeft)
        {
        }
        //override RespondToCollision
        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
        }
        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<GameObject> produceObjects = new List<GameObject>();
            //"drops" a Gift object when it is destroyed
            if (this.IsDestroyed)
            {
                produceObjects.Add(new Gift(this.topLeft));
            }
            return produceObjects;
        }
    }
}
