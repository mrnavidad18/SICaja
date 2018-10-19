namespace SICaja.Vista.FormulariosUsuario
{
    partial class AccesoUsuarioCaja
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodCajero = new System.Windows.Forms.TextBox();
            this.txtClaveAcceso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Código Cajero:";
            // 
            // txtCodCajero
            // 
            this.txtCodCajero.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodCajero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodCajero.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCajero.Location = new System.Drawing.Point(144, 14);
            this.txtCodCajero.Name = "txtCodCajero";
            this.txtCodCajero.Size = new System.Drawing.Size(72, 22);
            this.txtCodCajero.TabIndex = 13;
            // 
            // txtClaveAcceso
            // 
            this.txtClaveAcceso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClaveAcceso.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveAcceso.Location = new System.Drawing.Point(144, 44);
            this.txtClaveAcceso.MaxLength = 20;
            this.txtClaveAcceso.Name = "txtClaveAcceso";
            this.txtClaveAcceso.Size = new System.Drawing.Size(150, 22);
            this.txtClaveAcceso.TabIndex = 12;
            this.txtClaveAcceso.UseSystemPasswordChar = true;
            this.txtClaveAcceso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreCajero_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Clave Cajero:";
            // 
            // AccesoUsuarioCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 87);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodCajero);
            this.Controls.Add(this.txtClaveAcceso);
            this.Controls.Add(this.label2);
            this.Name = "AccesoUsuarioCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccesoUsuarioCaja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodCajero;
        private System.Windows.Forms.TextBox txtClaveAcceso;
        private System.Windows.Forms.Label label2;
    }
}