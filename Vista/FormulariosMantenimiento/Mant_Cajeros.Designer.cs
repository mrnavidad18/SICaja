namespace SICaja.Vista.FormulariosMantenimiento
{
    partial class Mant_Cajeros
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
            this.txtNombreCajero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnGenerarCodigo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDEmp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabEmpleados = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbUsuariosInactivos = new System.Windows.Forms.RadioButton();
            this.rbUsuariosActivos = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnGenerarAcceso = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClaveAcceso = new System.Windows.Forms.TextBox();
            this.btnRestablecerPass = new System.Windows.Forms.Button();
            this.btnCambiarEstado = new System.Windows.Forms.Button();
            this.tabEmpleados.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombreCajero
            // 
            this.txtNombreCajero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreCajero.Enabled = false;
            this.txtNombreCajero.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCajero.Location = new System.Drawing.Point(163, 65);
            this.txtNombreCajero.Name = "txtNombreCajero";
            this.txtNombreCajero.Size = new System.Drawing.Size(409, 22);
            this.txtNombreCajero.TabIndex = 5;
            this.txtNombreCajero.TextChanged += new System.EventHandler(this.txtNombreCajero_TextChanged);
            this.txtNombreCajero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreCajero_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre del Cajero:";
            // 
            // txtResult
            // 
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResult.Enabled = false;
            this.txtResult.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(163, 93);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(72, 22);
            this.txtResult.TabIndex = 6;
            // 
            // btnGenerarCodigo
            // 
            this.btnGenerarCodigo.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarCodigo.Location = new System.Drawing.Point(578, 89);
            this.btnGenerarCodigo.Name = "btnGenerarCodigo";
            this.btnGenerarCodigo.Size = new System.Drawing.Size(109, 23);
            this.btnGenerarCodigo.TabIndex = 7;
            this.btnGenerarCodigo.Text = "Generar Código";
            this.btnGenerarCodigo.UseVisualStyleBackColor = true;
            this.btnGenerarCodigo.Click += new System.EventHandler(this.btnGenerarCodigo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Código del Cajero:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "ID De Empleado:";
            // 
            // txtIDEmp
            // 
            this.txtIDEmp.BackColor = System.Drawing.SystemColors.Window;
            this.txtIDEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDEmp.Enabled = false;
            this.txtIDEmp.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDEmp.Location = new System.Drawing.Point(163, 37);
            this.txtIDEmp.Name = "txtIDEmp";
            this.txtIDEmp.Size = new System.Drawing.Size(72, 22);
            this.txtIDEmp.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label4.Location = new System.Drawing.Point(6, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(468, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "•Presione F5 para ingresar el DNI del empleado";
            // 
            // tabEmpleados
            // 
            this.tabEmpleados.Controls.Add(this.tabPage1);
            this.tabEmpleados.Controls.Add(this.tabPage2);
            this.tabEmpleados.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabEmpleados.Location = new System.Drawing.Point(9, 171);
            this.tabEmpleados.Name = "tabEmpleados";
            this.tabEmpleados.SelectedIndex = 0;
            this.tabEmpleados.Size = new System.Drawing.Size(1017, 378);
            this.tabEmpleados.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCambiarEstado);
            this.tabPage1.Controls.Add(this.btnRestablecerPass);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1009, 350);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Acceso de Usuarios";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(803, 281);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbUsuariosInactivos);
            this.groupBox1.Controls.Add(this.rbUsuariosActivos);
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 42);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado del Usuario";
            // 
            // rbUsuariosInactivos
            // 
            this.rbUsuariosInactivos.AutoSize = true;
            this.rbUsuariosInactivos.Location = new System.Drawing.Point(160, 17);
            this.rbUsuariosInactivos.Name = "rbUsuariosInactivos";
            this.rbUsuariosInactivos.Size = new System.Drawing.Size(81, 19);
            this.rbUsuariosInactivos.TabIndex = 1;
            this.rbUsuariosInactivos.TabStop = true;
            this.rbUsuariosInactivos.Text = "Inactivos";
            this.rbUsuariosInactivos.UseVisualStyleBackColor = true;
            this.rbUsuariosInactivos.CheckedChanged += new System.EventHandler(this.rbUsuariosInactivos_CheckedChanged);
            // 
            // rbUsuariosActivos
            // 
            this.rbUsuariosActivos.AutoSize = true;
            this.rbUsuariosActivos.Location = new System.Drawing.Point(44, 17);
            this.rbUsuariosActivos.Name = "rbUsuariosActivos";
            this.rbUsuariosActivos.Size = new System.Drawing.Size(72, 19);
            this.rbUsuariosActivos.TabIndex = 0;
            this.rbUsuariosActivos.TabStop = true;
            this.rbUsuariosActivos.Text = "Activos";
            this.rbUsuariosActivos.UseVisualStyleBackColor = true;
            this.rbUsuariosActivos.CheckedChanged += new System.EventHandler(this.rbUsuariosActivos_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1081, 350);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Información";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnGenerarAcceso
            // 
            this.btnGenerarAcceso.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarAcceso.Location = new System.Drawing.Point(578, 121);
            this.btnGenerarAcceso.Name = "btnGenerarAcceso";
            this.btnGenerarAcceso.Size = new System.Drawing.Size(109, 23);
            this.btnGenerarAcceso.TabIndex = 13;
            this.btnGenerarAcceso.Text = "Generar Acceso";
            this.btnGenerarAcceso.UseVisualStyleBackColor = true;
            this.btnGenerarAcceso.Click += new System.EventHandler(this.btnGenerarAcceso_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Clave de Acceso:";
            // 
            // txtClaveAcceso
            // 
            this.txtClaveAcceso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClaveAcceso.Enabled = false;
            this.txtClaveAcceso.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveAcceso.Location = new System.Drawing.Point(163, 121);
            this.txtClaveAcceso.MaxLength = 20;
            this.txtClaveAcceso.Name = "txtClaveAcceso";
            this.txtClaveAcceso.Size = new System.Drawing.Size(409, 22);
            this.txtClaveAcceso.TabIndex = 14;
            this.txtClaveAcceso.UseSystemPasswordChar = true;
            // 
            // btnRestablecerPass
            // 
            this.btnRestablecerPass.Enabled = false;
            this.btnRestablecerPass.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestablecerPass.Location = new System.Drawing.Point(821, 63);
            this.btnRestablecerPass.Name = "btnRestablecerPass";
            this.btnRestablecerPass.Size = new System.Drawing.Size(148, 23);
            this.btnRestablecerPass.TabIndex = 8;
            this.btnRestablecerPass.Text = "Restablecer Password";
            this.btnRestablecerPass.UseVisualStyleBackColor = true;
            this.btnRestablecerPass.Click += new System.EventHandler(this.btnRestablecerPass_Click);
            // 
            // btnCambiarEstado
            // 
            this.btnCambiarEstado.Enabled = false;
            this.btnCambiarEstado.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarEstado.Location = new System.Drawing.Point(821, 92);
            this.btnCambiarEstado.Name = "btnCambiarEstado";
            this.btnCambiarEstado.Size = new System.Drawing.Size(148, 23);
            this.btnCambiarEstado.TabIndex = 9;
            this.btnCambiarEstado.Text = "Cambiar Estado";
            this.btnCambiarEstado.UseVisualStyleBackColor = true;
            this.btnCambiarEstado.Click += new System.EventHandler(this.btnCambiarEstado_Click);
            // 
            // Mant_Cajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 580);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtClaveAcceso);
            this.Controls.Add(this.btnGenerarAcceso);
            this.Controls.Add(this.tabEmpleados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIDEmp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerarCodigo);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtNombreCajero);
            this.Controls.Add(this.label2);
            this.KeyPreview = true;
            this.Name = "Mant_Cajeros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mant_Cajeros";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Mant_Cajeros_KeyDown);
            this.tabEmpleados.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreCajero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnGenerarCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDEmp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabEmpleados;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnGenerarAcceso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtClaveAcceso;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbUsuariosInactivos;
        private System.Windows.Forms.RadioButton rbUsuariosActivos;
        private System.Windows.Forms.Button btnCambiarEstado;
        private System.Windows.Forms.Button btnRestablecerPass;
    }
}