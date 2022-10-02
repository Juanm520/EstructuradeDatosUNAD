namespace Fase1JuanRodriguez
{
    partial class Registro
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
            this.in_name_pet = new System.Windows.Forms.TextBox();
            this.inlist_estrato = new System.Windows.Forms.ComboBox();
            this.in_name_owner = new System.Windows.Forms.TextBox();
            this.in_id_owner = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.in_date = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inrd_service3 = new System.Windows.Forms.RadioButton();
            this.inrd_service2 = new System.Windows.Forms.RadioButton();
            this.inrd_service1 = new System.Windows.Forms.RadioButton();
            this.h1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_registro = new System.Windows.Forms.Button();
            this.bt_reporte = new System.Windows.Forms.Button();
            this.bt_salir = new System.Windows.Forms.Button();
            this.out_Cost_service = new System.Windows.Forms.Label();
            this.out_registercomplete = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // in_name_pet
            // 
            this.in_name_pet.Location = new System.Drawing.Point(216, 149);
            this.in_name_pet.Name = "in_name_pet";
            this.in_name_pet.Size = new System.Drawing.Size(274, 20);
            this.in_name_pet.TabIndex = 51;
            // 
            // inlist_estrato
            // 
            this.inlist_estrato.DisplayMember = "1";
            this.inlist_estrato.FormattingEnabled = true;
            this.inlist_estrato.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.inlist_estrato.Location = new System.Drawing.Point(216, 190);
            this.inlist_estrato.Name = "inlist_estrato";
            this.inlist_estrato.Size = new System.Drawing.Size(121, 21);
            this.inlist_estrato.TabIndex = 50;
            // 
            // in_name_owner
            // 
            this.in_name_owner.Location = new System.Drawing.Point(216, 106);
            this.in_name_owner.Name = "in_name_owner";
            this.in_name_owner.Size = new System.Drawing.Size(275, 20);
            this.in_name_owner.TabIndex = 49;
            // 
            // in_id_owner
            // 
            this.in_id_owner.Location = new System.Drawing.Point(217, 68);
            this.in_id_owner.Name = "in_id_owner";
            this.in_id_owner.Size = new System.Drawing.Size(124, 20);
            this.in_id_owner.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Estrato:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Nombre de la mascota:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Identificacion del Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Nombre y Apellidos del propietario:";
            // 
            // in_date
            // 
            this.in_date.Enabled = false;
            this.in_date.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.in_date.Location = new System.Drawing.Point(220, 333);
            this.in_date.MinDate = new System.DateTime(2022, 10, 1, 0, 0, 0, 0);
            this.in_date.Name = "in_date";
            this.in_date.Size = new System.Drawing.Size(271, 20);
            this.in_date.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "Hora y Fecha de registro:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inrd_service3);
            this.groupBox1.Controls.Add(this.inrd_service2);
            this.groupBox1.Controls.Add(this.inrd_service1);
            this.groupBox1.Location = new System.Drawing.Point(217, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 107);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Servicio";
            // 
            // inrd_service3
            // 
            this.inrd_service3.AutoSize = true;
            this.inrd_service3.Location = new System.Drawing.Point(19, 74);
            this.inrd_service3.Name = "inrd_service3";
            this.inrd_service3.Size = new System.Drawing.Size(265, 17);
            this.inrd_service3.TabIndex = 2;
            this.inrd_service3.TabStop = true;
            this.inrd_service3.Text = "Baño, corte, vacuna antigarrapatas y antiparasitos.";
            this.inrd_service3.UseVisualStyleBackColor = true;
            this.inrd_service3.CheckedChanged += new System.EventHandler(this.inrd_service3_CheckedChanged);
            // 
            // inrd_service2
            // 
            this.inrd_service2.AutoSize = true;
            this.inrd_service2.Location = new System.Drawing.Point(19, 51);
            this.inrd_service2.Name = "inrd_service2";
            this.inrd_service2.Size = new System.Drawing.Size(195, 17);
            this.inrd_service2.TabIndex = 1;
            this.inrd_service2.TabStop = true;
            this.inrd_service2.Text = "Baño, corte, vacuna antigarrapatas.";
            this.inrd_service2.UseVisualStyleBackColor = true;
            this.inrd_service2.CheckedChanged += new System.EventHandler(this.inrd_service2_CheckedChanged);
            // 
            // inrd_service1
            // 
            this.inrd_service1.AutoSize = true;
            this.inrd_service1.Location = new System.Drawing.Point(19, 28);
            this.inrd_service1.Name = "inrd_service1";
            this.inrd_service1.Size = new System.Drawing.Size(88, 17);
            this.inrd_service1.TabIndex = 0;
            this.inrd_service1.TabStop = true;
            this.inrd_service1.Text = "Baño y corte.";
            this.inrd_service1.UseVisualStyleBackColor = true;
            this.inrd_service1.CheckedChanged += new System.EventHandler(this.inrd_service1_CheckedChanged);
            // 
            // h1
            // 
            this.h1.AutoSize = true;
            this.h1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h1.Location = new System.Drawing.Point(123, 18);
            this.h1.Name = "h1";
            this.h1.Size = new System.Drawing.Size(368, 31);
            this.h1.TabIndex = 63;
            this.h1.Text = "Registro -Spa Mascotas App-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "Costo del Servicio:";
            // 
            // bt_registro
            // 
            this.bt_registro.Location = new System.Drawing.Point(220, 417);
            this.bt_registro.Name = "bt_registro";
            this.bt_registro.Size = new System.Drawing.Size(82, 44);
            this.bt_registro.TabIndex = 66;
            this.bt_registro.Text = "Registro";
            this.bt_registro.UseVisualStyleBackColor = true;
            this.bt_registro.Click += new System.EventHandler(this.bt_registro_Click);
            // 
            // bt_reporte
            // 
            this.bt_reporte.Location = new System.Drawing.Point(317, 417);
            this.bt_reporte.Name = "bt_reporte";
            this.bt_reporte.Size = new System.Drawing.Size(82, 44);
            this.bt_reporte.TabIndex = 67;
            this.bt_reporte.Text = "Reporte";
            this.bt_reporte.UseVisualStyleBackColor = true;
            this.bt_reporte.Click += new System.EventHandler(this.bt_reporte_Click);
            // 
            // bt_salir
            // 
            this.bt_salir.Location = new System.Drawing.Point(412, 417);
            this.bt_salir.Name = "bt_salir";
            this.bt_salir.Size = new System.Drawing.Size(82, 44);
            this.bt_salir.TabIndex = 68;
            this.bt_salir.Text = "Salir";
            this.bt_salir.UseVisualStyleBackColor = true;
            this.bt_salir.Click += new System.EventHandler(this.bt_salir_Click);
            // 
            // out_Cost_service
            // 
            this.out_Cost_service.AutoSize = true;
            this.out_Cost_service.BackColor = System.Drawing.SystemColors.Info;
            this.out_Cost_service.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.out_Cost_service.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.out_Cost_service.Location = new System.Drawing.Point(217, 366);
            this.out_Cost_service.Name = "out_Cost_service";
            this.out_Cost_service.Size = new System.Drawing.Size(2, 22);
            this.out_Cost_service.TabIndex = 69;
            // 
            // out_registercomplete
            // 
            this.out_registercomplete.AutoSize = true;
            this.out_registercomplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.out_registercomplete.ForeColor = System.Drawing.Color.ForestGreen;
            this.out_registercomplete.Location = new System.Drawing.Point(216, 464);
            this.out_registercomplete.Name = "out_registercomplete";
            this.out_registercomplete.Size = new System.Drawing.Size(0, 15);
            this.out_registercomplete.TabIndex = 70;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 489);
            this.Controls.Add(this.out_registercomplete);
            this.Controls.Add(this.out_Cost_service);
            this.Controls.Add(this.bt_salir);
            this.Controls.Add(this.bt_reporte);
            this.Controls.Add(this.bt_registro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.h1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.in_date);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.in_name_pet);
            this.Controls.Add(this.inlist_estrato);
            this.Controls.Add(this.in_name_owner);
            this.Controls.Add(this.in_id_owner);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Registro";
            this.Text = "Registro -Spa Mascotas App-";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox in_name_pet;
        private System.Windows.Forms.ComboBox inlist_estrato;
        private System.Windows.Forms.TextBox in_name_owner;
        private System.Windows.Forms.TextBox in_id_owner;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker in_date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton inrd_service3;
        private System.Windows.Forms.RadioButton inrd_service2;
        private System.Windows.Forms.RadioButton inrd_service1;
        private System.Windows.Forms.Label h1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_registro;
        private System.Windows.Forms.Button bt_reporte;
        private System.Windows.Forms.Button bt_salir;
        private System.Windows.Forms.Label out_Cost_service;
        private System.Windows.Forms.Label out_registercomplete;
    }
}