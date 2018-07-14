namespace Calculadora2
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.rconductor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.largo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.n_conductores_por_fase = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Vb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Sb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.d_fasciculos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mcm = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dab = new System.Windows.Forms.TextBox();
            this.dbc = new System.Windows.Forms.TextBox();
            this.dca = new System.Windows.Forms.TextBox();
            this.calcular = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cprima = new System.Windows.Forms.TextBox();
            this.lprima = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.rprima = new System.Windows.Forms.TextBox();
            this.Rprimaresultado = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rconductor [ Ohm/km ]";
            // 
            // rconductor
            // 
            this.rconductor.Location = new System.Drawing.Point(219, 37);
            this.rconductor.Name = "rconductor";
            this.rconductor.Size = new System.Drawing.Size(91, 20);
            this.rconductor.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Largo de la línea [ km ]";
            // 
            // largo
            // 
            this.largo.Location = new System.Drawing.Point(219, 105);
            this.largo.Name = "largo";
            this.largo.Size = new System.Drawing.Size(91, 20);
            this.largo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Número de conductores por fase";
            // 
            // n_conductores_por_fase
            // 
            this.n_conductores_por_fase.Location = new System.Drawing.Point(219, 71);
            this.n_conductores_por_fase.Name = "n_conductores_por_fase";
            this.n_conductores_por_fase.Size = new System.Drawing.Size(91, 20);
            this.n_conductores_por_fase.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Voltaje Base [ kV ]";
            // 
            // Vb
            // 
            this.Vb.Location = new System.Drawing.Point(219, 142);
            this.Vb.Name = "Vb";
            this.Vb.Size = new System.Drawing.Size(91, 20);
            this.Vb.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Potencia Base [ MVA ]";
            // 
            // Sb
            // 
            this.Sb.Location = new System.Drawing.Point(219, 176);
            this.Sb.Name = "Sb";
            this.Sb.Size = new System.Drawing.Size(91, 20);
            this.Sb.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Distancia entre fasciculos [m]";
            // 
            // d_fasciculos
            // 
            this.d_fasciculos.Location = new System.Drawing.Point(219, 210);
            this.d_fasciculos.Name = "d_fasciculos";
            this.d_fasciculos.Size = new System.Drawing.Size(91, 20);
            this.d_fasciculos.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(93, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Sección S [MCM]";
            // 
            // mcm
            // 
            this.mcm.Location = new System.Drawing.Point(219, 241);
            this.mcm.Name = "mcm";
            this.mcm.Size = new System.Drawing.Size(91, 20);
            this.mcm.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Distancia entre fase A y B [m]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 309);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Distancia entre fase B y C [m]";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 337);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Distancia entre fase C y A [m]";
            // 
            // dab
            // 
            this.dab.Location = new System.Drawing.Point(219, 276);
            this.dab.Name = "dab";
            this.dab.Size = new System.Drawing.Size(91, 20);
            this.dab.TabIndex = 18;
            // 
            // dbc
            // 
            this.dbc.Location = new System.Drawing.Point(219, 305);
            this.dbc.Name = "dbc";
            this.dbc.Size = new System.Drawing.Size(91, 20);
            this.dbc.TabIndex = 19;
            // 
            // dca
            // 
            this.dca.Location = new System.Drawing.Point(219, 336);
            this.dca.Name = "dca";
            this.dca.Size = new System.Drawing.Size(91, 20);
            this.dca.TabIndex = 20;
            // 
            // calcular
            // 
            this.calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcular.Location = new System.Drawing.Point(64, 375);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(232, 42);
            this.calcular.TabIndex = 21;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.boton_calcular);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cprima);
            this.groupBox1.Controls.Add(this.lprima);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.rprima);
            this.groupBox1.Controls.Add(this.Rprimaresultado);
            this.groupBox1.Location = new System.Drawing.Point(343, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 294);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultado";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(9, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 16);
            this.label13.TabIndex = 7;
            this.label13.Text = "C\' = ";
            // 
            // cprima
            // 
            this.cprima.Location = new System.Drawing.Point(46, 126);
            this.cprima.Name = "cprima";
            this.cprima.Size = new System.Drawing.Size(131, 20);
            this.cprima.TabIndex = 6;
            // 
            // lprima
            // 
            this.lprima.Location = new System.Drawing.Point(46, 84);
            this.lprima.Name = "lprima";
            this.lprima.Size = new System.Drawing.Size(131, 20);
            this.lprima.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(7, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 16);
            this.label12.TabIndex = 4;
            this.label12.Text = "L\' = ";
            // 
            // rprima
            // 
            this.rprima.Location = new System.Drawing.Point(46, 43);
            this.rprima.Name = "rprima";
            this.rprima.Size = new System.Drawing.Size(131, 20);
            this.rprima.TabIndex = 3;
            // 
            // Rprimaresultado
            // 
            this.Rprimaresultado.AutoSize = true;
            this.Rprimaresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rprimaresultado.Location = new System.Drawing.Point(7, 44);
            this.Rprimaresultado.Name = "Rprimaresultado";
            this.Rprimaresultado.Size = new System.Drawing.Size(34, 16);
            this.Rprimaresultado.TabIndex = 0;
            this.Rprimaresultado.Text = "R\' = ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 429);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.dca);
            this.Controls.Add(this.dbc);
            this.Controls.Add(this.dab);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mcm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.d_fasciculos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Sb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Vb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.n_conductores_por_fase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.largo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rconductor);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Calculadora de Parametros RLC";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rconductor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox largo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox n_conductores_por_fase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Vb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Sb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox d_fasciculos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox mcm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox dab;
        private System.Windows.Forms.TextBox dbc;
        private System.Windows.Forms.TextBox dca;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox cprima;
        private System.Windows.Forms.TextBox lprima;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox rprima;
        private System.Windows.Forms.Label Rprimaresultado;
    }
}

