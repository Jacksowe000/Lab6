using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipCalculator {
    public partial class BillToBePayedOutLabel : Form {
        private double billTotal;
        private double tipPercent;
        public BillToBePayedOutLabel() {
            billTotal = 0;
            tipPercent = .2;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void ComputeTip_Click(object sender, EventArgs e) {
            TipOutputBox.Text = "$" + (billTotal * tipPercent).ToString();
            AmountToPayOut.Text = "$" + (billTotal + billTotal * tipPercent).ToString();
        }

        private void BillEntryBox_TextChanged(object sender, EventArgs e) {
            if (Double.TryParse(BillEntryBox.Text, out double num))
                billTotal = num;
        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void TipPercentageEntry_TextChanged(object sender, EventArgs e) {
            if (double.TryParse(TipPercentageEntry.Text, out double num))
                tipPercent = .01 * num;

            TipOutputBox.Text = "$" + (billTotal * tipPercent).ToString();
            AmountToPayOut.Text = "$" + (billTotal + billTotal * tipPercent).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }
    }
}
