using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace WindowsFormsApp1
{
    public partial class Calculator : Form
    {
        private string result = "";
        public string Result {
            get => result;
            set {
                resultLabel.Text = value;
                result = value;
            }
        }

        private string input = "";
        public string Input {
            get => input;
            set {
                input = value;
                inputTextBox.Text = input;
            }
        }

        private double leftPart, rightPart;
        private string usedOper = "";

        public Calculator()
        {
            InitializeComponent();
            Result = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void numClicked(object sender, EventArgs e)
        {
            string num = getButtonText(sender);

            string leftPartStr = leftPart.ToString();
            if (usedOper.Equals("")) {
                Input += num;
                double leftPartBackup = leftPart;
                if (!Double.TryParse(Input, out leftPart))
                {
                    Input = Input.Substring(0, Input.Length - 1);
                    leftPart = leftPartBackup;
                }
            }else {
                double rightPartBackup = rightPart;
                if (Input.IndexOf(leftPartStr) != -1) {
                    Input += num;
                    string rightPartStr = Input.Substring(leftPartStr.Length + 1);
                    if (!Double.TryParse(rightPartStr, out rightPart)) { 
                        Input = Input.Substring(0, Input.Length - 1);
                        rightPart = rightPartBackup;
                    }
                }
            }
        }

        private void operClicked(object sender, EventArgs e) {
            string oper = getButtonText(sender);

            if (Input != null && Input.Length != 0)
            {
                string lastSym = Input.Last().ToString();
                Regex re = new Regex(@"\d");
                if (re.IsMatch(lastSym) && rightPart != 0) {
                    calculate();
                }
                if (!isOper(lastSym))
                {
                    usedOper = oper;
                }
                else if (!lastSym.Equals("-") || ( isOper(preLastInputSym()) && isOper(lastSym) ) ) {
                    return;
                }
                Input += oper;
            } else if (oper == "-") {
                Input += oper;
            }
            
        }

        private string preLastInputSym()
        {
            int inputLength = Input.Length;
            return Input.Length > 2 ? Input.Substring(inputLength - 2, 1) : "";
        }

        private bool isOper(string input) {
            return input.Equals("-")
                || input.Equals("+")
                || input.Equals("*")
                || input.Equals("/");
        }

        private void calculate()
        {
            double operationRes = 0;
            if (usedOper.Equals("+"))
            {
                operationRes = leftPart + rightPart;
            }
            else if (usedOper.Equals("-"))
            {
                operationRes = leftPart - rightPart;
            }
            else if (usedOper.Equals("*"))
            {
                operationRes = leftPart * rightPart;
            }
            else if (usedOper.Equals("/"))
            {
                if(rightPart == 0)
                {
                    MessageBox.Show("На нуль ділити не можна!");
                    clearAll(null, null);
                    return;
                }
                operationRes = leftPart / rightPart;
            }

            leftPart = operationRes;
            rightPart = 0;
            usedOper = "";
            Result = operationRes.ToString();
            Input = Result;
        }

        private void equalsButtonClicked(object sender, EventArgs e)
        {
            calculate();
        }

        private void contraryOperation(object sender, EventArgs e)
        {
            if (usedOper.Equals("")) {
                leftPart = leftPart * -1;
                rightPart = 0;
                Result = leftPart.ToString();
                Input = Result;
            }
        }

        private void clearAll(object sender, EventArgs e)
        {
            leftPart = 0;
            rightPart = 0;
            usedOper = "";
            Result = "";
            Input = "";
        }

        private void clearInput(object sender, EventArgs e)
        {
            leftPart = 0;
            rightPart = 0;
            usedOper = "";
            Input = "";
        }

        private void deleteOne(object sender, EventArgs e)
        {
            if (Input != null) {

                string leftNumStr = leftPart.ToString();
                int leftNumLength = leftNumStr.Length;


                if (leftNumLength == Input.Length)
                {
                    if (leftNumLength == 1)
                    {
                        clearInput(sender, e);
                    }
                    else if (leftNumLength > 0)
                    {
                        try {
                            leftNumStr = leftNumStr.Substring(0, leftNumLength - 1);
                            leftPart = Double.Parse(leftNumStr);
                        }catch (FormatException formatException) {
                            leftPart = 0;    
                        }
                    }
                }
                else if (Input.Length == leftNumLength + 1)
                {
                    usedOper = "";
                }else {
                    string rightPartStr = rightPart.ToString();
                    int rightNumLength = rightPartStr.Length;
                    if (rightNumLength == 1) {
                        clearInput(sender, e);
                    } else if (rightNumLength > 0) {
                        try{
                            rightPartStr = rightPartStr.Substring(0, rightNumLength - 1);
                            rightPart = Double.Parse(rightPartStr);
                        }catch (FormatException formatException)
                        {
                            rightPart = 0;
                        }
                    }
                }
                int resLen = Input.Length - 1;
                if (resLen < 0) {
                    resLen = 0;
                }
                Input = Input.Substring(0, resLen);
            }
        }

        private string getButtonText(object sender) {
            Button button = (Button)sender;
            return button.Text;
        }
    }
}
