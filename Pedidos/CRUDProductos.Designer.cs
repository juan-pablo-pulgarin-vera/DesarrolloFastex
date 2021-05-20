
namespace Pedidos
{
    partial class lblIdentificadorproducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lblIdentificadorproducto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcbSalir = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxDetallesproductos = new System.Windows.Forms.GroupBox();
            this.identidicador1 = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.preciounidad = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.marca = new System.Windows.Forms.TextBox();
            this.talla = new System.Windows.Forms.TextBox();
            this.color = new System.Windows.Forms.TextBox();
            this.lblColorproducto = new System.Windows.Forms.Label();
            this.lblpreciounidad = new System.Windows.Forms.Label();
            this.lblTallaproducto = new System.Windows.Forms.Label();
            this.lblMarcaProducto = new System.Windows.Forms.Label();
            this.lblNombreproducto = new System.Windows.Forms.Label();
            this.lista = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bttnNuevo = new System.Windows.Forms.Button();
            this.bttnModificar = new System.Windows.Forms.Button();
            this.bttnRegistrar = new System.Windows.Forms.Button();
            this.bttnEliminar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSalir)).BeginInit();
            this.gbxDetallesproductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(227)))));
            this.panel1.Controls.Add(this.pcbSalir);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 68);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pcbSalir
            // 
            this.pcbSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcbSalir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbSalir.Image = ((System.Drawing.Image)(resources.GetObject("pcbSalir.Image")));
            this.pcbSalir.Location = new System.Drawing.Point(1302, 0);
            this.pcbSalir.Name = "pcbSalir";
            this.pcbSalir.Size = new System.Drawing.Size(48, 45);
            this.pcbSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbSalir.TabIndex = 1;
            this.pcbSalir.TabStop = false;
            this.pcbSalir.Click += new System.EventHandler(this.pcbSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(466, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANTENIMIENTO PRODUCTOS";
            // 
            // gbxDetallesproductos
            // 
            this.gbxDetallesproductos.Controls.Add(this.identidicador1);
            this.gbxDetallesproductos.Controls.Add(this.label);
            this.gbxDetallesproductos.Controls.Add(this.preciounidad);
            this.gbxDetallesproductos.Controls.Add(this.nombre);
            this.gbxDetallesproductos.Controls.Add(this.marca);
            this.gbxDetallesproductos.Controls.Add(this.talla);
            this.gbxDetallesproductos.Controls.Add(this.color);
            this.gbxDetallesproductos.Controls.Add(this.lblColorproducto);
            this.gbxDetallesproductos.Controls.Add(this.lblpreciounidad);
            this.gbxDetallesproductos.Controls.Add(this.lblTallaproducto);
            this.gbxDetallesproductos.Controls.Add(this.lblMarcaProducto);
            this.gbxDetallesproductos.Controls.Add(this.lblNombreproducto);
            this.gbxDetallesproductos.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDetallesproductos.Location = new System.Drawing.Point(47, 269);
            this.gbxDetallesproductos.Name = "gbxDetallesproductos";
            this.gbxDetallesproductos.Size = new System.Drawing.Size(416, 328);
            this.gbxDetallesproductos.TabIndex = 1;
            this.gbxDetallesproductos.TabStop = false;
            this.gbxDetallesproductos.Text = "Detalles productos ";
            // 
            // identidicador1
            // 
            this.identidicador1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.identidicador1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.identidicador1.Location = new System.Drawing.Point(147, 43);
            this.identidicador1.Name = "identidicador1";
            this.identidicador1.Size = new System.Drawing.Size(256, 25);
            this.identidicador1.TabIndex = 13;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(36, 43);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(97, 18);
            this.label.TabIndex = 12;
            this.label.Text = "Identificador:";
            // 
            // preciounidad
            // 
            this.preciounidad.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.preciounidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.preciounidad.Location = new System.Drawing.Point(147, 282);
            this.preciounidad.Name = "preciounidad";
            this.preciounidad.Size = new System.Drawing.Size(256, 25);
            this.preciounidad.TabIndex = 11;
            // 
            // nombre
            // 
            this.nombre.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nombre.Location = new System.Drawing.Point(147, 77);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(256, 25);
            this.nombre.TabIndex = 10;
            // 
            // marca
            // 
            this.marca.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.marca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.marca.Location = new System.Drawing.Point(147, 133);
            this.marca.Name = "marca";
            this.marca.Size = new System.Drawing.Size(256, 25);
            this.marca.TabIndex = 9;
            // 
            // talla
            // 
            this.talla.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.talla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.talla.Location = new System.Drawing.Point(147, 182);
            this.talla.Name = "talla";
            this.talla.Size = new System.Drawing.Size(256, 25);
            this.talla.TabIndex = 8;
            // 
            // color
            // 
            this.color.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.color.Location = new System.Drawing.Point(147, 238);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(256, 25);
            this.color.TabIndex = 7;
            // 
            // lblColorproducto
            // 
            this.lblColorproducto.AutoSize = true;
            this.lblColorproducto.Location = new System.Drawing.Point(36, 238);
            this.lblColorproducto.Name = "lblColorproducto";
            this.lblColorproducto.Size = new System.Drawing.Size(48, 18);
            this.lblColorproducto.TabIndex = 5;
            this.lblColorproducto.Text = "Color:";
            // 
            // lblpreciounidad
            // 
            this.lblpreciounidad.AutoSize = true;
            this.lblpreciounidad.Location = new System.Drawing.Point(36, 289);
            this.lblpreciounidad.Name = "lblpreciounidad";
            this.lblpreciounidad.Size = new System.Drawing.Size(102, 18);
            this.lblpreciounidad.TabIndex = 4;
            this.lblpreciounidad.Text = "Precio unidad:";
            // 
            // lblTallaproducto
            // 
            this.lblTallaproducto.AutoSize = true;
            this.lblTallaproducto.Location = new System.Drawing.Point(36, 185);
            this.lblTallaproducto.Name = "lblTallaproducto";
            this.lblTallaproducto.Size = new System.Drawing.Size(45, 18);
            this.lblTallaproducto.TabIndex = 3;
            this.lblTallaproducto.Text = "Talla:";
            // 
            // lblMarcaProducto
            // 
            this.lblMarcaProducto.AutoSize = true;
            this.lblMarcaProducto.Location = new System.Drawing.Point(36, 133);
            this.lblMarcaProducto.Name = "lblMarcaProducto";
            this.lblMarcaProducto.Size = new System.Drawing.Size(54, 18);
            this.lblMarcaProducto.TabIndex = 2;
            this.lblMarcaProducto.Text = "Marca:";
            // 
            // lblNombreproducto
            // 
            this.lblNombreproducto.AutoSize = true;
            this.lblNombreproducto.Location = new System.Drawing.Point(36, 80);
            this.lblNombreproducto.Name = "lblNombreproducto";
            this.lblNombreproducto.Size = new System.Drawing.Size(66, 18);
            this.lblNombreproducto.TabIndex = 1;
            this.lblNombreproducto.Text = "Nombre:";
            // 
            // lista
            // 
            this.lista.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.lista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lista.Location = new System.Drawing.Point(6, 27);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(790, 393);
            this.lista.TabIndex = 2;
            this.lista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lista_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lista);
            this.groupBox1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(522, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(802, 426);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(49, 603);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bus);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(522, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(802, 97);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar";
            // 
            // bus
            // 
            this.bus.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.bus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bus.Location = new System.Drawing.Point(179, 44);
            this.bus.Name = "bus";
            this.bus.Size = new System.Drawing.Size(404, 29);
            this.bus.TabIndex = 1;
            this.bus.TextChanged += new System.EventHandler(this.bus_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre producto:";
            // 
            // bttnNuevo
            // 
            this.bttnNuevo.BackColor = System.Drawing.Color.SkyBlue;
            this.bttnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnNuevo.Font = new System.Drawing.Font("Bell MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnNuevo.Location = new System.Drawing.Point(49, 137);
            this.bttnNuevo.Name = "bttnNuevo";
            this.bttnNuevo.Size = new System.Drawing.Size(93, 35);
            this.bttnNuevo.TabIndex = 7;
            this.bttnNuevo.Text = "Nuevo";
            this.bttnNuevo.UseVisualStyleBackColor = false;
            this.bttnNuevo.Click += new System.EventHandler(this.bttnNuevo_Click);
            // 
            // bttnModificar
            // 
            this.bttnModificar.BackColor = System.Drawing.Color.SkyBlue;
            this.bttnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnModificar.Font = new System.Drawing.Font("Bell MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.bttnModificar.Location = new System.Drawing.Point(49, 197);
            this.bttnModificar.Name = "bttnModificar";
            this.bttnModificar.Size = new System.Drawing.Size(93, 35);
            this.bttnModificar.TabIndex = 8;
            this.bttnModificar.Text = "Modificar";
            this.bttnModificar.UseVisualStyleBackColor = false;
            this.bttnModificar.Click += new System.EventHandler(this.bttnModificar_Click);
            // 
            // bttnRegistrar
            // 
            this.bttnRegistrar.BackColor = System.Drawing.Color.SkyBlue;
            this.bttnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnRegistrar.Font = new System.Drawing.Font("Bell MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.bttnRegistrar.Location = new System.Drawing.Point(174, 137);
            this.bttnRegistrar.Name = "bttnRegistrar";
            this.bttnRegistrar.Size = new System.Drawing.Size(93, 35);
            this.bttnRegistrar.TabIndex = 9;
            this.bttnRegistrar.Text = "Registrar";
            this.bttnRegistrar.UseVisualStyleBackColor = false;
            this.bttnRegistrar.Click += new System.EventHandler(this.bttnRegistrar_Click);
            // 
            // bttnEliminar
            // 
            this.bttnEliminar.BackColor = System.Drawing.Color.SkyBlue;
            this.bttnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnEliminar.Font = new System.Drawing.Font("Bell MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.bttnEliminar.Location = new System.Drawing.Point(174, 197);
            this.bttnEliminar.Name = "bttnEliminar";
            this.bttnEliminar.Size = new System.Drawing.Size(93, 35);
            this.bttnEliminar.TabIndex = 10;
            this.bttnEliminar.Text = "Eliminar";
            this.bttnEliminar.UseVisualStyleBackColor = false;
            this.bttnEliminar.Click += new System.EventHandler(this.bttnEliminar_Click);
            // 
            // lblIdentificadorproducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.bttnEliminar);
            this.Controls.Add(this.bttnRegistrar);
            this.Controls.Add(this.bttnModificar);
            this.Controls.Add(this.bttnNuevo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxDetallesproductos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "lblIdentificadorproducto";
            this.Text = "ccccccc";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSalir)).EndInit();
            this.gbxDetallesproductos.ResumeLayout(false);
            this.gbxDetallesproductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcbSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxDetallesproductos;
        private System.Windows.Forms.Label lblTallaproducto;
        private System.Windows.Forms.Label lblMarcaProducto;
        private System.Windows.Forms.Label lblNombreproducto;
        private System.Windows.Forms.Label lblColorproducto;
        private System.Windows.Forms.Label lblpreciounidad;
        private System.Windows.Forms.DataGridView lista;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox preciounidad;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox marca;
        private System.Windows.Forms.TextBox talla;
        private System.Windows.Forms.TextBox color;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox bus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bttnNuevo;
        private System.Windows.Forms.Button bttnModificar;
        private System.Windows.Forms.Button bttnRegistrar;
        private System.Windows.Forms.Button bttnEliminar;
        private System.Windows.Forms.TextBox identidicador1;
        private System.Windows.Forms.Label label;
    }
}