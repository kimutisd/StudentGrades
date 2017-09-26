namespace StudentsGrades
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
            this.calculationBtn = new System.Windows.Forms.Button();
            this.gradeInput = new System.Windows.Forms.TextBox();
            this.calculatedGrade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculationBtn
            // 
            this.calculationBtn.Location = new System.Drawing.Point(84, 91);
            this.calculationBtn.Name = "calculationBtn";
            this.calculationBtn.Size = new System.Drawing.Size(121, 23);
            this.calculationBtn.TabIndex = 0;
            this.calculationBtn.Text = "Calculate";
            this.calculationBtn.UseVisualStyleBackColor = true;
            this.calculationBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // gradeInput
            // 
            this.gradeInput.Location = new System.Drawing.Point(84, 49);
            this.gradeInput.Name = "gradeInput";
            this.gradeInput.Size = new System.Drawing.Size(121, 20);
            this.gradeInput.TabIndex = 1;
            this.gradeInput.Text = "Put your grade here";
            this.gradeInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gradeInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // calculatedGrade
            // 
            this.calculatedGrade.AutoSize = true;
            this.calculatedGrade.Location = new System.Drawing.Point(120, 144);
            this.calculatedGrade.Name = "calculatedGrade";
            this.calculatedGrade.Size = new System.Drawing.Size(0, 13);
            this.calculatedGrade.TabIndex = 3;
            this.calculatedGrade.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.calculatedGrade);
            this.Controls.Add(this.gradeInput);
            this.Controls.Add(this.calculationBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculationBtn;
        private System.Windows.Forms.TextBox gradeInput;
        private System.Windows.Forms.Label calculatedGrade;
    }
}

