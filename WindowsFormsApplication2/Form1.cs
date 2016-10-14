using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Jeff Hall
//200328772
namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        // price variables
        double pStereo = 425.76;
        double pLeather = 987.41;
        double pComputer = 1741.23;
        double pExtStandard = 0;
        double pExtPearlized = 345.72;
        double pExtCustomized = 599.99;
        double taxRate = 0.13;
        //start form
        public Form1()
        {
            InitializeComponent();
            TaxBox.Text = (taxRate * 100).ToString() + "%";
        }
        // Exit event for the toolstrip
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caluclate();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeFont();
        }
        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeColor();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program calculates the amount due on a New or Used Vehicle", "About");
        }
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            caluclate();
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
// Methods
        // calculate the users selection
        private void caluclate()
        {
            double subTotal;
            double total;
            double amountDue;
            double basePrice = checkInput(PriceBox.Text);
            double tradeIn = checkInput(TradeInBox.Text);
            double extras = ((CheckStereo.Checked) ? pStereo : 0) +
                ((CheckLeather.Checked) ? pLeather : 0) +
                ((CheckComp.Checked) ? pComputer : 0) +
                ((RadioStandard.Checked) ? pExtStandard : 0) +
                ((RadioPearl.Checked) ? pExtPearlized : 0) +
                ((RadioCust.Checked) ? pExtCustomized : 0);
            // make sure that basePrice is bigger then 0 and trade in is 
            if ((basePrice > 0) && (tradeIn >= 0))
            {
                // calculation for all textboxes then send to text boxes
                subTotal = basePrice + extras;
                total = subTotal + (subTotal * taxRate);
                amountDue = total - tradeIn;
                PriceBox.Text = basePrice.ToString("C2");
                TradeInBox.Text = tradeIn.ToString("C2");
                OptionsBox.Text = extras.ToString("C2");
                SubTBox.Text = subTotal.ToString("C2");
                TotalBox.Text = total.ToString("C2");
                AmountBox.Text = amountDue.ToString("C2");
            }
            else if ((basePrice == -1) || (tradeIn == -1))
            {
                // we don't need message box here
            }// error message
            else
            {
                MessageBox.Show("Input is invalid", "Price to Low");
            }
        
        }
        // clears all text and check boxes
        private void clearAll()
        {
            PriceBox.ResetText();
            OptionsBox.ResetText();
            TotalBox.ResetText();
            SubTBox.ResetText();
            TaxBox.Text = (taxRate * 100).ToString();
            TradeInBox.Text = "0";
            AmountBox.ResetText();
            CheckStereo.Checked = false;
            CheckLeather.Checked = false;
            CheckComp.Checked = false;
            RadioStandard.Checked = true;
        }
        // method to make sure user input is a valid number
        private double checkInput(String plsNoNum)
        {
            try
            {
                return Convert.ToDouble(plsNoNum);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Invalid Input. Numbers Only", "Input Error");
                Debug.WriteLine(exception.Message);
                clearAll();
                return -1;
            }
        }
            // changefont magic screen thing
            private void changeFont()
        {
            FontBox.Font = dueL.Font;
            if (FontBox.ShowDialog() == DialogResult.OK)
            {
                baseL.Font = FontBox.Font;
                dueL.Font = FontBox.Font;
                PriceBox.Font = FontBox.Font;
                AmountBox.Font = FontBox.Font;
            }
        }
            // changeColour magic screen thing
            private void changeColor()
        {
            ColorDialog MyDialog = new ColorDialog();

            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                baseL.ForeColor = MyDialog.Color;
                dueL.ForeColor = MyDialog.Color;
                PriceBox.ForeColor = MyDialog.Color;
                AmountBox.ForeColor = MyDialog.Color;
            }
        }


        
    }
    }

