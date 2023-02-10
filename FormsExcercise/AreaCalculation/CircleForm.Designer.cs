namespace CalculateArea
{
    partial class CircleForm
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
            this.returnButton = new System.Windows.Forms.Button();
            this.valueLbl = new System.Windows.Forms.Label();
            this.isRadiusChk = new System.Windows.Forms.CheckBox();
            this.valueTxt = new System.Windows.Forms.TextBox();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.resultsLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(631, 384);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(142, 44);
            this.returnButton.TabIndex = 1;
            this.returnButton.Text = "Return to Menu";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // valueLbl
            // 
            this.valueLbl.AutoSize = true;
            this.valueLbl.Location = new System.Drawing.Point(209, 80);
            this.valueLbl.Name = "valueLbl";
            this.valueLbl.Size = new System.Drawing.Size(65, 13);
            this.valueLbl.TabIndex = 2;
            this.valueLbl.Text = "Enter Value:";
            // 
            // isRadiusChk
            // 
            this.isRadiusChk.AutoSize = true;
            this.isRadiusChk.Location = new System.Drawing.Point(246, 148);
            this.isRadiusChk.Name = "isRadiusChk";
            this.isRadiusChk.Size = new System.Drawing.Size(222, 17);
            this.isRadiusChk.TabIndex = 3;
            this.isRadiusChk.Text = "Radius (Assumes Diameter if Unchecked)";
            this.isRadiusChk.UseVisualStyleBackColor = true;
            // 
            // valueTxt
            // 
            this.valueTxt.Location = new System.Drawing.Point(297, 80);
            this.valueTxt.Name = "valueTxt";
            this.valueTxt.Size = new System.Drawing.Size(171, 20);
            this.valueTxt.TabIndex = 4;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(537, 80);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(133, 85);
            this.calculateBtn.TabIndex = 5;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // resultsLbl
            // 
            this.resultsLbl.AutoSize = true;
            this.resultsLbl.Location = new System.Drawing.Point(212, 211);
            this.resultsLbl.Name = "resultsLbl";
            this.resultsLbl.Size = new System.Drawing.Size(271, 13);
            this.resultsLbl.TabIndex = 6;
            this.resultsLbl.Text = "Enter Value to calculate area. Check box if using radius.";
            // 
            // CircleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultsLbl);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.valueTxt);
            this.Controls.Add(this.isRadiusChk);
            this.Controls.Add(this.valueLbl);
            this.Controls.Add(this.returnButton);
            this.Name = "CircleForm";
            this.Text = "CircleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label valueLbl;
        private System.Windows.Forms.CheckBox isRadiusChk;
        private System.Windows.Forms.TextBox valueTxt;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Label resultsLbl;
    }
}