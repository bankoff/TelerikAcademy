//06.   Implement a MeteoriteBall. It should inherit the Ball class and should leave a trail of TrailObject objects. 
//      Each trail objects should last for 3 "turns". Other than that, the Meteorite ball should behave the same way 
//      as the normal ball. You must NOT edit any existing .cs file.

using System.Collections.Generic;

namespace AcademyPopcorn
{
    public class MeteoriteBall : Ball
    {
        const int meteoriteBallLife = 3;
        private char[,] trailBallBody = new char[,] { { '¤' } };
        private int trailLifetime;

        public int TrailLifetime
        {
            get { return trailLifetime; }
            set { trailLifetime = value; }
        }
          
        public MeteoriteBall(MatrixCoords topLeft,MatrixCoords speed)
            : base(topLeft,speed)
            
        {
            this.TrailLifetime = meteoriteBallLife;
        }

        public override IEnumerable<GameObject> ProduceObjects()        
        {            
            List<TrailObject> trailObj = new List<TrailObject>();             
            TrailObject trailObject = new TrailObject(this.TopLeft, this.trailBallBody, this.trailLifetime);            
            trailObj.Add(trailObject);            
            return trailObj;        
        }
    }
}