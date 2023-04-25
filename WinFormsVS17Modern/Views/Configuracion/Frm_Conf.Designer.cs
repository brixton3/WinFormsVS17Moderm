namespace WinFormsVS17Modern.Views.Configuracion
{
    partial class Frm_Conf
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
            this.brixPanel1 = new BrixComponente.BrixPanel();
            this.GBAccesosDB = new System.Windows.Forms.GroupBox();
            this.GBCateCA = new System.Windows.Forms.GroupBox();
            this.CBoxReporteCA = new System.Windows.Forms.CheckBox();
            this.CBHabCateCA = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CBTipoCuentaCA = new System.Windows.Forms.ComboBox();
            this.GBCateMDQ = new System.Windows.Forms.GroupBox();
            this.CBoxReporteMDQ = new System.Windows.Forms.CheckBox();
            this.CBHabCateMDQ = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CBTipoCuentaMDQ = new System.Windows.Forms.ComboBox();
            this.GBCateLP = new System.Windows.Forms.GroupBox();
            this.CBoxReporteLP = new System.Windows.Forms.CheckBox();
            this.CBHabCateLP = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CBTipoCuentaLP = new System.Windows.Forms.ComboBox();
            this.GBDatos = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.GBPrivilegios = new System.Windows.Forms.GroupBox();
            this.cbVerUsuarios = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.BtnCrear = new System.Windows.Forms.Button();
            this.brixPanel1.SuspendLayout();
            this.GBAccesosDB.SuspendLayout();
            this.GBCateCA.SuspendLayout();
            this.GBCateMDQ.SuspendLayout();
            this.GBCateLP.SuspendLayout();
            this.GBDatos.SuspendLayout();
            this.GBPrivilegios.SuspendLayout();
            this.SuspendLayout();
            // 
            // brixPanel1
            // 
            this.brixPanel1.BackColor = System.Drawing.Color.White;
            this.brixPanel1.BorderRadius = 0;
            this.brixPanel1.Controls.Add(this.GBAccesosDB);
            this.brixPanel1.Controls.Add(this.GBDatos);
            this.brixPanel1.Controls.Add(this.label6);
            this.brixPanel1.Controls.Add(this.btnLimpiar);
            this.brixPanel1.Controls.Add(this.btnCancelar);
            this.brixPanel1.Controls.Add(this.BtnCrear);
            this.brixPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.brixPanel1.ForeColor = System.Drawing.Color.Black;
            this.brixPanel1.GradientAngle = 90F;
            this.brixPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(219)))), ((int)(((byte)(236)))));
            this.brixPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(20)))));
            this.brixPanel1.Location = new System.Drawing.Point(0, 0);
            this.brixPanel1.Name = "brixPanel1";
            this.brixPanel1.Size = new System.Drawing.Size(824, 532);
            this.brixPanel1.TabIndex = 0;
            // 
            // GBAccesosDB
            // 
            this.GBAccesosDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(74)))), ((int)(((byte)(91)))));
            this.GBAccesosDB.Controls.Add(this.GBCateCA);
            this.GBAccesosDB.Controls.Add(this.GBCateMDQ);
            this.GBAccesosDB.Controls.Add(this.GBCateLP);
            this.GBAccesosDB.Location = new System.Drawing.Point(22, 249);
            this.GBAccesosDB.Name = "GBAccesosDB";
            this.GBAccesosDB.Size = new System.Drawing.Size(781, 214);
            this.GBAccesosDB.TabIndex = 28;
            this.GBAccesosDB.TabStop = false;
            this.GBAccesosDB.Text = "Accesos a DB";
            // 
            // GBCateCA
            // 
            this.GBCateCA.BackColor = System.Drawing.Color.LightGray;
            this.GBCateCA.Controls.Add(this.CBoxReporteCA);
            this.GBCateCA.Controls.Add(this.CBHabCateCA);
            this.GBCateCA.Controls.Add(this.label9);
            this.GBCateCA.Controls.Add(this.CBTipoCuentaCA);
            this.GBCateCA.Location = new System.Drawing.Point(531, 32);
            this.GBCateCA.Name = "GBCateCA";
            this.GBCateCA.Size = new System.Drawing.Size(244, 157);
            this.GBCateCA.TabIndex = 27;
            this.GBCateCA.TabStop = false;
            this.GBCateCA.Text = "Cate Campana";
            // 
            // CBoxReporteCA
            // 
            this.CBoxReporteCA.AutoSize = true;
            this.CBoxReporteCA.Font = new System.Drawing.Font("Arial", 12F);
            this.CBoxReporteCA.Location = new System.Drawing.Point(119, 124);
            this.CBoxReporteCA.Name = "CBoxReporteCA";
            this.CBoxReporteCA.Size = new System.Drawing.Size(119, 22);
            this.CBoxReporteCA.TabIndex = 16;
            this.CBoxReporteCA.Text = "Ver Reportes";
            this.CBoxReporteCA.UseVisualStyleBackColor = true;
            // 
            // CBHabCateCA
            // 
            this.CBHabCateCA.AutoSize = true;
            this.CBHabCateCA.Font = new System.Drawing.Font("Arial", 12F);
            this.CBHabCateCA.Location = new System.Drawing.Point(15, 31);
            this.CBHabCateCA.Name = "CBHabCateCA";
            this.CBHabCateCA.Size = new System.Drawing.Size(168, 22);
            this.CBHabCateCA.TabIndex = 14;
            this.CBHabCateCA.Text = "Habilitar Acceso CA";
            this.CBHabCateCA.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 18);
            this.label9.TabIndex = 14;
            this.label9.Text = "Tipo de cuenta";
            // 
            // CBTipoCuentaCA
            // 
            this.CBTipoCuentaCA.FormattingEnabled = true;
            this.CBTipoCuentaCA.Location = new System.Drawing.Point(7, 94);
            this.CBTipoCuentaCA.Name = "CBTipoCuentaCA";
            this.CBTipoCuentaCA.Size = new System.Drawing.Size(231, 21);
            this.CBTipoCuentaCA.TabIndex = 15;
            // 
            // GBCateMDQ
            // 
            this.GBCateMDQ.BackColor = System.Drawing.Color.LightGray;
            this.GBCateMDQ.Controls.Add(this.CBoxReporteMDQ);
            this.GBCateMDQ.Controls.Add(this.CBHabCateMDQ);
            this.GBCateMDQ.Controls.Add(this.label8);
            this.GBCateMDQ.Controls.Add(this.CBTipoCuentaMDQ);
            this.GBCateMDQ.Location = new System.Drawing.Point(274, 32);
            this.GBCateMDQ.Name = "GBCateMDQ";
            this.GBCateMDQ.Size = new System.Drawing.Size(238, 157);
            this.GBCateMDQ.TabIndex = 26;
            this.GBCateMDQ.TabStop = false;
            this.GBCateMDQ.Text = "Cate Mar Del Plata";
            // 
            // CBoxReporteMDQ
            // 
            this.CBoxReporteMDQ.AutoSize = true;
            this.CBoxReporteMDQ.Font = new System.Drawing.Font("Arial", 12F);
            this.CBoxReporteMDQ.Location = new System.Drawing.Point(113, 124);
            this.CBoxReporteMDQ.Name = "CBoxReporteMDQ";
            this.CBoxReporteMDQ.Size = new System.Drawing.Size(119, 22);
            this.CBoxReporteMDQ.TabIndex = 13;
            this.CBoxReporteMDQ.Text = "Ver Reportes";
            this.CBoxReporteMDQ.UseVisualStyleBackColor = true;
            // 
            // CBHabCateMDQ
            // 
            this.CBHabCateMDQ.AutoSize = true;
            this.CBHabCateMDQ.Font = new System.Drawing.Font("Arial", 12F);
            this.CBHabCateMDQ.Location = new System.Drawing.Point(13, 31);
            this.CBHabCateMDQ.Name = "CBHabCateMDQ";
            this.CBHabCateMDQ.Size = new System.Drawing.Size(182, 22);
            this.CBHabCateMDQ.TabIndex = 11;
            this.CBHabCateMDQ.Text = "Habilitar Acceso MDQ";
            this.CBHabCateMDQ.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tipo de cuenta";
            // 
            // CBTipoCuentaMDQ
            // 
            this.CBTipoCuentaMDQ.FormattingEnabled = true;
            this.CBTipoCuentaMDQ.Location = new System.Drawing.Point(5, 94);
            this.CBTipoCuentaMDQ.Name = "CBTipoCuentaMDQ";
            this.CBTipoCuentaMDQ.Size = new System.Drawing.Size(231, 21);
            this.CBTipoCuentaMDQ.TabIndex = 12;
            // 
            // GBCateLP
            // 
            this.GBCateLP.BackColor = System.Drawing.Color.LightGray;
            this.GBCateLP.Controls.Add(this.CBoxReporteLP);
            this.GBCateLP.Controls.Add(this.CBHabCateLP);
            this.GBCateLP.Controls.Add(this.label2);
            this.GBCateLP.Controls.Add(this.CBTipoCuentaLP);
            this.GBCateLP.Location = new System.Drawing.Point(6, 32);
            this.GBCateLP.Name = "GBCateLP";
            this.GBCateLP.Size = new System.Drawing.Size(243, 157);
            this.GBCateLP.TabIndex = 25;
            this.GBCateLP.TabStop = false;
            this.GBCateLP.Text = "Cate La Plata";
            // 
            // CBoxReporteLP
            // 
            this.CBoxReporteLP.AutoSize = true;
            this.CBoxReporteLP.Font = new System.Drawing.Font("Arial", 12F);
            this.CBoxReporteLP.Location = new System.Drawing.Point(118, 124);
            this.CBoxReporteLP.Name = "CBoxReporteLP";
            this.CBoxReporteLP.Size = new System.Drawing.Size(119, 22);
            this.CBoxReporteLP.TabIndex = 10;
            this.CBoxReporteLP.Text = "Ver Reportes";
            this.CBoxReporteLP.UseVisualStyleBackColor = true;
            // 
            // CBHabCateLP
            // 
            this.CBHabCateLP.AutoSize = true;
            this.CBHabCateLP.Font = new System.Drawing.Font("Arial", 12F);
            this.CBHabCateLP.Location = new System.Drawing.Point(18, 31);
            this.CBHabCateLP.Name = "CBHabCateLP";
            this.CBHabCateLP.Size = new System.Drawing.Size(165, 22);
            this.CBHabCateLP.TabIndex = 8;
            this.CBHabCateLP.Text = "Habilitar Acceso LP";
            this.CBHabCateLP.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipo de cuenta";
            // 
            // CBTipoCuentaLP
            // 
            this.CBTipoCuentaLP.FormattingEnabled = true;
            this.CBTipoCuentaLP.Location = new System.Drawing.Point(7, 94);
            this.CBTipoCuentaLP.Name = "CBTipoCuentaLP";
            this.CBTipoCuentaLP.Size = new System.Drawing.Size(231, 21);
            this.CBTipoCuentaLP.TabIndex = 9;
            // 
            // GBDatos
            // 
            this.GBDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(74)))), ((int)(((byte)(91)))));
            this.GBDatos.Controls.Add(this.label7);
            this.GBDatos.Controls.Add(this.GBPrivilegios);
            this.GBDatos.Controls.Add(this.label3);
            this.GBDatos.Controls.Add(this.button1);
            this.GBDatos.Controls.Add(this.txtpass);
            this.GBDatos.Controls.Add(this.txtApellido);
            this.GBDatos.Controls.Add(this.txtuser);
            this.GBDatos.Controls.Add(this.txtLegajo);
            this.GBDatos.Controls.Add(this.label5);
            this.GBDatos.Controls.Add(this.txtnombre);
            this.GBDatos.Controls.Add(this.label1);
            this.GBDatos.Controls.Add(this.label4);
            this.GBDatos.Location = new System.Drawing.Point(22, 47);
            this.GBDatos.Name = "GBDatos";
            this.GBDatos.Size = new System.Drawing.Size(781, 196);
            this.GBDatos.TabIndex = 27;
            this.GBDatos.TabStop = false;
            this.GBDatos.Text = "Datos Personales";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nombre de Usuario:";
            // 
            // GBPrivilegios
            // 
            this.GBPrivilegios.Controls.Add(this.cbVerUsuarios);
            this.GBPrivilegios.Location = new System.Drawing.Point(403, 97);
            this.GBPrivilegios.Name = "GBPrivilegios";
            this.GBPrivilegios.Size = new System.Drawing.Size(358, 81);
            this.GBPrivilegios.TabIndex = 20;
            this.GBPrivilegios.TabStop = false;
            this.GBPrivilegios.Text = "Privilegios Administrador";
            // 
            // cbVerUsuarios
            // 
            this.cbVerUsuarios.AutoSize = true;
            this.cbVerUsuarios.Font = new System.Drawing.Font("Arial", 12F);
            this.cbVerUsuarios.Location = new System.Drawing.Point(82, 33);
            this.cbVerUsuarios.Name = "cbVerUsuarios";
            this.cbVerUsuarios.Size = new System.Drawing.Size(210, 22);
            this.cbVerUsuarios.TabIndex = 7;
            this.cbVerUsuarios.Text = "Ver Usuarios y/o modificar";
            this.cbVerUsuarios.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contraseña:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(448, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Comprobar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(192, 57);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.ShortcutsEnabled = false;
            this.txtpass.Size = new System.Drawing.Size(236, 20);
            this.txtpass.TabIndex = 3;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(126, 128);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(241, 20);
            this.txtApellido.TabIndex = 5;
            // 
            // txtuser
            // 
            this.txtuser.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtuser.Location = new System.Drawing.Point(191, 31);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(237, 20);
            this.txtuser.TabIndex = 1;
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(126, 158);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(241, 20);
            this.txtLegajo.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Apellido:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(127, 97);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(241, 20);
            this.txtnombre.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Legajo:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(292, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(257, 24);
            this.label6.TabIndex = 23;
            this.label6.Text = "Alta de Nuevos Usuarios";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(331, 469);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(144, 44);
            this.btnLimpiar.TabIndex = 25;
            this.btnLimpiar.Text = "Limpiar Campos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(516, 469);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(144, 44);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cerrar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // BtnCrear
            // 
            this.BtnCrear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrear.Location = new System.Drawing.Point(148, 469);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Size = new System.Drawing.Size(144, 44);
            this.BtnCrear.TabIndex = 24;
            this.BtnCrear.Text = "Crear cuenta";
            this.BtnCrear.UseVisualStyleBackColor = true;
            this.BtnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // Frm_Conf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 532);
            this.Controls.Add(this.brixPanel1);
            this.Name = "Frm_Conf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Conf";
            this.brixPanel1.ResumeLayout(false);
            this.brixPanel1.PerformLayout();
            this.GBAccesosDB.ResumeLayout(false);
            this.GBCateCA.ResumeLayout(false);
            this.GBCateCA.PerformLayout();
            this.GBCateMDQ.ResumeLayout(false);
            this.GBCateMDQ.PerformLayout();
            this.GBCateLP.ResumeLayout(false);
            this.GBCateLP.PerformLayout();
            this.GBDatos.ResumeLayout(false);
            this.GBDatos.PerformLayout();
            this.GBPrivilegios.ResumeLayout(false);
            this.GBPrivilegios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BrixComponente.BrixPanel brixPanel1;
        private System.Windows.Forms.GroupBox GBAccesosDB;
        private System.Windows.Forms.GroupBox GBCateCA;
        private System.Windows.Forms.CheckBox CBoxReporteCA;
        private System.Windows.Forms.CheckBox CBHabCateCA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CBTipoCuentaCA;
        private System.Windows.Forms.GroupBox GBCateMDQ;
        private System.Windows.Forms.CheckBox CBoxReporteMDQ;
        private System.Windows.Forms.CheckBox CBHabCateMDQ;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CBTipoCuentaMDQ;
        private System.Windows.Forms.GroupBox GBCateLP;
        private System.Windows.Forms.CheckBox CBoxReporteLP;
        private System.Windows.Forms.CheckBox CBHabCateLP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBTipoCuentaLP;
        private System.Windows.Forms.GroupBox GBDatos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox GBPrivilegios;
        private System.Windows.Forms.CheckBox cbVerUsuarios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button BtnCrear;
    }
}