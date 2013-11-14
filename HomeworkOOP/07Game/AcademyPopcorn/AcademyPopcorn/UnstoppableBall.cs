//08.   Implement an UnstoppableBall and an UnpassableBlock. The UnstopableBall only bounces off UnpassableBlocks 
//      and will destroy any other block it passes through. The UnpassableBlock should be indestructible. 
//      Hint: Take a look at the RespondToCollision method, the GetCollisionGroupString method and the CollisionData class.

namespace AcademyPopcorn
{
    public class UnstoppableBall : Ball
    {
        public UnstoppableBall(MatrixCoords topLeft, MatrixCoords speed)
            : base(topLeft, speed)
        {
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            //the unstoppable ball should respond (change direction) only        
            //if it collides with an indestructible block or a racket     
            if (collisionData.hitObjectsCollisionGroupStrings.Contains(IndestructibleBlock.CollisionGroupString) ||
                collisionData.hitObjectsCollisionGroupStrings.Contains(Racket.CollisionGroupString))
            {
                base.RespondToCollision(collisionData);
            }
        }
    }
}