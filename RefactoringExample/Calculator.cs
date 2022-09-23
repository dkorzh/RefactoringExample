namespace RefactoringExample
{
    public class Calculator
    {
        public int? Calculate(int a, int b, string operation)
        {
            if (operation.Equals("+"))
            {
                return a + b;
            }

            if (operation.Equals("-"))
            {
                return a - b;
            }

            if (operation.Equals("*"))
            {
                return a * b;
            }

            if (operation.Equals("/"))
            {
                return a / b;
            }

            return null;
        }
    }
}