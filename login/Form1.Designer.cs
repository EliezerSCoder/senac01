namespace login
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            textBoxU = new TextBox();
            textboxSenha = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            labelResultado = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxU
            // 
            textBoxU.Location = new Point(219, 151);
            textBoxU.Name = "textBoxU";
            textBoxU.Size = new Size(318, 23);
            textBoxU.TabIndex = 0;
            // 
            // textboxSenha
            // 
            textboxSenha.Location = new Point(219, 231);
            textboxSenha.Name = "textboxSenha";
            textboxSenha.Size = new Size(318, 23);
            textboxSenha.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(288, 275);
            button1.Name = "button1";
            button1.Size = new Size(90, 31);
            button1.TabIndex = 2;
            button1.Text = "ENTRAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(219, 128);
            label1.Name = "label1";
            label1.Size = new Size(64, 19);
            label1.TabIndex = 3;
            label1.Text = "EMAIL:\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(219, 210);
            label2.Name = "label2";
            label2.Size = new Size(63, 18);
            label2.TabIndex = 4;
            label2.Text = "SENHA:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Algerian", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Lime;
            label3.Location = new Point(244, 64);
            label3.Name = "label3";
            label3.Size = new Size(279, 39);
            label3.TabIndex = 5;
            label3.Text = "CLONA CARTÃO ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, -28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(792, 455);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.BackColor = Color.Transparent;
            labelResultado.Font = new Font("Book Antiqua", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelResultado.ForeColor = Color.White;
            labelResultado.Location = new Point(199, 322);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(11, 17);
            labelResultado.TabIndex = 7;
            labelResultado.Text = ".";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(384, 275);
            button2.Name = "button2";
            button2.Size = new Size(94, 31);
            button2.TabIndex = 8;
            button2.Text = "CADASTRO";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FormLogin
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(789, 417);
            Controls.Add(button2);
            Controls.Add(labelResultado);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textboxSenha);
            Controls.Add(textBoxU);
            Controls.Add(pictureBox1);
            ForeColor = Color.FromArgb(128, 255, 128);
            Name = "FormLogin";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxU;
        private TextBox textboxSenha;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Label labelResultado;
        private Button button2;
    }
}
