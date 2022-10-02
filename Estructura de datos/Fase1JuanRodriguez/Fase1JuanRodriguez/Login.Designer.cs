namespace Fase1JuanRodriguez
{
    partial class Login
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
            this.h1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_send_pass = new System.Windows.Forms.Button();
            this.in_pass = new System.Windows.Forms.TextBox();
            this.label_wrongpass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // h1
            // 
            this.h1.AutoSize = true;
            this.h1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h1.Location = new System.Drawing.Point(21, 9);
            this.h1.Name = "h1";
            this.h1.Size = new System.Drawing.Size(324, 39);
            this.h1.TabIndex = 0;
            this.h1.Text = "Estructura de Datos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Juan Manuel Rodriguez Lanza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 89);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Acceso a la Aplicación";
            // 
            // bt_send_pass
            // 
            this.bt_send_pass.Location = new System.Drawing.Point(137, 179);
            this.bt_send_pass.Name = "bt_send_pass";
            this.bt_send_pass.Size = new System.Drawing.Size(75, 23);
            this.bt_send_pass.TabIndex = 4;
            this.bt_send_pass.Text = "Ingresar";
            this.bt_send_pass.UseVisualStyleBackColor = true;
            this.bt_send_pass.Click += new System.EventHandler(this.bt_send_pass_Click);
            // 
            // in_pass
            // 
            this.in_pass.Location = new System.Drawing.Point(125, 124);
            this.in_pass.Name = "in_pass";
            this.in_pass.PasswordChar = '*';
            this.in_pass.Size = new System.Drawing.Size(100, 20);
            this.in_pass.TabIndex = 9;
            // 
            // label_wrongpass
            // 
            this.label_wrongpass.AutoSize = true;
            this.label_wrongpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_wrongpass.ForeColor = System.Drawing.Color.DarkRed;
            this.label_wrongpass.Location = new System.Drawing.Point(122, 163);
            this.label_wrongpass.Name = "label_wrongpass";
            this.label_wrongpass.Size = new System.Drawing.Size(0, 13);
            this.label_wrongpass.TabIndex = 10;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 242);
            this.Controls.Add(this.label_wrongpass);
            this.Controls.Add(this.in_pass);
            this.Controls.Add(this.bt_send_pass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.h1);
            this.Name = "Login";
            this.Text = "Login -Spa Mascotas App-";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label h1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_send_pass;
        private System.Windows.Forms.TextBox in_pass;
        private System.Windows.Forms.Label label_wrongpass;
    }
}

