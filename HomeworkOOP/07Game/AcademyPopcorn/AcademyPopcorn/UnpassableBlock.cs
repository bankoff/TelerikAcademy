//08.   Implement an UnstoppableBall and an UnpassableBlock. The UnstopableBall only bounces off UnpassableBlocks 
//      and will destroy any other block it passes through. The UnpassableBlock should be indestructible. 
//      Hint: Take a look at the RespondToCollision method, the GetCollisionGroupString method and the CollisionData class.

namespace AcademyPopcorn
{
    class UnpassableBlock : IndestructibleBlock
    {
        public new const string CollisionGroupString = "Unpassable Block";

        public override string GetCollisionGroupString()
        {
            return UnpassableBlock.CollisionGroupString;
        }
        public UnpassableBlock(MatrixCoords upperLeft)
            : base(upperLeft)
        {
        }
    }
}