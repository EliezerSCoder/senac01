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
            buttonCadastrar = new Button();
            texteNovaSenha = new TextBox();
            textNovoCadastro = new TextBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxU
            // 
            textBoxU.Location = new Point(12, 150);
            textBoxU.Name = "textBoxU";
            textBoxU.Size = new Size(318, 23);
            textBoxU.TabIndex = 0;
            textBoxU.Text = "l";
            // 
            // textboxSenha
            // 
            textboxSenha.Location = new Point(12, 231);
            textboxSenha.Name = "textboxSenha";
            textboxSenha.Size = new Size(318, 23);
            textboxSenha.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(240, 275);
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
            label1.Location = new Point(21, 128);
            label1.Name = "label1";
            label1.Size = new Size(64, 19);
            label1.TabIndex = 3;
            label1.Text = "EMAIL:\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 210);
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
            label3.Font = new Font("Chiller", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Lime;
            label3.Location = new Point(181, 24);
            label3.Name = "label3";
            label3.Size = new Size(399, 74);
            label3.TabIndex = 5;
            label3.Text = "CLONA CARTÃO ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, -35);
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
            // buttonCadastrar
            // 
            buttonCadastrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCadastrar.ForeColor = Color.Black;
            buttonCadastrar.Location = new Point(658, 275);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(94, 31);
            buttonCadastrar.TabIndex = 8;
            buttonCadastrar.Text = "CADASTRAR";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += button2_Click;
            // 
            // texteNovaSenha
            // 
            texteNovaSenha.Location = new Point(434, 231);
            texteNovaSenha.Name = "texteNovaSenha";
            texteNovaSenha.Size = new Size(318, 23);
            texteNovaSenha.TabIndex = 9;
            // 
            // textNovoCadastro
            // 
            textNovoCadastro.Location = new Point(434, 150);
            textNovoCadastro.Name = "textNovoCadastro";
            textNovoCadastro.Size = new Size(318, 23);
            textNovoCadastro.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(434, 126);
            label4.Name = "label4";
            label4.Size = new Size(146, 21);
            label4.TabIndex = 11;
            label4.Text = "NOVO CADASTRO";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(434, 207);
            label5.Name = "label5";
            label5.Size = new Size(118, 21);
            label5.TabIndex = 12;
            label5.Text = "NOVA SENHA ";
            label5.Click += label5_Click;
            // 
            // FormLogin
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(789, 417);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textNovoCadastro);
            Controls.Add(texteNovaSenha);
            Controls.Add(buttonCadastrar);
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
        private Button buttonCadastrar;
        private TextBox texteNovaSenha;
        private TextBox textNovoCadastro;
        private Label label4;
        private Label label5;
    }
}
