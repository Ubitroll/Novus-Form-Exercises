namespace CalculateArea
{
    partial class RectangleForm
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
            this.heightLbl = new System.Windows.Forms.Label();
            this.widthLbl = new System.Windows.Forms.Label();
            this.heightTxt = new System.Windows.Forms.TextBox();
            this.widthTxt = new System.Windows.Forms.TextBox();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.resultsLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(624, 381);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(142, 44);
            this.returnButton.TabIndex = 1;
            this.returnButton.Text = "Return to Menu";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // heightLbl
            // 
            this.heightLbl.AutoSize = true;
            this.heightLbl.Location = new System.Drawing.Point(161, 64);
            this.heightLbl.Name = "heightLbl";
            this.heightLbl.Size = new System.Drawing.Size(38, 13);
            this.heightLbl.TabIndex = 2;
            this.heightLbl.Text = "Height";
            // 
            // widthLbl
            // 
            this.widthLbl.AutoSize = true;
            this.widthLbl.Location = new System.Drawing.Point(161, 121);
            this.widthLbl.Name = "widthLbl";
            this.widthLbl.Size = new System.Drawing.Size(35, 13);
            this.widthLbl.TabIndex = 3;
            this.widthLbl.Text = "Width";
            // 
            // heightTxt
            // 
            this.heightTxt.Location = new System.Drawing.Point(268, 64);
            this.heightTxt.Name = "heightTxt";
            this.heightTxt.Size = new System.Drawing.Size(148, 20);
            this.heightTxt.TabIndex = 5;
            // 
            // widthTxt
            // 
            this.widthTxt.Location = new System.Drawing.Point(268, 121);
            this.widthTxt.Name = "widthTxt";
            this.widthTxt.Size = new System.Drawing.Size(148, 20);
            this.widthTxt.TabIndex = 6;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(479, 64);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(107, 77);
            this.calculateBtn.TabIndex = 7;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // resultsLbl
            // 
            this.resultsLbl.AutoSize = true;
            this.resultsLbl.Location = new System.Drawing.Point(218, 189);
            this.resultsLbl.Name = "resultsLbl";
            this.resultsLbl.Size = new System.Drawing.Size(256, 13);
            this.resultsLbl.TabIndex = 8;
            this.resultsLbl.Text = "Please enter a height and width to calculate the area";
            // 
            // RectangleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultsLbl);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.widthTxt);
            this.Controls.Add(this.heightTxt);
            this.Controls.Add(this.widthLbl);
            this.Controls.Add(this.heightLbl);
            this.Controls.Add(this.returnButton);
            this.Name = "RectangleForm";
            this.Text = "RectangleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label heightLbl;
        private System.Windows.Forms.Label widthLbl;
        private System.Windows.Forms.TextBox heightTxt;
        private System.Windows.Forms.TextBox widthTxt;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Label resultsLbl;
    }
}