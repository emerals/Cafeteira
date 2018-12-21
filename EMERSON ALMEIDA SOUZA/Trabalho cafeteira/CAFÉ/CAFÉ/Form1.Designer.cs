namespace CAFÉ
{
    partial class CAFETEIRA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CAFETEIRA));
            this.button2 = new System.Windows.Forms.Button();
            this.button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMenu = new System.Windows.Forms.ListBox();
            this.txtCredito = new System.Windows.Forms.TextBox();
            this.btnCreditarSaldo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTroco = new System.Windows.Forms.Label();
            this.btnDevolverTroco = new System.Windows.Forms.Button();
            this.bnAdicionarCreditos = new System.Windows.Forms.Button();
            this.txtSaldo = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnDiminuir = new System.Windows.Forms.Button();
            this.txtMeuTroco = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Sienna;
            this.button2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(631, 475);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(234, 197);
            this.button2.TabIndex = 32;
            this.button2.Text = "CAFÉ COM LEITE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Beber);
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.Sienna;
            this.button.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button.Location = new System.Drawing.Point(884, 475);
            this.button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(234, 197);
            this.button.TabIndex = 31;
            this.button.Text = "CHOCOLATE";
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.Beber);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Sienna;
            this.button1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(631, 257);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 197);
            this.button1.TabIndex = 30;
            this.button1.Text = "CAFÉ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Beber);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.SaddleBrown;
            this.label6.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(787, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 29);
            this.label6.TabIndex = 28;
            this.label6.Text = "SALDO  R$\r\n";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Sienna;
            this.button4.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(884, 257);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(234, 197);
            this.button4.TabIndex = 27;
            this.button4.Text = "CAPUCCINO";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Beber);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SaddleBrown;
            this.label4.Font = new System.Drawing.Font("Georgia", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(651, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(409, 38);
            this.label4.TabIndex = 26;
            this.label4.Text = "ESCOLHA SUA BEBIDA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SaddleBrown;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(75, 639);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 29);
            this.label3.TabIndex = 25;
            this.label3.Text = "INSIRA MOEDAS AQUI!!\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SaddleBrown;
            this.label2.Font = new System.Drawing.Font("Georgia", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(159, 191);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 47);
            this.label2.TabIndex = 23;
            this.label2.Text = "MENU";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SaddleBrown;
            this.label1.Font = new System.Drawing.Font("Georgia", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(503, 169);
            this.label1.TabIndex = 22;
            this.label1.Text = "CAFETEIRA\r\nLP1\r\n\r\n";
            // 
            // txtMenu
            // 
            this.txtMenu.BackColor = System.Drawing.Color.PeachPuff;
            this.txtMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMenu.ForeColor = System.Drawing.Color.Peru;
            this.txtMenu.FormattingEnabled = true;
            this.txtMenu.ItemHeight = 37;
            this.txtMenu.Items.AddRange(new object[] {
            "",
            "CAFÉ:\t\tR$0.50",
            "",
            "CAFÉ C/LEITE:\tR$1.00",
            "",
            "CAPUCCINO:\tR$2.00",
            "",
            "CHOCOLATE:\tR$3.00"});
            this.txtMenu.Location = new System.Drawing.Point(18, 243);
            this.txtMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMenu.Name = "txtMenu";
            this.txtMenu.Size = new System.Drawing.Size(463, 337);
            this.txtMenu.TabIndex = 21;
            // 
            // txtCredito
            // 
            this.txtCredito.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCredito.ForeColor = System.Drawing.SystemColors.Info;
            this.txtCredito.Location = new System.Drawing.Point(129, 671);
            this.txtCredito.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCredito.Name = "txtCredito";
            this.txtCredito.Size = new System.Drawing.Size(217, 43);
            this.txtCredito.TabIndex = 24;
            this.txtCredito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarCreditos);
            // 
            // btnCreditarSaldo
            // 
            this.btnCreditarSaldo.BackColor = System.Drawing.Color.Sienna;
            this.btnCreditarSaldo.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreditarSaldo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreditarSaldo.Location = new System.Drawing.Point(134, 728);
            this.btnCreditarSaldo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreditarSaldo.Name = "btnCreditarSaldo";
            this.btnCreditarSaldo.Size = new System.Drawing.Size(194, 60);
            this.btnCreditarSaldo.TabIndex = 33;
            this.btnCreditarSaldo.Text = "CREDITAR\r\n";
            this.btnCreditarSaldo.UseVisualStyleBackColor = false;
            this.btnCreditarSaldo.Click += new System.EventHandler(this.btnCreditarSaldo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SaddleBrown;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(75, 683);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 29);
            this.label5.TabIndex = 34;
            this.label5.Text = "R$";
            // 
            // txtTroco
            // 
            this.txtTroco.BackColor = System.Drawing.SystemColors.Info;
            this.txtTroco.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtTroco.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTroco.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTroco.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txtTroco.Location = new System.Drawing.Point(812, 731);
            this.txtTroco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.Size = new System.Drawing.Size(124, 49);
            this.txtTroco.TabIndex = 36;
            this.txtTroco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDevolverTroco
            // 
            this.btnDevolverTroco.BackColor = System.Drawing.Color.Sienna;
            this.btnDevolverTroco.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolverTroco.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDevolverTroco.Location = new System.Drawing.Point(944, 698);
            this.btnDevolverTroco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDevolverTroco.Name = "btnDevolverTroco";
            this.btnDevolverTroco.Size = new System.Drawing.Size(165, 82);
            this.btnDevolverTroco.TabIndex = 37;
            this.btnDevolverTroco.Text = "Receber Troco";
            this.btnDevolverTroco.UseVisualStyleBackColor = false;
            this.btnDevolverTroco.Click += new System.EventHandler(this.FuncaoTroco);
            // 
            // bnAdicionarCreditos
            // 
            this.bnAdicionarCreditos.BackColor = System.Drawing.Color.Sienna;
            this.bnAdicionarCreditos.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnAdicionarCreditos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bnAdicionarCreditos.Location = new System.Drawing.Point(637, 704);
            this.bnAdicionarCreditos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bnAdicionarCreditos.Name = "bnAdicionarCreditos";
            this.bnAdicionarCreditos.Size = new System.Drawing.Size(165, 82);
            this.bnAdicionarCreditos.TabIndex = 38;
            this.bnAdicionarCreditos.Text = "Creditar Troco";
            this.bnAdicionarCreditos.UseVisualStyleBackColor = false;
            this.bnAdicionarCreditos.Click += new System.EventHandler(this.FuncaoTroco);
            // 
            // txtSaldo
            // 
            this.txtSaldo.BackColor = System.Drawing.SystemColors.Info;
            this.txtSaldo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldo.Location = new System.Drawing.Point(671, 38);
            this.txtSaldo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(370, 66);
            this.txtSaldo.TabIndex = 39;
            this.txtSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.Info;
            this.progressBar1.ForeColor = System.Drawing.Color.Sienna;
            this.progressBar1.Location = new System.Drawing.Point(773, 202);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(150, 35);
            this.progressBar1.TabIndex = 41;
            this.progressBar1.Value = 50;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.Sienna;
            this.btnAdicionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdicionar.Location = new System.Drawing.Point(953, 200);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(112, 37);
            this.btnAdicionar.TabIndex = 42;
            this.btnAdicionar.Text = "+";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnDiminuir
            // 
            this.btnDiminuir.BackColor = System.Drawing.Color.Sienna;
            this.btnDiminuir.ForeColor = System.Drawing.Color.White;
            this.btnDiminuir.Location = new System.Drawing.Point(631, 200);
            this.btnDiminuir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDiminuir.Name = "btnDiminuir";
            this.btnDiminuir.Size = new System.Drawing.Size(112, 37);
            this.btnDiminuir.TabIndex = 43;
            this.btnDiminuir.Text = "-";
            this.btnDiminuir.UseVisualStyleBackColor = false;
            this.btnDiminuir.Click += new System.EventHandler(this.btnDiminuir_Click);
            // 
            // txtMeuTroco
            // 
            this.txtMeuTroco.AutoSize = true;
            this.txtMeuTroco.BackColor = System.Drawing.Color.SaddleBrown;
            this.txtMeuTroco.Font = new System.Drawing.Font("Georgia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeuTroco.ForeColor = System.Drawing.SystemColors.Info;
            this.txtMeuTroco.Location = new System.Drawing.Point(812, 698);
            this.txtMeuTroco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtMeuTroco.Name = "txtMeuTroco";
            this.txtMeuTroco.Size = new System.Drawing.Size(123, 24);
            this.txtMeuTroco.TabIndex = 44;
            this.txtMeuTroco.Text = "Meu Troco";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.SaddleBrown;
            this.label7.Font = new System.Drawing.Font("Georgia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(736, 173);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 24);
            this.label7.TabIndex = 45;
            this.label7.Text = "Quantidade de açucar";
            // 
            // CAFETEIRA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CAFÉ.Properties.Resources.Café_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1148, 795);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMeuTroco);
            this.Controls.Add(this.btnDiminuir);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.bnAdicionarCreditos);
            this.Controls.Add(this.btnDevolverTroco);
            this.Controls.Add(this.txtTroco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCreditarSaldo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCredito);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "CAFETEIRA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAFETEIRA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox txtMenu;
        private System.Windows.Forms.TextBox txtCredito;
        private System.Windows.Forms.Button btnCreditarSaldo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtTroco;
        private System.Windows.Forms.Button btnDevolverTroco;
        private System.Windows.Forms.Button bnAdicionarCreditos;
        private System.Windows.Forms.Label txtSaldo;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnDiminuir;
        private System.Windows.Forms.Label txtMeuTroco;
        private System.Windows.Forms.Label label7;
    }
}

