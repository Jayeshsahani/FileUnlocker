
namespace FileUnlocker.Tool
{
    partial class MainForm
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
            this.opfd = new System.Windows.Forms.OpenFileDialog();
            this.txtfilepath = new System.Windows.Forms.TextBox();
            this.btnfileopen = new System.Windows.Forms.Button();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.txtstarttext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkPattern = new System.Windows.Forms.CheckedListBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtmin = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmax = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmax)).BeginInit();
            this.SuspendLayout();
            // 
            // opfd
            // 
            this.opfd.FileName = "openFileDialog1";
            this.opfd.FileOk += new System.ComponentModel.CancelEventHandler(this.opfd_FileOk);
            // 
            // txtfilepath
            // 
            this.txtfilepath.Location = new System.Drawing.Point(12, 25);
            this.txtfilepath.Name = "txtfilepath";
            this.txtfilepath.Size = new System.Drawing.Size(617, 20);
            this.txtfilepath.TabIndex = 0;
            // 
            // btnfileopen
            // 
            this.btnfileopen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnfileopen.ForeColor = System.Drawing.Color.White;
            this.btnfileopen.Location = new System.Drawing.Point(635, 23);
            this.btnfileopen.Name = "btnfileopen";
            this.btnfileopen.Size = new System.Drawing.Size(153, 38);
            this.btnfileopen.TabIndex = 1;
            this.btnfileopen.Text = "Select File";
            this.btnfileopen.UseVisualStyleBackColor = false;
            this.btnfileopen.Click += new System.EventHandler(this.btnfileopen_Click);
            // 
            // rtb
            // 
            this.rtb.Enabled = false;
            this.rtb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rtb.Location = new System.Drawing.Point(351, 108);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(437, 244);
            this.rtb.TabIndex = 2;
            this.rtb.Text = "";
            // 
            // txtstarttext
            // 
            this.txtstarttext.Location = new System.Drawing.Point(13, 67);
            this.txtstarttext.Name = "txtstarttext";
            this.txtstarttext.Size = new System.Drawing.Size(319, 20);
            this.txtstarttext.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Start Text";
            // 
            // chkPattern
            // 
            this.chkPattern.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.chkPattern.FormattingEnabled = true;
            this.chkPattern.Items.AddRange(new object[] {
            "abcdefghijklmnopqrstuvwxyz",
            "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
            "0123456789",
            "~!@#$%^&*()-_=+[]{}\\\\|;:\'\\\"<>,./?*"});
            this.chkPattern.Location = new System.Drawing.Point(15, 108);
            this.chkPattern.Name = "chkPattern";
            this.chkPattern.Size = new System.Drawing.Size(317, 244);
            this.chkPattern.TabIndex = 6;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(701, 358);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(87, 36);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtmin
            // 
            this.txtmin.Location = new System.Drawing.Point(384, 68);
            this.txtmin.Name = "txtmin";
            this.txtmin.Size = new System.Drawing.Size(153, 20);
            this.txtmin.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(348, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 9;
            // 
            // txtmax
            // 
            this.txtmax.Location = new System.Drawing.Point(606, 67);
            this.txtmax.Name = "txtmax";
            this.txtmax.Size = new System.Drawing.Size(153, 20);
            this.txtmax.TabIndex = 10;
            this.txtmax.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Min :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(561, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Max :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 406);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmax);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmin);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.chkPattern);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtstarttext);
            this.Controls.Add(this.rtb);
            this.Controls.Add(this.btnfileopen);
            this.Controls.Add(this.txtfilepath);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Unlocker";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog opfd;
        private System.Windows.Forms.TextBox txtfilepath;
        private System.Windows.Forms.Button btnfileopen;
        private System.Windows.Forms.RichTextBox rtb;
        private System.Windows.Forms.TextBox txtstarttext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox chkPattern;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown txtmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtmax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

