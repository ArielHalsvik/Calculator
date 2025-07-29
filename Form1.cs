namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private int _number = 0;
        private string _arithmetic = "";

        private void button1_Click(object sender, EventArgs e)
        {
            if (_arithmetic == "") textBox.Text = "";
            textBox.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_arithmetic == "") textBox.Text = "";
            textBox.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_arithmetic == "") textBox.Text = "";
            textBox.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_arithmetic == "") textBox.Text = "";
            textBox.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_arithmetic == "") textBox.Text = "";
            textBox.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (_arithmetic == "") textBox.Text = "";
            textBox.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (_arithmetic == "") textBox.Text = "";
            textBox.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (_arithmetic == "") textBox.Text = "";
            textBox.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (_arithmetic == "") textBox.Text = "";
            textBox.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (_arithmetic == "") textBox.Text = "";
            textBox.Text += "0";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            _number = 0;
            _arithmetic = "";
            textBox.Text = "";
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            var sum = Numbers.UpdateNumbers(_number, _arithmetic, textBox.Text);
            _arithmetic = "";
            _number = 0;
            textBox.Text =  sum.ToString();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _arithmetic = "+";
            var sum = Numbers.UpdateNumbers(_number, _arithmetic, textBox.Text);
            textBox.Text = "";
            _number = sum;
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            _arithmetic = "-";
            var sum = Numbers.UpdateNumbers(_number, _arithmetic, textBox.Text);
            textBox.Text = "";
            _number = sum;
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            _arithmetic = "*";
            var sum = Numbers.UpdateNumbers(_number, _arithmetic, textBox.Text);
            textBox.Text = "";
            _number = sum;
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            _arithmetic = "/";
            var sum = Numbers.UpdateNumbers(_number, _arithmetic, textBox.Text);
            textBox.Text = "";
            _number = sum;
        }
    }
}
