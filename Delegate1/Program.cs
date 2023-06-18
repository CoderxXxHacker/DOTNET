using System;
namespace DelegatesDemo
{
    public delegate void WorkPerformedHandler(int hours, WorkType workType);

    public delegate void PlayGameHandler(PlayGame game);

    class Program
    {
        static void Main(string[] args)
        {
            WorkPerformedHandler del1 = 
                        new WorkPerformedHandler(Manager_WorkPerformed);
            del1(10, WorkType.Golf);
            //del1.Invoke(50, WorkType.GotoMeetings);

            Program P = new Program();

            PlayGameHandler pg = new PlayGameHandler(P.playingGame);

            pg(PlayGame.Cricket);
            Console.ReadKey();
        }

        public static void Manager_WorkPerformed(int workHours, WorkType wType)
        {
            Console.WriteLine("Work Performed by Event Handler");
            Console.WriteLine($"Work Hours: {workHours}, Work Type: {wType}");
        }

        public void playingGame(PlayGame G)
        {
            Console.WriteLine("=================================");
            Console.WriteLine($"Currrently playing game : {G}");
        }
    }

    public enum WorkType
    {
        Golf,
        GotoMeetings,
        GenerateReports
    }

    public enum PlayGame
    {
        Cricket,
        Football,
        Chess,
        Volleyball,
        Basketball
    }
}
