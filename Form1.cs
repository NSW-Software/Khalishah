using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace try1
{
    public partial class Form1 : Form
    {   
        private double fstNum, secNum; //for the resut
        private string mathOperator;//math operation
        private bool isMathPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private string no = "";

        private void UpdateDisplay()
        {
           textBox1.Text = no;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(isMathPerformed) //clear textbox
            {
                textBox1.Clear();
            }
            textBox1.Text += btn0.Text;
            isMathPerformed = false;  //no math operation happened
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn3.Text;
        }
       
        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn4.Text;
        }
       
        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn5.Text;
        }
       
        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn6.Text;
        }
      
        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn7.Text;
        }
       
        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn8.Text;
        }
       
        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn9.Text;
        }


        private void dotBtn_Click(object sender, EventArgs e)
        {
            if(!textBox1.Text.Contains("."))
            {
                textBox1.Text += dotBtn.Text;
            }
            
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            no = "";
            UpdateDisplay();
            equal = false;
            lblCurrentDisplay.Text = "";
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            string currentDisplay = textBox1.Text;
            if (currentDisplay.Length > 0 )
            {
                string deleteDisplay = currentDisplay.Remove (currentDisplay.Length - 1);   
                textBox1 .Text = deleteDisplay;
            }

        }

        private async void addBtn_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out fstNum))
            {
                mathOperator = "+";
                textBox1.Text = "";
                lblCurrentDisplay.Text = fstNum.ToString() + "" + mathOperator;
                isMathPerformed = true;
            }
            else
            {
                textBox1.Text = "Invalid Input";
                await Task.Delay(1000);
                UpdateDisplay();
            }
        }

        private async void subBtn_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out fstNum))
            { 
                mathOperator = "-";
                textBox1.Text = "";
                lblCurrentDisplay.Text = fstNum.ToString() + "" + mathOperator;
                isMathPerformed = true;
            }
            else
            {
                textBox1.Text = "Invalid Input";
                await Task.Delay(1000);
                UpdateDisplay();
            }
        }

        private async void multiBtn_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out fstNum))
            {
                mathOperator = "*";
                textBox1.Text = "";
                lblCurrentDisplay.Text = fstNum.ToString() + "" + mathOperator;
                isMathPerformed = true;
            }

            else
            {
                textBox1.Text = "Invalid Input";
                await Task.Delay(1000);
                UpdateDisplay();
            }
        }


        private async void divBtn_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out fstNum))
            {
             
                mathOperator = "/";
                textBox1.Text = "";
                lblCurrentDisplay.Text = fstNum.ToString() + "" + mathOperator;
                isMathPerformed = true;
            }
        
            else
            {
                textBox1.Text = "Invalid Input";
                await Task.Delay(1000);
                UpdateDisplay();
            }
         }

        bool equal = false;
        private async void equalBtn_Click(object sender, EventArgs e)
       {
            if (!equal)
            {
                double.TryParse(textBox1.Text, out secNum);
                equal = true;
            }

            if (textBox1.Text != "")
            {

                switch (mathOperator)
                {
                    case "+":
                        textBox1.Text = (fstNum + secNum).ToString();
                        break;
                    case "-":
                        textBox1.Text = (fstNum - secNum).ToString();
                        break;
                    case "*":
                        textBox1.Text = (fstNum * secNum).ToString();
                        break;
                    case "/":
                        if (secNum != 0)
                        {
                            textBox1.Text = (fstNum / secNum).ToString();
                        }
                        else
                        {
                            textBox1.Text = "ERROR";
                            await Task.Delay(1000);
                            UpdateDisplay();
                        }
                        break;
                    default:
                        break;

                }

                fstNum = double.Parse(textBox1.Text);
            }
            else
            {
              textBox1.Text = "Invalid Input";
              await Task.Delay(1000);
              UpdateDisplay();
            }

       }
    }
}
