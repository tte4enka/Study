namespace _1task
{
    public abstract class Place
    {
        private string Continent;
        public string continent { get { return Continent; } set { } }

        public Place(string continent)
        {
            Continent = continent;
        }

        public Place()
        {
            Continent = "Африка";
        }
        public abstract void GetPlace();
        public abstract void ChangePlace();
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Place temp = (Place)obj;
            return Continent == temp.Continent;
        }
    }

}