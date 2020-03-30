namespace Coffee
{
    public class Latte : Coffee, IMilk
    {
        public override int Price()
        {
            return 40;
        }
        public override string Name()
        {
            return "Kaffe latte";
        }
        public override string Strength()
        {
            return "mild";
        }
        public int mlMilk()
        {
            return 200;
        }
        public override string ToString()
        {
            return base.ToString() + $" Indeholder {mlMilk()} ml mælk.";
        }
    }
}