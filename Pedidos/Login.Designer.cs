
namespace Pedidos
{
    partial class Login
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
            this.textBoxUsuarioLogin = new System.Windows.Forms.TextBox();
            this.textBoxContrasenaLogin = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxUsuarioLogin
            // 
            this.textBoxUsuarioLogin.Location = new System.Drawing.Point(407, 221);
            this.textBoxUsuarioLogin.Multiline = true;
            this.textBoxUsuarioLogin.Name = "textBoxUsuarioLogin";
            this.textBoxUsuarioLogin.Size = new System.Drawing.Size(253, 20);
            this.textBoxUsuarioLogin.TabIndex = 0;
            // 
            // textBoxContrasenaLogin
            // 
            this.textBoxContrasenaLogin.Location = new System.Drawing.Point(407, 371);
            this.textBoxContrasenaLogin.Multiline = true;
            this.textBoxContrasenaLogin.Name = "textBoxContrasenaLogin";
            this.textBoxContrasenaLogin.PasswordChar = '*';
            this.textBoxContrasenaLogin.Size = new System.Drawing.Size(253, 20);
            this.textBoxContrasenaLogin.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(607, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(607, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Registrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(712, 532);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxContrasenaLogin);
            this.Controls.Add(this.textBoxUsuarioLogin);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsuarioLogin;
        private System.Windows.Forms.TextBox textBoxContrasenaLogin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}