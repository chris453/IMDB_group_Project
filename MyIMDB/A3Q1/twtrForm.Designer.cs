namespace A3Q1
{
    partial class twtrForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.twtrPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.twtrPB)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(619, 31);
            this.label3.TabIndex = 20;
            this.label3.Text = "Just follow us and download the Twitter extension!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 51);
            this.label2.TabIndex = 19;
            this.label2.Text = "Twitter?";
            // 
            // twtrPB
            // 
            this.twtrPB.Image = global::A3Q1.Properties.Resources.twtr_logo;
            this.twtrPB.Location = new System.Drawing.Point(59, 114);
            this.twtrPB.Margin = new System.Windows.Forms.Padding(4);
            this.twtrPB.Name = "twtrPB";
            this.twtrPB.Size = new System.Drawing.Size(100, 88);
            this.twtrPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.twtrPB.TabIndex = 21;
            this.twtrPB.TabStop = false;
            // 
            // twtrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 380);
            this.Controls.Add(this.twtrPB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "twtrForm";
            this.Text = "twtrForm";
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.twtrPB, 0);
            ((System.ComponentModel.ISupportInitialize)(this.twtrPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox twtrPB;
    }
}