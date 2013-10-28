using System;

class InvalidRangeException<T>
        : ArgumentOutOfRangeException
{
    private T start;
    private T end;


    public T Start
    {
        get { return start; }
        protected set { start = value; }
    }

    public T End
    {
        get { return end; }
        protected set { end = value; }
    }


    public InvalidRangeException(string message, T start, T end)
        : base(message)
    {
        this.Start = start;
        this.End = end;
    }

    public override string Message
    {
        get
        {
            if (this.Start != null && this.End != null)
            {
                return string.Format("Value must be between {0} and {1}. )", this.Start, this.End);
            }
            else
            {
                return base.Message;
            }
        }
    }
}