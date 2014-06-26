using System;

public class SimpleMathExam : Exam
{
    private int problemsSolved;

    public SimpleMathExam(int problemsSolved)
    {
        this.ProblemsSolved = problemsSolved;
    }

    public int ProblemsSolved
    {
        get
        {
            return this.problemsSolved;
        }

        private set
        {
            if (0 <= value && value <= 10)
            {
                this.problemsSolved = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("The solved problems should in the range from 0 to 10, including.");
            }
        }
    }

    public override ExamResult Check()
    {
        if (this.ProblemsSolved == 0)
        {
            return new ExamResult(2, 2, 6, "Bad result: nothing done.");
        }
        else if (this.ProblemsSolved == 1)
        {
            return new ExamResult(4, 2, 6, "Good result: One problem solved.");
        }
        else
        {
            return new ExamResult(6, 2, 6, "Excellent result: Two or more problems solved.");
        }
    }
}
