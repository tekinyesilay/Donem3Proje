namespace WindowsFormsApp3
{
    partial class kayıtol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kayıtol));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Telefon Numarası:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(324, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Şifre:";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(422, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "Kayıt Ol";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(566, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(188, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(372, 44);
            this.label4.TabIndex = 9;
            this.label4.Text = "HAYVAN PAZARCIM";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox2.Location = new System.Drawing.Point(394, 278);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(234, 35);
            this.textBox2.TabIndex = 12;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maskedTextBox1.Location = new System.Drawing.Point(394, 216);
            this.maskedTextBox1.Mask = "(500) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(234, 35);
            this.maskedTextBox1.TabIndex = 13;
            // 
            // kayıtol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 495);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "kayıtol";
            this.Text = "kayıtol";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}