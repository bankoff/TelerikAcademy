using System.Collections.Generic;
namespace AcademyPopcorn
{    
    public class ShootingRacket : Racket   
    {
        public ShootingRacket(MatrixCoords topleft, int width)
            : base(topleft, width)
        {

        }


        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<GameObject> bullets = new List<GameObject>();
            bullets.Add(new Bullet(this.topLeft, new char[,] { { '|' } }, new MatrixCoords(-1, 0)));
            return bullets;
        }
    }
}