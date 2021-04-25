
namespace Game
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
            this.btnStart = new System.Windows.Forms.Button();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.lblWarning = new System.Windows.Forms.Label();
            this.pnlBox = new System.Windows.Forms.Panel();
            this.lblMaxAttempts = new System.Windows.Forms.Label();
            this.lblMaxAttemptNo = new System.Windows.Forms.Label();
            this.lblCrntAttempts = new System.Windows.Forms.Label();
            this.lblCrntAttemptNo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lstGamers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstScores = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(115, 270);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(178, 57);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtWord
            // 
            this.txtWord.Enabled = false;
            this.txtWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWord.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtWord.Location = new System.Drawing.Point(67, 59);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(281, 35);
            this.txtWord.TabIndex = 1;
            this.txtWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(40, 233);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(68, 17);
            this.lblWarning.TabIndex = 3;
            this.lblWarning.Text = "Warning";
            this.lblWarning.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblWarning.Visible = false;
            // 
            // pnlBox
            // 
            this.pnlBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBox.Location = new System.Drawing.Point(55, 172);
            this.pnlBox.Name = "pnlBox";
            this.pnlBox.Size = new System.Drawing.Size(293, 58);
            this.pnlBox.TabIndex = 4;
            // 
            // lblMaxAttempts
            // 
            this.lblMaxAttempts.AutoSize = true;
            this.lblMaxAttempts.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxAttempts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblMaxAttempts.Location = new System.Drawing.Point(38, 97);
            this.lblMaxAttempts.Name = "lblMaxAttempts";
            this.lblMaxAttempts.Size = new System.Drawing.Size(268, 31);
            this.lblMaxAttempts.TabIndex = 5;
            this.lblMaxAttempts.Text = "Maximum Attempts ";
            // 
            // lblMaxAttemptNo
            // 
            this.lblMaxAttemptNo.AutoSize = true;
            this.lblMaxAttemptNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxAttemptNo.ForeColor = System.Drawing.Color.Navy;
            this.lblMaxAttemptNo.Location = new System.Drawing.Point(328, 97);
            this.lblMaxAttemptNo.Name = "lblMaxAttemptNo";
            this.lblMaxAttemptNo.Size = new System.Drawing.Size(92, 31);
            this.lblMaxAttemptNo.TabIndex = 6;
            this.lblMaxAttemptNo.Text = "label1";
            // 
            // lblCrntAttempts
            // 
            this.lblCrntAttempts.AutoSize = true;
            this.lblCrntAttempts.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrntAttempts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblCrntAttempts.Location = new System.Drawing.Point(38, 128);
            this.lblCrntAttempts.Name = "lblCrntAttempts";
            this.lblCrntAttempts.Size = new System.Drawing.Size(284, 31);
            this.lblCrntAttempts.TabIndex = 7;
            this.lblCrntAttempts.Text = "Remaining Attempts ";
            this.lblCrntAttempts.Visible = false;
            // 
            // lblCrntAttemptNo
            // 
            this.lblCrntAttemptNo.AutoSize = true;
            this.lblCrntAttemptNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrntAttemptNo.ForeColor = System.Drawing.Color.Navy;
            this.lblCrntAttemptNo.Location = new System.Drawing.Point(328, 128);
            this.lblCrntAttemptNo.Name = "lblCrntAttemptNo";
            this.lblCrntAttemptNo.Size = new System.Drawing.Size(92, 31);
            this.lblCrntAttemptNo.TabIndex = 8;
            this.lblCrntAttemptNo.Text = "label1";
            this.lblCrntAttemptNo.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Purple;
            this.lblName.Location = new System.Drawing.Point(80, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(268, 31);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Maximum Attempts ";
            // 
            // lstGamers
            // 
            this.lstGamers.BackColor = System.Drawing.Color.LightCyan;
            this.lstGamers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lstGamers.FormattingEnabled = true;
            this.lstGamers.ItemHeight = 15;
            this.lstGamers.Location = new System.Drawing.Point(556, 206);
            this.lstGamers.Name = "lstGamers";
            this.lstGamers.Size = new System.Drawing.Size(215, 199);
            this.lstGamers.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(550, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Top Scorers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(554, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 31);
            this.label2.TabIndex = 15;
            this.label2.Text = "Scores";
            // 
            // lstScores
            // 
            this.lstScores.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lstScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lstScores.FormattingEnabled = true;
            this.lstScores.ItemHeight = 15;
            this.lstScores.Location = new System.Drawing.Point(556, 38);
            this.lstScores.Name = "lstScores";
            this.lstScores.Size = new System.Drawing.Size(167, 109);
            this.lstScores.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstScores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstGamers);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCrntAttemptNo);
            this.Controls.Add(this.lblCrntAttempts);
            this.Controls.Add(this.lblMaxAttemptNo);
            this.Controls.Add(this.lblMaxAttempts);
            this.Controls.Add(this.pnlBox);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Panel pnlBox;
        private System.Windows.Forms.Label lblMaxAttempts;
        private System.Windows.Forms.Label lblMaxAttemptNo;
        private System.Windows.Forms.Label lblCrntAttempts;
        private System.Windows.Forms.Label lblCrntAttemptNo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ListBox lstGamers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstScores;
    }
}

