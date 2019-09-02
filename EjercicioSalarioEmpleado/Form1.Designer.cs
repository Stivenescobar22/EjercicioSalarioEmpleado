namespace EjercicioSalarioEmpleado
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblhorastrabajadas = new System.Windows.Forms.Label();
            this.lblvalorhora = new System.Windows.Forms.Label();
            this.txthorastrabajadas = new System.Windows.Forms.TextBox();
            this.txtvalorhora = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lbltotalpagar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(163, 36);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(388, 24);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "programa para calcular salario del empleado ";
            // 
            // lblhorastrabajadas
            // 
            this.lblhorastrabajadas.AutoSize = true;
            this.lblhorastrabajadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhorastrabajadas.Location = new System.Drawing.Point(51, 128);
            this.lblhorastrabajadas.Name = "lblhorastrabajadas";
            this.lblhorastrabajadas.Size = new System.Drawing.Size(311, 20);
            this.lblhorastrabajadas.TabIndex = 1;
            this.lblhorastrabajadas.Text = "Ingrese horas trabajadas por el empleado: ";
            // 
            // lblvalorhora
            // 
            this.lblvalorhora.AutoSize = true;
            this.lblvalorhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalorhora.Location = new System.Drawing.Point(147, 190);
            this.lblvalorhora.Name = "lblvalorhora";
            this.lblvalorhora.Size = new System.Drawing.Size(215, 20);
            this.lblvalorhora.TabIndex = 2;
            this.lblvalorhora.Text = "ingrese el valor de cada hora:";
            // 
            // txthorastrabajadas
            // 
            this.txthorastrabajadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthorastrabajadas.Location = new System.Drawing.Point(374, 130);
            this.txthorastrabajadas.Name = "txthorastrabajadas";
            this.txthorastrabajadas.Size = new System.Drawing.Size(109, 26);
            this.txthorastrabajadas.TabIndex = 3;
            // 
            // txtvalorhora
            // 
            this.txtvalorhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalorhora.Location = new System.Drawing.Point(374, 187);
            this.txtvalorhora.Name = "txtvalorhora";
            this.txtvalorhora.Size = new System.Drawing.Size(109, 26);
            this.txtvalorhora.TabIndex = 4;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(374, 257);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(78, 26);
            this.btncalcular.TabIndex = 5;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(87, 385);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(53, 18);
            this.lbltotal.TabIndex = 6;
            this.lbltotal.Text = "Total : ";
            // 
            // lbltotalpagar
            // 
            this.lbltotalpagar.AutoSize = true;
            this.lbltotalpagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalpagar.Location = new System.Drawing.Point(148, 385);
            this.lbltotalpagar.Name = "lbltotalpagar";
            this.lbltotalpagar.Size = new System.Drawing.Size(84, 16);
            this.lbltotalpagar.TabIndex = 7;
            this.lbltotalpagar.Text = "TotalApagar";
            this.lbltotalpagar.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbltotalpagar);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtvalorhora);
            this.Controls.Add(this.txthorastrabajadas);
            this.Controls.Add(this.lblvalorhora);
            this.Controls.Add(this.lblhorastrabajadas);
            this.Controls.Add(this.lbltitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblhorastrabajadas;
        private System.Windows.Forms.Label lblvalorhora;
        private System.Windows.Forms.TextBox txthorastrabajadas;
        private System.Windows.Forms.TextBox txtvalorhora;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lbltotalpagar;
    }
}

