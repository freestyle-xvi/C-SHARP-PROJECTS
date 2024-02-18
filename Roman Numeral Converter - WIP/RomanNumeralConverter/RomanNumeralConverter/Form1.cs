using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RomanNumeralConverter
{
    public partial class frmRomanNumeralConverter : Form
    {
        public frmRomanNumeralConverter()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnConvertToRomanNumeral_Click(object sender, EventArgs e)
        {
            const string ROMAN_1 = "I";
            const string ROMAN_2 = "II";
            const string ROMAN_3 = "III";
            const string ROMAN_4 = "IV";
            const string ROMAN_5 = "V";
            const string ROMAN_6 = "VI";
            const string ROMAN_7 = "VII";
            const string ROMAN_8 = "VIII";
            const string ROMAN_9 = "IX";
            const string ROMAN_10 = "X";

            int number = 0;
            if(int.TryParse(txtNumber.Text, out number))
            {
                if(number >= 1 && number <= 10)
                {
                    switch(number)
                    {
                        case 1:
                            lblDisplay.Text = ROMAN_1;
                            break;
                        case 2:
                            lblDisplay.Text = ROMAN_2;
                            break;
                        case 3:
                            lblDisplay.Text = ROMAN_3;
                            break;
                        case 4:
                            lblDisplay.Text = ROMAN_4;
                            break;
                        case 5:
                            lblDisplay.Text = ROMAN_5;
                            break;
                        case 6:
                            lblDisplay.Text = ROMAN_6;
                            break;
                        case 7:
                            lblDisplay.Text = ROMAN_7;
                            break;
                        case 8:
                            lblDisplay.Text = ROMAN_8;
                            break;
                        case 9:
                            lblDisplay.Text = ROMAN_9;
                            break;
                        default:
                            lblDisplay.Text = ROMAN_10;
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("The number must be between 1 and 10", "Invalid Input");
                }
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid number 1 through 10");
            }
        }
    }
}
