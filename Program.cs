namespace SchoolSubjectGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! What is your favorite school subject?");
            var userAnswer = Console.ReadLine().ToLower();

                switch (userAnswer)
                {
                    case "math":
                        Console.WriteLine("Math has always been complicated for me - kudos for enjoying this subject!");
                        break;
                    case "science":
                        Console.WriteLine("Science has always been interesting and fun for me!");
                        break;
                    case "history":
                        Console.WriteLine("History will never change and should be taught in schools!");
                        break;
                    case "Language":
                        Console.WriteLine("Language is fun and more languages should be taught!");
                        break;
                    case "gym":
                        Console.WriteLine("I've never been a gym rat, but I wish I could've been!");
                        break;
                    case "lunch":
                        Console.WriteLine("Lunch! Now we're talking a social subject I enjoyed!");
                        break;
                    default:
                        Console.WriteLine("Hmm, never heard of that sugject before. :)");
                        break;

                }
            
          
        }
    }
}