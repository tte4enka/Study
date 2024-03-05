namespace _2task
{
    public abstract class Triad
    {
        public int First { get; set; }
        public int Second { get; set; }
        public int Third { get; set; }

        public Triad(int first, int second, int third)
        {
            First = first;
            Second = second;
            Third = third;
        }

        public bool Equals(Triad other)
        {
            return this.First == other.First &&
               this.Second == other.Second &&
               this.Third == other.Third;
        }
    }
}
