using System;

namespace FitTrack
{
    class Program
    {
        static void Main()
        {
            FitnessTracker tracker = new FitnessTracker("BasicTracker");
            FitTrackPro proTracker = new FitTrackPro("ProTracker");
            tracker.AddUser("Alice");
            tracker.AddUser("Bob");
            tracker.AddUser("Charlie");
            tracker.AddUser("David"); 
            Console.WriteLine();

            tracker.TrackSteps(5000);
            tracker.TrackSteps(20000);
            tracker.TrackSteps(60000); 

            Console.WriteLine();

         
            proTracker.TrackSteps(70000);
            proTracker.TrackSteps(150000); 

            Console.WriteLine();

            
            Running run = new Running("Morning Run", 30);
            run.CalculateCalories();

            Cycling cycle = new Cycling("Evening Ride", 45);
            cycle.CalculateCalories();
        }
    }
}
