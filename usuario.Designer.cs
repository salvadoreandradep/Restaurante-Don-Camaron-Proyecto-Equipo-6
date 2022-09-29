
namespace Semena_6___Parcial_1
{
    partial class usuario
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtusu = new System.Windows.Forms.TextBox();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Semena_6___Parcial_1.DataSet1();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.bprimero = new System.Windows.Forms.Button();
            this.banterior = new System.Windows.Forms.Button();
            this.bsiguiente = new System.Windows.Forms.Button();
            this.bultimo = new System.Windows.Forms.Button();
            this.bnuevo = new System.Windows.Forms.Button();
            this.beliminar = new System.Windows.Forms.Button();
            this.bmodificar = new System.Windows.Forms.Button();
            this.bsalir = new System.Windows.Forms.Button();
            this.bguardar = new System.Windows.Forms.Button();
            this.bactualizar = new System.Windows.Forms.Button();
            this.txtnivel = new System.Windows.Forms.ComboBox();
            this.usuariosTableAdapter = new Semena_6___Parcial_1.DataSet1TableAdapters.usuariosTableAdapter();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Semena_6___Parcial_1.Properties.Resources.Gender_Neutral_User_icon_icons1;
            this.pictureBox1.Location = new System.Drawing.Point(73, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(261, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(299, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nivel";
            // 
            // txtusu
            // 
            this.txtusu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "usuario", true));
            this.txtusu.Location = new System.Drawing.Point(354, 80);
            this.txtusu.Name = "txtusu";
            this.txtusu.Size = new System.Drawing.Size(175, 20);
            this.txtusu.TabIndex = 4;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "usuarios";
            this.usuariosBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtclave
            // 
            this.txtclave.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "clave", true));
            this.txtclave.Location = new System.Drawing.Point(354, 123);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(175, 20);
            this.txtclave.TabIndex = 5;
            // 
            // bprimero
            // 
            this.bprimero.Location = new System.Drawing.Point(143, 232);
            this.bprimero.Name = "bprimero";
            this.bprimero.Size = new System.Drawing.Size(75, 23);
            this.bprimero.TabIndex = 6;
            this.bprimero.Text = "Primero";
            this.bprimero.UseVisualStyleBackColor = true;
            this.bprimero.Click += new System.EventHandler(this.bprimero_Click);
            // 
            // banterior
            // 
            this.banterior.Location = new System.Drawing.Point(243, 232);
            this.banterior.Name = "banterior";
            this.banterior.Size = new System.Drawing.Size(75, 23);
            this.banterior.TabIndex = 7;
            this.banterior.Text = "Anterior";
            this.banterior.UseVisualStyleBackColor = true;
            this.banterior.Click += new System.EventHandler(this.banterior_Click);
            // 
            // bsiguiente
            // 
            this.bsiguiente.Location = new System.Drawing.Point(344, 232);
            this.bsiguiente.Name = "bsiguiente";
            this.bsiguiente.Size = new System.Drawing.Size(75, 23);
            this.bsiguiente.TabIndex = 8;
            this.bsiguiente.Text = "Siguiente";
            this.bsiguiente.UseVisualStyleBackColor = true;
            this.bsiguiente.Click += new System.EventHandler(this.bsiguiente_Click);
            // 
            // bultimo
            // 
            this.bultimo.Location = new System.Drawing.Point(444, 232);
            this.bultimo.Name = "bultimo";
            this.bultimo.Size = new System.Drawing.Size(75, 23);
            this.bultimo.TabIndex = 9;
            this.bultimo.Text = "Ultimo";
            this.bultimo.UseVisualStyleBackColor = true;
            this.bultimo.Click += new System.EventHandler(this.bultimo_Click);
            // 
            // bnuevo
            // 
            this.bnuevo.Location = new System.Drawing.Point(143, 264);
            this.bnuevo.Name = "bnuevo";
            this.bnuevo.Size = new System.Drawing.Size(75, 23);
            this.bnuevo.TabIndex = 10;
            this.bnuevo.Text = "Nuevo";
            this.bnuevo.UseVisualStyleBackColor = true;
            this.bnuevo.Click += new System.EventHandler(this.bnuevo_Click);
            // 
            // beliminar
            // 
            this.beliminar.Location = new System.Drawing.Point(243, 264);
            this.beliminar.Name = "beliminar";
            this.beliminar.Size = new System.Drawing.Size(75, 23);
            this.beliminar.TabIndex = 11;
            this.beliminar.Text = "Eliminar";
            this.beliminar.UseVisualStyleBackColor = true;
            this.beliminar.Click += new System.EventHandler(this.beliminar_Click);
            // 
            // bmodificar
            // 
            this.bmodificar.Location = new System.Drawing.Point(344, 264);
            this.bmodificar.Name = "bmodificar";
            this.bmodificar.Size = new System.Drawing.Size(75, 23);
            this.bmodificar.TabIndex = 12;
            this.bmodificar.Text = "Modificar";
            this.bmodificar.UseVisualStyleBackColor = true;
            this.bmodificar.Click += new System.EventHandler(this.bmodificar_Click);
            // 
            // bsalir
            // 
            this.bsalir.Location = new System.Drawing.Point(444, 264);
            this.bsalir.Name = "bsalir";
            this.bsalir.Size = new System.Drawing.Size(75, 23);
            this.bsalir.TabIndex = 13;
            this.bsalir.Text = "Salir";
            this.bsalir.UseVisualStyleBackColor = true;
            this.bsalir.Click += new System.EventHandler(this.bsalir_Click);
            // 
            // bguardar
            // 
            this.bguardar.Location = new System.Drawing.Point(143, 294);
            this.bguardar.Name = "bguardar";
            this.bguardar.Size = new System.Drawing.Size(75, 23);
            this.bguardar.TabIndex = 14;
            this.bguardar.Text = "Guardar";
            this.bguardar.UseVisualStyleBackColor = true;
            this.bguardar.Visible = false;
            this.bguardar.Click += new System.EventHandler(this.bguardar_Click);
            // 
            // bactualizar
            // 
            this.bactualizar.Location = new System.Drawing.Point(344, 294);
            this.bactualizar.Name = "bactualizar";
            this.bactualizar.Size = new System.Drawing.Size(75, 23);
            this.bactualizar.TabIndex = 16;
            this.bactualizar.Text = "Actualizar";
            this.bactualizar.UseVisualStyleBackColor = true;
            this.bactualizar.Visible = false;
            this.bactualizar.Click += new System.EventHandler(this.bactualizar_Click);
            // 
            // txtnivel
            // 
            this.txtnivel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "nivel", true));
            this.txtnivel.FormattingEnabled = true;
            this.txtnivel.Location = new System.Drawing.Point(354, 170);
            this.txtnivel.Name = "txtnivel";
            this.txtnivel.Size = new System.Drawing.Size(175, 21);
            this.txtnivel.TabIndex = 17;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkOrange;
            this.pictureBox2.Location = new System.Drawing.Point(-4, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(677, 31);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 341);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(538, 150);
            this.dataGridView1.TabIndex = 19;
            // 
            // usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 541);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtnivel);
            this.Controls.Add(this.bactualizar);
            this.Controls.Add(this.bguardar);
            this.Controls.Add(this.bsalir);
            this.Controls.Add(this.bmodificar);
            this.Controls.Add(this.beliminar);
            this.Controls.Add(this.bnuevo);
            this.Controls.Add(this.bultimo);
            this.Controls.Add(this.bsiguiente);
            this.Controls.Add(this.banterior);
            this.Controls.Add(this.bprimero);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.txtusu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "usuario";
            this.Load += new System.EventHandler(this.usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtusu;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.Button bprimero;
        private System.Windows.Forms.Button banterior;
        private System.Windows.Forms.Button bsiguiente;
        private System.Windows.Forms.Button bultimo;
        private System.Windows.Forms.Button bnuevo;
        private System.Windows.Forms.Button beliminar;
        private System.Windows.Forms.Button bmodificar;
        private System.Windows.Forms.Button bsalir;
        private System.Windows.Forms.Button bguardar;
        private System.Windows.Forms.Button bactualizar;
        private System.Windows.Forms.ComboBox txtnivel;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private DataSet1TableAdapters.usuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}