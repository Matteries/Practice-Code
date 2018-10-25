namespace TextScrubberApplication
{
    public class TextProgram
    {
        protected static string ProgramStarterOriginalInput;

        public static void Main(string[] args)
        {
            var programStarter = new TextScrubber();
            ProgramStarterOriginalInput = programStarter.OriginalInput;
        }
    }
}