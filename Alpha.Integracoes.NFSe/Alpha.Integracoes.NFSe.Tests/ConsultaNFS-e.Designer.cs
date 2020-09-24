namespace Alpha.Integracoes.NFSe.Tests
{
    partial class Consulta_NFS_e
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
            this.btnConsultarNFSe = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.StatusNFSe = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtInscricaoMunicipal_Prestador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCNPJ_Prestador = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConsultarNFSe
            // 
            this.btnConsultarNFSe.BackColor = System.Drawing.Color.Silver;
            this.btnConsultarNFSe.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnConsultarNFSe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConsultarNFSe.Location = new System.Drawing.Point(434, 47);
            this.btnConsultarNFSe.Name = "btnConsultarNFSe";
            this.btnConsultarNFSe.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarNFSe.TabIndex = 32;
            this.btnConsultarNFSe.Text = "Consultar";
            this.btnConsultarNFSe.UseVisualStyleBackColor = false;
            this.btnConsultarNFSe.Click += new System.EventHandler(this.btnConsultarNFSe_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 186);
            this.panel1.TabIndex = 33;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.StatusNFSe);
            this.panel3.Location = new System.Drawing.Point(17, 101);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(565, 77);
            this.panel3.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(224, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Status da Operação";
            // 
            // StatusNFSe
            // 
            this.StatusNFSe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusNFSe.AutoSize = true;
            this.StatusNFSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusNFSe.Location = new System.Drawing.Point(250, 40);
            this.StatusNFSe.Name = "StatusNFSe";
            this.StatusNFSe.Size = new System.Drawing.Size(66, 24);
            this.StatusNFSe.TabIndex = 8;
            this.StatusNFSe.Text = "Status";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtInscricaoMunicipal_Prestador);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnConsultarNFSe);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtCNPJ_Prestador);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(17, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(565, 86);
            this.panel2.TabIndex = 33;
            // 
            // txtInscricaoMunicipal_Prestador
            // 
            this.txtInscricaoMunicipal_Prestador.Location = new System.Drawing.Point(254, 50);
            this.txtInscricaoMunicipal_Prestador.Name = "txtInscricaoMunicipal_Prestador";
            this.txtInscricaoMunicipal_Prestador.Size = new System.Drawing.Size(153, 20);
            this.txtInscricaoMunicipal_Prestador.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Informe as Informações do Prestador do Serviço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "CPF/CNPJ:";
            // 
            // txtCNPJ_Prestador
            // 
            this.txtCNPJ_Prestador.Location = new System.Drawing.Point(20, 50);
            this.txtCNPJ_Prestador.Name = "txtCNPJ_Prestador";
            this.txtCNPJ_Prestador.Size = new System.Drawing.Size(170, 20);
            this.txtCNPJ_Prestador.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Inscrição Municipal:";
            // 
            // Consulta_NFS_e
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 190);
            this.Controls.Add(this.panel1);
            this.Name = "Consulta_NFS_e";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta_NFS_e";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsultarNFSe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtInscricaoMunicipal_Prestador;
        private System.Windows.Forms.TextBox txtCNPJ_Prestador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label StatusNFSe;
        private System.Windows.Forms.Panel panel2;
    }
}