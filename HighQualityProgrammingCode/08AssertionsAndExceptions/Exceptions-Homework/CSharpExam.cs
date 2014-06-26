using System;

public class CSharpExam : Exam
{
    private int score;

    public CSharpExam(int score)
    {
        this.Score = score;
    }

    public int Score
    {
        get
        {
            return this.score;
        }

        private set
        {
            if (0 <= this.Score && this.Score <= 100)
            {
                this.score = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("The score should in the range from 0 to 100, including.");
            }
        }
    }

    public override ExamResult Check()
    {
        ExamResult newExamResult = new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");

        return newExamResult;
    }
}
