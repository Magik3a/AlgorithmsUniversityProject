namespace AlgorithmsComputers
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblErrorKBiggerThanN = new System.Windows.Forms.Label();
            this.btnCleanResult = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblErrorN = new System.Windows.Forms.Label();
            this.txtNValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblErrorK = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtCombinationClass = new System.Windows.Forms.TextBox();
            this.lblEnterNumber = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblErrorKBiggerThanN);
            this.panel1.Controls.Add(this.btnCleanResult);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtResult);
            this.panel1.Controls.Add(this.lblErrorN);
            this.panel1.Controls.Add(this.txtNValue);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblErrorK);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.txtCombinationClass);
            this.panel1.Controls.Add(this.lblEnterNumber);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 617);
            this.panel1.TabIndex = 0;
            // 
            // lblErrorKBiggerThanN
            // 
            this.lblErrorKBiggerThanN.AutoSize = true;
            this.lblErrorKBiggerThanN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorKBiggerThanN.ForeColor = System.Drawing.Color.Red;
            this.lblErrorKBiggerThanN.Location = new System.Drawing.Point(49, 169);
            this.lblErrorKBiggerThanN.Name = "lblErrorKBiggerThanN";
            this.lblErrorKBiggerThanN.Size = new System.Drawing.Size(78, 17);
            this.lblErrorKBiggerThanN.TabIndex = 11;
            this.lblErrorKBiggerThanN.Text = "Опа, k > n ";
            // 
            // btnCleanResult
            // 
            this.btnCleanResult.Location = new System.Drawing.Point(390, 193);
            this.btnCleanResult.Name = "btnCleanResult";
            this.btnCleanResult.Size = new System.Drawing.Size(75, 23);
            this.btnCleanResult.TabIndex = 10;
            this.btnCleanResult.Text = "Изчисти";
            this.btnCleanResult.UseVisualStyleBackColor = true;
            this.btnCleanResult.Click += new System.EventHandler(this.btnCleanResult_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Резултат";
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.Moccasin;
            this.txtResult.CausesValidation = false;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtResult.Location = new System.Drawing.Point(49, 222);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(416, 344);
            this.txtResult.TabIndex = 8;
            // 
            // lblErrorN
            // 
            this.lblErrorN.AutoSize = true;
            this.lblErrorN.ForeColor = System.Drawing.Color.Red;
            this.lblErrorN.Location = new System.Drawing.Point(158, 149);
            this.lblErrorN.Name = "lblErrorN";
            this.lblErrorN.Size = new System.Drawing.Size(169, 13);
            this.lblErrorN.TabIndex = 7;
            this.lblErrorN.Text = "Въведената стойност е грешна!";
            // 
            // txtNValue
            // 
            this.txtNValue.Location = new System.Drawing.Point(52, 146);
            this.txtNValue.Name = "txtNValue";
            this.txtNValue.Size = new System.Drawing.Size(100, 20);
            this.txtNValue.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Въведи елементи - n, разделени с \',\'";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 50);
            this.label1.TabIndex = 4;
            this.label1.Text = "Генериране на комбинации без повторение\r\n от к-ти клас на n - елемента";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErrorK
            // 
            this.lblErrorK.AutoSize = true;
            this.lblErrorK.ForeColor = System.Drawing.Color.Red;
            this.lblErrorK.Location = new System.Drawing.Point(158, 96);
            this.lblErrorK.Name = "lblErrorK";
            this.lblErrorK.Size = new System.Drawing.Size(176, 13);
            this.lblErrorK.TabIndex = 3;
            this.lblErrorK.Text = "Въведената стойност не е число!";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(134, 584);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(253, 30);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Run, Forest, Run";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtCombinationClass
            // 
            this.txtCombinationClass.Location = new System.Drawing.Point(52, 93);
            this.txtCombinationClass.Name = "txtCombinationClass";
            this.txtCombinationClass.Size = new System.Drawing.Size(100, 20);
            this.txtCombinationClass.TabIndex = 1;
            // 
            // lblEnterNumber
            // 
            this.lblEnterNumber.AutoSize = true;
            this.lblEnterNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterNumber.Location = new System.Drawing.Point(49, 73);
            this.lblEnterNumber.Name = "lblEnterNumber";
            this.lblEnterNumber.Size = new System.Drawing.Size(230, 17);
            this.lblEnterNumber.TabIndex = 0;
            this.lblEnterNumber.Text = "Въведи клас на комбинацията - k";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 641);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Генериране на комбинации";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEnterNumber;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtCombinationClass;
        private System.Windows.Forms.Label lblErrorK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblErrorN;
        private System.Windows.Forms.TextBox txtNValue;
        private System.Windows.Forms.Button btnCleanResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblErrorKBiggerThanN;
    }
}

