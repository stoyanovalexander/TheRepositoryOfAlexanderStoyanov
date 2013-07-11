//Implement a TrailObject class. It should inherit the GameObject class and should have a constructor which takes an additional "lifetime" integer.
//The TrailObject should disappear after a "lifetime" amount of turns. You must NOT edit any existing .cs file. 
//Then test the TrailObject by adding an instance of it in the engine through the AcademyPopcornMain.cs file.

using System;

namespace AcademyPopcorn
{
    public class TrailObject : GameObject
    {
        //priviete field for the lifeTime 
        private int lifeTime;

        //protect the field with properties
        public int LifeTime
        {
            get
            {
                return this.lifeTime;
            }
            set
            {
                this.lifeTime = value;
            }
        }
        public TrailObject(MatrixCoords topLeft, char[,] body, int lifeTime)
            : base(topLeft, body)
        {
            this.LifeTime = lifeTime;
        }
        //override the Update method in order to make TrailObject disappear after a "lifetime" amount of turns
        public override void Update()
        {
            LifeTime--;
            if (LifeTime <= 0)
            {
                this.IsDestroyed = true;
            }
        }
    }
}
