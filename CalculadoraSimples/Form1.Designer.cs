namespace CalculadoraSimples
{
    partial class frmCalculadoraSimp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculadoraSimp));
            panelAreaQuad = new Panel();
            lblTitResultado = new Label();
            lblTitExpressao = new Label();
            btnCalcular = new Button();
            lblResultado = new Label();
            lblExpressao = new Label();
            lblLxL = new Label();
            lblFormula = new Label();
            txtLadoQuad = new TextBox();
            pictureBox2 = new PictureBox();
            panelAreaRet = new Panel();
            lblExpressaoRet = new Label();
            lblResultadoRet = new Label();
            lblDescFormula = new Label();
            lblFormula2 = new Label();
            lblLadoB = new Label();
            lblLadoA = new Label();
            txtLadoB = new TextBox();
            txtLadoA = new TextBox();
            pictureBox3 = new PictureBox();
            btnCalcularRet = new Button();
            panelAreaCirc = new Panel();
            lblResultadoCirc = new Label();
            lblExpressaoCirc = new Label();
            lblRaio = new Label();
            label1 = new Label();
            lblDescFormulaCirc = new Label();
            lblFormulaCirc = new Label();
            pictureBox4 = new PictureBox();
            txtRaioCirc = new TextBox();
            btnCalcularCirc = new Button();
            rdbAreaQuad = new RadioButton();
            rdbAreaRet = new RadioButton();
            rdbAreaCirc = new RadioButton();
            rdbAreaTri = new RadioButton();
            lblTitulo = new Label();
            rdbAreaTrap = new RadioButton();
            pictureBox1 = new PictureBox();
            panelAreaQuad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelAreaRet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panelAreaCirc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelAreaQuad
            // 
            panelAreaQuad.BackColor = Color.DarkGreen;
            panelAreaQuad.Controls.Add(lblTitResultado);
            panelAreaQuad.Controls.Add(lblTitExpressao);
            panelAreaQuad.Controls.Add(btnCalcular);
            panelAreaQuad.Controls.Add(lblResultado);
            panelAreaQuad.Controls.Add(lblExpressao);
            panelAreaQuad.Controls.Add(lblLxL);
            panelAreaQuad.Controls.Add(lblFormula);
            panelAreaQuad.Controls.Add(txtLadoQuad);
            panelAreaQuad.Controls.Add(pictureBox2);
            panelAreaQuad.Location = new Point(202, 12);
            panelAreaQuad.Name = "panelAreaQuad";
            panelAreaQuad.Size = new Size(586, 426);
            panelAreaQuad.TabIndex = 0;
            // 
            // lblTitResultado
            // 
            lblTitResultado.AutoSize = true;
            lblTitResultado.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitResultado.Location = new Point(254, 263);
            lblTitResultado.Name = "lblTitResultado";
            lblTitResultado.Size = new Size(83, 21);
            lblTitResultado.TabIndex = 8;
            lblTitResultado.Text = "Resultado";
            // 
            // lblTitExpressao
            // 
            lblTitExpressao.AutoSize = true;
            lblTitExpressao.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitExpressao.Location = new Point(28, 263);
            lblTitExpressao.Name = "lblTitExpressao";
            lblTitExpressao.Size = new Size(83, 21);
            lblTitExpressao.TabIndex = 7;
            lblTitExpressao.Text = "Expressão";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(379, 282);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.BackColor = Color.FloralWhite;
            lblResultado.BorderStyle = BorderStyle.FixedSingle;
            lblResultado.Location = new Point(254, 286);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(2, 17);
            lblResultado.TabIndex = 5;
            // 
            // lblExpressao
            // 
            lblExpressao.AutoSize = true;
            lblExpressao.BackColor = Color.FloralWhite;
            lblExpressao.BorderStyle = BorderStyle.FixedSingle;
            lblExpressao.Location = new Point(28, 286);
            lblExpressao.Name = "lblExpressao";
            lblExpressao.Size = new Size(2, 17);
            lblExpressao.TabIndex = 4;
            // 
            // lblLxL
            // 
            lblLxL.AutoSize = true;
            lblLxL.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblLxL.Location = new Point(379, 182);
            lblLxL.Name = "lblLxL";
            lblLxL.Size = new Size(42, 21);
            lblLxL.TabIndex = 3;
            lblLxL.Text = "L x L";
            // 
            // lblFormula
            // 
            lblFormula.AutoSize = true;
            lblFormula.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormula.Location = new Point(379, 98);
            lblFormula.Name = "lblFormula";
            lblFormula.Size = new Size(117, 25);
            lblFormula.TabIndex = 2;
            lblFormula.Text = "<-- Fórmula";
            // 
            // txtLadoQuad
            // 
            txtLadoQuad.Location = new Point(379, 206);
            txtLadoQuad.Name = "txtLadoQuad";
            txtLadoQuad.Size = new Size(100, 23);
            txtLadoQuad.TabIndex = 1;
            txtLadoQuad.KeyPress += txtLadoQuad_KeyPress;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(28, 31);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(309, 196);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panelAreaRet
            // 
            panelAreaRet.BackColor = Color.LightGray;
            panelAreaRet.Controls.Add(lblExpressaoRet);
            panelAreaRet.Controls.Add(lblResultadoRet);
            panelAreaRet.Controls.Add(lblDescFormula);
            panelAreaRet.Controls.Add(lblFormula2);
            panelAreaRet.Controls.Add(lblLadoB);
            panelAreaRet.Controls.Add(lblLadoA);
            panelAreaRet.Controls.Add(txtLadoB);
            panelAreaRet.Controls.Add(txtLadoA);
            panelAreaRet.Controls.Add(pictureBox3);
            panelAreaRet.Controls.Add(btnCalcularRet);
            panelAreaRet.Location = new Point(202, 12);
            panelAreaRet.Name = "panelAreaRet";
            panelAreaRet.Size = new Size(586, 426);
            panelAreaRet.TabIndex = 9;
            // 
            // lblExpressaoRet
            // 
            lblExpressaoRet.AutoSize = true;
            lblExpressaoRet.BackColor = Color.Silver;
            lblExpressaoRet.BorderStyle = BorderStyle.FixedSingle;
            lblExpressaoRet.Location = new Point(53, 365);
            lblExpressaoRet.Name = "lblExpressaoRet";
            lblExpressaoRet.Size = new Size(2, 17);
            lblExpressaoRet.TabIndex = 9;
            // 
            // lblResultadoRet
            // 
            lblResultadoRet.AutoSize = true;
            lblResultadoRet.BackColor = Color.Silver;
            lblResultadoRet.BorderStyle = BorderStyle.FixedSingle;
            lblResultadoRet.Location = new Point(187, 365);
            lblResultadoRet.Name = "lblResultadoRet";
            lblResultadoRet.Size = new Size(2, 17);
            lblResultadoRet.TabIndex = 8;
            // 
            // lblDescFormula
            // 
            lblDescFormula.AutoSize = true;
            lblDescFormula.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescFormula.Location = new Point(376, 203);
            lblDescFormula.Name = "lblDescFormula";
            lblDescFormula.Size = new Size(45, 21);
            lblDescFormula.TabIndex = 7;
            lblDescFormula.Text = "A x L";
            // 
            // lblFormula2
            // 
            lblFormula2.AutoSize = true;
            lblFormula2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormula2.Location = new Point(376, 143);
            lblFormula2.Name = "lblFormula2";
            lblFormula2.Size = new Size(96, 21);
            lblFormula2.TabIndex = 6;
            lblFormula2.Text = "<-- Fórmula";
            // 
            // lblLadoB
            // 
            lblLadoB.AutoSize = true;
            lblLadoB.Location = new Point(187, 312);
            lblLadoB.Name = "lblLadoB";
            lblLadoB.Size = new Size(43, 15);
            lblLadoB.TabIndex = 5;
            lblLadoB.Text = "Lado B";
            // 
            // lblLadoA
            // 
            lblLadoA.AutoSize = true;
            lblLadoA.Location = new Point(53, 312);
            lblLadoA.Name = "lblLadoA";
            lblLadoA.Size = new Size(44, 15);
            lblLadoA.TabIndex = 4;
            lblLadoA.Text = "Lado A";
            // 
            // txtLadoB
            // 
            txtLadoB.Location = new Point(187, 330);
            txtLadoB.Name = "txtLadoB";
            txtLadoB.Size = new Size(100, 23);
            txtLadoB.TabIndex = 3;
            txtLadoB.KeyPress += txtLadoB_KeyPress;
            // 
            // txtLadoA
            // 
            txtLadoA.Location = new Point(53, 330);
            txtLadoA.Name = "txtLadoA";
            txtLadoA.Size = new Size(100, 23);
            txtLadoA.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(53, 61);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(284, 196);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // btnCalcularRet
            // 
            btnCalcularRet.Location = new Point(376, 329);
            btnCalcularRet.Name = "btnCalcularRet";
            btnCalcularRet.Size = new Size(75, 23);
            btnCalcularRet.TabIndex = 0;
            btnCalcularRet.Text = "Calcular";
            btnCalcularRet.UseVisualStyleBackColor = true;
            btnCalcularRet.Click += btnCalcularRet_Click;
            // 
            // panelAreaCirc
            // 
            panelAreaCirc.BackColor = Color.Bisque;
            panelAreaCirc.Controls.Add(lblResultadoCirc);
            panelAreaCirc.Controls.Add(lblExpressaoCirc);
            panelAreaCirc.Controls.Add(lblRaio);
            panelAreaCirc.Controls.Add(label1);
            panelAreaCirc.Controls.Add(lblDescFormulaCirc);
            panelAreaCirc.Controls.Add(lblFormulaCirc);
            panelAreaCirc.Controls.Add(pictureBox4);
            panelAreaCirc.Controls.Add(txtRaioCirc);
            panelAreaCirc.Controls.Add(btnCalcularCirc);
            panelAreaCirc.Location = new Point(202, 12);
            panelAreaCirc.Name = "panelAreaCirc";
            panelAreaCirc.Size = new Size(586, 423);
            panelAreaCirc.TabIndex = 10;
            // 
            // lblResultadoCirc
            // 
            lblResultadoCirc.AutoSize = true;
            lblResultadoCirc.BackColor = SystemColors.Window;
            lblResultadoCirc.BorderStyle = BorderStyle.FixedSingle;
            lblResultadoCirc.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultadoCirc.Location = new Point(187, 357);
            lblResultadoCirc.Name = "lblResultadoCirc";
            lblResultadoCirc.Size = new Size(2, 22);
            lblResultadoCirc.TabIndex = 8;
            // 
            // lblExpressaoCirc
            // 
            lblExpressaoCirc.AutoSize = true;
            lblExpressaoCirc.BackColor = SystemColors.Window;
            lblExpressaoCirc.BorderStyle = BorderStyle.FixedSingle;
            lblExpressaoCirc.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblExpressaoCirc.Location = new Point(187, 302);
            lblExpressaoCirc.Name = "lblExpressaoCirc";
            lblExpressaoCirc.Size = new Size(2, 22);
            lblExpressaoCirc.TabIndex = 7;
            // 
            // lblRaio
            // 
            lblRaio.AutoSize = true;
            lblRaio.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblRaio.Location = new Point(28, 300);
            lblRaio.Name = "lblRaio";
            lblRaio.Size = new Size(65, 20);
            lblRaio.TabIndex = 6;
            lblRaio.Text = "Raio (2):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(28, 300);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 5;
            // 
            // lblDescFormulaCirc
            // 
            lblDescFormulaCirc.AutoSize = true;
            lblDescFormulaCirc.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescFormulaCirc.Location = new Point(343, 179);
            lblDescFormulaCirc.Name = "lblDescFormulaCirc";
            lblDescFormulaCirc.Size = new Size(49, 20);
            lblDescFormulaCirc.TabIndex = 4;
            lblDescFormulaCirc.Text = "Pi * r²";
            // 
            // lblFormulaCirc
            // 
            lblFormulaCirc.AutoSize = true;
            lblFormulaCirc.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormulaCirc.Location = new Point(343, 120);
            lblFormulaCirc.Name = "lblFormulaCirc";
            lblFormulaCirc.Size = new Size(117, 25);
            lblFormulaCirc.TabIndex = 3;
            lblFormulaCirc.Text = "<-- Fórmula";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(28, 58);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(303, 199);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // txtRaioCirc
            // 
            txtRaioCirc.Location = new Point(28, 326);
            txtRaioCirc.Name = "txtRaioCirc";
            txtRaioCirc.Size = new Size(100, 23);
            txtRaioCirc.TabIndex = 1;
            txtRaioCirc.KeyPress += txtRaioCirc_KeyPress;
            // 
            // btnCalcularCirc
            // 
            btnCalcularCirc.Location = new Point(404, 327);
            btnCalcularCirc.Name = "btnCalcularCirc";
            btnCalcularCirc.Size = new Size(75, 23);
            btnCalcularCirc.TabIndex = 0;
            btnCalcularCirc.Text = "Calcular";
            btnCalcularCirc.UseVisualStyleBackColor = true;
            btnCalcularCirc.Click += btnCalcularCirc_Click;
            // 
            // rdbAreaQuad
            // 
            rdbAreaQuad.AutoSize = true;
            rdbAreaQuad.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            rdbAreaQuad.ForeColor = SystemColors.ActiveCaption;
            rdbAreaQuad.Location = new Point(43, 125);
            rdbAreaQuad.Name = "rdbAreaQuad";
            rdbAreaQuad.Size = new Size(154, 24);
            rdbAreaQuad.TabIndex = 1;
            rdbAreaQuad.TabStop = true;
            rdbAreaQuad.Text = "Área do Quadrado";
            rdbAreaQuad.UseVisualStyleBackColor = true;
            rdbAreaQuad.CheckedChanged += rdbAreaQuad_CheckedChanged;
            // 
            // rdbAreaRet
            // 
            rdbAreaRet.AutoSize = true;
            rdbAreaRet.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            rdbAreaRet.ForeColor = SystemColors.ActiveCaption;
            rdbAreaRet.Location = new Point(43, 155);
            rdbAreaRet.Name = "rdbAreaRet";
            rdbAreaRet.Size = new Size(155, 24);
            rdbAreaRet.TabIndex = 2;
            rdbAreaRet.TabStop = true;
            rdbAreaRet.Text = "Área do Retangulo";
            rdbAreaRet.UseVisualStyleBackColor = true;
            rdbAreaRet.CheckedChanged += rdbAreaRet_CheckedChanged;
            // 
            // rdbAreaCirc
            // 
            rdbAreaCirc.AutoSize = true;
            rdbAreaCirc.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            rdbAreaCirc.ForeColor = SystemColors.ActiveCaption;
            rdbAreaCirc.Location = new Point(43, 185);
            rdbAreaCirc.Name = "rdbAreaCirc";
            rdbAreaCirc.Size = new Size(133, 24);
            rdbAreaCirc.TabIndex = 3;
            rdbAreaCirc.TabStop = true;
            rdbAreaCirc.Text = "Área do Circulo";
            rdbAreaCirc.UseVisualStyleBackColor = true;
            rdbAreaCirc.CheckedChanged += rdbAreaCirc_CheckedChanged;
            // 
            // rdbAreaTri
            // 
            rdbAreaTri.AutoSize = true;
            rdbAreaTri.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            rdbAreaTri.ForeColor = SystemColors.ActiveCaption;
            rdbAreaTri.Location = new Point(43, 215);
            rdbAreaTri.Name = "rdbAreaTri";
            rdbAreaTri.Size = new Size(150, 24);
            rdbAreaTri.TabIndex = 4;
            rdbAreaTri.TabStop = true;
            rdbAreaTri.Text = "Área do Triangulo";
            rdbAreaTri.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = SystemColors.ActiveCaption;
            lblTitulo.Location = new Point(12, 73);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(184, 25);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "Calculadora de Área";
            // 
            // rdbAreaTrap
            // 
            rdbAreaTrap.AutoSize = true;
            rdbAreaTrap.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            rdbAreaTrap.ForeColor = SystemColors.ActiveCaption;
            rdbAreaTrap.Location = new Point(43, 245);
            rdbAreaTrap.Name = "rdbAreaTrap";
            rdbAreaTrap.Size = new Size(143, 24);
            rdbAreaTrap.TabIndex = 6;
            rdbAreaTrap.TabStop = true;
            rdbAreaTrap.Text = "Área do Trapézio";
            rdbAreaTrap.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 275);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // frmCalculadoraSimp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(800, 450);
            Controls.Add(panelAreaCirc);
            Controls.Add(panelAreaRet);
            Controls.Add(pictureBox1);
            Controls.Add(rdbAreaTrap);
            Controls.Add(lblTitulo);
            Controls.Add(rdbAreaTri);
            Controls.Add(rdbAreaCirc);
            Controls.Add(rdbAreaRet);
            Controls.Add(rdbAreaQuad);
            Controls.Add(panelAreaQuad);
            Name = "frmCalculadoraSimp";
            Text = "Form1";
            panelAreaQuad.ResumeLayout(false);
            panelAreaQuad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelAreaRet.ResumeLayout(false);
            panelAreaRet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panelAreaCirc.ResumeLayout(false);
            panelAreaCirc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelAreaQuad;
        private Button btnCalcular;
        private Label lblLxL;
        private Label lblFormula;
        private TextBox txtLadoQuad;
        private PictureBox pictureBox2;
        private RadioButton rdbAreaQuad;
        private RadioButton rdbAreaRet;
        private RadioButton rdbAreaCirc;
        private RadioButton rdbAreaTri;
        private Label lblTitulo;
        private RadioButton rdbAreaTrap;
        private PictureBox pictureBox1;
        private Label lblResultado;
        private Label lblExpressao;
        private Label lblTitResultado;
        private Label lblTitExpressao;
        private Panel panelAreaRet;
        private Label lblLadoB;
        private Label lblLadoA;
        private TextBox txtLadoB;
        private TextBox txtLadoA;
        private PictureBox pictureBox3;
        private Button btnCalcularRet;
        private Label lblDescFormula;
        private Label lblFormula2;
        private Label lblResultadoRet;
        private Label lblExpressaoRet;
        private Panel panelAreaCirc;
        private Label lblResultadoCirc;
        private Label lblExpressaoCirc;
        private Label lblRaio;
        private Label label1;
        private Label lblDescFormulaCirc;
        private Label lblFormulaCirc;
        private PictureBox pictureBox4;
        private TextBox txtRaioCirc;
        private Button btnCalcularCirc;
    }
}