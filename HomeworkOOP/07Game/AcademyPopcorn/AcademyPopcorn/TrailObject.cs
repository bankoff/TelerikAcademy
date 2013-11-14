//05.   Implement a TrailObject class. It should inherit the GameObject class and should have a constructor 
//      which takes an additional "lifetime" integer. The TrailObject should disappear after a "lifetime" 
//      amount of turns. You must NOT edit any existing .cs file. Then test the TrailObject by adding an 
//      instance of it in the engine through the AcademyPopcornMain.cs file.

namespace AcademyPopcorn
{
    public class TrailObject : GameObject
    {
        private int lifetime;

        public int Lifetime
        {
            get { return lifetime; }
            set { lifetime = value; }
        }

        public TrailObject(MatrixCoords topLeft, char[,] body, int lifetime)
            : base(topLeft, body)
        {
            this.Lifetime = lifetime;
        }

        public override void Update()
        {
            this.Lifetime--;
            if (this.Lifetime <= 0)
            {
                this.IsDestroyed = true;
            }
        }

    }
}
