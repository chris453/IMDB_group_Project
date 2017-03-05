namespace A3Q1
{
    partial class addtoListForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.listDGV = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(634, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Which list would you like to add to?";
            // 
            // listDGV
            // 
            this.listDGV.AllowDrop = true;
            this.listDGV.AllowUserToAddRows = false;
            this.listDGV.AllowUserToDeleteRows = false;
            this.listDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.listDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listDGV.Dock = System.Windows.Forms.DockStyle.Top;
            this.listDGV.Location = new System.Drawing.Point(0, 84);
            this.listDGV.Name = "listDGV";
            this.listDGV.ReadOnly = true;
            this.listDGV.RowTemplate.Height = 33;
            this.listDGV.Size = new System.Drawing.Size(819, 620);
            this.listDGV.TabIndex = 1;
            this.listDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listDGV_CellContentClick);
            this.listDGV.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listDGV_CellContentDoubleClick);
            this.listDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listDGV_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(545, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "movie name goes here";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(0, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(415, 42);
            this.label3.TabIndex = 3;
            this.label3.Text = "- Double click to select";
            // 
            // addtoListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 669);
            this.Controls.Add(this.listDGV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "addtoListForm";
            this.Text = "addtoListForm";
            ((System.ComponentModel.ISupportInitialize)(this.listDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView listDGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}