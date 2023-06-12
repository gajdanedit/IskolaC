namespace _18._6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.méret = new System.Windows.Forms.HScrollBar();
            this.piros = new System.Windows.Forms.HScrollBar();
            this.kék = new System.Windows.Forms.HScrollBar();
            this.zöld = new System.Windows.Forms.HScrollBar();
            this.szín = new System.Windows.Forms.Label();
            this.szám = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // méret
            // 
            this.méret.Location = new System.Drawing.Point(163, 65);
            this.méret.Name = "méret";
            this.méret.Size = new System.Drawing.Size(390, 17);
            this.méret.TabIndex = 0;
            this.méret.ValueChanged += new System.EventHandler(this.méret_ValueChanged);
            // 
            // piros
            // 
            this.piros.Location = new System.Drawing.Point(163, 283);
            this.piros.Name = "piros";
            this.piros.Size = new System.Drawing.Size(390, 17);
            this.piros.TabIndex = 1;
            this.piros.ValueChanged += new System.EventHandler(this.piros_ValueChanged);
            // 
            // kék
            // 
            this.kék.Location = new System.Drawing.Point(163, 332);
            this.kék.Name = "kék";
            this.kék.Size = new System.Drawing.Size(390, 17);
            this.kék.TabIndex = 2;
            this.kék.ValueChanged += new System.EventHandler(this.kék_ValueChanged);
            // 
            // zöld
            // 
            this.zöld.Location = new System.Drawing.Point(163, 382);
            this.zöld.Name = "zöld";
            this.zöld.Size = new System.Drawing.Size(390, 17);
            this.zöld.TabIndex = 3;
            this.zöld.ValueChanged += new System.EventHandler(this.zöld_ValueChanged);
            // 
            // szín
            // 
            this.szín.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.szín.Location = new System.Drawing.Point(163, 101);
            this.szín.Name = "szín";
            this.szín.Size = new System.Drawing.Size(23, 23);
            this.szín.TabIndex = 4;
            // 
            // szám
            // 
            this.szám.AutoSize = true;
            this.szám.Location = new System.Drawing.Point(174, 21);
            this.szám.Name = "szám";
            this.szám.Size = new System.Drawing.Size(13, 15);
            this.szám.TabIndex = 5;
            this.szám.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "piros";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "kék";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "zöld";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.szám);
            this.Controls.Add(this.szín);
            this.Controls.Add(this.zöld);
            this.Controls.Add(this.kék);
            this.Controls.Add(this.piros);
            this.Controls.Add(this.méret);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HScrollBar méret;
        private HScrollBar piros;
        private HScrollBar kék;
        private HScrollBar zöld;
        private Label szín;
        private Label szám;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}