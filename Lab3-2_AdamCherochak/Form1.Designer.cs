namespace Lab3_2_AdamCherochak
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.txtBox_UserInput = new System.Windows.Forms.TextBox();
            this.lbl_DisplayResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.picBox_PrimeOrNot = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_PrimeOrNot)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_Title.Location = new System.Drawing.Point(12, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(192, 24);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Is It A Prime Number?";
            // 
            // txtBox_UserInput
            // 
            this.txtBox_UserInput.Location = new System.Drawing.Point(16, 61);
            this.txtBox_UserInput.Name = "txtBox_UserInput";
            this.txtBox_UserInput.Size = new System.Drawing.Size(157, 20);
            this.txtBox_UserInput.TabIndex = 0;
            this.txtBox_UserInput.Text = "Enter a Number";
            // 
            // lbl_DisplayResult
            // 
            this.lbl_DisplayResult.AutoSize = true;
            this.lbl_DisplayResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DisplayResult.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_DisplayResult.Location = new System.Drawing.Point(55, 99);
            this.lbl_DisplayResult.Name = "lbl_DisplayResult";
            this.lbl_DisplayResult.Size = new System.Drawing.Size(138, 20);
            this.lbl_DisplayResult.TabIndex = 2;
            this.lbl_DisplayResult.Text = "Prime? Let\'s see...";
            this.lbl_DisplayResult.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(118, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Test If Prime";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(221, 166);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // picBox_PrimeOrNot
            // 
            this.picBox_PrimeOrNot.Location = new System.Drawing.Point(16, 95);
            this.picBox_PrimeOrNot.Name = "picBox_PrimeOrNot";
            this.picBox_PrimeOrNot.Size = new System.Drawing.Size(33, 28);
            this.picBox_PrimeOrNot.TabIndex = 6;
            this.picBox_PrimeOrNot.TabStop = false;
            this.picBox_PrimeOrNot.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 201);
            this.Controls.Add(this.picBox_PrimeOrNot);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_DisplayResult);
            this.Controls.Add(this.txtBox_UserInput);
            this.Controls.Add(this.lbl_Title);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_PrimeOrNot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.TextBox txtBox_UserInput;
        private System.Windows.Forms.Label lbl_DisplayResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox picBox_PrimeOrNot;
    }
}

