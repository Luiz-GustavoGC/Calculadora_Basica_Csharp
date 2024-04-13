namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtResultado = new TextBox();
            btnZero = new Button();
            btnUm = new Button();
            btnDois = new Button();
            btnTres = new Button();
            btnSeis = new Button();
            btnCinco = new Button();
            btnQuatro = new Button();
            btnNove = new Button();
            btnOito = new Button();
            btnSete = new Button();
            btnVirgula = new Button();
            btnIgual = new Button();
            btnMais = new Button();
            btnBarra = new Button();
            btnVezes = new Button();
            btnMenos = new Button();
            btnC = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(35, 12);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(266, 23);
            txtResultado.TabIndex = 0;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            txtResultado.TextChanged += txtResultado_TextChanged;
            // 
            // btnZero
            // 
            btnZero.Location = new Point(103, 296);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(62, 61);
            btnZero.TabIndex = 1;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // btnUm
            // 
            btnUm.Location = new Point(35, 230);
            btnUm.Name = "btnUm";
            btnUm.Size = new Size(62, 61);
            btnUm.TabIndex = 2;
            btnUm.Text = "1";
            btnUm.UseVisualStyleBackColor = true;
            btnUm.Click += btnUm_Click;
            // 
            // btnDois
            // 
            btnDois.Location = new Point(103, 230);
            btnDois.Name = "btnDois";
            btnDois.Size = new Size(62, 61);
            btnDois.TabIndex = 3;
            btnDois.Text = "2";
            btnDois.UseVisualStyleBackColor = true;
            btnDois.Click += btnDois_Click;
            // 
            // btnTres
            // 
            btnTres.Location = new Point(171, 230);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(62, 61);
            btnTres.TabIndex = 4;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = true;
            btnTres.Click += btnTres_Click;
            // 
            // btnSeis
            // 
            btnSeis.Location = new Point(171, 163);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(62, 61);
            btnSeis.TabIndex = 7;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = true;
            btnSeis.Click += btnSeis_Click;
            // 
            // btnCinco
            // 
            btnCinco.Location = new Point(103, 163);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(62, 61);
            btnCinco.TabIndex = 6;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = true;
            btnCinco.Click += btnCinco_Click;
            // 
            // btnQuatro
            // 
            btnQuatro.Location = new Point(35, 163);
            btnQuatro.Name = "btnQuatro";
            btnQuatro.Size = new Size(62, 61);
            btnQuatro.TabIndex = 5;
            btnQuatro.Text = "4";
            btnQuatro.UseVisualStyleBackColor = true;
            btnQuatro.Click += btnQuatro_Click;
            // 
            // btnNove
            // 
            btnNove.Location = new Point(171, 96);
            btnNove.Name = "btnNove";
            btnNove.Size = new Size(62, 61);
            btnNove.TabIndex = 10;
            btnNove.Text = "9";
            btnNove.UseVisualStyleBackColor = true;
            btnNove.Click += btnNove_Click;
            // 
            // btnOito
            // 
            btnOito.Location = new Point(103, 96);
            btnOito.Name = "btnOito";
            btnOito.Size = new Size(62, 61);
            btnOito.TabIndex = 9;
            btnOito.Text = "8";
            btnOito.UseVisualStyleBackColor = true;
            btnOito.Click += btnOito_Click;
            // 
            // btnSete
            // 
            btnSete.Location = new Point(35, 96);
            btnSete.Name = "btnSete";
            btnSete.Size = new Size(62, 61);
            btnSete.TabIndex = 8;
            btnSete.Text = "7";
            btnSete.UseVisualStyleBackColor = true;
            btnSete.Click += btnSete_Click;
            // 
            // btnVirgula
            // 
            btnVirgula.Location = new Point(35, 296);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(62, 61);
            btnVirgula.TabIndex = 11;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = true;
            btnVirgula.Click += btnVirgula_Click;
            // 
            // btnIgual
            // 
            btnIgual.Location = new Point(171, 296);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(62, 61);
            btnIgual.TabIndex = 12;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnMais
            // 
            btnMais.Location = new Point(239, 296);
            btnMais.Name = "btnMais";
            btnMais.Size = new Size(62, 61);
            btnMais.TabIndex = 16;
            btnMais.Text = "+";
            btnMais.UseVisualStyleBackColor = true;
            btnMais.Click += btnMais_Click;
            // 
            // btnBarra
            // 
            btnBarra.Location = new Point(239, 96);
            btnBarra.Name = "btnBarra";
            btnBarra.Size = new Size(62, 61);
            btnBarra.TabIndex = 15;
            btnBarra.Text = "/";
            btnBarra.UseVisualStyleBackColor = true;
            btnBarra.Click += btnBarra_Click;
            // 
            // btnVezes
            // 
            btnVezes.Location = new Point(239, 163);
            btnVezes.Name = "btnVezes";
            btnVezes.Size = new Size(62, 61);
            btnVezes.TabIndex = 14;
            btnVezes.Text = "X";
            btnVezes.UseVisualStyleBackColor = true;
            btnVezes.Click += btnVezes_Click;
            // 
            // btnMenos
            // 
            btnMenos.Location = new Point(239, 230);
            btnMenos.Name = "btnMenos";
            btnMenos.Size = new Size(62, 61);
            btnMenos.TabIndex = 13;
            btnMenos.Text = "-";
            btnMenos.UseVisualStyleBackColor = true;
            btnMenos.Click += btnMenos_Click;
            // 
            // btnC
            // 
            btnC.Location = new Point(239, 47);
            btnC.Name = "btnC";
            btnC.Size = new Size(62, 43);
            btnC.TabIndex = 17;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 16);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 373);
            Controls.Add(label1);
            Controls.Add(btnC);
            Controls.Add(btnMais);
            Controls.Add(btnBarra);
            Controls.Add(btnVezes);
            Controls.Add(btnMenos);
            Controls.Add(btnIgual);
            Controls.Add(btnVirgula);
            Controls.Add(btnNove);
            Controls.Add(btnOito);
            Controls.Add(btnSete);
            Controls.Add(btnSeis);
            Controls.Add(btnCinco);
            Controls.Add(btnQuatro);
            Controls.Add(btnTres);
            Controls.Add(btnDois);
            Controls.Add(btnUm);
            Controls.Add(btnZero);
            Controls.Add(txtResultado);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Button btnZero;
        private Button btnUm;
        private Button btnDois;
        private Button btnTres;
        private Button btnSeis;
        private Button btnCinco;
        private Button btnQuatro;
        private Button btnNove;
        private Button btnOito;
        private Button btnSete;
        private Button btnVirgula;
        private Button btnIgual;
        private Button btnMais;
        private Button btnBarra;
        private Button btnVezes;
        private Button btnMenos;
        private Button btnC;
        private Label label1;
    }
}