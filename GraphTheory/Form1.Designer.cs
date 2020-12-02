﻿namespace GraphTheory
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.dinh = new System.Windows.Forms.Label();
            this.printPicture = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.start = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDHeadVertex = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbDTailVertex = new System.Windows.Forms.ComboBox();
            this.logShow = new System.Windows.Forms.Label();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.printPicture)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(293, 187);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.StatusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.StatusLbl.Location = new System.Drawing.Point(12, 236);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(0, 16);
            this.StatusLbl.TabIndex = 3;
            // 
            // dinh
            // 
            this.dinh.AutoSize = true;
            this.dinh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dinh.Location = new System.Drawing.Point(360, 34);
            this.dinh.Name = "dinh";
            this.dinh.Size = new System.Drawing.Size(51, 13);
            this.dinh.TabIndex = 4;
            this.dinh.Text = "Số Đinh: ";
            // 
            // printPicture
            // 
            this.printPicture.BackColor = System.Drawing.Color.White;
            this.printPicture.Location = new System.Drawing.Point(363, 50);
            this.printPicture.Name = "printPicture";
            this.printPicture.Size = new System.Drawing.Size(411, 300);
            this.printPicture.TabIndex = 7;
            this.printPicture.TabStop = false;
            this.printPicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.printPicture_MouseMove);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveGraphToolStripMenuItem,
            this.openToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(791, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveGraphToolStripMenuItem
            // 
            this.saveGraphToolStripMenuItem.Name = "saveGraphToolStripMenuItem";
            this.saveGraphToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.saveGraphToolStripMenuItem.Text = "Save Graph";
            this.saveGraphToolStripMenuItem.Click += new System.EventHandler(this.writeGr_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.openToolStripMenuItem.Text = "Open..";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.readGr_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 225);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập ma trận";
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.start.Location = new System.Drawing.Point(18, 307);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(213, 29);
            this.start.TabIndex = 76;
            this.start.Text = "Bắt đầu";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(120, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 75;
            this.label3.Text = "đến đỉnh";
            // 
            // cbDHeadVertex
            // 
            this.cbDHeadVertex.Enabled = false;
            this.cbDHeadVertex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDHeadVertex.FormattingEnabled = true;
            this.cbDHeadVertex.Location = new System.Drawing.Point(69, 268);
            this.cbDHeadVertex.Name = "cbDHeadVertex";
            this.cbDHeadVertex.Size = new System.Drawing.Size(48, 28);
            this.cbDHeadVertex.TabIndex = 74;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(15, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 73;
            this.label5.Text = "Từ đỉnh";
            // 
            // cbDTailVertex
            // 
            this.cbDTailVertex.Enabled = false;
            this.cbDTailVertex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDTailVertex.FormattingEnabled = true;
            this.cbDTailVertex.Location = new System.Drawing.Point(183, 268);
            this.cbDTailVertex.Name = "cbDTailVertex";
            this.cbDTailVertex.Size = new System.Drawing.Size(48, 28);
            this.cbDTailVertex.TabIndex = 72;
            // 
            // logShow
            // 
            this.logShow.AutoSize = true;
            this.logShow.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logShow.Location = new System.Drawing.Point(18, 338);
            this.logShow.Name = "logShow";
            this.logShow.Size = new System.Drawing.Size(31, 16);
            this.logShow.TabIndex = 78;
            this.logShow.Text = "Log";
            // 
            // rtbLog
            // 
            this.rtbLog.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbLog.Location = new System.Drawing.Point(18, 357);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(227, 198);
            this.rtbLog.TabIndex = 77;
            this.rtbLog.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(791, 567);
            this.Controls.Add(this.logShow);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbDHeadVertex);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbDTailVertex);
            this.Controls.Add(this.printPicture);
            this.Controls.Add(this.dinh);
            this.Controls.Add(this.StatusLbl);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "GraphTheory";
            ((System.ComponentModel.ISupportInitialize)(this.printPicture)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label StatusLbl;
        private System.Windows.Forms.Label dinh;
        public System.Windows.Forms.PictureBox printPicture;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveGraphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cbDHeadVertex;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cbDTailVertex;
        private System.Windows.Forms.Label logShow;
        public System.Windows.Forms.RichTextBox rtbLog;
    }
}

