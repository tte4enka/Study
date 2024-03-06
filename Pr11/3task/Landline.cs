namespace _3task
{
    public enum Mobility
    {
        portable,
        notPortable
    };
    public class Landline : Phone
    {
        private Mobility mobility;

        public Landline() : base()
        {
            mobility = Mobility.portable;
        }

        public Landline(string brand, int funcC, Mobility mobility) : base(brand, funcC)
        {
            mobility = Mobility.portable;
        }

        public Mobility Mobility { get => mobility; set => mobility = value; }

        public override double Cost()
        {
            if (this.Mobility == Mobility.portable)
                return base.Cost() + 5.7;
            else
                return base.Cost() - 3.2;
        }
    }
}
