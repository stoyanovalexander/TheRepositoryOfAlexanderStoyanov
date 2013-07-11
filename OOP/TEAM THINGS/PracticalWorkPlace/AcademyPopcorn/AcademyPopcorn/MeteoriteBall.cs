using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    // Task6: ImplementMeteoriteBall
    public class MeteoriteBall : Ball
    {
        private char[,] TrailObject = new char[,] { { 'X' } };
        private int TrailObjectsNumber=3;

        public MeteoriteBall(MatrixCoords topLeft, MatrixCoords speed,int trailObjectNumber)
            : base(topLeft, speed)
        {
             this.TrailObjectsNumber = trailObjectNumber;
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<TrailObject> tailList = new List<TrailObject>();

            TrailObject trailObject = new TrailObject(this.TopLeft, this.TrailObject, this.TrailObjectsNumber);
            tailList.Add(trailObject);

            return tailList;
        }
    }
    //==============================================================================================================
}
