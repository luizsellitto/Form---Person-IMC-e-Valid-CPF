namespace Form___Person_IMC_e_Valid_CPF
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tx_nome = new System.Windows.Forms.TextBox();
            this.tx_idade = new System.Windows.Forms.TextBox();
            this.mask_cpf = new System.Windows.Forms.MaskedTextBox();
            this.mask_altura = new System.Windows.Forms.MaskedTextBox();
            this.bt_calcular = new System.Windows.Forms.Button();
            this.cb_sexo = new System.Windows.Forms.ComboBox();
            this.lb_imc = new System.Windows.Forms.Label();
            this.lb_grau = new System.Windows.Forms.Label();
            this.lb_classificacao = new System.Windows.Forms.Label();
            this.num_peso = new System.Windows.Forms.NumericUpDown();
            this.lb_valida = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_peso)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(372, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sexo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Idade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(372, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Peso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(372, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Altura";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(312, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Calculando o IMC";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // tx_nome
            // 
            this.tx_nome.Location = new System.Drawing.Point(139, 88);
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(227, 20);
            this.tx_nome.TabIndex = 8;
            // 
            // tx_idade
            // 
            this.tx_idade.Location = new System.Drawing.Point(139, 250);
            this.tx_idade.Name = "tx_idade";
            this.tx_idade.Size = new System.Drawing.Size(227, 20);
            this.tx_idade.TabIndex = 11;
            // 
            // mask_cpf
            // 
            this.mask_cpf.Location = new System.Drawing.Point(139, 168);
            this.mask_cpf.Mask = "000,000,000-00";
            this.mask_cpf.Name = "mask_cpf";
            this.mask_cpf.Size = new System.Drawing.Size(227, 20);
            this.mask_cpf.TabIndex = 12;
            this.mask_cpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mask_cpf_MaskInputRejected);
            // 
            // mask_altura
            // 
            this.mask_altura.Location = new System.Drawing.Point(455, 249);
            this.mask_altura.Mask = "0.00";
            this.mask_altura.Name = "mask_altura";
            this.mask_altura.Size = new System.Drawing.Size(196, 20);
            this.mask_altura.TabIndex = 13;
            this.mask_altura.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mask_altura_MaskInputRejected);
            // 
            // bt_calcular
            // 
            this.bt_calcular.Location = new System.Drawing.Point(174, 354);
            this.bt_calcular.Name = "bt_calcular";
            this.bt_calcular.Size = new System.Drawing.Size(75, 23);
            this.bt_calcular.TabIndex = 15;
            this.bt_calcular.Text = "Calcular";
            this.bt_calcular.UseVisualStyleBackColor = true;
            this.bt_calcular.Click += new System.EventHandler(this.button2_Click);
            // 
            // cb_sexo
            // 
            this.cb_sexo.FormattingEnabled = true;
            this.cb_sexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cb_sexo.Location = new System.Drawing.Point(455, 88);
            this.cb_sexo.Name = "cb_sexo";
            this.cb_sexo.Size = new System.Drawing.Size(121, 21);
            this.cb_sexo.TabIndex = 16;
            this.cb_sexo.SelectedIndexChanged += new System.EventHandler(this.cb_sexo_SelectedIndexChanged);
            // 
            // lb_imc
            // 
            this.lb_imc.AutoSize = true;
            this.lb_imc.Location = new System.Drawing.Point(401, 313);
            this.lb_imc.Name = "lb_imc";
            this.lb_imc.Size = new System.Drawing.Size(35, 13);
            this.lb_imc.TabIndex = 19;
            this.lb_imc.Text = "label8";
            // 
            // lb_grau
            // 
            this.lb_grau.AutoSize = true;
            this.lb_grau.Location = new System.Drawing.Point(401, 401);
            this.lb_grau.Name = "lb_grau";
            this.lb_grau.Size = new System.Drawing.Size(35, 13);
            this.lb_grau.TabIndex = 20;
            this.lb_grau.Text = "label9";
            // 
            // lb_classificacao
            // 
            this.lb_classificacao.AutoSize = true;
            this.lb_classificacao.Location = new System.Drawing.Point(401, 359);
            this.lb_classificacao.Name = "lb_classificacao";
            this.lb_classificacao.Size = new System.Drawing.Size(41, 13);
            this.lb_classificacao.TabIndex = 21;
            this.lb_classificacao.Text = "label10";
            // 
            // num_peso
            // 
            this.num_peso.Location = new System.Drawing.Point(456, 166);
            this.num_peso.Name = "num_peso";
            this.num_peso.Size = new System.Drawing.Size(195, 20);
            this.num_peso.TabIndex = 18;
            // 
            // lb_valida
            // 
            this.lb_valida.AutoSize = true;
            this.lb_valida.Location = new System.Drawing.Point(139, 195);
            this.lb_valida.Name = "lb_valida";
            this.lb_valida.Size = new System.Drawing.Size(35, 13);
            this.lb_valida.TabIndex = 22;
            this.lb_valida.Text = "label8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_valida);
            this.Controls.Add(this.lb_classificacao);
            this.Controls.Add(this.lb_grau);
            this.Controls.Add(this.lb_imc);
            this.Controls.Add(this.num_peso);
            this.Controls.Add(this.cb_sexo);
            this.Controls.Add(this.bt_calcular);
            this.Controls.Add(this.mask_altura);
            this.Controls.Add(this.mask_cpf);
            this.Controls.Add(this.tx_idade);
            this.Controls.Add(this.tx_nome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_peso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tx_nome;
        private System.Windows.Forms.TextBox tx_idade;
        private System.Windows.Forms.MaskedTextBox mask_cpf;
        private System.Windows.Forms.MaskedTextBox mask_altura;
        private System.Windows.Forms.Button bt_calcular;
        private System.Windows.Forms.ComboBox cb_sexo;
        private System.Windows.Forms.Label lb_imc;
        private System.Windows.Forms.Label lb_grau;
        private System.Windows.Forms.Label lb_classificacao;
        private System.Windows.Forms.NumericUpDown num_peso;
        private System.Windows.Forms.Label lb_valida;
    }
}

