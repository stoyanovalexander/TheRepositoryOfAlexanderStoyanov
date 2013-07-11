// Implement a MeteoriteBall. It should inherit the Ball class and should leave a trail of TrailObject objects.
//Each trail objects should last for 3 "turns". Other than that, the Meteorite ball should behave the same way as the normal ball. 
//You must NOT edit any existing .cs file.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    public class MeteoriteBall : Ball
    {
        private char[,] trailObjectBody = new char[,] { { 'x' } };

        //create new constructor 
        public MeteoriteBall(MatrixCoords topLeft, MatrixCoords speed)
            : base(topLeft, speed)
        {
        }
        public override IEnumerable<GameObject> ProduceObjects()
        {
            //create a list of trail objects
            List<TrailObject> trailOfObjects = new List<TrailObject>();
            // add a new trail object to the list
            TrailObject trailObject = new TrailObject(base.TopLeft, this.trailObjectBody, 3);
            trailOfObjects.Add(trailObject);
            return trailOfObjects;
        }
    }
}
