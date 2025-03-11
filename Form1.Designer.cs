namespace Operaciones_Basicas
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
            this.bttSuma = new System.Windows.Forms.Button();
            this.bttResta = new System.Windows.Forms.Button();
            this.bttMultiplicacion = new System.Windows.Forms.Button();
            this.bttDivision = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txbNum1 = new System.Windows.Forms.TextBox();
            this.txbNum2 = new System.Windows.Forms.TextBox();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblSigno = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttSuma
            // 
            this.bttSuma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bttSuma.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold);
            this.bttSuma.Location = new System.Drawing.Point(126, 401);
            this.bttSuma.Name = "bttSuma";
            this.bttSuma.Size = new System.Drawing.Size(102, 37);
            this.bttSuma.TabIndex = 3;
            this.bttSuma.Text = "Sumar +";
            this.bttSuma.UseVisualStyleBackColor = false;
            this.bttSuma.Click += new System.EventHandler(this.bttSuma_Click);
            // 
            // bttResta
            // 
            this.bttResta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bttResta.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold);
            this.bttResta.Location = new System.Drawing.Point(271, 403);
            this.bttResta.Name = "bttResta";
            this.bttResta.Size = new System.Drawing.Size(100, 35);
            this.bttResta.TabIndex = 4;
            this.bttResta.Text = "Restar -";
            this.bttResta.UseVisualStyleBackColor = false;
            this.bttResta.Click += new System.EventHandler(this.bttResta_Click);
            // 
            // bttMultiplicacion
            // 
            this.bttMultiplicacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bttMultiplicacion.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttMultiplicacion.Location = new System.Drawing.Point(412, 403);
            this.bttMultiplicacion.Name = "bttMultiplicacion";
            this.bttMultiplicacion.Size = new System.Drawing.Size(100, 35);
            this.bttMultiplicacion.TabIndex = 5;
            this.bttMultiplicacion.Text = "Multiplicar x";
            this.bttMultiplicacion.UseVisualStyleBackColor = false;
            this.bttMultiplicacion.Click += new System.EventHandler(this.bttMultiplicacion_Click);
            // 
            // bttDivision
            // 
            this.bttDivision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bttDivision.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold);
            this.bttDivision.Location = new System.Drawing.Point(550, 401);
            this.bttDivision.Name = "bttDivision";
            this.bttDivision.Size = new System.Drawing.Size(100, 35);
            this.bttDivision.TabIndex = 6;
            this.bttDivision.Text = "Dividir /";
            this.bttDivision.UseVisualStyleBackColor = false;
            this.bttDivision.Click += new System.EventHandler(this.bttDivision_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Consolas", 50F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTitulo.Location = new System.Drawing.Point(186, -1);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(441, 79);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Nacho Opera";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbNum1
            // 
            this.txbNum1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txbNum1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNum1.Location = new System.Drawing.Point(50, 175);
            this.txbNum1.Name = "txbNum1";
            this.txbNum1.Size = new System.Drawing.Size(246, 31);
            this.txbNum1.TabIndex = 1;
            this.txbNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbNum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressNums);
            // 
            // txbNum2
            // 
            this.txbNum2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txbNum2.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.txbNum2.Location = new System.Drawing.Point(494, 175);
            this.txbNum2.Name = "txbNum2";
            this.txbNum2.Size = new System.Drawing.Size(248, 31);
            this.txbNum2.TabIndex = 2;
            this.txbNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbNum2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressNums);
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblNum2.Location = new System.Drawing.Point(490, 150);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(260, 22);
            this.lblNum2.TabIndex = 7;
            this.lblNum2.Text = "Ingrese el segundo numero";
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum1.Location = new System.Drawing.Point(46, 150);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(250, 22);
            this.lblNum1.TabIndex = 8;
            this.lblNum1.Text = "Ingrese el primer numero";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(183, 92);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(432, 38);
            this.lblDescripcion.TabIndex = 9;
            this.lblDescripcion.Text = "Ingresa dos numeros decimales para hacer alguna\r\n de las 4 operaciones basicas";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSigno
            // 
            this.lblSigno.Font = new System.Drawing.Font("Candara", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSigno.Location = new System.Drawing.Point(305, 150);
            this.lblSigno.Name = "lblSigno";
            this.lblSigno.Size = new System.Drawing.Size(179, 82);
            this.lblSigno.TabIndex = 10;
            this.lblSigno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResultado
            // 
            this.lblResultado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultado.Font = new System.Drawing.Font("Candara", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblResultado.Location = new System.Drawing.Point(50, 250);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(700, 100);
            this.lblResultado.TabIndex = 11;
            this.lblResultado.Text = "=";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(173, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Elige la operacion para ver el resultado\r\n\r\n\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblSigno);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.txbNum2);
            this.Controls.Add(this.txbNum1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.bttDivision);
            this.Controls.Add(this.bttMultiplicacion);
            this.Controls.Add(this.bttResta);
            this.Controls.Add(this.bttSuma);
            this.Name = "Form1";
            this.Text = "Nacho Opera";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttSuma;
        private System.Windows.Forms.Button bttResta;
        private System.Windows.Forms.Button bttMultiplicacion;
        private System.Windows.Forms.Button bttDivision;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txbNum1;
        private System.Windows.Forms.TextBox txbNum2;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblSigno;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label1;
    }
}

