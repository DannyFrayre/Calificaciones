namespace Practica
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbAlumno = new System.Windows.Forms.Label();
            this.lbCal1 = new System.Windows.Forms.Label();
            this.tbAlumno = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnPromedio = new System.Windows.Forms.Button();
            this.lbPromedio = new System.Windows.Forms.Label();
            this.tbPromedio = new System.Windows.Forms.TextBox();
            this.lbCal2 = new System.Windows.Forms.Label();
            this.lbCal3 = new System.Windows.Forms.Label();
            this.lbCal4 = new System.Windows.Forms.Label();
            this.lbCal5 = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.tb4 = new System.Windows.Forms.TextBox();
            this.tb5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbAlumno
            // 
            this.lbAlumno.AutoSize = true;
            this.lbAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlumno.Location = new System.Drawing.Point(113, 40);
            this.lbAlumno.Name = "lbAlumno";
            this.lbAlumno.Size = new System.Drawing.Size(97, 25);
            this.lbAlumno.TabIndex = 0;
            this.lbAlumno.Text = "Alumno:";
            // 
            // lbCal1
            // 
            this.lbCal1.AutoSize = true;
            this.lbCal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCal1.Location = new System.Drawing.Point(48, 83);
            this.lbCal1.Name = "lbCal1";
            this.lbCal1.Size = new System.Drawing.Size(162, 25);
            this.lbCal1.TabIndex = 1;
            this.lbCal1.Text = "Calificacion 1:";
            // 
            // tbAlumno
            // 
            this.tbAlumno.Location = new System.Drawing.Point(219, 42);
            this.tbAlumno.Multiline = true;
            this.tbAlumno.Name = "tbAlumno";
            this.tbAlumno.Size = new System.Drawing.Size(212, 25);
            this.tbAlumno.TabIndex = 2;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(35, 333);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(161, 68);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(238, 333);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(161, 68);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnPromedio
            // 
            this.btnPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromedio.Location = new System.Drawing.Point(432, 333);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(161, 68);
            this.btnPromedio.TabIndex = 5;
            this.btnPromedio.Text = "Promedio";
            this.btnPromedio.UseVisualStyleBackColor = true;
            this.btnPromedio.Click += new System.EventHandler(this.btnPromedio_Click);
            // 
            // lbPromedio
            // 
            this.lbPromedio.AutoSize = true;
            this.lbPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPromedio.Location = new System.Drawing.Point(2, 278);
            this.lbPromedio.Name = "lbPromedio";
            this.lbPromedio.Size = new System.Drawing.Size(208, 25);
            this.lbPromedio.TabIndex = 6;
            this.lbPromedio.Text = "Promedio General:";
            // 
            // tbPromedio
            // 
            this.tbPromedio.Location = new System.Drawing.Point(216, 278);
            this.tbPromedio.Multiline = true;
            this.tbPromedio.Name = "tbPromedio";
            this.tbPromedio.Size = new System.Drawing.Size(212, 25);
            this.tbPromedio.TabIndex = 7;
            // 
            // lbCal2
            // 
            this.lbCal2.AutoSize = true;
            this.lbCal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCal2.Location = new System.Drawing.Point(48, 117);
            this.lbCal2.Name = "lbCal2";
            this.lbCal2.Size = new System.Drawing.Size(162, 25);
            this.lbCal2.TabIndex = 8;
            this.lbCal2.Text = "Calificacion 2:";
            // 
            // lbCal3
            // 
            this.lbCal3.AutoSize = true;
            this.lbCal3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCal3.Location = new System.Drawing.Point(48, 154);
            this.lbCal3.Name = "lbCal3";
            this.lbCal3.Size = new System.Drawing.Size(162, 25);
            this.lbCal3.TabIndex = 9;
            this.lbCal3.Text = "Calificacion 3:";
            // 
            // lbCal4
            // 
            this.lbCal4.AutoSize = true;
            this.lbCal4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCal4.Location = new System.Drawing.Point(48, 190);
            this.lbCal4.Name = "lbCal4";
            this.lbCal4.Size = new System.Drawing.Size(162, 25);
            this.lbCal4.TabIndex = 10;
            this.lbCal4.Text = "Calificacion 4:";
            // 
            // lbCal5
            // 
            this.lbCal5.AutoSize = true;
            this.lbCal5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCal5.Location = new System.Drawing.Point(48, 229);
            this.lbCal5.Name = "lbCal5";
            this.lbCal5.Size = new System.Drawing.Size(162, 25);
            this.lbCal5.TabIndex = 11;
            this.lbCal5.Text = "Calificacion 5:";
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(216, 89);
            this.tb1.Multiline = true;
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(66, 25);
            this.tb1.TabIndex = 12;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(216, 123);
            this.tb2.Multiline = true;
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(66, 25);
            this.tb2.TabIndex = 13;
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(216, 160);
            this.tb3.Multiline = true;
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(66, 25);
            this.tb3.TabIndex = 14;
            // 
            // tb4
            // 
            this.tb4.Location = new System.Drawing.Point(216, 196);
            this.tb4.Multiline = true;
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(66, 25);
            this.tb4.TabIndex = 15;
            // 
            // tb5
            // 
            this.tb5.Location = new System.Drawing.Point(216, 235);
            this.tb5.Multiline = true;
            this.tb5.Name = "tb5";
            this.tb5.Size = new System.Drawing.Size(66, 25);
            this.tb5.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(624, 461);
            this.Controls.Add(this.tb5);
            this.Controls.Add(this.tb4);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.lbCal5);
            this.Controls.Add(this.lbCal4);
            this.Controls.Add(this.lbCal3);
            this.Controls.Add(this.lbCal2);
            this.Controls.Add(this.tbPromedio);
            this.Controls.Add(this.lbPromedio);
            this.Controls.Add(this.btnPromedio);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.tbAlumno);
            this.Controls.Add(this.lbCal1);
            this.Controls.Add(this.lbAlumno);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAlumno;
        private System.Windows.Forms.Label lbCal1;
        private System.Windows.Forms.TextBox tbAlumno;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnPromedio;
        private System.Windows.Forms.Label lbPromedio;
        private System.Windows.Forms.TextBox tbPromedio;
        private System.Windows.Forms.Label lbCal2;
        private System.Windows.Forms.Label lbCal3;
        private System.Windows.Forms.Label lbCal4;
        private System.Windows.Forms.Label lbCal5;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.TextBox tb4;
        private System.Windows.Forms.TextBox tb5;
    }
}

