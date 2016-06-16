namespace Calculator
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
            this.btn_calc = new System.Windows.Forms.Button();
            this.pn_opselect = new System.Windows.Forms.Panel();
            this.op_divide = new System.Windows.Forms.RadioButton();
            this.op_times = new System.Windows.Forms.RadioButton();
            this.op_minus = new System.Windows.Forms.RadioButton();
            this.op_plus = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_n1 = new System.Windows.Forms.TextBox();
            this.tb_n2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.pn_opselect.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(201, 120);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(96, 47);
            this.btn_calc.TabIndex = 0;
            this.btn_calc.Text = "Calculate";
            this.btn_calc.UseVisualStyleBackColor = true;
            // 
            // pn_opselect
            // 
            this.pn_opselect.Controls.Add(this.op_divide);
            this.pn_opselect.Controls.Add(this.op_times);
            this.pn_opselect.Controls.Add(this.op_minus);
            this.pn_opselect.Controls.Add(this.op_plus);
            this.pn_opselect.Location = new System.Drawing.Point(232, 17);
            this.pn_opselect.Name = "pn_opselect";
            this.pn_opselect.Size = new System.Drawing.Size(65, 97);
            this.pn_opselect.TabIndex = 1;
            // 
            // op_divide
            // 
            this.op_divide.AutoSize = true;
            this.op_divide.Location = new System.Drawing.Point(4, 75);
            this.op_divide.Name = "op_divide";
            this.op_divide.Size = new System.Drawing.Size(55, 17);
            this.op_divide.TabIndex = 3;
            this.op_divide.TabStop = true;
            this.op_divide.Text = "Divide";
            this.op_divide.UseVisualStyleBackColor = true;
            // 
            // op_times
            // 
            this.op_times.AutoSize = true;
            this.op_times.Location = new System.Drawing.Point(4, 51);
            this.op_times.Name = "op_times";
            this.op_times.Size = new System.Drawing.Size(53, 17);
            this.op_times.TabIndex = 2;
            this.op_times.TabStop = true;
            this.op_times.Text = "Times";
            this.op_times.UseVisualStyleBackColor = true;
            // 
            // op_minus
            // 
            this.op_minus.AutoSize = true;
            this.op_minus.Location = new System.Drawing.Point(4, 27);
            this.op_minus.Name = "op_minus";
            this.op_minus.Size = new System.Drawing.Size(53, 17);
            this.op_minus.TabIndex = 1;
            this.op_minus.TabStop = true;
            this.op_minus.Text = "Minus";
            this.op_minus.UseVisualStyleBackColor = true;
            // 
            // op_plus
            // 
            this.op_plus.AutoSize = true;
            this.op_plus.Location = new System.Drawing.Point(4, 4);
            this.op_plus.Name = "op_plus";
            this.op_plus.Size = new System.Drawing.Size(45, 17);
            this.op_plus.TabIndex = 0;
            this.op_plus.TabStop = true;
            this.op_plus.Text = "Plus";
            this.op_plus.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Number";
            // 
            // tb_n1
            // 
            this.tb_n1.Location = new System.Drawing.Point(104, 13);
            this.tb_n1.Name = "tb_n1";
            this.tb_n1.Size = new System.Drawing.Size(122, 20);
            this.tb_n1.TabIndex = 3;
            // 
            // tb_n2
            // 
            this.tb_n2.Location = new System.Drawing.Point(104, 40);
            this.tb_n2.Name = "tb_n2";
            this.tb_n2.Size = new System.Drawing.Size(122, 20);
            this.tb_n2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Second Number";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(99, 120);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(96, 47);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 179);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_n2);
            this.Controls.Add(this.tb_n1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pn_opselect);
            this.Controls.Add(this.btn_calc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pn_opselect.ResumeLayout(false);
            this.pn_opselect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Panel pn_opselect;
        private System.Windows.Forms.RadioButton op_divide;
        private System.Windows.Forms.RadioButton op_times;
        private System.Windows.Forms.RadioButton op_minus;
        private System.Windows.Forms.RadioButton op_plus;
        private System.Windows.Forms.TextBox tb_n1;
        private System.Windows.Forms.TextBox tb_n2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_clear;
    }
}

