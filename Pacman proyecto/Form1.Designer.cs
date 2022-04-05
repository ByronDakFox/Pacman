namespace Pacman_proyecto
{
    partial class INICIO
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(INICIO));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.txtJugador = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblPorce = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(240, 341);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(252, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(187, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre: ";
            // 
            // txtJugador
            // 
            this.txtJugador.Location = new System.Drawing.Point(309, 186);
            this.txtJugador.Name = "txtJugador";
            this.txtJugador.Size = new System.Drawing.Size(153, 22);
            this.txtJugador.TabIndex = 4;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAceptar.BackgroundImage = global::Pacman_proyecto.Properties.Resources.star1;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAceptar.FlatAppearance.BorderSize = 3;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Image = global::Pacman_proyecto.Properties.Resources.star1;
            this.btnAceptar.Location = new System.Drawing.Point(289, 268);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(150, 52);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            this.btnAceptar.Move += new System.EventHandler(this.button1_Move);
            // 
            // lblPorce
            // 
            this.lblPorce.AutoSize = true;
            this.lblPorce.BackColor = System.Drawing.Color.Transparent;
            this.lblPorce.Font = new System.Drawing.Font("Digital-7", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorce.ForeColor = System.Drawing.Color.Yellow;
            this.lblPorce.Location = new System.Drawing.Point(340, 367);
            this.lblPorce.Name = "lblPorce";
            this.lblPorce.Size = new System.Drawing.Size(0, 25);
            this.lblPorce.TabIndex = 5;
            // 
            // INICIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 477);
            this.Controls.Add(this.lblPorce);
            this.Controls.Add(this.txtJugador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.progressBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "INICIO";
            this.Text = "INICIO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtJugador;
        private System.Windows.Forms.Label lblPorce;
    }
}

