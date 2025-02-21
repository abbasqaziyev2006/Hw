namespace FitTrack
{
    class FitnessTracker
    {
        protected string DeviceName;
        protected int BatteryLife = 24;
        protected int TotalSteps = 0;
        protected List<string> Users = new();

        public FitnessTracker(string name) => DeviceName = name;

        public void TrackSteps(int steps)
        {
            if (steps <  1 || steps >  50000)
                Console.WriteLine("Invalid steps.");
            else
                Console.WriteLine($"{(TotalSteps += steps)} steps total.");
        }

        public void AddUser(string user)
        {
            if (Users.Count >= 3)
                Console.WriteLine("User limit reached.");
            else
                Console.WriteLine($"User {user} added.");
        }
    }

    class FitTrackPro : FitnessTracker
    {
        public FitTrackPro(string name) : base(name) => BatteryLife = 48;

        public new void TrackSteps(int steps)
        {
            if (steps is < 1 or > 100000)
                Console.WriteLine("Invalid steps.");
            else
                Console.WriteLine($"{(TotalSteps += steps)} steps total.");
        }
    }

    abstract class Activity
    {
        public string Name;
        public int Duration;

        protected Activity(string name, int duration) => (Name, Duration) = (name, duration);
        public abstract void CalculateCalories();
    }

    class Running : Activity
    {
        public Running(string name, int duration) : base(name, duration) { }
        public override void CalculateCalories() => Console.WriteLine($"{Name} burned {Duration * 10} cal.");
    }

    class Cycling : Activity
    {
        public Cycling(string name, int duration) : base(name, duration) { }
        public override void CalculateCalories() => Console.WriteLine($"{Name} burned {Duration * 8} cal.");
    }
}
