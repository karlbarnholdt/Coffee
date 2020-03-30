namespace Coffee
{
    public abstract class Coffee
    {
        public virtual int Price()
        {
            return 20;
        }
        public abstract string Name();
        public abstract string Strength();

        public override string ToString()
        {
            return $"{Name()} koster {Price()},- DKK og har styrken {Strength()}.";
        }
    }
}