
namespace Pedidos
{
    partial class Principal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DCLIENTE = new System.Windows.Forms.Button();
            this.DPEDIDO = new System.Windows.Forms.Button();
            this.COM = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-5, -46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIENVENIDO A FASTEX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(248, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccione la tarea que desea realizar: ";
            // 
            // DCLIENTE
            // 
            this.DCLIENTE.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.DCLIENTE.Location = new System.Drawing.Point(45, 118);
            this.DCLIENTE.Name = "DCLIENTE";
            this.DCLIENTE.Size = new System.Drawing.Size(181, 23);
            this.DCLIENTE.TabIndex = 2;
            this.DCLIENTE.Text = "MODIFICAR DATOS CLIENTE ";
            this.DCLIENTE.UseVisualStyleBackColor = false;
            this.DCLIENTE.Click += new System.EventHandler(this.DCLIENTE_Click);
            // 
            // DPEDIDO
            // 
            this.DPEDIDO.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.DPEDIDO.Location = new System.Drawing.Point(547, 118);
            this.DPEDIDO.Name = "DPEDIDO";
            this.DPEDIDO.Size = new System.Drawing.Size(181, 23);
            this.DPEDIDO.TabIndex = 3;
            this.DPEDIDO.Text = "MODIFICAR DATOS PEDIDOS";
            this.DPEDIDO.UseVisualStyleBackColor = false;
            this.DPEDIDO.Click += new System.EventHandler(this.DPEDIDO_Click);
            // 
            // COM
            // 
            this.COM.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.COM.Location = new System.Drawing.Point(297, 118);
            this.COM.Name = "COM";
            this.COM.Size = new System.Drawing.Size(181, 23);
            this.COM.TabIndex = 4;
            this.COM.Text = "COMPRAS";
            this.COM.UseVisualStyleBackColor = false;
            this.COM.Click += new System.EventHandler(this.COM_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 192);
            this.Controls.Add(this.COM);
            this.Controls.Add(this.DPEDIDO);
            this.Controls.Add(this.DCLIENTE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DCLIENTE;
        private System.Windows.Forms.Button DPEDIDO;
        private System.Windows.Forms.Button COM;
    }
}