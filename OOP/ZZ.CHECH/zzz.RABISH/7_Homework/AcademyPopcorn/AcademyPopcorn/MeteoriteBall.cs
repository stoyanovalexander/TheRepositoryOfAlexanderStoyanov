using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    class MeteoriteBall : Ball
    {
        public MeteoriteBall(MatrixCoords topLeft, MatrixCoords speed)
            : base(topLeft, speed)
        {}

        public override IEnumerable<GameObject> ProduceObjects()
        {
            char[,] trail = {{'*'}};

            List<TrailObject> trailObjects = new List<TrailObject>()
            {
                new TrailObject(base.topLeft, trail, 3)
            };
            return trailObjects;
        }
    }
}
