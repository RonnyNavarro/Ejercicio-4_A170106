
namespace ServicioWebRonnyCliente
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
            this.BotonCuadrado = new System.Windows.Forms.Button();
            this.BotonTriangulo = new System.Windows.Forms.Button();
            this.BotonCirculo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LadoCuadradoTextBox = new System.Windows.Forms.TextBox();
            this.BaseTextBox = new System.Windows.Forms.TextBox();
            this.AlturaTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RadioTextBox = new System.Windows.Forms.TextBox();
            this.ResultadoLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BotonCuadrado
            // 
            this.BotonCuadrado.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCuadrado.Location = new System.Drawing.Point(358, 129);
            this.BotonCuadrado.Name = "BotonCuadrado";
            this.BotonCuadrado.Size = new System.Drawing.Size(153, 40);
            this.BotonCuadrado.TabIndex = 0;
            this.BotonCuadrado.Text = "Calcular Área de Cuadrado";
            this.BotonCuadrado.UseVisualStyleBackColor = true;
            this.BotonCuadrado.Click += new System.EventHandler(this.button1_Click);
            // 
            // BotonTriangulo
            // 
            this.BotonTriangulo.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonTriangulo.Location = new System.Drawing.Point(358, 246);
            this.BotonTriangulo.Name = "BotonTriangulo";
            this.BotonTriangulo.Size = new System.Drawing.Size(153, 41);
            this.BotonTriangulo.TabIndex = 1;
            this.BotonTriangulo.Text = "Calcular Área del Triángulo";
            this.BotonTriangulo.UseVisualStyleBackColor = true;
            this.BotonTriangulo.Click += new System.EventHandler(this.BotonTriangulo_Click);
            // 
            // BotonCirculo
            // 
            this.BotonCirculo.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCirculo.Location = new System.Drawing.Point(358, 353);
            this.BotonCirculo.Name = "BotonCirculo";
            this.BotonCirculo.Size = new System.Drawing.Size(153, 40);
            this.BotonCirculo.TabIndex = 2;
            this.BotonCirculo.Text = "Calcular Área del Círculo";
            this.BotonCirculo.UseVisualStyleBackColor = true;
            this.BotonCirculo.Click += new System.EventHandler(this.BotonCirculo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese el valor del lado del Cuadrado";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingrese los valores de Base y Altura del Triángulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Base:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // LadoCuadradoTextBox
            // 
            this.LadoCuadradoTextBox.Location = new System.Drawing.Point(143, 149);
            this.LadoCuadradoTextBox.Name = "LadoCuadradoTextBox";
            this.LadoCuadradoTextBox.Size = new System.Drawing.Size(100, 20);
            this.LadoCuadradoTextBox.TabIndex = 6;
            this.LadoCuadradoTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BaseTextBox
            // 
            this.BaseTextBox.Location = new System.Drawing.Point(59, 267);
            this.BaseTextBox.Name = "BaseTextBox";
            this.BaseTextBox.Size = new System.Drawing.Size(100, 20);
            this.BaseTextBox.TabIndex = 7;
            // 
            // AlturaTextBox
            // 
            this.AlturaTextBox.Location = new System.Drawing.Point(223, 265);
            this.AlturaTextBox.Name = "AlturaTextBox";
            this.AlturaTextBox.Size = new System.Drawing.Size(100, 20);
            this.AlturaTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(175, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Altura:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ingrese el valor del Radio del Círculo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Lado de Cuadrado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 376);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Radio:";
            // 
            // RadioTextBox
            // 
            this.RadioTextBox.Location = new System.Drawing.Point(67, 373);
            this.RadioTextBox.Name = "RadioTextBox";
            this.RadioTextBox.Size = new System.Drawing.Size(100, 20);
            this.RadioTextBox.TabIndex = 13;
            // 
            // ResultadoLabel
            // 
            this.ResultadoLabel.AutoSize = true;
            this.ResultadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultadoLabel.Location = new System.Drawing.Point(654, 236);
            this.ResultadoLabel.Name = "ResultadoLabel";
            this.ResultadoLabel.Size = new System.Drawing.Size(0, 39);
            this.ResultadoLabel.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(83, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(629, 35);
            this.label9.TabIndex = 15;
            this.label9.Text = "SERVICIO WEB PARA CALCULAR ÁREAS";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ResultadoLabel);
            this.Controls.Add(this.RadioTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AlturaTextBox);
            this.Controls.Add(this.BaseTextBox);
            this.Controls.Add(this.LadoCuadradoTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BotonCirculo);
            this.Controls.Add(this.BotonTriangulo);
            this.Controls.Add(this.BotonCuadrado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonCuadrado;
        private System.Windows.Forms.Button BotonTriangulo;
        private System.Windows.Forms.Button BotonCirculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LadoCuadradoTextBox;
        private System.Windows.Forms.TextBox BaseTextBox;
        private System.Windows.Forms.TextBox AlturaTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox RadioTextBox;
        private System.Windows.Forms.Label ResultadoLabel;
        private System.Windows.Forms.Label label9;
    }
}

