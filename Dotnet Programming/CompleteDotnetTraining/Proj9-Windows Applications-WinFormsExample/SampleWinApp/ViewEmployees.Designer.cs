namespace SampleWinApp
{
    partial class ViewEmployees
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
            this.grdEmployees = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // grdEmployees
            // 
            this.grdEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdEmployees.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grdEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEmployees.Location = new System.Drawing.Point(13, 98);
            this.grdEmployees.Name = "grdEmployees";
            this.grdEmployees.ReadOnly = true;
            this.grdEmployees.ShowEditingIcon = false;
            this.grdEmployees.Size = new System.Drawing.Size(786, 348);
            this.grdEmployees.TabIndex = 0;
            this.grdEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdEmployees_CellContentClick);
            this.grdEmployees.SelectionChanged += new System.EventHandler(this.grdEmployees_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(275, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "List of Employees";
            // 
            // ViewEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grdEmployees);
            this.Name = "ViewEmployees";
            this.Text = "ViewEmployees";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewEmployees_FormClosed);
            this.Load += new System.EventHandler(this.ViewEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdEmployees;
        private System.Windows.Forms.Label label2;
    }
}