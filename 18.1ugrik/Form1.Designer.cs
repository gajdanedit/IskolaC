namespace _18._1ugrik
{
    partial class Formugratás
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
            this.btnbalrafel = new System.Windows.Forms.Button();
            this.btnjobbrafel = new System.Windows.Forms.Button();
            this.btnjobbrale = new System.Windows.Forms.Button();
            this.btnbalrale = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnbalrafel
            // 
            this.btnbalrafel.BackColor = System.Drawing.Color.Tomato;
            this.btnbalrafel.Location = new System.Drawing.Point(121, 78);
            this.btnbalrafel.Name = "btnbalrafel";
            this.btnbalrafel.Size = new System.Drawing.Size(121, 66);
            this.btnbalrafel.TabIndex = 0;
            this.btnbalrafel.Text = "balrafel";
            this.btnbalrafel.UseVisualStyleBackColor = false;
            this.btnbalrafel.Click += new System.EventHandler(this.btnbalrafel_Click);
            // 
            // btnjobbrafel
            // 
            this.btnjobbrafel.BackColor = System.Drawing.Color.Tomato;
            this.btnjobbrafel.Location = new System.Drawing.Point(350, 76);
            this.btnjobbrafel.Name = "btnjobbrafel";
            this.btnjobbrafel.Size = new System.Drawing.Size(111, 68);
            this.btnjobbrafel.TabIndex = 1;
            this.btnjobbrafel.Text = "jobbrafel";
            this.btnjobbrafel.UseVisualStyleBackColor = false;
            this.btnjobbrafel.Click += new System.EventHandler(this.btnjobbrafel_Click);
            // 
            // btnjobbrale
            // 
            this.btnjobbrale.BackColor = System.Drawing.Color.Tomato;
            this.btnjobbrale.Location = new System.Drawing.Point(350, 220);
            this.btnjobbrale.Name = "btnjobbrale";
            this.btnjobbrale.Size = new System.Drawing.Size(111, 71);
            this.btnjobbrale.TabIndex = 2;
            this.btnjobbrale.Text = "jobbrale";
            this.btnjobbrale.UseVisualStyleBackColor = false;
            this.btnjobbrale.Click += new System.EventHandler(this.btnjobbrale_Click);
            // 
            // btnbalrale
            // 
            this.btnbalrale.BackColor = System.Drawing.Color.Tomato;
            this.btnbalrale.Location = new System.Drawing.Point(130, 211);
            this.btnbalrale.Name = "btnbalrale";
            this.btnbalrale.Size = new System.Drawing.Size(112, 76);
            this.btnbalrale.TabIndex = 3;
            this.btnbalrale.Text = "balrale";
            this.btnbalrale.UseVisualStyleBackColor = false;
            this.btnbalrale.Click += new System.EventHandler(this.btnbalrale_Click);
            // 
            // Formugratás
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnbalrale);
            this.Controls.Add(this.btnjobbrale);
            this.Controls.Add(this.btnjobbrafel);
            this.Controls.Add(this.btnbalrafel);
            this.Name = "Formugratás";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnbalrafel;
        private Button btnjobbrafel;
        private Button btnjobbrale;
        private Button btnbalrale;
    }
}