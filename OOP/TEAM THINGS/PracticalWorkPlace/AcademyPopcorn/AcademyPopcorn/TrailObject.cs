using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    // Task5: TrailObject
    public class TrailObject : GameObject
    {
        public int LifeTime { get; set; }
        public TrailObject(MatrixCoords topLeft, char[,] body, int lifeTime)
            : base(topLeft, body)
        {
            this.LifeTime = lifeTime;
        }
        public override void Update()
        {
            LifeTime--;
            if (LifeTime == 0)
            {
                this.IsDestroyed = true;
            }
        }
    }
    //===============================================================================
}
