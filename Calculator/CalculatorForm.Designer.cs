namespace Calculator
{
    partial class CalculatorForm
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
            this.calcTextBox = new System.Windows.Forms.TextBox();
            this.btnEquals = new System.Windows.Forms.Button();
            this.operationLabel = new System.Windows.Forms.Label();
            this.btnSum = new Calculator.OperatorButton();
            this.btn0 = new Calculator.NumberButton();
            this.btnDot = new Calculator.NumberButton();
            this.btnSub = new Calculator.OperatorButton();
            this.btn9 = new Calculator.NumberButton();
            this.btn8 = new Calculator.NumberButton();
            this.btn7 = new Calculator.NumberButton();
            this.btnMult = new Calculator.OperatorButton();
            this.btn6 = new Calculator.NumberButton();
            this.btn5 = new Calculator.NumberButton();
            this.btn4 = new Calculator.NumberButton();
            this.btnDiv = new Calculator.OperatorButton();
            this.btn3 = new Calculator.NumberButton();
            this.btn2 = new Calculator.NumberButton();
            this.btn1 = new Calculator.NumberButton();
            this.signBtn = new System.Windows.Forms.Button();
            this.ceBtn = new System.Windows.Forms.Button();
            this.ansBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calcTextBox
            // 
            this.calcTextBox.Font = new System.Drawing.Font("Nirmala UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcTextBox.Location = new System.Drawing.Point(31, 57);
            this.calcTextBox.Name = "calcTextBox";
            this.calcTextBox.ReadOnly = true;
            this.calcTextBox.Size = new System.Drawing.Size(815, 114);
            this.calcTextBox.TabIndex = 0;
            this.calcTextBox.TabStop = false;
            this.calcTextBox.Text = "99";
            this.calcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnEquals
            // 
            this.btnEquals.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEquals.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEquals.Location = new System.Drawing.Point(661, 560);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(185, 66);
            this.btnEquals.TabIndex = 15;
            this.btnEquals.Tag = "=";
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = false;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // operationLabel
            // 
            this.operationLabel.Font = new System.Drawing.Font("Nirmala UI Semilight", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operationLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.operationLabel.Location = new System.Drawing.Point(31, 23);
            this.operationLabel.Name = "operationLabel";
            this.operationLabel.Size = new System.Drawing.Size(815, 31);
            this.operationLabel.TabIndex = 17;
            this.operationLabel.Text = "10 +";
            this.operationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSum
            // 
            this.btnSum.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSum.Location = new System.Drawing.Point(661, 473);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(185, 66);
            this.btnSum.TabIndex = 16;
            this.btnSum.Tag = "+";
            this.btnSum.Text = "+";
            this.btnSum.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(242, 473);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(185, 66);
            this.btn0.TabIndex = 14;
            this.btn0.Tag = "0";
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            // 
            // btnDot
            // 
            this.btnDot.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.Location = new System.Drawing.Point(31, 473);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(185, 66);
            this.btnDot.TabIndex = 13;
            this.btnDot.Tag = ".";
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            // 
            // btnSub
            // 
            this.btnSub.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.Location = new System.Drawing.Point(661, 383);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(185, 66);
            this.btnSub.TabIndex = 12;
            this.btnSub.Tag = "-";
            this.btnSub.Text = "–";
            this.btnSub.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(450, 383);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(185, 66);
            this.btn9.TabIndex = 11;
            this.btn9.Tag = "9";
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(242, 383);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(185, 66);
            this.btn8.TabIndex = 10;
            this.btn8.Tag = "8";
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(31, 383);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(185, 66);
            this.btn7.TabIndex = 9;
            this.btn7.Tag = "7";
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            // 
            // btnMult
            // 
            this.btnMult.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMult.Location = new System.Drawing.Point(661, 293);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(185, 66);
            this.btnMult.TabIndex = 8;
            this.btnMult.Tag = "*";
            this.btnMult.Text = "x";
            this.btnMult.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(450, 293);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(185, 66);
            this.btn6.TabIndex = 7;
            this.btn6.Tag = "6";
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(242, 293);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(185, 66);
            this.btn5.TabIndex = 6;
            this.btn5.Tag = "5";
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(31, 293);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(185, 66);
            this.btn4.TabIndex = 5;
            this.btn4.Tag = "4";
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.Location = new System.Drawing.Point(661, 203);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(185, 66);
            this.btnDiv.TabIndex = 4;
            this.btnDiv.Tag = "/";
            this.btnDiv.Text = "÷";
            this.btnDiv.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(450, 203);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(185, 66);
            this.btn3.TabIndex = 3;
            this.btn3.Tag = "3";
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(242, 203);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(185, 66);
            this.btn2.TabIndex = 2;
            this.btn2.Tag = "2";
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(31, 203);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(185, 66);
            this.btn1.TabIndex = 1;
            this.btn1.Tag = "1";
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // signBtn
            // 
            this.signBtn.BackColor = System.Drawing.SystemColors.Window;
            this.signBtn.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.signBtn.Location = new System.Drawing.Point(450, 473);
            this.signBtn.Name = "signBtn";
            this.signBtn.Size = new System.Drawing.Size(185, 66);
            this.signBtn.TabIndex = 18;
            this.signBtn.Tag = "";
            this.signBtn.Text = "+/–";
            this.signBtn.UseVisualStyleBackColor = false;
            this.signBtn.Click += new System.EventHandler(this.signBtn_Click);
            // 
            // ceBtn
            // 
            this.ceBtn.BackColor = System.Drawing.SystemColors.Window;
            this.ceBtn.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ceBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ceBtn.Location = new System.Drawing.Point(450, 560);
            this.ceBtn.Name = "ceBtn";
            this.ceBtn.Size = new System.Drawing.Size(185, 66);
            this.ceBtn.TabIndex = 19;
            this.ceBtn.Tag = "";
            this.ceBtn.Text = "CE";
            this.ceBtn.UseVisualStyleBackColor = false;
            this.ceBtn.Click += new System.EventHandler(this.ceBtn_Click);
            // 
            // ansBtn
            // 
            this.ansBtn.BackColor = System.Drawing.SystemColors.Window;
            this.ansBtn.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ansBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ansBtn.Location = new System.Drawing.Point(242, 560);
            this.ansBtn.Name = "ansBtn";
            this.ansBtn.Size = new System.Drawing.Size(185, 66);
            this.ansBtn.TabIndex = 20;
            this.ansBtn.Tag = "";
            this.ansBtn.Text = "Ans";
            this.ansBtn.UseVisualStyleBackColor = false;
            this.ansBtn.Click += new System.EventHandler(this.ansBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(31, 560);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 35);
            this.button1.TabIndex = 22;
            this.button1.Tag = "";
            this.button1.Text = "Hecho por...";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 654);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ansBtn);
            this.Controls.Add(this.ceBtn);
            this.Controls.Add(this.signBtn);
            this.Controls.Add(this.operationLabel);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.calcTextBox);
            this.Name = "CalculatorForm";
            this.Text = "MiCalc 1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox calcTextBox;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Label operationLabel;
        private NumberButton btn1;
        private NumberButton btn2;
        private OperatorButton btnDiv;
        private NumberButton btn3;
        private OperatorButton btnMult;
        private NumberButton btn6;
        private NumberButton btn5;
        private NumberButton btn4;
        private OperatorButton btnSum;
        private NumberButton btn0;
        private NumberButton btnDot;
        private OperatorButton btnSub;
        private NumberButton btn9;
        private NumberButton btn8;
        private NumberButton btn7;
        private System.Windows.Forms.Button signBtn;
        private System.Windows.Forms.Button ceBtn;
        private System.Windows.Forms.Button ansBtn;
        private System.Windows.Forms.Button button1;
    }
}

