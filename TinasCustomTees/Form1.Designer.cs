namespace TinasCustomTees
{
    partial class frmTinasCustomTees
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHeader = new System.Windows.Forms.Label();
            this.groupColor = new System.Windows.Forms.GroupBox();
            this.radioColorRed = new System.Windows.Forms.RadioButton();
            this.radioColorWhite = new System.Windows.Forms.RadioButton();
            this.radioColorBlue = new System.Windows.Forms.RadioButton();
            this.groupSize = new System.Windows.Forms.GroupBox();
            this.radioSizeLarge = new System.Windows.Forms.RadioButton();
            this.radioSizeMedium = new System.Windows.Forms.RadioButton();
            this.radioSizeSmall = new System.Windows.Forms.RadioButton();
            this.groupQuantity = new System.Windows.Forms.GroupBox();
            this.radioQuantityHundred = new System.Windows.Forms.RadioButton();
            this.radioQuantityTen = new System.Windows.Forms.RadioButton();
            this.radioQuantityOne = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDeliveryDate = new System.Windows.Forms.Label();
            this.txtDeliveryDate = new System.Windows.Forms.TextBox();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.groupColor.SuspendLayout();
            this.groupSize.SuspendLayout();
            this.groupQuantity.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(74, 21);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(643, 76);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Tina\'s Custom Tees";
            // 
            // groupColor
            // 
            this.groupColor.Controls.Add(this.radioColorBlue);
            this.groupColor.Controls.Add(this.radioColorWhite);
            this.groupColor.Controls.Add(this.radioColorRed);
            this.groupColor.Location = new System.Drawing.Point(23, 21);
            this.groupColor.Name = "groupColor";
            this.groupColor.Size = new System.Drawing.Size(98, 172);
            this.groupColor.TabIndex = 1;
            this.groupColor.TabStop = false;
            this.groupColor.Text = "T-Shirt Color";
            // 
            // radioColorRed
            // 
            this.radioColorRed.AutoSize = true;
            this.radioColorRed.Checked = true;
            this.radioColorRed.Location = new System.Drawing.Point(6, 41);
            this.radioColorRed.Name = "radioColorRed";
            this.radioColorRed.Size = new System.Drawing.Size(45, 17);
            this.radioColorRed.TabIndex = 0;
            this.radioColorRed.TabStop = true;
            this.radioColorRed.Text = "Red";
            this.radioColorRed.UseVisualStyleBackColor = true;
            this.radioColorRed.CheckedChanged += new System.EventHandler(this.radioColorRed_CheckedChanged);
            // 
            // radioColorWhite
            // 
            this.radioColorWhite.AutoSize = true;
            this.radioColorWhite.Location = new System.Drawing.Point(6, 86);
            this.radioColorWhite.Name = "radioColorWhite";
            this.radioColorWhite.Size = new System.Drawing.Size(53, 17);
            this.radioColorWhite.TabIndex = 1;
            this.radioColorWhite.Text = "White";
            this.radioColorWhite.UseVisualStyleBackColor = true;
            this.radioColorWhite.CheckedChanged += new System.EventHandler(this.radioColorWhite_CheckedChanged);
            // 
            // radioColorBlue
            // 
            this.radioColorBlue.AutoSize = true;
            this.radioColorBlue.Location = new System.Drawing.Point(6, 131);
            this.radioColorBlue.Name = "radioColorBlue";
            this.radioColorBlue.Size = new System.Drawing.Size(46, 17);
            this.radioColorBlue.TabIndex = 2;
            this.radioColorBlue.Text = "Blue";
            this.radioColorBlue.UseVisualStyleBackColor = true;
            this.radioColorBlue.CheckedChanged += new System.EventHandler(this.radioColorBlue_CheckedChanged);
            // 
            // groupSize
            // 
            this.groupSize.Controls.Add(this.radioSizeLarge);
            this.groupSize.Controls.Add(this.radioSizeMedium);
            this.groupSize.Controls.Add(this.radioSizeSmall);
            this.groupSize.Location = new System.Drawing.Point(156, 20);
            this.groupSize.Name = "groupSize";
            this.groupSize.Size = new System.Drawing.Size(177, 172);
            this.groupSize.TabIndex = 2;
            this.groupSize.TabStop = false;
            this.groupSize.Text = "T-Shirt Size";
            // 
            // radioSizeLarge
            // 
            this.radioSizeLarge.AutoSize = true;
            this.radioSizeLarge.Location = new System.Drawing.Point(6, 131);
            this.radioSizeLarge.Name = "radioSizeLarge";
            this.radioSizeLarge.Size = new System.Drawing.Size(106, 17);
            this.radioSizeLarge.TabIndex = 2;
            this.radioSizeLarge.Text = "Large ($12 each)";
            this.radioSizeLarge.UseVisualStyleBackColor = true;
            this.radioSizeLarge.CheckedChanged += new System.EventHandler(this.radioSizeLarge_CheckedChanged);
            // 
            // radioSizeMedium
            // 
            this.radioSizeMedium.AutoSize = true;
            this.radioSizeMedium.Location = new System.Drawing.Point(6, 86);
            this.radioSizeMedium.Name = "radioSizeMedium";
            this.radioSizeMedium.Size = new System.Drawing.Size(116, 17);
            this.radioSizeMedium.TabIndex = 1;
            this.radioSizeMedium.Text = "Medium ($10 each)";
            this.radioSizeMedium.UseVisualStyleBackColor = true;
            this.radioSizeMedium.CheckedChanged += new System.EventHandler(this.radioSizeMedium_CheckedChanged);
            // 
            // radioSizeSmall
            // 
            this.radioSizeSmall.AutoSize = true;
            this.radioSizeSmall.Checked = true;
            this.radioSizeSmall.Location = new System.Drawing.Point(6, 41);
            this.radioSizeSmall.Name = "radioSizeSmall";
            this.radioSizeSmall.Size = new System.Drawing.Size(98, 17);
            this.radioSizeSmall.TabIndex = 0;
            this.radioSizeSmall.TabStop = true;
            this.radioSizeSmall.Text = "Small ($8 each)";
            this.radioSizeSmall.UseVisualStyleBackColor = true;
            this.radioSizeSmall.CheckedChanged += new System.EventHandler(this.radioSizeSmall_CheckedChanged);
            // 
            // groupQuantity
            // 
            this.groupQuantity.Controls.Add(this.radioQuantityHundred);
            this.groupQuantity.Controls.Add(this.radioQuantityTen);
            this.groupQuantity.Controls.Add(this.radioQuantityOne);
            this.groupQuantity.Location = new System.Drawing.Point(358, 20);
            this.groupQuantity.Name = "groupQuantity";
            this.groupQuantity.Size = new System.Drawing.Size(75, 173);
            this.groupQuantity.TabIndex = 3;
            this.groupQuantity.TabStop = false;
            this.groupQuantity.Text = "# Ordered";
            // 
            // radioQuantityHundred
            // 
            this.radioQuantityHundred.AutoSize = true;
            this.radioQuantityHundred.Location = new System.Drawing.Point(6, 131);
            this.radioQuantityHundred.Name = "radioQuantityHundred";
            this.radioQuantityHundred.Size = new System.Drawing.Size(43, 17);
            this.radioQuantityHundred.TabIndex = 2;
            this.radioQuantityHundred.Text = "100";
            this.radioQuantityHundred.UseVisualStyleBackColor = true;
            this.radioQuantityHundred.CheckedChanged += new System.EventHandler(this.radioQuantityHundred_CheckedChanged);
            // 
            // radioQuantityTen
            // 
            this.radioQuantityTen.AutoSize = true;
            this.radioQuantityTen.Location = new System.Drawing.Point(6, 86);
            this.radioQuantityTen.Name = "radioQuantityTen";
            this.radioQuantityTen.Size = new System.Drawing.Size(37, 17);
            this.radioQuantityTen.TabIndex = 1;
            this.radioQuantityTen.Text = "10";
            this.radioQuantityTen.UseVisualStyleBackColor = true;
            this.radioQuantityTen.CheckedChanged += new System.EventHandler(this.radioQuantityTen_CheckedChanged);
            // 
            // radioQuantityOne
            // 
            this.radioQuantityOne.AutoSize = true;
            this.radioQuantityOne.Checked = true;
            this.radioQuantityOne.Location = new System.Drawing.Point(6, 41);
            this.radioQuantityOne.Name = "radioQuantityOne";
            this.radioQuantityOne.Size = new System.Drawing.Size(31, 17);
            this.radioQuantityOne.TabIndex = 0;
            this.radioQuantityOne.TabStop = true;
            this.radioQuantityOne.Text = "1";
            this.radioQuantityOne.UseVisualStyleBackColor = true;
            this.radioQuantityOne.CheckedChanged += new System.EventHandler(this.radioQuantityOne_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupColor);
            this.groupBox1.Controls.Add(this.groupQuantity);
            this.groupBox1.Controls.Add(this.groupSize);
            this.groupBox1.Location = new System.Drawing.Point(40, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 215);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.AutoSize = true;
            this.lblDeliveryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryDate.Location = new System.Drawing.Point(235, 362);
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.Size = new System.Drawing.Size(113, 18);
            this.lblDeliveryDate.TabIndex = 6;
            this.lblDeliveryDate.Text = "Delivery Date:";
            // 
            // txtDeliveryDate
            // 
            this.txtDeliveryDate.Location = new System.Drawing.Point(373, 363);
            this.txtDeliveryDate.Name = "txtDeliveryDate";
            this.txtDeliveryDate.ReadOnly = true;
            this.txtDeliveryDate.Size = new System.Drawing.Size(139, 20);
            this.txtDeliveryDate.TabIndex = 7;
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Location = new System.Drawing.Point(373, 412);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.ReadOnly = true;
            this.txtTotalCost.Size = new System.Drawing.Size(139, 20);
            this.txtTotalCost.TabIndex = 9;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(251, 411);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(97, 18);
            this.lblTotalCost.TabIndex = 8;
            this.lblTotalCost.Text = "Total Cost: ";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(555, 141);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 10;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // frmTinasCustomTees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.txtTotalCost);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.txtDeliveryDate);
            this.Controls.Add(this.lblDeliveryDate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblHeader);
            this.Name = "frmTinasCustomTees";
            this.Text = "Tina\'s Custom Tees";
            this.Load += new System.EventHandler(this.frmTinasCustomTees_Load);
            this.groupColor.ResumeLayout(false);
            this.groupColor.PerformLayout();
            this.groupSize.ResumeLayout(false);
            this.groupSize.PerformLayout();
            this.groupQuantity.ResumeLayout(false);
            this.groupQuantity.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox groupColor;
        private System.Windows.Forms.RadioButton radioColorWhite;
        private System.Windows.Forms.RadioButton radioColorRed;
        private System.Windows.Forms.RadioButton radioColorBlue;
        private System.Windows.Forms.GroupBox groupSize;
        private System.Windows.Forms.RadioButton radioSizeLarge;
        private System.Windows.Forms.RadioButton radioSizeMedium;
        private System.Windows.Forms.RadioButton radioSizeSmall;
        private System.Windows.Forms.GroupBox groupQuantity;
        private System.Windows.Forms.RadioButton radioQuantityHundred;
        private System.Windows.Forms.RadioButton radioQuantityTen;
        private System.Windows.Forms.RadioButton radioQuantityOne;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDeliveryDate;
        private System.Windows.Forms.TextBox txtDeliveryDate;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}

