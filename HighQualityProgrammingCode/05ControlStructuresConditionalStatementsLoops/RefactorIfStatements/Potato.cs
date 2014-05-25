namespace RefactorIfStatements
{
    public class Potato
    {
        public bool IsRotten { get; set; }

        public bool IsPeeled { get; set; }

        public static void CookPotato()
        {
            Potato potato = null;

            // ... 
            if (potato != null)
            {
                if (potato.IsPeeled && !potato.IsRotten)
                {
                    Cook(potato);
                }
            }
        }

        private static void Cook(Potato potato)
        {
            throw new System.NotImplementedException();
        }
    }
}
