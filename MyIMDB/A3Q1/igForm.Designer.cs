namespace A3Q1
{
    partial class igForm
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
            this.igPB = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.igPB)).BeginInit();
            this.SuspendLayout();
            // 
            // igPB
            // 
            this.igPB.Image = global::A3Q1.Properties.Resources.ig_logo;
            this.igPB.Location = new System.Drawing.Point(68, 115);
            this.igPB.Margin = new System.Windows.Forms.Padding(4);
            this.igPB.Name = "igPB";
            this.igPB.Size = new System.Drawing.Size(100, 88);
            this.igPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.igPB.TabIndex = 17;
            this.igPB.TabStop = false;
            this.igPB.Click += new System.EventHandler(this.igPB_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 51);
            this.label2.TabIndex = 18;
            this.label2.Text = "Instagram?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(521, 31);
            this.label3.TabIndex = 19;
            this.label3.Text = "Just follow us and download the IG plugin!";
            // 
            // igForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 380);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.igPB);
            this.Name = "igForm";
            this.Text = "igForm";
            this.Controls.SetChildIndex(this.igPB, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.igPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox igPB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}