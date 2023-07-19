

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (numbers.Contains(","))
            {
                var lhs = int.Parse(numbers.Substring(0, 1));
                var rhs = int.Parse(numbers.Substring(2));
                return lhs + rhs;
            }
            return numbers == "" ? 0 : int.Parse(numbers);
        }
    }
}
