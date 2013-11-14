namespace AcademyPopcorn
{
    public class ExplodingObject : MovingObject   
    {       
        public ExplodingObject(MatrixCoords topLeft, MatrixCoords speed)           
            : base(topLeft, new char[,] { { '*' } }, speed)      
        {      
        }        
        
        public override void Update()      
        {           
            this.IsDestroyed = true;   
        }     
        
        public override bool CanCollideWith(string otherCollisionGroupString)  
        {           
            return otherCollisionGroupString == Block.CollisionGroupString;      
        }   
    }
}