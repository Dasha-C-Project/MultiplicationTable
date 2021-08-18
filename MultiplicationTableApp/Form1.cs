using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiplicationTableApp
{
    public partial class Form1 : Form
    {
        public int q { get; set; }
        public int qRight { get; set; }

        public Form1()
        {
            InitializeComponent();
        }
        private void showStartPicture()
        {
            startPicture.Visible = true;
            startText.Visible = true;
            successPicture.Visible = false;
            successText.Visible = false;
            failPicture.Visible = false;
            failText.Visible = false;
        }
        private void showSuccessPicture()
        {
            startPicture.Visible = false;
            startText.Visible = false;
            successPicture.Visible = true;
            successText.Visible = true;
            failPicture.Visible = false;
            failText.Visible = false;
        }
        private void showFailPicture()
        {
            startPicture.Visible = false;
            startText.Visible = false;
            successPicture.Visible = false;
            successText.Visible = false;
            failPicture.Visible = true;
            failText.Visible = true;
        }
        private void randNumb()
        {
            Random rand = new Random();
            firstNumber.Text = rand.Next(1, 11).ToString();
            secondNumber.Text = rand.Next(1, 11).ToString();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (int.Parse(firstNumber.Text) * int.Parse(secondNumber.Text) == int.Parse(resultBox.Text))
                {
                    showSuccessPicture();
                    qRight++;
                    checkButton.Enabled = false;
                    nextButton.Enabled = true;
                    resultBox.ReadOnly = true;
                }
                else
                {
                    showFailPicture();
                    resultBox.Focus();
                }
                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                resultBox.Clear();
                resultBox.Focus();
            }
            q++;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            showStartPicture();
            randNumb();
            resultBox.Clear();
            resultBox.Focus();
            checkButton.Enabled = true;
            nextButton.Enabled = false;
            resultBox.ReadOnly = false;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = false;
            checkButton.Enabled = true;
            endButton.Enabled = true;
            nextButton.Enabled = true;
            resultBox.ReadOnly = false;
            resultBox.Clear();
            randNumb();
            quantityText.Text = "-";
            rightQuantityText.Text = "-";
            markText.Text = "-";
            q = 0;
            qRight = 0;
            nextButton.Enabled = false;
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            showStartPicture();
            resultBox.ReadOnly = true;
            quantityText.Text = q.ToString();
            rightQuantityText.Text = qRight.ToString();
            markText.Text = (12 * qRight / q).ToString();
            checkButton.Enabled = false;
            endButton.Enabled = false;
            nextButton.Enabled = false;
            startButton.Enabled = true;
        }
    }
}
