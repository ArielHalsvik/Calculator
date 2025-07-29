namespace Calculator;

public abstract class Numbers
{
    private static bool CheckNumber(int number) => number > 0;

    private static bool CheckTextBox(string? textBox) => !string.IsNullOrEmpty(textBox);
    
    public static int UpdateNumbers(int number, string arithmetic, string? textBox)
    {
        var checkNumber = CheckNumber(number);
        var checkTextBox = CheckTextBox(textBox);

        if (checkTextBox && !checkNumber)
        {
            number = int.Parse(textBox!);
        }
        else if (checkNumber && checkTextBox)
        {
            var textBoxNumber = int.Parse(textBox!);
            var result = arithmetic switch
            {
                "+" => number! + textBoxNumber!,
                "-" => number! - textBoxNumber!,
                "*" => number! * textBoxNumber!,
                "/" => number! / textBoxNumber!,
                _ => throw new ArgumentOutOfRangeException(nameof(arithmetic), arithmetic, null)
            };
            number = result;
        }
        return number;
    }
    
}