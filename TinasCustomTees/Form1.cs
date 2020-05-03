using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinasCustomTees
{
    public partial class frmTinasCustomTees : Form
    {

        //Declare global constants
        const int SMALLSHIRTPRICE = 8;
        const int MEDIUMSHIRTPRICE = 10;
        const int LARGESHIRTPRICE = 12;

        //Declare global variables
        int numOrdered      = 0;
        double costPerShirt = 0.0;
        double totalCost    = 0.0;

        public frmTinasCustomTees()
        {
            InitializeComponent();
        }

        private void radioColorWhite_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.White;
        }

        private void radioColorRed_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Red;
        }

        private void radioColorBlue_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Blue;
        }

        private void radioSizeSmall_CheckedChanged(object sender, EventArgs e)
        {
            costPerShirt = SMALLSHIRTPRICE;
            calculateTotals();
        }

        private void radioSizeMedium_CheckedChanged(object sender, EventArgs e)
        {
            costPerShirt = MEDIUMSHIRTPRICE;
            calculateTotals();
        }

        private void radioSizeLarge_CheckedChanged(object sender, EventArgs e)
        {
            costPerShirt = LARGESHIRTPRICE;
            calculateTotals();
        }

        private void radioQuantityOne_CheckedChanged(object sender, EventArgs e)
        {
            numOrdered = 1;
            calculateTotals();
        }

        private void radioQuantityTen_CheckedChanged(object sender, EventArgs e)
        {
            numOrdered = 10;
            calculateTotals();
        }

        private void radioQuantityHundred_CheckedChanged(object sender, EventArgs e)
        {
            numOrdered = 100;
            calculateTotals();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            monthCalendar1.MinDate = DateTime.Now;
            txtDeliveryDate.Text = "T-Shirt Delivery Date: " +
            monthCalendar1.SelectionStart.AddDays(3).ToShortDateString();
        }

        private void frmTinasCustomTees_Load(object sender, EventArgs e)
        {
            numOrdered = 1;
            costPerShirt = SMALLSHIRTPRICE;
            calculateTotals();
            txtDeliveryDate.Text = "T-Shirt Delivery Date: " + 
            monthCalendar1.SelectionStart.AddDays(3).ToShortDateString();
            this.BackColor = System.Drawing.Color.Red;
        }

        private void calculateTotals()
        {
            totalCost = numOrdered * costPerShirt;
            txtTotalCost.Text = totalCost.ToString("c");
        }
    }
}
