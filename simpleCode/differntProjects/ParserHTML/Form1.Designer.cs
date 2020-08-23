namespace ParserHTML {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbStart = new System.Windows.Forms.Label();
            this.numericStart = new System.Windows.Forms.NumericUpDown();
            this.numericEnd = new System.Windows.Forms.NumericUpDown();
            this.lbEnd = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnAbort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(8, 16);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(454, 420);
            this.listBox1.TabIndex = 0;
            // 
            // lbStart
            // 
            this.lbStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbStart.AutoSize = true;
            this.lbStart.Location = new System.Drawing.Point(480, 16);
            this.lbStart.Name = "lbStart";
            this.lbStart.Size = new System.Drawing.Size(73, 17);
            this.lbStart.TabIndex = 1;
            this.lbStart.Text = "Start point";
            // 
            // numericStart
            // 
            this.numericStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericStart.Location = new System.Drawing.Point(483, 46);
            this.numericStart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericStart.Name = "numericStart";
            this.numericStart.Size = new System.Drawing.Size(89, 22);
            this.numericStart.TabIndex = 2;
            this.numericStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericEnd
            // 
            this.numericEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericEnd.Location = new System.Drawing.Point(483, 118);
            this.numericEnd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericEnd.Name = "numericEnd";
            this.numericEnd.Size = new System.Drawing.Size(89, 22);
            this.numericEnd.TabIndex = 4;
            this.numericEnd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbEnd
            // 
            this.lbEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbEnd.AutoSize = true;
            this.lbEnd.Location = new System.Drawing.Point(480, 89);
            this.lbEnd.Name = "lbEnd";
            this.lbEnd.Size = new System.Drawing.Size(68, 17);
            this.lbEnd.TabIndex = 3;
            this.lbEnd.Text = "End point";
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(483, 185);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnAbort
            // 
            this.btnAbort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbort.Location = new System.Drawing.Point(483, 226);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(75, 23);
            this.btnAbort.TabIndex = 6;
            this.btnAbort.Text = "Abort";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 450);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.numericEnd);
            this.Controls.Add(this.lbEnd);
            this.Controls.Add(this.numericStart);
            this.Controls.Add(this.lbStart);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lbStart;
        private System.Windows.Forms.NumericUpDown numericStart;
        private System.Windows.Forms.NumericUpDown numericEnd;
        private System.Windows.Forms.Label lbEnd;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnAbort;
    }
}

