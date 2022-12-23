namespace Calcular_Frete
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtValorCombus = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbxTabela = new System.Windows.Forms.ComboBox();
            this.chbxIdaVolta = new System.Windows.Forms.CheckBox();
            this.txtAutonomia = new System.Windows.Forms.TextBox();
            this.txtDistKm = new System.Windows.Forms.TextBox();
            this.txtLocalidade = new System.Windows.Forms.TextBox();
            this.txtVeiculo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtConsumoCom = new System.Windows.Forms.TextBox();
            this.txtDespesaCom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCustoKm = new System.Windows.Forms.TextBox();
            this.txtKmRodado = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.imgVeiculo = new System.Windows.Forms.PictureBox();
            this.imgFrete = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgVeiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFrete)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.txtValorCombus);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.cbxTabela);
            this.panel1.Controls.Add(this.chbxIdaVolta);
            this.panel1.Controls.Add(this.txtAutonomia);
            this.panel1.Controls.Add(this.txtDistKm);
            this.panel1.Controls.Add(this.txtLocalidade);
            this.panel1.Controls.Add(this.txtVeiculo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.imgFrete);
            this.panel1.Location = new System.Drawing.Point(12, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 153);
            this.panel1.TabIndex = 0;
            // 
            // txtValorCombus
            // 
            this.txtValorCombus.Location = new System.Drawing.Point(9, 102);
            this.txtValorCombus.Name = "txtValorCombus";
            this.txtValorCombus.Size = new System.Drawing.Size(110, 20);
            this.txtValorCombus.TabIndex = 5;
            this.txtValorCombus.Leave += new System.EventHandler(this.txtValorCombus_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Valor do combustível: ";
            // 
            // cbxTabela
            // 
            this.cbxTabela.FormattingEnabled = true;
            this.cbxTabela.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbxTabela.Location = new System.Drawing.Point(140, 102);
            this.cbxTabela.Name = "cbxTabela";
            this.cbxTabela.Size = new System.Drawing.Size(105, 21);
            this.cbxTabela.TabIndex = 6;
            this.cbxTabela.Leave += new System.EventHandler(this.cbxTabela_Leave);
            // 
            // chbxIdaVolta
            // 
            this.chbxIdaVolta.AutoSize = true;
            this.chbxIdaVolta.Location = new System.Drawing.Point(386, 58);
            this.chbxIdaVolta.Name = "chbxIdaVolta";
            this.chbxIdaVolta.Size = new System.Drawing.Size(76, 17);
            this.chbxIdaVolta.TabIndex = 4;
            this.chbxIdaVolta.Text = "Ida / Volta";
            this.chbxIdaVolta.UseVisualStyleBackColor = true;
            // 
            // txtAutonomia
            // 
            this.txtAutonomia.Location = new System.Drawing.Point(264, 102);
            this.txtAutonomia.Name = "txtAutonomia";
            this.txtAutonomia.Size = new System.Drawing.Size(51, 20);
            this.txtAutonomia.TabIndex = 7;
            this.txtAutonomia.Leave += new System.EventHandler(this.txtAutonomia_Leave);
            // 
            // txtDistKm
            // 
            this.txtDistKm.Location = new System.Drawing.Point(316, 37);
            this.txtDistKm.Name = "txtDistKm";
            this.txtDistKm.Size = new System.Drawing.Size(146, 20);
            this.txtDistKm.TabIndex = 3;
            this.txtDistKm.Leave += new System.EventHandler(this.txtDistKm_Leave);
            // 
            // txtLocalidade
            // 
            this.txtLocalidade.Location = new System.Drawing.Point(164, 37);
            this.txtLocalidade.Name = "txtLocalidade";
            this.txtLocalidade.Size = new System.Drawing.Size(146, 20);
            this.txtLocalidade.TabIndex = 2;
            this.txtLocalidade.Leave += new System.EventHandler(this.txtLocalidade_Leave);
            // 
            // txtVeiculo
            // 
            this.txtVeiculo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtVeiculo.Location = new System.Drawing.Point(9, 37);
            this.txtVeiculo.Name = "txtVeiculo";
            this.txtVeiculo.Size = new System.Drawing.Size(146, 20);
            this.txtVeiculo.TabIndex = 1;
            this.txtVeiculo.Leave += new System.EventHandler(this.txtVeiculo_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tabela:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Autonomia combustível: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Distância Km:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Localidade:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Veículo:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(12, 199);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(104, 35);
            this.btnConfirmar.TabIndex = 8;
            this.btnConfirmar.Text = "Confirmar ";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(285, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(252, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "SISTEMA CÁLCULO FRETE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Consumo de combustível: ";
            // 
            // txtConsumoCom
            // 
            this.txtConsumoCom.Location = new System.Drawing.Point(170, 247);
            this.txtConsumoCom.Name = "txtConsumoCom";
            this.txtConsumoCom.Size = new System.Drawing.Size(111, 20);
            this.txtConsumoCom.TabIndex = 9;
            // 
            // txtDespesaCom
            // 
            this.txtDespesaCom.Location = new System.Drawing.Point(417, 247);
            this.txtDespesaCom.Name = "txtDespesaCom";
            this.txtDespesaCom.Size = new System.Drawing.Size(111, 20);
            this.txtDespesaCom.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(287, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Despesa do combustível: ";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(401, 310);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(127, 20);
            this.txtTotal.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(398, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Total:";
            // 
            // txtCustoKm
            // 
            this.txtCustoKm.Location = new System.Drawing.Point(170, 310);
            this.txtCustoKm.Name = "txtCustoKm";
            this.txtCustoKm.Size = new System.Drawing.Size(111, 20);
            this.txtCustoKm.TabIndex = 12;
            // 
            // txtKmRodado
            // 
            this.txtKmRodado.Location = new System.Drawing.Point(53, 310);
            this.txtKmRodado.Name = "txtKmRodado";
            this.txtKmRodado.Size = new System.Drawing.Size(111, 20);
            this.txtKmRodado.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(173, 294);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Custo por Km:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 294);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Km rodado:";
            // 
            // imgVeiculo
            // 
            this.imgVeiculo.Location = new System.Drawing.Point(534, 196);
            this.imgVeiculo.Name = "imgVeiculo";
            this.imgVeiculo.Size = new System.Drawing.Size(260, 142);
            this.imgVeiculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgVeiculo.TabIndex = 18;
            this.imgVeiculo.TabStop = false;
            // 
            // imgFrete
            // 
            this.imgFrete.Image = global::Calcular_Frete.Properties.Resources.Frete;
            this.imgFrete.Location = new System.Drawing.Point(484, 3);
            this.imgFrete.Name = "imgFrete";
            this.imgFrete.Size = new System.Drawing.Size(295, 147);
            this.imgFrete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFrete.TabIndex = 0;
            this.imgFrete.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(806, 342);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtKmRodado);
            this.Controls.Add(this.txtCustoKm);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDespesaCom);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.imgVeiculo);
            this.Controls.Add(this.txtConsumoCom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Principal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgVeiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFrete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chbxIdaVolta;
        private System.Windows.Forms.TextBox txtAutonomia;
        private System.Windows.Forms.TextBox txtDistKm;
        private System.Windows.Forms.TextBox txtLocalidade;
        private System.Windows.Forms.TextBox txtVeiculo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgFrete;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtConsumoCom;
        private System.Windows.Forms.PictureBox imgVeiculo;
        private System.Windows.Forms.TextBox txtDespesaCom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCustoKm;
        private System.Windows.Forms.TextBox txtKmRodado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbxTabela;
        private System.Windows.Forms.TextBox txtValorCombus;
        private System.Windows.Forms.Label label12;
    }
}

