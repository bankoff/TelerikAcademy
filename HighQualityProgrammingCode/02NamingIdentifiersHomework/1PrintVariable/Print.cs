namespace _1PrintVariable
{
    using System;

    public class Print
    {
        private const int MaxCountOfVariables = 6;

        public void PrintVariableToString(bool variable)
        {
            string variableToString = variable.ToString();
            Console.WriteLine(variableToString);
        }
    }
}
