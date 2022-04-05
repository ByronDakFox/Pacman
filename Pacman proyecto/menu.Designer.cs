namespace Pacman_proyecto
{
    partial class OPCION
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OPCION));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblJugador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.Image = global::Pacman_proyecto.Properties.Resources.muerto11;
            this.btnCerrar.Location = new System.Drawing.Point(406, 284);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(85, 79);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnPlay.FlatAppearance.BorderSize = 6;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlay.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPlay.Image = global::Pacman_proyecto.Properties.Resources.play_p2;
            this.btnPlay.Location = new System.Drawing.Point(117, 304);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(123, 59);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(58, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Esta seguro que desear Jugar:";
            // 
            // lblJugador
            // 
            this.lblJugador.AutoSize = true;
            this.lblJugador.BackColor = System.Drawing.Color.Transparent;
            this.lblJugador.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJugador.ForeColor = System.Drawing.Color.Aqua;
            this.lblJugador.Location = new System.Drawing.Point(382, 119);
            this.lblJugador.Name = "lblJugador";
            this.lblJugador.Size = new System.Drawing.Size(136, 21);
            this.lblJugador.TabIndex = 4;
            this.lblJugador.Text = "------------------";
            // 
            // OPCION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.lblJugador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnPlay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OPCION";
            this.Text = "OPCION";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblJugador;
    }
}