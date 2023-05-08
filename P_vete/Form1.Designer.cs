namespace P_vete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_vacunas = new System.Windows.Forms.Button();
            this.btn_desp = new System.Windows.Forms.Button();
            this.btn_mascotas = new System.Windows.Forms.Button();
            this.btn_cliente = new System.Windows.Forms.Button();
            this.btn_veterinario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_vacunas
            // 
            this.btn_vacunas.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_vacunas.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vacunas.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_vacunas.Image = ((System.Drawing.Image)(resources.GetObject("btn_vacunas.Image")));
            this.btn_vacunas.Location = new System.Drawing.Point(666, 330);
            this.btn_vacunas.Name = "btn_vacunas";
            this.btn_vacunas.Size = new System.Drawing.Size(201, 121);
            this.btn_vacunas.TabIndex = 11;
            this.btn_vacunas.Text = "Vacunas";
            this.btn_vacunas.UseVisualStyleBackColor = false;
            this.btn_vacunas.Click += new System.EventHandler(this.btn_vacunas_Click);
            // 
            // btn_desp
            // 
            this.btn_desp.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_desp.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_desp.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_desp.Image = ((System.Drawing.Image)(resources.GetObject("btn_desp.Image")));
            this.btn_desp.Location = new System.Drawing.Point(42, 330);
            this.btn_desp.Name = "btn_desp";
            this.btn_desp.Size = new System.Drawing.Size(201, 121);
            this.btn_desp.TabIndex = 10;
            this.btn_desp.Text = "Desparacitacion";
            this.btn_desp.UseVisualStyleBackColor = false;
            this.btn_desp.Click += new System.EventHandler(this.btn_desp_Click);
            // 
            // btn_mascotas
            // 
            this.btn_mascotas.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_mascotas.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mascotas.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_mascotas.Image = ((System.Drawing.Image)(resources.GetObject("btn_mascotas.Image")));
            this.btn_mascotas.Location = new System.Drawing.Point(666, 126);
            this.btn_mascotas.Name = "btn_mascotas";
            this.btn_mascotas.Size = new System.Drawing.Size(201, 119);
            this.btn_mascotas.TabIndex = 8;
            this.btn_mascotas.Text = "Mascotas";
            this.btn_mascotas.UseVisualStyleBackColor = false;
            this.btn_mascotas.Click += new System.EventHandler(this.btn_mascotas_Click);
            // 
            // btn_cliente
            // 
            this.btn_cliente.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_cliente.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cliente.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_cliente.Image = ((System.Drawing.Image)(resources.GetObject("btn_cliente.Image")));
            this.btn_cliente.Location = new System.Drawing.Point(364, 211);
            this.btn_cliente.Name = "btn_cliente";
            this.btn_cliente.Size = new System.Drawing.Size(201, 119);
            this.btn_cliente.TabIndex = 7;
            this.btn_cliente.Text = "Cliente";
            this.btn_cliente.UseVisualStyleBackColor = false;
            this.btn_cliente.Click += new System.EventHandler(this.btn_cliente_Click);
            // 
            // btn_veterinario
            // 
            this.btn_veterinario.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_veterinario.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_veterinario.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_veterinario.Image = ((System.Drawing.Image)(resources.GetObject("btn_veterinario.Image")));
            this.btn_veterinario.Location = new System.Drawing.Point(42, 126);
            this.btn_veterinario.Name = "btn_veterinario";
            this.btn_veterinario.Size = new System.Drawing.Size(201, 119);
            this.btn_veterinario.TabIndex = 6;
            this.btn_veterinario.Text = "Veterinario";
            this.btn_veterinario.UseVisualStyleBackColor = false;
            this.btn_veterinario.Click += new System.EventHandler(this.btn_veterinario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 44);
            this.label1.TabIndex = 12;
            this.label1.Text = "Veterinaria";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(902, 517);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_vacunas);
            this.Controls.Add(this.btn_desp);
            this.Controls.Add(this.btn_mascotas);
            this.Controls.Add(this.btn_cliente);
            this.Controls.Add(this.btn_veterinario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_vacunas;
        private System.Windows.Forms.Button btn_desp;
        private System.Windows.Forms.Button btn_mascotas;
        private System.Windows.Forms.Button btn_cliente;
        private System.Windows.Forms.Button btn_veterinario;
        private System.Windows.Forms.Label label1;
    }
}

