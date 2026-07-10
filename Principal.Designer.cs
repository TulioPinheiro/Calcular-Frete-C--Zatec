namespace Calcular_Frete_C__Zatec
{
    partial class Principal
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
            this.txtAutonomia = new System.Windows.Forms.TextBox();
            this.lblAutonomia = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.txtLocalidade = new System.Windows.Forms.TextBox();
            this.txtValorporLitro = new System.Windows.Forms.TextBox();
            this.txtVeiculo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTabela = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblValorCombustivel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkIdaVolta = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtConsumoDeCombustivel = new System.Windows.Forms.TextBox();
            this.txtDespesaCombustivel = new System.Windows.Forms.TextBox();
            this.txtKmRodado = new System.Windows.Forms.TextBox();
            this.txtCustoKM = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.imgVeiculo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgVeiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtAutonomia);
            this.panel1.Controls.Add(this.lblAutonomia);
            this.panel1.Controls.Add(this.checkIdaVolta);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.txtDistancia);
            this.panel1.Controls.Add(this.txtLocalidade);
            this.panel1.Controls.Add(this.txtValorporLitro);
            this.panel1.Controls.Add(this.txtVeiculo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblTabela);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblValorCombustivel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 140);
            this.panel1.TabIndex = 0;
            // 
            // txtAutonomia
            // 
            this.txtAutonomia.Location = new System.Drawing.Point(348, 95);
            this.txtAutonomia.Name = "txtAutonomia";
            this.txtAutonomia.Size = new System.Drawing.Size(100, 20);
            this.txtAutonomia.TabIndex = 13;
            // 
            // lblAutonomia
            // 
            this.lblAutonomia.AutoSize = true;
            this.lblAutonomia.Location = new System.Drawing.Point(345, 79);
            this.lblAutonomia.Name = "lblAutonomia";
            this.lblAutonomia.Size = new System.Drawing.Size(113, 13);
            this.lblAutonomia.TabIndex = 12;
            this.lblAutonomia.Text = "Autonimia Combustivel";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1,5",
            "2",
            "2,5",
            "3"});
            this.comboBox1.Location = new System.Drawing.Point(146, 94);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(111, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(329, 29);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(135, 20);
            this.txtDistancia.TabIndex = 3;
            // 
            // txtLocalidade
            // 
            this.txtLocalidade.Location = new System.Drawing.Point(134, 29);
            this.txtLocalidade.Name = "txtLocalidade";
            this.txtLocalidade.Size = new System.Drawing.Size(165, 20);
            this.txtLocalidade.TabIndex = 2;
            // 
            // txtValorporLitro
            // 
            this.txtValorporLitro.Location = new System.Drawing.Point(7, 94);
            this.txtValorporLitro.Name = "txtValorporLitro";
            this.txtValorporLitro.Size = new System.Drawing.Size(118, 20);
            this.txtValorporLitro.TabIndex = 4;
            // 
            // txtVeiculo
            // 
            this.txtVeiculo.Location = new System.Drawing.Point(3, 29);
            this.txtVeiculo.Name = "txtVeiculo";
            this.txtVeiculo.Size = new System.Drawing.Size(90, 20);
            this.txtVeiculo.TabIndex = 1;
            this.txtVeiculo.Leave += new System.EventHandler(this.txtVeiculo_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Distância KM";
            // 
            // lblTabela
            // 
            this.lblTabela.AutoSize = true;
            this.lblTabela.Location = new System.Drawing.Point(143, 78);
            this.lblTabela.Name = "lblTabela";
            this.lblTabela.Size = new System.Drawing.Size(46, 13);
            this.lblTabela.TabIndex = 3;
            this.lblTabela.Text = "Tabela :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Localidade :";
            // 
            // lblValorCombustivel
            // 
            this.lblValorCombustivel.AutoSize = true;
            this.lblValorCombustivel.Location = new System.Drawing.Point(3, 77);
            this.lblValorCombustivel.Name = "lblValorCombustivel";
            this.lblValorCombustivel.Size = new System.Drawing.Size(72, 13);
            this.lblValorCombustivel.TabIndex = 1;
            this.lblValorCombustivel.Text = "Valor por Litro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Véiculo:";
            // 
            // checkIdaVolta
            // 
            this.checkIdaVolta.AutoSize = true;
            this.checkIdaVolta.Location = new System.Drawing.Point(266, 97);
            this.checkIdaVolta.Name = "checkIdaVolta";
            this.checkIdaVolta.Size = new System.Drawing.Size(76, 17);
            this.checkIdaVolta.TabIndex = 11;
            this.checkIdaVolta.Text = "Ida / Volta";
            this.checkIdaVolta.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Consumo de Combustivél";
            // 
            // txtConsumoDeCombustivel
            // 
            this.txtConsumoDeCombustivel.Location = new System.Drawing.Point(146, 270);
            this.txtConsumoDeCombustivel.Name = "txtConsumoDeCombustivel";
            this.txtConsumoDeCombustivel.Size = new System.Drawing.Size(109, 20);
            this.txtConsumoDeCombustivel.TabIndex = 7;
            // 
            // txtDespesaCombustivel
            // 
            this.txtDespesaCombustivel.Location = new System.Drawing.Point(405, 274);
            this.txtDespesaCombustivel.Name = "txtDespesaCombustivel";
            this.txtDespesaCombustivel.Size = new System.Drawing.Size(136, 20);
            this.txtDespesaCombustivel.TabIndex = 8;
            // 
            // txtKmRodado
            // 
            this.txtKmRodado.Location = new System.Drawing.Point(13, 361);
            this.txtKmRodado.Name = "txtKmRodado";
            this.txtKmRodado.Size = new System.Drawing.Size(109, 20);
            this.txtKmRodado.TabIndex = 9;
            // 
            // txtCustoKM
            // 
            this.txtCustoKM.Location = new System.Drawing.Point(146, 361);
            this.txtCustoKM.Name = "txtCustoKM";
            this.txtCustoKM.Size = new System.Drawing.Size(109, 20);
            this.txtCustoKM.TabIndex = 10;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(405, 357);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(109, 20);
            this.txtTotal.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(275, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Despesa de Combustivel";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "KM rodado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(143, 341);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Custo por Km";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(445, 341);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Total";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(286, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(272, 25);
            this.label11.TabIndex = 14;
            this.label11.Text = "SISTEMA CÁLCULO FRETE";
            // 
            // imgVeiculo
            // 
            this.imgVeiculo.Location = new System.Drawing.Point(578, 197);
            this.imgVeiculo.Name = "imgVeiculo";
            this.imgVeiculo.Size = new System.Drawing.Size(238, 184);
            this.imgVeiculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgVeiculo.TabIndex = 2;
            this.imgVeiculo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Calcular_Frete_C__Zatec.Properties.Resources.Veiculos;
            this.pictureBox1.Location = new System.Drawing.Point(486, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(330, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(158, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 28);
            this.button2.TabIndex = 15;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 386);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtCustoKM);
            this.Controls.Add(this.txtKmRodado);
            this.Controls.Add(this.txtDespesaCombustivel);
            this.Controls.Add(this.txtConsumoDeCombustivel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imgVeiculo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Principal";
            this.Text = "Aplicativo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgVeiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.TextBox txtLocalidade;
        private System.Windows.Forms.TextBox txtValorporLitro;
        private System.Windows.Forms.TextBox txtVeiculo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTabela;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblValorCombustivel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkIdaVolta;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox imgVeiculo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtConsumoDeCombustivel;
        private System.Windows.Forms.TextBox txtDespesaCombustivel;
        private System.Windows.Forms.TextBox txtKmRodado;
        private System.Windows.Forms.TextBox txtCustoKM;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAutonomia;
        private System.Windows.Forms.Label lblAutonomia;
        private System.Windows.Forms.Button button2;
    }
}

