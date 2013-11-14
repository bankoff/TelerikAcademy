//10.   Implement an ExplodingBlock. It should destroy all blocks around it when it is destroyed. 
//      You must NOT edit any existing .cs file. Hint: what does an explosion "produce"?

using System.Collections.Generic;
namespace AcademyPopcorn
{ 
    public class ExplodingBlock : Block 
    { 
        public ExplodingBlock(MatrixCoords topLeft) 
            : base(topLeft)
        { 
        } 
        
        public override void RespondToCollision(CollisionData collisionData)
        { 
            this.IsDestroyed = true;
            this.ProduceObjects(); 
        }
        
        public override IEnumerable<GameObject> ProduceObjects()
        { 
            if (this.IsDestroyed)
            {
                List<ExplodingObject> explose = new List<ExplodingObject>();
                explose.Add(new ExplodingObject(this.TopLeft, new MatrixCoords(-1, -1)));
                explose.Add(new ExplodingObject(this.TopLeft, new MatrixCoords(-1, 0)));
                explose.Add(new ExplodingObject(this.TopLeft, new MatrixCoords(-1, 1)));
                explose.Add(new ExplodingObject(this.TopLeft, new MatrixCoords(0, -1)));
                explose.Add(new ExplodingObject(this.TopLeft, new MatrixCoords(0, 1)));
                explose.Add(new ExplodingObject(this.TopLeft, new MatrixCoords(1, -1)));
                explose.Add(new ExplodingObject(this.TopLeft, new MatrixCoords(1, 0)));
                explose.Add(new ExplodingObject(this.TopLeft, new MatrixCoords(1, 1)));
                return explose; 
            } 
            else
            { 
                return base.ProduceObjects(); 
            }
        } 
    } 
}