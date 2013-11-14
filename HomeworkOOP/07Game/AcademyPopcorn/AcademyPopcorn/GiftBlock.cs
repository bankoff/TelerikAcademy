//12.   Implement a GiftBlock class. It should be a block, which "drops" a Gift object when it is destroyed. 
//      You must NOT edit any existing .cs file. Test the Gift and GiftBlock classes by adding them through 
//      the AcademyPopcornMain.cs file.

using System.Collections.Generic;

namespace AcademyPopcorn
{
    class GiftBlock : Block
    {

        private char[,] giftBody = new char[,] { { '$' } };

        public GiftBlock(MatrixCoords topLeft)
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
                List<Gift> gifts = new List<Gift>();

                gifts.Add(new Gift(this.topLeft, this.giftBody));

                return gifts;
            }
            else
            {
                return base.ProduceObjects();
            }
        }
    }
}