namespace Calculator2._0
{
    public partial class Form1 : Form
    {

        string first = "";
        string second = "";
        char function;
        double result = 0.0;
        string userInput = "";
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += "0";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            function = '+';
            first = calculatorDisplay.Text;
            userInput = "";
            calculatorDisplay.Text += "+";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            function = '-';
            first = calculatorDisplay.Text;
            userInput = "";
            calculatorDisplay.Text += "-";
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            function = '*';
            first = calculatorDisplay.Text;
            userInput = "";
            calculatorDisplay.Text += "*";
        }

        private void Gayofa_Click(object sender, EventArgs e)
        {
            function = '/';
            first = calculatorDisplay.Text;
            userInput = "";
            calculatorDisplay.Text += "/";
        }

        private void equals_Click(object sender, EventArgs e)
        {

            double firstNum, secondNum;

            firstNum = Convert.ToDouble(first);

            //plus
            if (function == '+')
            {
                second = calculatorDisplay.Text.Split('+')[1];
                secondNum = Convert.ToDouble(second);
                result = firstNum + secondNum;
                calculatorDisplay.Text = result.ToString();

            }
            //minus
            else if (function == '-')
            {
                second = calculatorDisplay.Text.Split('-')[1];
                secondNum = Convert.ToDouble(second);
                result = secondNum - firstNum;
                calculatorDisplay.Text = result.ToString();
            }
            //devide
            else if (function == '/')
            {
                second = calculatorDisplay.Text.Split('/')[1];
                secondNum = Convert.ToDouble(second);
                if (secondNum == 0)
                {
                    calculatorDisplay.Text = "Nolze ar iyofa wadi matematika imecadine";
                }
                else
                {

                    result = firstNum / secondNum;
                    calculatorDisplay.Text = result.ToString();
                }
            }
            //Multiply
            else if (function == '*')
            {
                second = calculatorDisplay.Text.Split('*')[1];
                secondNum = Convert.ToDouble(second);
                result = firstNum * secondNum;
                calculatorDisplay.Text = result.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}