namespace Eleman_Ekleme_WinForm
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
            label1 = new Label();
            sayiTextBox = new TextBox();
            btnEkle = new Button();
            btnGoster = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 25);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "Sayı Giriniz:";
            // 
            // sayiTextBox
            // 
            sayiTextBox.Location = new Point(13, 53);
            sayiTextBox.Name = "sayiTextBox";
            sayiTextBox.Size = new Size(173, 23);
            sayiTextBox.TabIndex = 1;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(12, 91);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(174, 23);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "Elelman Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGoster
            // 
            btnGoster.Location = new Point(13, 132);
            btnGoster.Name = "btnGoster";
            btnGoster.Size = new Size(173, 61);
            btnGoster.TabIndex = 3;
            btnGoster.Text = "En Kucuk ve En Buyuk Eleman Goster";
            btnGoster.UseVisualStyleBackColor = true;
            btnGoster.Click += btnGoster_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(198, 207);
            Controls.Add(btnGoster);
            Controls.Add(btnEkle);
            Controls.Add(sayiTextBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox sayiTextBox;
        private Button btnEkle;
        private Button btnGoster;
    }
}