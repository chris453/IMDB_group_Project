namespace A3Q1
{
    partial class fbForm
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
            this.fbPB = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fbPB)).BeginInit();
            this.SuspendLayout();
            // 
            // fbPB
            // 
            this.fbPB.Image = global::A3Q1.Properties.Resources.fb_logo;
            this.fbPB.Location = new System.Drawing.Point(53, 114);
            this.fbPB.Margin = new System.Windows.Forms.Padding(4);
            this.fbPB.Name = "fbPB";
            this.fbPB.Size = new System.Drawing.Size(100, 88);
            this.fbPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fbPB.TabIndex = 16;
            this.fbPB.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 51);
            this.label2.TabIndex = 17;
            this.label2.Text = "Facebook?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(471, 31);
            this.label3.TabIndex = 18;
            this.label3.Text = "Just like us and download the FB app!";
            // 
            // fbForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 379);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fbPB);
            this.Name = "fbForm";
            this.Text = "fbForm";
            this.Controls.SetChildIndex(this.fbPB, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fbPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox fbPB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}