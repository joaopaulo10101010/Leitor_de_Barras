namespace Leitor_de_Barras
{
    partial class Leitorinterface
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
            this.saidanumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.caminho = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ArquivosLocais = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.formato = new System.Windows.Forms.TextBox();
            this.saidacodigodebarrasp = new System.Windows.Forms.PictureBox();
            this.checkmanual = new System.Windows.Forms.CheckBox();
            this.btinserir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numerocodigoentrada = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tipobox = new System.Windows.Forms.ComboBox();
            this.imagemsaidacb = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.alerta = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saidacodigodebarrasp)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagemsaidacb)).BeginInit();
            this.SuspendLayout();
            // 
            // saidanumero
            // 
            this.saidanumero.Location = new System.Drawing.Point(384, 137);
            this.saidanumero.Name = "saidanumero";
            this.saidanumero.ReadOnly = true;
            this.saidanumero.Size = new System.Drawing.Size(321, 20);
            this.saidanumero.TabIndex = 0;
            this.saidanumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero:";
            // 
            // caminho
            // 
            this.caminho.Location = new System.Drawing.Point(65, 54);
            this.caminho.Name = "caminho";
            this.caminho.ReadOnly = true;
            this.caminho.Size = new System.Drawing.Size(242, 20);
            this.caminho.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Caminho:";
            // 
            // ArquivosLocais
            // 
            this.ArquivosLocais.Location = new System.Drawing.Point(11, 23);
            this.ArquivosLocais.Name = "ArquivosLocais";
            this.ArquivosLocais.Size = new System.Drawing.Size(94, 23);
            this.ArquivosLocais.TabIndex = 5;
            this.ArquivosLocais.Text = "Arquivos Locais";
            this.ArquivosLocais.UseVisualStyleBackColor = true;
            this.ArquivosLocais.Click += new System.EventHandler(this.ArquivosLocais_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Leitor de Codigo de Barras";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.formato);
            this.groupBox1.Controls.Add(this.saidacodigodebarrasp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkmanual);
            this.groupBox1.Controls.Add(this.btinserir);
            this.groupBox1.Controls.Add(this.caminho);
            this.groupBox1.Controls.Add(this.saidanumero);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ArquivosLocais);
            this.groupBox1.Location = new System.Drawing.Point(51, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 163);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Codigo de Barras";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tipo:";
            // 
            // formato
            // 
            this.formato.Location = new System.Drawing.Point(65, 80);
            this.formato.Name = "formato";
            this.formato.ReadOnly = true;
            this.formato.Size = new System.Drawing.Size(124, 20);
            this.formato.TabIndex = 10;
            // 
            // saidacodigodebarrasp
            // 
            this.saidacodigodebarrasp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.saidacodigodebarrasp.Location = new System.Drawing.Point(384, 13);
            this.saidacodigodebarrasp.Name = "saidacodigodebarrasp";
            this.saidacodigodebarrasp.Size = new System.Drawing.Size(321, 118);
            this.saidacodigodebarrasp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.saidacodigodebarrasp.TabIndex = 9;
            this.saidacodigodebarrasp.TabStop = false;
            this.saidacodigodebarrasp.Click += new System.EventHandler(this.saidacodigodebarrasp_Click);
            // 
            // checkmanual
            // 
            this.checkmanual.AutoSize = true;
            this.checkmanual.Location = new System.Drawing.Point(313, 56);
            this.checkmanual.Name = "checkmanual";
            this.checkmanual.Size = new System.Drawing.Size(61, 17);
            this.checkmanual.TabIndex = 8;
            this.checkmanual.Text = "Manual";
            this.checkmanual.UseVisualStyleBackColor = true;
            this.checkmanual.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btinserir
            // 
            this.btinserir.Enabled = false;
            this.btinserir.Location = new System.Drawing.Point(114, 23);
            this.btinserir.Name = "btinserir";
            this.btinserir.Size = new System.Drawing.Size(75, 23);
            this.btinserir.TabIndex = 6;
            this.btinserir.Text = "Inserir";
            this.btinserir.UseVisualStyleBackColor = true;
            this.btinserir.Click += new System.EventHandler(this.btinserir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.imagemsaidacb);
            this.groupBox2.Controls.Add(this.tipobox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.numerocodigoentrada);
            this.groupBox2.Location = new System.Drawing.Point(51, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(710, 182);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Criar codigo de barras";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter_1);
            // 
            // numerocodigoentrada
            // 
            this.numerocodigoentrada.Location = new System.Drawing.Point(114, 19);
            this.numerocodigoentrada.Name = "numerocodigoentrada";
            this.numerocodigoentrada.Size = new System.Drawing.Size(263, 20);
            this.numerocodigoentrada.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Numero do Codigo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tipo:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tipobox
            // 
            this.tipobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipobox.FormattingEnabled = true;
            this.tipobox.Items.AddRange(new object[] {
            "PLESSEY",
            "MSI",
            "QR_CODE",
            "ITF",
            "DATA_MATRIX",
            "CODE_128",
            "CODE_93",
            "CODE_39",
            "CODABAR",
            "AZTEC"});
            this.tipobox.Location = new System.Drawing.Point(54, 51);
            this.tipobox.Name = "tipobox";
            this.tipobox.Size = new System.Drawing.Size(237, 21);
            this.tipobox.TabIndex = 3;
            this.tipobox.SelectedIndexChanged += new System.EventHandler(this.tipobox_SelectedIndexChanged);
            // 
            // imagemsaidacb
            // 
            this.imagemsaidacb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagemsaidacb.Location = new System.Drawing.Point(384, 12);
            this.imagemsaidacb.Name = "imagemsaidacb";
            this.imagemsaidacb.Size = new System.Drawing.Size(320, 164);
            this.imagemsaidacb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagemsaidacb.TabIndex = 4;
            this.imagemsaidacb.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Criar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // alerta
            // 
            this.alerta.AutoSize = true;
            this.alerta.Location = new System.Drawing.Point(518, 228);
            this.alerta.Name = "alerta";
            this.alerta.Size = new System.Drawing.Size(35, 13);
            this.alerta.TabIndex = 9;
            this.alerta.Text = "label7";
            // 
            // Leitorinterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.alerta);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Name = "Leitorinterface";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saidacodigodebarrasp)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagemsaidacb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox saidanumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox caminho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ArquivosLocais;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btinserir;
        private System.Windows.Forms.CheckBox checkmanual;
        private System.Windows.Forms.PictureBox saidacodigodebarrasp;
        private System.Windows.Forms.TextBox formato;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox numerocodigoentrada;
        private System.Windows.Forms.ComboBox tipobox;
        private System.Windows.Forms.PictureBox imagemsaidacb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label alerta;
    }
}

