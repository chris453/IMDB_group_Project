namespace A3Q1
{
    partial class ListPage
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listDGV = new System.Windows.Forms.DataGridView();
            this.movieDGV = new System.Windows.Forms.DataGridView();
            this.statsPanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.mailPB = new System.Windows.Forms.PictureBox();
            this.twtrPB = new System.Windows.Forms.PictureBox();
            this.igPB = new System.Windows.Forms.PictureBox();
            this.fbPB = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.listDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDGV)).BeginInit();
            this.statsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mailPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twtrPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fbPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "My Lists";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(0, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(424, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "From this page, you can look at the great lists you\'ve made.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(0, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(324, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "To create a list, click the \"Create List\" button.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(0, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(657, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "To add a movie to a list, search for that movie and click the widget on its page " +
    "to add to a list.";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // listDGV
            // 
            this.listDGV.AllowDrop = true;
            this.listDGV.AllowUserToAddRows = false;
            this.listDGV.AllowUserToDeleteRows = false;
            this.listDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listDGV.Dock = System.Windows.Forms.DockStyle.Left;
            this.listDGV.Location = new System.Drawing.Point(21, 225);
            this.listDGV.Margin = new System.Windows.Forms.Padding(2);
            this.listDGV.Name = "listDGV";
            this.listDGV.ReadOnly = true;
            this.listDGV.RowTemplate.Height = 33;
            this.listDGV.Size = new System.Drawing.Size(328, 516);
            this.listDGV.TabIndex = 6;
            this.listDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listDGV_CellContentClick);
            this.listDGV.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listDGV_CellContentClick);
            this.listDGV.DragDrop += new System.Windows.Forms.DragEventHandler(this.listDGV_DragDrop);
            this.listDGV.DragEnter += new System.Windows.Forms.DragEventHandler(this.listDGV_DragEnter);
            this.listDGV.DragOver += new System.Windows.Forms.DragEventHandler(this.listDGV_DragOver);
            // 
            // movieDGV
            // 
            this.movieDGV.AllowUserToAddRows = false;
            this.movieDGV.AllowUserToDeleteRows = false;
            this.movieDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.movieDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movieDGV.Dock = System.Windows.Forms.DockStyle.Left;
            this.movieDGV.Location = new System.Drawing.Point(381, 225);
            this.movieDGV.Margin = new System.Windows.Forms.Padding(2);
            this.movieDGV.Name = "movieDGV";
            this.movieDGV.ReadOnly = true;
            this.movieDGV.RowTemplate.Height = 33;
            this.movieDGV.Size = new System.Drawing.Size(321, 516);
            this.movieDGV.TabIndex = 7;
            this.movieDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.movieDGV_CellContentClick);
            this.movieDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.movieDGV_CellDoubleClick);
            this.movieDGV.MouseDown += new System.Windows.Forms.MouseEventHandler(this.movieDGV_MouseDown);
            this.movieDGV.MouseMove += new System.Windows.Forms.MouseEventHandler(this.movieDGV_MouseMove);
            // 
            // statsPanel
            // 
            this.statsPanel.AutoScroll = true;
            this.statsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statsPanel.Controls.Add(this.button3);
            this.statsPanel.Controls.Add(this.button2);
            this.statsPanel.Controls.Add(this.mailPB);
            this.statsPanel.Controls.Add(this.twtrPB);
            this.statsPanel.Controls.Add(this.igPB);
            this.statsPanel.Controls.Add(this.fbPB);
            this.statsPanel.Controls.Add(this.button1);
            this.statsPanel.Controls.Add(this.label7);
            this.statsPanel.Controls.Add(this.pictureBox5);
            this.statsPanel.Controls.Add(this.pictureBox4);
            this.statsPanel.Controls.Add(this.pictureBox3);
            this.statsPanel.Controls.Add(this.pictureBox2);
            this.statsPanel.Controls.Add(this.pictureBox1);
            this.statsPanel.Controls.Add(this.label6);
            this.statsPanel.Controls.Add(this.label5);
            this.statsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.statsPanel.Location = new System.Drawing.Point(734, 225);
            this.statsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.statsPanel.Name = "statsPanel";
            this.statsPanel.Size = new System.Drawing.Size(299, 516);
            this.statsPanel.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(21, 259);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(220, 31);
            this.button3.TabIndex = 20;
            this.button3.Text = "Delete List";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 31);
            this.button2.TabIndex = 19;
            this.button2.Text = "Remove Movie";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mailPB
            // 
            this.mailPB.Image = global::A3Q1.Properties.Resources.mail_logo;
            this.mailPB.Location = new System.Drawing.Point(191, 150);
            this.mailPB.Margin = new System.Windows.Forms.Padding(2);
            this.mailPB.Name = "mailPB";
            this.mailPB.Size = new System.Drawing.Size(50, 46);
            this.mailPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mailPB.TabIndex = 18;
            this.mailPB.TabStop = false;
            this.mailPB.Click += new System.EventHandler(this.mailPB_Click);
            // 
            // twtrPB
            // 
            this.twtrPB.Image = global::A3Q1.Properties.Resources.twtr_logo;
            this.twtrPB.Location = new System.Drawing.Point(134, 150);
            this.twtrPB.Margin = new System.Windows.Forms.Padding(2);
            this.twtrPB.Name = "twtrPB";
            this.twtrPB.Size = new System.Drawing.Size(50, 46);
            this.twtrPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.twtrPB.TabIndex = 17;
            this.twtrPB.TabStop = false;
            this.twtrPB.Click += new System.EventHandler(this.twtrPB_Click);
            // 
            // igPB
            // 
            this.igPB.Image = global::A3Q1.Properties.Resources.ig_logo;
            this.igPB.Location = new System.Drawing.Point(78, 150);
            this.igPB.Margin = new System.Windows.Forms.Padding(2);
            this.igPB.Name = "igPB";
            this.igPB.Size = new System.Drawing.Size(50, 46);
            this.igPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.igPB.TabIndex = 16;
            this.igPB.TabStop = false;
            this.igPB.Click += new System.EventHandler(this.igPB_Click);
            // 
            // fbPB
            // 
            this.fbPB.Image = global::A3Q1.Properties.Resources.fb_logo;
            this.fbPB.Location = new System.Drawing.Point(20, 150);
            this.fbPB.Margin = new System.Windows.Forms.Padding(2);
            this.fbPB.Name = "fbPB";
            this.fbPB.Size = new System.Drawing.Size(50, 46);
            this.fbPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fbPB.TabIndex = 15;
            this.fbPB.TabStop = false;
            this.fbPB.Click += new System.EventHandler(this.fbPB_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 31);
            this.button1.TabIndex = 9;
            this.button1.Text = "Create List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 122);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 26);
            this.label7.TabIndex = 14;
            this.label7.Text = "Share:";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::A3Q1.Properties.Resources.goldStar;
            this.pictureBox5.Location = new System.Drawing.Point(195, 68);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 45);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::A3Q1.Properties.Resources.goldStar;
            this.pictureBox4.Location = new System.Drawing.Point(152, 68);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 45);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::A3Q1.Properties.Resources.goldStar;
            this.pictureBox3.Location = new System.Drawing.Point(108, 68);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::A3Q1.Properties.Resources.goldStar;
            this.pictureBox2.Location = new System.Drawing.Point(64, 68);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::A3Q1.Properties.Resources.goldStar;
            this.pictureBox1.Location = new System.Drawing.Point(21, 68);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 40);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 26);
            this.label6.TabIndex = 1;
            this.label6.Text = "Friend\'s Rating:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 2);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "List Statistics:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label8.Location = new System.Drawing.Point(0, 187);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(678, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "To quickly add a movie from one list to another, simply drag the movie onto the l" +
    "ist you want it in!";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(702, 225);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(32, 516);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 225);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(21, 516);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(349, 225);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(32, 516);
            this.panel3.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 207);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1137, 18);
            this.panel4.TabIndex = 12;
            // 
            // ListPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 741);
            this.Controls.Add(this.statsPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.movieDGV);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.listDGV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "ListPage";
            this.Text = "ListPage";
            this.Load += new System.EventHandler(this.ListPage_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.listDGV, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.movieDGV, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.statsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.listDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDGV)).EndInit();
            this.statsPanel.ResumeLayout(false);
            this.statsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mailPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twtrPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fbPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView listDGV;
        private System.Windows.Forms.DataGridView movieDGV;
        private System.Windows.Forms.Panel statsPanel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox mailPB;
        private System.Windows.Forms.PictureBox twtrPB;
        private System.Windows.Forms.PictureBox igPB;
        private System.Windows.Forms.PictureBox fbPB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}