//Implement an ExplodingBlock. It should destroy all blocks around it when it is destroyed. You must NOT edit any existing .cs file. 
//Hint: what does an explosion "produce"?


using System;
using System.Collections.Generic;
using System.Linq;
namespace AcademyPopcorn
{
    public class ExplodingBlock : Block
    {
       //create constructor for the exploding block
        public ExplodingBlock(MatrixCoords topLeft)
            : base(topLeft)
        {
        }

        //we  overrrive the RespondToCollision
        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
            this.ProduceObjects();
        }

        //create objects that are produced after the explosion
        public override IEnumerable<GameObject> ProduceObjects()
        {
            if (this.IsDestroyed)
            {
                //create a list of exloded objects
                List<ExlodedObjects> ExlodedObjects = new List<ExlodedObjects>();

                ExlodedObjects.Add(new ExlodedObjects(this.TopLeft, new MatrixCoords(0, -1)));
                ExlodedObjects.Add(new ExlodedObjects(this.TopLeft, new MatrixCoords(0, 1)));
                ExlodedObjects.Add(new ExlodedObjects(this.TopLeft, new MatrixCoords(-1, -1)));
                ExlodedObjects.Add(new ExlodedObjects(this.TopLeft, new MatrixCoords(-1, 0)));
                ExlodedObjects.Add(new ExlodedObjects(this.TopLeft, new MatrixCoords(-1, 1)));
                ExlodedObjects.Add(new ExlodedObjects(this.TopLeft, new MatrixCoords(1, -1)));
                ExlodedObjects.Add(new ExlodedObjects(this.TopLeft, new MatrixCoords(1, 0)));
                ExlodedObjects.Add(new ExlodedObjects(this.TopLeft, new MatrixCoords(1, 1)));

                return ExlodedObjects;
            }
            else
            {
                return base.ProduceObjects();
            }
        }
    }
}
