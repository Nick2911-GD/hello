namespace Lab_7
{
    public abstract class ISoccer
    {
        protected int totalgoals;
        int Totalgoals 
        {
            get { return totalgoals; }
            set { totalgoals = value; }
        }

        public int Addgoal(int goal)
        {
            return Totalgoals + goal;
        }
    }
}