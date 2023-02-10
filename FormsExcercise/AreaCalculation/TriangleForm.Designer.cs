namespace CalculateArea
{
    partial class TriangleForm
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
            this.lengthALbl = new System.Windows.Forms.Label();
            this.lengthBLbl = new System.Windows.Forms.Label();
            this.lengthCLbl = new System.Windows.Forms.Label();
            this.lengthATxt = new System.Windows.Forms.TextBox();
            this.lengthBTxt = new System.Windows.Forms.TextBox();
            this.lengthCTxt = new System.Windows.Forms.TextBox();
            this.resultsLbl = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(622, 380);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(142, 44);
            this.returnButton.TabIndex = 1;
            this.returnButton.Text = "Return to Menu";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // lengthALbl
            // 
            this.lengthALbl.AutoSize = true;
            this.lengthALbl.Location = new System.Drawing.Point(141, 42);
            this.lengthALbl.Name = "lengthALbl";
            this.lengthALbl.Size = new System.Drawing.Size(84, 13);
            this.lengthALbl.TabIndex = 3;
            this.lengthALbl.Text = "Length of side A";
            // 
            // lengthBLbl
            // 
            this.lengthBLbl.AutoSize = true;
            this.lengthBLbl.Location = new System.Drawing.Point(141, 81);
            this.lengthBLbl.Name = "lengthBLbl";
            this.lengthBLbl.Size = new System.Drawing.Size(84, 13);
            this.lengthBLbl.TabIndex = 4;
            this.lengthBLbl.Text = "Length of side B";
            // 
            // lengthCLbl
            // 
            this.lengthCLbl.AutoSize = true;
            this.lengthCLbl.Location = new System.Drawing.Point(141, 120);
            this.lengthCLbl.Name = "lengthCLbl";
            this.lengthCLbl.Size = new System.Drawing.Size(85, 13);
            this.lengthCLbl.TabIndex = 5;
            this.lengthCLbl.Text = "Length of Size C";
            // 
            // lengthATxt
            // 
            this.lengthATxt.Location = new System.Drawing.Point(281, 42);
            this.lengthATxt.Name = "lengthATxt";
            this.lengthATxt.Size = new System.Drawing.Size(156, 20);
            this.lengthATxt.TabIndex = 7;
            // 
            // lengthBTxt
            // 
            this.lengthBTxt.Location = new System.Drawing.Point(281, 81);
            this.lengthBTxt.Name = "lengthBTxt";
            this.lengthBTxt.Size = new System.Drawing.Size(156, 20);
            this.lengthBTxt.TabIndex = 8;
            // 
            // lengthCTxt
            // 
            this.lengthCTxt.Location = new System.Drawing.Point(281, 120);
            this.lengthCTxt.Name = "lengthCTxt";
            this.lengthCTxt.Size = new System.Drawing.Size(156, 20);
            this.lengthCTxt.TabIndex = 9;
            // 
            // resultsLbl
            // 
            this.resultsLbl.AutoSize = true;
            this.resultsLbl.Location = new System.Drawing.Point(144, 180);
            this.resultsLbl.Name = "resultsLbl";
            this.resultsLbl.Size = new System.Drawing.Size(313, 13);
            this.resultsLbl.TabIndex = 10;
            this.resultsLbl.Text = "Enter the length of each side of the triangle to calculate the area.";
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(500, 42);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(122, 98);
            this.calculateBtn.TabIndex = 11;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // TriangleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.resultsLbl);
            this.Controls.Add(this.lengthCTxt);
            this.Controls.Add(this.lengthBTxt);
            this.Controls.Add(this.lengthATxt);
            this.Controls.Add(this.lengthCLbl);
            this.Controls.Add(this.lengthBLbl);
            this.Controls.Add(this.lengthALbl);
            this.Controls.Add(this.returnButton);
            this.Name = "TriangleForm";
            this.Text = "TriangleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label lengthALbl;
        private System.Windows.Forms.Label lengthBLbl;
        private System.Windows.Forms.Label lengthCLbl;
        private System.Windows.Forms.TextBox lengthATxt;
        private System.Windows.Forms.TextBox lengthBTxt;
        private System.Windows.Forms.TextBox lengthCTxt;
        private System.Windows.Forms.Label resultsLbl;
        private System.Windows.Forms.Button calculateBtn;
    }
}