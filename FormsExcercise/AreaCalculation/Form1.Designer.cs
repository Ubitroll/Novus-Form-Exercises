namespace AreaCalculation
{
    partial class Form1
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
            this.menuTextLbl = new System.Windows.Forms.Label();
            this.rectangleBtn = new System.Windows.Forms.Button();
            this.circleBtn = new System.Windows.Forms.Button();
            this.triangleBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuTextLbl
            // 
            this.menuTextLbl.AutoSize = true;
            this.menuTextLbl.Location = new System.Drawing.Point(247, 64);
            this.menuTextLbl.Name = "menuTextLbl";
            this.menuTextLbl.Size = new System.Drawing.Size(271, 13);
            this.menuTextLbl.TabIndex = 0;
            this.menuTextLbl.Text = "Selected which shape you would like to find the area of:";
            // 
            // rectangleBtn
            // 
            this.rectangleBtn.Location = new System.Drawing.Point(171, 191);
            this.rectangleBtn.Name = "rectangleBtn";
            this.rectangleBtn.Size = new System.Drawing.Size(75, 23);
            this.rectangleBtn.TabIndex = 1;
            this.rectangleBtn.Text = "Rectangle";
            this.rectangleBtn.UseVisualStyleBackColor = true;
            this.rectangleBtn.Click += new System.EventHandler(this.rectangleBtn_Click);
            // 
            // circleBtn
            // 
            this.circleBtn.Location = new System.Drawing.Point(333, 191);
            this.circleBtn.Name = "circleBtn";
            this.circleBtn.Size = new System.Drawing.Size(75, 23);
            this.circleBtn.TabIndex = 2;
            this.circleBtn.Text = "Circle";
            this.circleBtn.UseVisualStyleBackColor = true;
            this.circleBtn.Click += new System.EventHandler(this.circleBtn_Click);
            // 
            // triangleBtn
            // 
            this.triangleBtn.Location = new System.Drawing.Point(511, 191);
            this.triangleBtn.Name = "triangleBtn";
            this.triangleBtn.Size = new System.Drawing.Size(75, 23);
            this.triangleBtn.TabIndex = 3;
            this.triangleBtn.Text = "Triangle";
            this.triangleBtn.UseVisualStyleBackColor = true;
            this.triangleBtn.Click += new System.EventHandler(this.triangleBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.triangleBtn);
            this.Controls.Add(this.circleBtn);
            this.Controls.Add(this.rectangleBtn);
            this.Controls.Add(this.menuTextLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label menuTextLbl;
        private System.Windows.Forms.Button rectangleBtn;
        private System.Windows.Forms.Button circleBtn;
        private System.Windows.Forms.Button triangleBtn;
    }
}

