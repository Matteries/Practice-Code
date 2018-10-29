namespace Calculator
{
    partial class CalculatorTemp
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
            this.button0 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttondot = new System.Windows.Forms.Button();
            this.buttonplus = new System.Windows.Forms.Button();
            this.buttonminus = new System.Windows.Forms.Button();
            this.buttonequals = new System.Windows.Forms.Button();
            this.buttonc = new System.Windows.Forms.Button();
            this.buttonce = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttontimes = new System.Windows.Forms.Button();
            this.buttondivide = new System.Windows.Forms.Button();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.currentOperation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(12, 407);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(171, 77);
            this.button0.TabIndex = 0;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.number_click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 77);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.number_click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(100, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 77);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.number_click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(188, 324);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 77);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.number_click);
            // 
            // buttondot
            // 
            this.buttondot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondot.Location = new System.Drawing.Point(189, 407);
            this.buttondot.Name = "buttondot";
            this.buttondot.Size = new System.Drawing.Size(83, 77);
            this.buttondot.TabIndex = 4;
            this.buttondot.Text = ".";
            this.buttondot.UseVisualStyleBackColor = true;
            this.buttondot.Click += new System.EventHandler(this.number_click);
            // 
            // buttonplus
            // 
            this.buttonplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonplus.Location = new System.Drawing.Point(278, 407);
            this.buttonplus.Name = "buttonplus";
            this.buttonplus.Size = new System.Drawing.Size(79, 77);
            this.buttonplus.TabIndex = 5;
            this.buttonplus.Text = "+";
            this.buttonplus.UseVisualStyleBackColor = true;
            this.buttonplus.Click += new System.EventHandler(this.operator_click);
            // 
            // buttonminus
            // 
            this.buttonminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonminus.Location = new System.Drawing.Point(277, 324);
            this.buttonminus.Name = "buttonminus";
            this.buttonminus.Size = new System.Drawing.Size(79, 77);
            this.buttonminus.TabIndex = 6;
            this.buttonminus.Text = "-";
            this.buttonminus.UseVisualStyleBackColor = true;
            this.buttonminus.Click += new System.EventHandler(this.operator_click);
            // 
            // buttonequals
            // 
            this.buttonequals.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonequals.Location = new System.Drawing.Point(362, 324);
            this.buttonequals.Name = "buttonequals";
            this.buttonequals.Size = new System.Drawing.Size(79, 160);
            this.buttonequals.TabIndex = 7;
            this.buttonequals.Text = "=";
            this.buttonequals.UseVisualStyleBackColor = true;
            this.buttonequals.Click += new System.EventHandler(this.buttonequals_Click);
            // 
            // buttonc
            // 
            this.buttonc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonc.Location = new System.Drawing.Point(362, 241);
            this.buttonc.Name = "buttonc";
            this.buttonc.Size = new System.Drawing.Size(79, 77);
            this.buttonc.TabIndex = 8;
            this.buttonc.Text = "C";
            this.buttonc.UseVisualStyleBackColor = true;
            this.buttonc.Click += new System.EventHandler(this.clear_Values);
            // 
            // buttonce
            // 
            this.buttonce.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonce.Location = new System.Drawing.Point(362, 158);
            this.buttonce.Name = "buttonce";
            this.buttonce.Size = new System.Drawing.Size(79, 77);
            this.buttonce.TabIndex = 9;
            this.buttonce.Text = "CE";
            this.buttonce.UseVisualStyleBackColor = true;
            this.buttonce.Click += new System.EventHandler(this.clearentry_Values);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(12, 241);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 77);
            this.button4.TabIndex = 10;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.number_click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(99, 241);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(83, 77);
            this.button5.TabIndex = 11;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.number_click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(188, 241);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(83, 77);
            this.button6.TabIndex = 12;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.number_click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(12, 158);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(83, 77);
            this.button7.TabIndex = 13;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.number_click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(99, 158);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(83, 77);
            this.button8.TabIndex = 14;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.number_click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(188, 158);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(83, 77);
            this.button9.TabIndex = 15;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.number_click);
            // 
            // buttontimes
            // 
            this.buttontimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttontimes.Location = new System.Drawing.Point(278, 241);
            this.buttontimes.Name = "buttontimes";
            this.buttontimes.Size = new System.Drawing.Size(79, 77);
            this.buttontimes.TabIndex = 16;
            this.buttontimes.Text = "*";
            this.buttontimes.UseVisualStyleBackColor = true;
            this.buttontimes.Click += new System.EventHandler(this.operator_click);
            // 
            // buttondivide
            // 
            this.buttondivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondivide.Location = new System.Drawing.Point(277, 158);
            this.buttondivide.Name = "buttondivide";
            this.buttondivide.Size = new System.Drawing.Size(79, 77);
            this.buttondivide.TabIndex = 17;
            this.buttondivide.Text = "/";
            this.buttondivide.UseVisualStyleBackColor = true;
            this.buttondivide.Click += new System.EventHandler(this.operator_click);
            // 
            // textBox_Result
            // 
            this.textBox_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Result.Location = new System.Drawing.Point(12, 76);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.Size = new System.Drawing.Size(429, 38);
            this.textBox_Result.TabIndex = 18;
            this.textBox_Result.Text = "0";
            this.textBox_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // currentOperation
            // 
            this.currentOperation.AutoSize = true;
            this.currentOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentOperation.Location = new System.Drawing.Point(12, 49);
            this.currentOperation.Name = "currentOperation";
            this.currentOperation.Size = new System.Drawing.Size(0, 24);
            this.currentOperation.TabIndex = 19;
            // 
            // CalculatorTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 493);
            this.Controls.Add(this.currentOperation);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.buttondivide);
            this.Controls.Add(this.buttontimes);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonce);
            this.Controls.Add(this.buttonc);
            this.Controls.Add(this.buttonequals);
            this.Controls.Add(this.buttonminus);
            this.Controls.Add(this.buttonplus);
            this.Controls.Add(this.buttondot);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button0);
            this.Name = "CalculatorTemp";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttondot;
        private System.Windows.Forms.Button buttonplus;
        private System.Windows.Forms.Button buttonminus;
        private System.Windows.Forms.Button buttonequals;
        private System.Windows.Forms.Button buttonc;
        private System.Windows.Forms.Button buttonce;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttontimes;
        private System.Windows.Forms.Button buttondivide;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Label currentOperation;
    }
}

