namespace MoodAnalyser_Day20
{
    
    class Program
    {
        public static void Main(string[] args)
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser();

            Console.WriteLine(moodAnalyser.AnalyseMood("I'm in any mood".ToLower()));
        }
    }
}