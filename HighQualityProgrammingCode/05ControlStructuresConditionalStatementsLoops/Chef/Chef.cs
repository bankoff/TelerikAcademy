namespace Chef
{
    public class Chef
    {
        public void Cook()
        {
            Carrot carrot = this.GetCarrot();
            Potato potato = this.GetPotato();

            this.Peel(carrot);
            this.Peel(potato);
            this.Cut(carrot);
            this.Cut(potato);            

            Bowl bowl = this.GetBowl();

            bowl.Add(carrot);
            bowl.Add(potato);
        }

        private Bowl GetBowl()
        {
            // ... 
            return new Bowl();
        }

        private Carrot GetCarrot()
        {
            // ...
            return new Carrot();
        }

        private Potato GetPotato()
        {
            // ...
            return new Potato();
        }

        private void Peel(Vegetable vegetable)
        {
            // ...
        }

        private void Cut(Vegetable vegetable)
        {
            // ...
        }
    }
}