namespace ColorApp
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.Label();
            this.n1 = new System.Windows.Forms.NumericUpDown();
            this.n2 = new System.Windows.Forms.NumericUpDown();
            this.n3 = new System.Windows.Forms.NumericUpDown();
            this.p1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.n1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Blue";
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(222, 297);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(28, 13);
            this.l1.TabIndex = 7;
            this.l1.Text = "Blue";
            this.l1.Visible = false;
            // 
            // n1
            // 
            this.n1.Location = new System.Drawing.Point(286, 100);
            this.n1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(120, 20);
            this.n1.TabIndex = 8;
            // 
            // n2
            // 
            this.n2.Location = new System.Drawing.Point(286, 126);
            this.n2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(120, 20);
            this.n2.TabIndex = 9;
            // 
            // n3
            // 
            this.n3.Location = new System.Drawing.Point(286, 159);
            this.n3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(120, 20);
            this.n3.TabIndex = 10;
            // 
            // p1
            // 
            this.p1.Location = new System.Drawing.Point(395, 270);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(93, 60);
            this.p1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.n1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.NumericUpDown n1;
        private System.Windows.Forms.NumericUpDown n2;
        private System.Windows.Forms.NumericUpDown n3;
        private System.Windows.Forms.Panel p1;
    }
}

