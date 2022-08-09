namespace OOP_SAMPLE_CODE
{
     class Program
    {
        static void Main(string[] args)
        {
            Candidate john = new Candidate();
            Console.WriteLine("Are you a Nigerian? (yes/no)");
            string nationality = Console.ReadLine().ToLower();
            Console.WriteLine("Are you above 18?(yes/no)");
            string age = Console.ReadLine().ToLower();
            Console.WriteLine("Grade is 2:1 and above? (yes/no)");
            string grade = Console.ReadLine().ToLower();
            Console.WriteLine("Score is Seventy and above(yes / no)");
            string score = Console.ReadLine().ToLower();

            john.IsAgeaboveEighteen= john.Age(age);
            john.IsNigerian=john.Nationality(nationality);
            john.IsGradeAboveSeventy=john.Score(score);
            john.IsSecondUpperAndAbove=john.Grade(grade);

            john.Employ();
        }
     }
}
