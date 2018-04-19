namespace BJOChapter16Exercise5
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
            this.label1 = new System.Windows.Forms.Label();
            this.btEncode = new System.Windows.Forms.Button();
            this.txtBxEnglish = new System.Windows.Forms.TextBox();
            this.txtBxPigLatin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "*Text can not contain any punctuation marks or word less than two characters";
            // 
            // btEncode
            // 
            this.btEncode.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btEncode.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btEncode.FlatAppearance.BorderSize = 2;
            this.btEncode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btEncode.Location = new System.Drawing.Point(21, 158);
            this.btEncode.Name = "btEncode";
            this.btEncode.Size = new System.Drawing.Size(347, 23);
            this.btEncode.TabIndex = 2;
            this.btEncode.Text = "Press to Encode In Pig Latin!";
            this.btEncode.UseVisualStyleBackColor = false;
            this.btEncode.Click += new System.EventHandler(this.btEncode_Click);
            // 
            // txtBxEnglish
            // 
            this.txtBxEnglish.Location = new System.Drawing.Point(21, 41);
            this.txtBxEnglish.Multiline = true;
            this.txtBxEnglish.Name = "txtBxEnglish";
            this.txtBxEnglish.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBxEnglish.Size = new System.Drawing.Size(347, 111);
            this.txtBxEnglish.TabIndex = 0;
            // 
            // txtBxPigLatin
            // 
            this.txtBxPigLatin.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtBxPigLatin.Location = new System.Drawing.Point(12, 258);
            this.txtBxPigLatin.Multiline = true;
            this.txtBxPigLatin.Name = "txtBxPigLatin";
            this.txtBxPigLatin.ReadOnly = true;
            this.txtBxPigLatin.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBxPigLatin.Size = new System.Drawing.Size(392, 233);
            this.txtBxPigLatin.TabIndex = 5;
            this.txtBxPigLatin.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(347, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter a phrase below to have it encoded in Pig Latin*\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Encoded Phrases";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btEncode);
            this.groupBox1.Controls.Add(this.txtBxEnglish);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 213);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 503);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBxPigLatin);
            this.Name = "Form1";
            this.Text = "Pig Latin Encoder";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btEncode;
        private System.Windows.Forms.TextBox txtBxEnglish;
        private System.Windows.Forms.TextBox txtBxPigLatin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;

    }
}

