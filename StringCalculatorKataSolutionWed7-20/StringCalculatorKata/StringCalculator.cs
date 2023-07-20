namespace StringCalculatorKata;

public class StringCalculator
{
    public int Add(string numbers)
    {
        if (numbers == "")
        {
            return 0;
        }


        var delimeters = new[] { ',', '\n' };
        if ( numbers.Length > 1 && numbers.Substring(0,2) == "//")
        {
            delimeters = delimeters.Concat(new char[] { numbers.ToCharArray()[2] } ).ToArray();
            numbers = numbers.Substring(5);
        }



        return numbers.Split(delimeters, StringSplitOptions.RemoveEmptyEntries) // ["108"]
                .Select(int.Parse) // [ 108 ]
                .Sum(); // Sum them up!
    }
}