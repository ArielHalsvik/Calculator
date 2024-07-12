namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        int? number1;
        int? number2;
        string arithmetic;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox.Text += "0";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            number1 = null;
            number2 = null;
            arithmetic = "";
            textBox.Text = "";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            CheckNumbers.Number1 = number1;
            bool checkNumber = CheckNumbers.CheckNumber();

            CheckNumbers.TextBox = textBox.Text;
            bool checkTextBox = CheckNumbers.CheckTextBox();

            if (checkNumber && checkTextBox)
            {
                number2 = int.Parse(textBox.Text);
            }
            else if (checkNumber)
            {
                number2 = 0;
            }
            else
            {
                number1 = int.Parse(textBox.Text);
            }

            SumNumbers.Arithmetic = arithmetic;
            SumNumbers.TotalSum(number1, number2);
            textBox.Text = SumNumbers.Sum.ToString();
            System.Diagnostics.Debug.WriteLine("Sum: " + SumNumbers.Sum);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            CheckNumbers.Number1 = number1;
            bool checkNumber = CheckNumbers.CheckNumber();

            CheckNumbers.TextBox = textBox.Text;
            bool checkTextBox = CheckNumbers.CheckTextBox();

            if (checkNumber && checkTextBox)
            {
                number2 = int.Parse(textBox.Text);
            }
            else if (checkNumber)
            {
                number2 = 0;
            }
            else
            {
                number1 = int.Parse(textBox.Text);
            }

            arithmetic = "+";
            textBox.Text = "";
            System.Diagnostics.Debug.WriteLine("Number1: " + number1 + "Number2: " + number2);

        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            CheckNumbers.Number1 = number1;
            bool checkNumber = CheckNumbers.CheckNumber();

            CheckNumbers.TextBox = textBox.Text;
            bool checkTextBox = CheckNumbers.CheckTextBox();

            if (checkNumber && checkTextBox)
            {
                number2 = int.Parse(textBox.Text);
            }
            else if (checkNumber)
            {
                number2 = 0;
            }
            else
            {
                number1 = int.Parse(textBox.Text);
            }

            arithmetic = "-";
            textBox.Text = "";
            System.Diagnostics.Debug.WriteLine("Number1: " + number1 + "Number2: " + number2);

        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            CheckNumbers.Number1 = number1;
            bool checkNumber = CheckNumbers.CheckNumber();

            CheckNumbers.TextBox = textBox.Text;
            bool checkTextBox = CheckNumbers.CheckTextBox();

            if (checkNumber && checkTextBox)
            {
                number2 = int.Parse(textBox.Text);
            }
            else if (checkNumber)
            {
                number2 = 0;
            }
            else
            {
                number1 = int.Parse(textBox.Text);
            }

            arithmetic = "*";
            textBox.Text = "";
            System.Diagnostics.Debug.WriteLine("Number1: " + number1 + "Number2: " + number2);

        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            CheckNumbers.Number1 = number1;
            bool checkNumber = CheckNumbers.CheckNumber();

            CheckNumbers.TextBox = textBox.Text;
            bool checkTextBox = CheckNumbers.CheckTextBox();

            if (checkNumber && checkTextBox)
            {
                number2 = int.Parse(textBox.Text);
            }
            else if (checkNumber)
            {
                number2 = 0;
            }
            else
            {
                number1 = int.Parse(textBox.Text);
            }

            arithmetic = "/";
            textBox.Text = "";
            System.Diagnostics.Debug.WriteLine("Number1: " + number1 + "Number2: " + number2);

        }
    }

    public class CheckNumbers
    {
        public static int? Number1 { get; set; }
        public static string? TextBox { get; set; }

        public static bool CheckNumber()
        {
            return Number1.HasValue;
        }
        public static bool CheckTextBox()
        {
            return !string.IsNullOrEmpty(TextBox);
        }
    }

    public class SumNumbers
    {
        public static int? Sum { get; set; }
        public static string Arithmetic { get; set; }

        public static int? TotalSum(int? number1, int? number2)
        {
            if (number1 == null)
            {
                number1 = 0;
            }
            else if (number2 == null)
            {
                number2 = 0;
            }

            if (Arithmetic == "+")
            {
                Sum = number1 + number2;
            }
            else if (Arithmetic == "-")
            {
                Sum = number1 - number2;
            }
            else if (Arithmetic == "*")
            {
                Sum = number1 * number2;
            }
            else if (Arithmetic == "/")
            {
                Sum = number1 / number2;
            }
            return Sum;
        }
    }
}

