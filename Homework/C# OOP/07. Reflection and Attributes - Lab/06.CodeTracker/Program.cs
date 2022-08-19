using System;

namespace AuthorProblem
{
    [Author("Ivan")]
    public class StartUp
    {
        [Author("George")]

        static void Main(string[] args)
        {
            Tracker tracker = new Tracker();
            tracker.PrintMethodsByAuthor("Ivan");

        }

    }
}
