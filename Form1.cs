namespace Caculator_cy
{
    public partial class Form1 : Form
    {
        enum Operators
        {
            None,
            Add,
            Subtract,
            Multiply,
            Divide,
            Result
        }

        Operators currentOperator = Operators.None;
        Boolean operatorChangeFlag = false;
        Boolean isOperator = false;
        int firstOperand = 0;
        int secondOperand = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void NumButton_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            Button button = (Button)sender;

            string strNumber = display.Text += button.Text;
            int intNumber = int.Parse(strNumber);
            display.Text = intNumber.ToString();

        }
        private void CommonOperator(object common)
        {
                display.Text = firstOperand.ToString();
                Enum.TryParse(common.ToString(), out currentOperator);
                secondOperand = 0;
                operatorChangeFlag = true;
        }

        private void OperatorButton(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (isOperator == false)
            {
                firstOperand = int.Parse(display.Text);
                if(button.Tag != null) Enum.TryParse(button.Tag.ToString(), out currentOperator);
                operatorChangeFlag = true;
                isOperator = true;
            }
            else if (isOperator == true && currentOperator == Operators.Add)
            {
                secondOperand = int.Parse(display.Text);
                firstOperand += secondOperand;
                if (button.Tag != null) CommonOperator(button.Tag);
            }
            else if (isOperator == true && currentOperator == Operators.Subtract)
            {
                secondOperand = int.Parse(display.Text);
                firstOperand -= secondOperand;
                if (button.Tag != null) CommonOperator(button.Tag);

            }
            else if (isOperator == true && currentOperator == Operators.Multiply)
            {
                secondOperand = int.Parse(display.Text);
                firstOperand *= secondOperand;
                if (button.Tag != null) CommonOperator(button.Tag);

            }
            else if (isOperator == true && currentOperator == Operators.Divide)
            {
                secondOperand = int.Parse(display.Text);
                firstOperand /= secondOperand;
                if (button.Tag != null) CommonOperator(button.Tag);
            }
        }

        private void ButtonResult_Click(object sender, EventArgs e)
        {
            secondOperand = int.Parse(display.Text);
            isOperator = false;
            if (currentOperator == Operators.Add)
            {
                firstOperand += secondOperand;
                display.Text = firstOperand.ToString();
            }
            else if (currentOperator == Operators.Subtract)
            {
                firstOperand -= secondOperand;
                display.Text = firstOperand.ToString();
            }
            else if (currentOperator == Operators.Multiply)
            {
                firstOperand *= secondOperand;
                display.Text = firstOperand.ToString();
            }
            else if (currentOperator == Operators.Divide)
            {
                if (secondOperand != 0)
                {
                    firstOperand /= secondOperand;
                    display.Text = firstOperand.ToString();
                    
                } else if (secondOperand == 0) {
                    display.Text = "0";
                }
                
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            firstOperand = 0;
            secondOperand = 0;
            currentOperator = Operators.None;
            display.Text = "0";
            isOperator = false;
        }


    }
}
