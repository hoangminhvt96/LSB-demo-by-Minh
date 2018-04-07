namespace LSB_demo
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
            this.label2 = new System.Windows.Forms.Label();
            this.image = new System.Windows.Forms.PictureBox();
            this.image_enc = new System.Windows.Forms.PictureBox();
            this.openImage = new System.Windows.Forms.Button();
            this.showText = new System.Windows.Forms.Button();
            this.hideText = new System.Windows.Forms.Button();
            this.saveImage = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_enc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ảnh gốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(589, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ảnh đã được mã hóa";
            // 
            // image
            // 
            this.image.BackColor = System.Drawing.SystemColors.Window;
            this.image.Location = new System.Drawing.Point(12, 52);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(344, 301);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 2;
            this.image.TabStop = false;
            // 
            // image_enc
            // 
            this.image_enc.BackColor = System.Drawing.SystemColors.Window;
            this.image_enc.Location = new System.Drawing.Point(482, 52);
            this.image_enc.Name = "image_enc";
            this.image_enc.Size = new System.Drawing.Size(344, 301);
            this.image_enc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image_enc.TabIndex = 3;
            this.image_enc.TabStop = false;
            // 
            // openImage
            // 
            this.openImage.Location = new System.Drawing.Point(56, 470);
            this.openImage.Name = "openImage";
            this.openImage.Size = new System.Drawing.Size(113, 28);
            this.openImage.TabIndex = 4;
            this.openImage.Text = "Mở tệp";
            this.openImage.UseVisualStyleBackColor = true;
            this.openImage.Click += new System.EventHandler(this.openImage_Click);
            // 
            // showText
            // 
            this.showText.Location = new System.Drawing.Point(200, 470);
            this.showText.Name = "showText";
            this.showText.Size = new System.Drawing.Size(100, 28);
            this.showText.TabIndex = 5;
            this.showText.Text = "Decode";
            this.showText.UseVisualStyleBackColor = true;
            this.showText.Click += new System.EventHandler(this.showText_Click);
            // 
            // hideText
            // 
            this.hideText.Location = new System.Drawing.Point(527, 470);
            this.hideText.Name = "hideText";
            this.hideText.Size = new System.Drawing.Size(113, 28);
            this.hideText.TabIndex = 6;
            this.hideText.Text = "Encode";
            this.hideText.UseVisualStyleBackColor = true;
            this.hideText.Click += new System.EventHandler(this.hideText_Click);
            // 
            // saveImage
            // 
            this.saveImage.Location = new System.Drawing.Point(673, 470);
            this.saveImage.Name = "saveImage";
            this.saveImage.Size = new System.Drawing.Size(113, 28);
            this.saveImage.TabIndex = 7;
            this.saveImage.Text = "Lưu hình";
            this.saveImage.UseVisualStyleBackColor = true;
            this.saveImage.Click += new System.EventHandler(this.saveImage_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 359);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(814, 105);
            this.textBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 525);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.saveImage);
            this.Controls.Add(this.hideText);
            this.Controls.Add(this.showText);
            this.Controls.Add(this.openImage);
            this.Controls.Add(this.image_enc);
            this.Controls.Add(this.image);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Demo Steg ver 6.9 by Minh";
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_enc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.PictureBox image_enc;
        private System.Windows.Forms.Button openImage;
        private System.Windows.Forms.Button showText;
        private System.Windows.Forms.Button hideText;
        private System.Windows.Forms.Button saveImage;
        private System.Windows.Forms.TextBox textBox1;
    }
}

