namespace SampleWinApp
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
            this.btnClick = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdDivide = new System.Windows.Forms.RadioButton();
            this.rdMultiply = new System.Windows.Forms.RadioButton();
            this.rdSubtract = new System.Windows.Forms.RadioButton();
            this.rdAdd = new System.Windows.Forms.RadioButton();
            this.txtSecondValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClick
            // 
            this.btnClick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClick.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClick.Location = new System.Drawing.Point(14, 317);
            this.btnClick.Margin = new System.Windows.Forms.Padding(5);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(185, 73);
            this.btnClick.TabIndex = 0;
            this.btnClick.Text = "Click Me!";
            this.btnClick.UseVisualStyleBackColor = false;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.rdDivide);
            this.groupBox1.Controls.Add(this.rdMultiply);
            this.groupBox1.Controls.Add(this.rdSubtract);
            this.groupBox1.Controls.Add(this.rdAdd);
            this.groupBox1.Controls.Add(this.txtSecondValue);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFirstValue);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(48, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 243);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calc Program";
            // 
            // rdDivide
            // 
            this.rdDivide.AutoSize = true;
            this.rdDivide.Location = new System.Drawing.Point(430, 175);
            this.rdDivide.Name = "rdDivide";
            this.rdDivide.Size = new System.Drawing.Size(88, 26);
            this.rdDivide.TabIndex = 7;
            this.rdDivide.TabStop = true;
            this.rdDivide.Text = "Divide";
            this.rdDivide.UseVisualStyleBackColor = true;
            this.rdDivide.Click += new System.EventHandler(this.OnRadio_Clicked);
            // 
            // rdMultiply
            // 
            this.rdMultiply.AutoSize = true;
            this.rdMultiply.Location = new System.Drawing.Point(317, 175);
            this.rdMultiply.Name = "rdMultiply";
            this.rdMultiply.Size = new System.Drawing.Size(108, 26);
            this.rdMultiply.TabIndex = 6;
            this.rdMultiply.TabStop = true;
            this.rdMultiply.Text = "Multiply";
            this.rdMultiply.UseVisualStyleBackColor = true;
            this.rdMultiply.Click += new System.EventHandler(this.OnRadio_Clicked);
            // 
            // rdSubtract
            // 
            this.rdSubtract.AutoSize = true;
            this.rdSubtract.Location = new System.Drawing.Point(204, 175);
            this.rdSubtract.Name = "rdSubtract";
            this.rdSubtract.Size = new System.Drawing.Size(108, 26);
            this.rdSubtract.TabIndex = 5;
            this.rdSubtract.TabStop = true;
            this.rdSubtract.Text = "Subtract";
            this.rdSubtract.UseVisualStyleBackColor = true;
            this.rdSubtract.Click += new System.EventHandler(this.OnRadio_Clicked);
            // 
            // rdAdd
            // 
            this.rdAdd.AutoSize = true;
            this.rdAdd.Location = new System.Drawing.Point(141, 175);
            this.rdAdd.Name = "rdAdd";
            this.rdAdd.Size = new System.Drawing.Size(58, 26);
            this.rdAdd.TabIndex = 4;
            this.rdAdd.TabStop = true;
            this.rdAdd.Text = "Add";
            this.rdAdd.UseVisualStyleBackColor = true;
            this.rdAdd.Click += new System.EventHandler(this.OnRadio_Clicked);
            // 
            // txtSecondValue
            // 
            this.txtSecondValue.Location = new System.Drawing.Point(230, 87);
            this.txtSecondValue.Name = "txtSecondValue";
            this.txtSecondValue.Size = new System.Drawing.Size(284, 30);
            this.txtSecondValue.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Second Value";
            // 
            // txtFirstValue
            // 
            this.txtFirstValue.Location = new System.Drawing.Point(230, 32);
            this.txtFirstValue.Name = "txtFirstValue";
            this.txtFirstValue.Size = new System.Drawing.Size(284, 30);
            this.txtFirstValue.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter First Value";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 404);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClick);
            this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdDivide;
        private System.Windows.Forms.RadioButton rdMultiply;
        private System.Windows.Forms.RadioButton rdSubtract;
        private System.Windows.Forms.RadioButton rdAdd;
        private System.Windows.Forms.TextBox txtSecondValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstValue;
        private System.Windows.Forms.Label label1;
    }
}

