namespace Coffee
{
    public class Cortardo : Coffee, IMilk
    {
        public override int Price()
        {
            return 25;
        }
        public override string Name()
        {
            return "Cortardo";
        }
        public override string Strength()
        {
            return "medium";
        }
        public int mlMilk()
        {
            return 40;
        }
        public override string ToString()
        {
            return base.ToString() + $" Indeholder {mlMilk()} ml mælk.";
        }
    }
}