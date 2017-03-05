namespace A3Q1
{
    partial class mailForm
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
            this.mailPB = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mailPB)).BeginInit();
            this.SuspendLayout();
            // 
            // mailPB
            // 
            this.mailPB.Image = global::A3Q1.Properties.Resources.mail_logo;
            this.mailPB.Location = new System.Drawing.Point(61, 122);
            this.mailPB.Margin = new System.Windows.Forms.Padding(4);
            this.mailPB.Name = "mailPB";
            this.mailPB.Size = new System.Drawing.Size(100, 88);
            this.mailPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mailPB.TabIndex = 19;
            this.mailPB.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(390, 51);
            this.label2.TabIndex = 20;
            this.label2.Text = "Friends via email?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(588, 31);
            this.label3.TabIndex = 21;
            this.label3.Text = "Just download the Outlook extension and cc us!";
            // 
            // mailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 380);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mailPB);
            this.Name = "mailForm";
            this.Text = "mailForm";
            this.Controls.SetChildIndex(this.mailPB, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.mailPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mailPB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}