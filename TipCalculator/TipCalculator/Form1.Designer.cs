
namespace TipCalculator {
    partial class BillToBePayedOutLabel {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.ComputeTip = new System.Windows.Forms.Button();
            this.BillEntryBox = new System.Windows.Forms.TextBox();
            this.TipOutputBox = new System.Windows.Forms.TextBox();
            this.TipEntryLabel = new System.Windows.Forms.Label();
            this.TipPercentageEntry = new System.Windows.Forms.TextBox();
            this.AmountToPayOut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Total Bill";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ComputeTip
            // 
            this.ComputeTip.Location = new System.Drawing.Point(108, 129);
            this.ComputeTip.Name = "ComputeTip";
            this.ComputeTip.Size = new System.Drawing.Size(87, 27);
            this.ComputeTip.TabIndex = 1;
            this.ComputeTip.Text = "Compute Tip";
            this.ComputeTip.UseVisualStyleBackColor = true;
            this.ComputeTip.Click += new System.EventHandler(this.ComputeTip_Click);
            // 
            // BillEntryBox
            // 
            this.BillEntryBox.Location = new System.Drawing.Point(266, 55);
            this.BillEntryBox.Name = "BillEntryBox";
            this.BillEntryBox.Size = new System.Drawing.Size(116, 23);
            this.BillEntryBox.TabIndex = 2;
            this.BillEntryBox.TextChanged += new System.EventHandler(this.BillEntryBox_TextChanged);
            // 
            // TipOutputBox
            // 
            this.TipOutputBox.Location = new System.Drawing.Point(266, 132);
            this.TipOutputBox.Name = "TipOutputBox";
            this.TipOutputBox.Size = new System.Drawing.Size(116, 23);
            this.TipOutputBox.TabIndex = 3;
            // 
            // TipEntryLabel
            // 
            this.TipEntryLabel.AutoSize = true;
            this.TipEntryLabel.Location = new System.Drawing.Point(469, 62);
            this.TipEntryLabel.Name = "TipEntryLabel";
            this.TipEntryLabel.Size = new System.Drawing.Size(115, 15);
            this.TipEntryLabel.TabIndex = 4;
            this.TipEntryLabel.Text = "Enter Tip Percentage";
            this.TipEntryLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // TipPercentageEntry
            // 
            this.TipPercentageEntry.Location = new System.Drawing.Point(602, 59);
            this.TipPercentageEntry.Name = "TipPercentageEntry";
            this.TipPercentageEntry.Size = new System.Drawing.Size(116, 23);
            this.TipPercentageEntry.TabIndex = 5;
            this.TipPercentageEntry.TextChanged += new System.EventHandler(this.TipPercentageEntry_TextChanged);
            // 
            // AmountToPayOut
            // 
            this.AmountToPayOut.Location = new System.Drawing.Point(602, 133);
            this.AmountToPayOut.Name = "AmountToPayOut";
            this.AmountToPayOut.Size = new System.Drawing.Size(116, 23);
            this.AmountToPayOut.TabIndex = 6;
            this.AmountToPayOut.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Total Bill To Be Payed";
            // 
            // BillToBePayedOutLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AmountToPayOut);
            this.Controls.Add(this.TipPercentageEntry);
            this.Controls.Add(this.TipEntryLabel);
            this.Controls.Add(this.TipOutputBox);
            this.Controls.Add(this.BillEntryBox);
            this.Controls.Add(this.ComputeTip);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BillToBePayedOutLabel";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ComputeTip;
        private System.Windows.Forms.TextBox BillEntryBox;
        private System.Windows.Forms.TextBox TipOutputBox;
        private System.Windows.Forms.Label TipEntryLabel;
        private System.Windows.Forms.TextBox TipPercentageEntry;
        private System.Windows.Forms.TextBox AmountToPayOut;
        private System.Windows.Forms.Label label2;
    }
}

