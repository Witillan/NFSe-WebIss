﻿namespace Alpha.Integracoes.NFSe.Tests
{
    partial class ConsultarLoteRps
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
            this.btnConsultarLoteRps = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtInscricaoMunicipal_Prestador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCNPJ_Prestador = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConsultarLoteRps
            // 
            this.btnConsultarLoteRps.BackColor = System.Drawing.Color.Silver;
            this.btnConsultarLoteRps.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnConsultarLoteRps.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConsultarLoteRps.Location = new System.Drawing.Point(460, 50);
            this.btnConsultarLoteRps.Name = "btnConsultarLoteRps";
            this.btnConsultarLoteRps.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarLoteRps.TabIndex = 33;
            this.btnConsultarLoteRps.Text = "Consultar";
            this.btnConsultarLoteRps.UseVisualStyleBackColor = false;
            this.btnConsultarLoteRps.Click += new System.EventHandler(this.btnConsultarLoteRps_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(565, 247);
            this.dataGridView1.TabIndex = 37;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtInscricaoMunicipal_Prestador);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnConsultarLoteRps);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtCNPJ_Prestador);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(565, 86);
            this.panel2.TabIndex = 36;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(222, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "NFSe Correspondente";
            // 
            // ConsultarLoteRps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 414);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Name = "ConsultarLoteRps";
            this.Text = "ConsultarLoteRps";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultarLoteRps;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtInscricaoMunicipal_Prestador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCNPJ_Prestador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}