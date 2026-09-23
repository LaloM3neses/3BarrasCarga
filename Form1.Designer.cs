namespace _3BarrasProgreso
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
            this.components = new System.ComponentModel.Container();
            this.lblParametro1 = new System.Windows.Forms.Label();
            this.panelBarra1 = new System.Windows.Forms.Panel();
            this.lblPorcentaje1 = new System.Windows.Forms.Label();
            this.lblParametro2 = new System.Windows.Forms.Label();
            this.panelBarra2 = new System.Windows.Forms.Panel();
            this.lblPorcentaje2 = new System.Windows.Forms.Label();
            this.lblParametro3 = new System.Windows.Forms.Label();
            this.panelBarra3 = new System.Windows.Forms.Panel();
            this.lblPorcentaje3 = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelFondo1 = new System.Windows.Forms.Panel();
            this.panelFondo2 = new System.Windows.Forms.Panel();
            this.panelFondo3 = new System.Windows.Forms.Panel();
            this.panelFondo1.SuspendLayout();
            this.panelFondo2.SuspendLayout();
            this.panelFondo3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblParametro1
            // 
            this.lblParametro1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParametro1.Location = new System.Drawing.Point(30, 105);
            this.lblParametro1.Name = "lblParametro1";
            this.lblParametro1.Size = new System.Drawing.Size(140, 20);
            this.lblParametro1.TabIndex = 0;
            this.lblParametro1.Text = "CPU";
            this.lblParametro1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBarra1
            // 
            this.panelBarra1.BackColor = System.Drawing.Color.LightGreen;
            this.panelBarra1.Location = new System.Drawing.Point(3, 3);
            this.panelBarra1.Name = "panelBarra1";
            this.panelBarra1.Size = new System.Drawing.Size(493, 22);
            this.panelBarra1.TabIndex = 1;
            // 
            // lblPorcentaje1
            // 
            this.lblPorcentaje1.AutoSize = true;
            this.lblPorcentaje1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentaje1.Location = new System.Drawing.Point(700, 105);
            this.lblPorcentaje1.Name = "lblPorcentaje1";
            this.lblPorcentaje1.Size = new System.Drawing.Size(28, 16);
            this.lblPorcentaje1.TabIndex = 2;
            this.lblPorcentaje1.Text = "0%";
            // 
            // lblParametro2
            // 
            this.lblParametro2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParametro2.Location = new System.Drawing.Point(12, 167);
            this.lblParametro2.Name = "lblParametro2";
            this.lblParametro2.Size = new System.Drawing.Size(158, 40);
            this.lblParametro2.TabIndex = 3;
            this.lblParametro2.Text = "Memoria RAM";
            this.lblParametro2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBarra2
            // 
            this.panelBarra2.BackColor = System.Drawing.Color.LightGreen;
            this.panelBarra2.Location = new System.Drawing.Point(5, 5);
            this.panelBarra2.Name = "panelBarra2";
            this.panelBarra2.Size = new System.Drawing.Size(493, 22);
            this.panelBarra2.TabIndex = 4;
            // 
            // lblPorcentaje2
            // 
            this.lblPorcentaje2.AutoSize = true;
            this.lblPorcentaje2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentaje2.Location = new System.Drawing.Point(700, 178);
            this.lblPorcentaje2.Name = "lblPorcentaje2";
            this.lblPorcentaje2.Size = new System.Drawing.Size(28, 16);
            this.lblPorcentaje2.TabIndex = 5;
            this.lblPorcentaje2.Text = "0%";
            // 
            // lblParametro3
            // 
            this.lblParametro3.AutoSize = true;
            this.lblParametro3.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblParametro3.Location = new System.Drawing.Point(44, 248);
            this.lblParametro3.Name = "lblParametro3";
            this.lblParametro3.Size = new System.Drawing.Size(115, 24);
            this.lblParametro3.TabIndex = 6;
            this.lblParametro3.Text = "Disco Duro";
            // 
            // panelBarra3
            // 
            this.panelBarra3.BackColor = System.Drawing.Color.LightGreen;
            this.panelBarra3.Location = new System.Drawing.Point(5, 6);
            this.panelBarra3.Name = "panelBarra3";
            this.panelBarra3.Size = new System.Drawing.Size(493, 22);
            this.panelBarra3.TabIndex = 7;
            // 
            // lblPorcentaje3
            // 
            this.lblPorcentaje3.AutoSize = true;
            this.lblPorcentaje3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentaje3.Location = new System.Drawing.Point(700, 251);
            this.lblPorcentaje3.Name = "lblPorcentaje3";
            this.lblPorcentaje3.Size = new System.Drawing.Size(28, 16);
            this.lblPorcentaje3.TabIndex = 8;
            this.lblPorcentaje3.Text = "0%";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(550, 351);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(140, 40);
            this.btnIniciar.TabIndex = 9;
            this.btnIniciar.Text = "Detectar Parametro";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelFondo1
            // 
            this.panelFondo1.BackColor = System.Drawing.Color.White;
            this.panelFondo1.Controls.Add(this.panelBarra1);
            this.panelFondo1.Location = new System.Drawing.Point(189, 99);
            this.panelFondo1.Name = "panelFondo1";
            this.panelFondo1.Size = new System.Drawing.Size(501, 30);
            this.panelFondo1.TabIndex = 10;
            // 
            // panelFondo2
            // 
            this.panelFondo2.BackColor = System.Drawing.Color.White;
            this.panelFondo2.Controls.Add(this.panelBarra2);
            this.panelFondo2.Location = new System.Drawing.Point(190, 167);
            this.panelFondo2.Name = "panelFondo2";
            this.panelFondo2.Size = new System.Drawing.Size(501, 32);
            this.panelFondo2.TabIndex = 11;
            // 
            // panelFondo3
            // 
            this.panelFondo3.BackColor = System.Drawing.Color.White;
            this.panelFondo3.Controls.Add(this.panelBarra3);
            this.panelFondo3.Location = new System.Drawing.Point(189, 248);
            this.panelFondo3.Name = "panelFondo3";
            this.panelFondo3.Size = new System.Drawing.Size(501, 35);
            this.panelFondo3.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelFondo3);
            this.Controls.Add(this.panelFondo2);
            this.Controls.Add(this.panelFondo1);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.lblPorcentaje3);
            this.Controls.Add(this.lblParametro3);
            this.Controls.Add(this.lblPorcentaje2);
            this.Controls.Add(this.lblParametro2);
            this.Controls.Add(this.lblPorcentaje1);
            this.Controls.Add(this.lblParametro1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelFondo1.ResumeLayout(false);
            this.panelFondo2.ResumeLayout(false);
            this.panelFondo3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblParametro1;
        private System.Windows.Forms.Panel panelBarra1;
        private System.Windows.Forms.Label lblPorcentaje1;
        private System.Windows.Forms.Label lblParametro2;
        private System.Windows.Forms.Panel panelBarra2;
        private System.Windows.Forms.Label lblPorcentaje2;
        private System.Windows.Forms.Label lblParametro3;
        private System.Windows.Forms.Panel panelBarra3;
        private System.Windows.Forms.Label lblPorcentaje3;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelFondo1;
        private System.Windows.Forms.Panel panelFondo2;
        private System.Windows.Forms.Panel panelFondo3;
    }
}

