namespace Day5Examples
{
        public class Exam
    {
        private int score = 0;

        public void AddMarks(int marks)
        {
            if (marks > 0)
                score += marks;
        }

        public void DeductMarks(int marks)
        {
            if (marks > 0 && marks <= score)
                score -= marks;
        }

        public int GetScore()
        {
            return score;
        }
    }
    public static class MarkAlloc
    {
        public static void Run()
        {
            Console.WriteLine("Mark Allocation Example\n");

            Exam exam = new Exam();

            exam.AddMarks(10);
            exam.AddMarks(5);
            Console.WriteLine("Score after correct answers: " + exam.GetScore());

            exam.DeductMarks(3);
            Console.WriteLine("Score after negative marking: " + exam.GetScore());
        }
    }


}