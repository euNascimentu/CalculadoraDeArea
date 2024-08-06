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
            btnLimparQuad = new Button();
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
            btnLimparRet = new Button();
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
            btnLimparCirc = new Button();
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
            panelAreaTri = new Panel();
            btnLimparTri = new Button();
            lblDescFormulaTri = new Label();
            lblFormulaTri = new Label();
            lblResultTri = new Label();
            lblExpTri = new Label();
            txtAlturaTri = new TextBox();
            txtBaseTri = new TextBox();
            lblAlturaTri = new Label();
            lblBaseTri = new Label();
            btnCalcularTri = new Button();
            pictureBox5 = new PictureBox();
            panelAreaTrap = new Panel();
            btnLimpar = new Button();
            lblFormulaTrap = new Label();
            lblDescFormTrap = new Label();
            lblResultTrap = new Label();
            lblExpTrap = new Label();
            lblAlturaTap = new Label();
            lblBase2 = new Label();
            lblBase1 = new Label();
            txtAltTrap = new TextBox();
            txtBase2 = new TextBox();
            txtBase1 = new TextBox();
            btnCalcularTrap = new Button();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            panelAreaQuad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelAreaRet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panelAreaCirc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelAreaTri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panelAreaTrap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // panelAreaQuad
            // 
            panelAreaQuad.BackColor = Color.DarkGreen;
            panelAreaQuad.Controls.Add(btnLimparQuad);
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
            // btnLimparQuad
            // 
            btnLimparQuad.Location = new Point(474, 281);
            btnLimparQuad.Name = "btnLimparQuad";
            btnLimparQuad.Size = new Size(75, 23);
            btnLimparQuad.TabIndex = 9;
            btnLimparQuad.Text = "Limpar";
            btnLimparQuad.UseVisualStyleBackColor = true;
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
            panelAreaRet.Controls.Add(btnLimparRet);
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
            // btnLimparRet
            // 
            btnLimparRet.Location = new Point(457, 330);
            btnLimparRet.Name = "btnLimparRet";
            btnLimparRet.Size = new Size(75, 23);
            btnLimparRet.TabIndex = 10;
            btnLimparRet.Text = "Limpar";
            btnLimparRet.UseVisualStyleBackColor = true;
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
            panelAreaCirc.Controls.Add(btnLimparCirc);
            panelAreaCirc.Controls.Add(lblResultadoCirc);
            panelAreaCirc.Controls.Add(lblExpressaoCirc);
            panelAreaCirc.Controls.Add(panelAreaTri);
            panelAreaCirc.Controls.Add(lblRaio);
            panelAreaCirc.Controls.Add(label1);
            panelAreaCirc.Controls.Add(lblDescFormulaCirc);
            panelAreaCirc.Controls.Add(lblFormulaCirc);
            panelAreaCirc.Controls.Add(pictureBox4);
            panelAreaCirc.Controls.Add(txtRaioCirc);
            panelAreaCirc.Controls.Add(btnCalcularCirc);
            panelAreaCirc.Location = new Point(202, 12);
            panelAreaCirc.Name = "panelAreaCirc";
            panelAreaCirc.Size = new Size(586, 426);
            panelAreaCirc.TabIndex = 10;
            // 
            // btnLimparCirc
            // 
            btnLimparCirc.Location = new Point(485, 327);
            btnLimparCirc.Name = "btnLimparCirc";
            btnLimparCirc.Size = new Size(75, 23);
            btnLimparCirc.TabIndex = 9;
            btnLimparCirc.Text = "Limpar";
            btnLimparCirc.UseVisualStyleBackColor = true;
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
            rdbAreaTri.CheckedChanged += rdbAreaTri_CheckedChanged;
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
            rdbAreaTrap.CheckedChanged += rdbAreaTrap_CheckedChanged;
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
            // panelAreaTri
            // 
            panelAreaTri.BackColor = Color.MediumAquamarine;
            panelAreaTri.Controls.Add(btnLimparTri);
            panelAreaTri.Controls.Add(lblDescFormulaTri);
            panelAreaTri.Controls.Add(lblFormulaTri);
            panelAreaTri.Controls.Add(lblResultTri);
            panelAreaTri.Controls.Add(lblExpTri);
            panelAreaTri.Controls.Add(txtAlturaTri);
            panelAreaTri.Controls.Add(txtBaseTri);
            panelAreaTri.Controls.Add(lblAlturaTri);
            panelAreaTri.Controls.Add(lblBaseTri);
            panelAreaTri.Controls.Add(btnCalcularTri);
            panelAreaTri.Controls.Add(pictureBox5);
            panelAreaTri.Location = new Point(0, 0);
            panelAreaTri.Name = "panelAreaTri";
            panelAreaTri.Size = new Size(586, 426);
            panelAreaTri.TabIndex = 9;
            // 
            // btnLimparTri
            // 
            btnLimparTri.Location = new Point(485, 318);
            btnLimparTri.Name = "btnLimparTri";
            btnLimparTri.Size = new Size(75, 23);
            btnLimparTri.TabIndex = 10;
            btnLimparTri.Text = "Limpar";
            btnLimparTri.UseVisualStyleBackColor = true;
            // 
            // lblDescFormulaTri
            // 
            lblDescFormulaTri.AutoSize = true;
            lblDescFormulaTri.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescFormulaTri.Location = new Point(337, 133);
            lblDescFormulaTri.Name = "lblDescFormulaTri";
            lblDescFormulaTri.Size = new Size(156, 21);
            lblDescFormulaTri.TabIndex = 9;
            lblDescFormulaTri.Text = "B * A (Base X Altura)";
            // 
            // lblFormulaTri
            // 
            lblFormulaTri.AutoSize = true;
            lblFormulaTri.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormulaTri.Location = new Point(337, 77);
            lblFormulaTri.Name = "lblFormulaTri";
            lblFormulaTri.Size = new Size(90, 21);
            lblFormulaTri.TabIndex = 8;
            lblFormulaTri.Text = "<- Fórmula";
            // 
            // lblResultTri
            // 
            lblResultTri.AutoSize = true;
            lblResultTri.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultTri.Location = new Point(192, 338);
            lblResultTri.Name = "lblResultTri";
            lblResultTri.Size = new Size(0, 21);
            lblResultTri.TabIndex = 7;
            // 
            // lblExpTri
            // 
            lblExpTri.AutoSize = true;
            lblExpTri.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblExpTri.Location = new Point(28, 338);
            lblExpTri.Name = "lblExpTri";
            lblExpTri.Size = new Size(0, 21);
            lblExpTri.TabIndex = 6;
            // 
            // txtAlturaTri
            // 
            txtAlturaTri.Location = new Point(192, 312);
            txtAlturaTri.Name = "txtAlturaTri";
            txtAlturaTri.Size = new Size(100, 23);
            txtAlturaTri.TabIndex = 5;
            txtAlturaTri.KeyPress += txtAlturaTri_keyPress;
            // 
            // txtBaseTri
            // 
            txtBaseTri.Location = new Point(28, 312);
            txtBaseTri.Name = "txtBaseTri";
            txtBaseTri.Size = new Size(100, 23);
            txtBaseTri.TabIndex = 4;
            // 
            // lblAlturaTri
            // 
            lblAlturaTri.AutoSize = true;
            lblAlturaTri.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAlturaTri.Location = new Point(192, 288);
            lblAlturaTri.Name = "lblAlturaTri";
            lblAlturaTri.Size = new Size(54, 21);
            lblAlturaTri.TabIndex = 3;
            lblAlturaTri.Text = "Altura";
            // 
            // lblBaseTri
            // 
            lblBaseTri.AutoSize = true;
            lblBaseTri.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBaseTri.Location = new Point(28, 288);
            lblBaseTri.Name = "lblBaseTri";
            lblBaseTri.Size = new Size(44, 21);
            lblBaseTri.TabIndex = 2;
            lblBaseTri.Text = "Base";
            // 
            // btnCalcularTri
            // 
            btnCalcularTri.Location = new Point(395, 318);
            btnCalcularTri.Name = "btnCalcularTri";
            btnCalcularTri.Size = new Size(75, 23);
            btnCalcularTri.TabIndex = 1;
            btnCalcularTri.Text = "Calcular";
            btnCalcularTri.UseVisualStyleBackColor = true;
            btnCalcularTri.Click += btnCalcularTri_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(28, 31);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(284, 202);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // panelAreaTrap
            // 
            panelAreaTrap.BackColor = SystemColors.ControlDark;
            panelAreaTrap.Controls.Add(btnLimpar);
            panelAreaTrap.Controls.Add(lblFormulaTrap);
            panelAreaTrap.Controls.Add(lblDescFormTrap);
            panelAreaTrap.Controls.Add(lblResultTrap);
            panelAreaTrap.Controls.Add(lblExpTrap);
            panelAreaTrap.Controls.Add(lblAlturaTap);
            panelAreaTrap.Controls.Add(lblBase2);
            panelAreaTrap.Controls.Add(lblBase1);
            panelAreaTrap.Controls.Add(txtAltTrap);
            panelAreaTrap.Controls.Add(txtBase2);
            panelAreaTrap.Controls.Add(txtBase1);
            panelAreaTrap.Controls.Add(btnCalcularTrap);
            panelAreaTrap.Controls.Add(pictureBox6);
            panelAreaTrap.Location = new Point(202, 12);
            panelAreaTrap.Name = "panelAreaTrap";
            panelAreaTrap.Size = new Size(586, 426);
            panelAreaTrap.TabIndex = 11;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(417, 372);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 12;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // lblFormulaTrap
            // 
            lblFormulaTrap.AutoSize = true;
            lblFormulaTrap.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormulaTrap.Location = new Point(379, 98);
            lblFormulaTrap.Name = "lblFormulaTrap";
            lblFormulaTrap.Size = new Size(109, 25);
            lblFormulaTrap.TabIndex = 11;
            lblFormulaTrap.Text = "<- Fórmula";
            // 
            // lblDescFormTrap
            // 
            lblDescFormTrap.AutoSize = true;
            lblDescFormTrap.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescFormTrap.Location = new Point(379, 143);
            lblDescFormTrap.Name = "lblDescFormTrap";
            lblDescFormTrap.Size = new Size(83, 21);
            lblDescFormTrap.TabIndex = 10;
            lblDescFormTrap.Text = "(B+b)*h/2";
            // 
            // lblResultTrap
            // 
            lblResultTrap.AutoSize = true;
            lblResultTrap.BorderStyle = BorderStyle.FixedSingle;
            lblResultTrap.Location = new Point(235, 352);
            lblResultTrap.Name = "lblResultTrap";
            lblResultTrap.Size = new Size(2, 17);
            lblResultTrap.TabIndex = 9;
            // 
            // lblExpTrap
            // 
            lblExpTrap.AutoSize = true;
            lblExpTrap.BorderStyle = BorderStyle.FixedSingle;
            lblExpTrap.Location = new Point(33, 352);
            lblExpTrap.Name = "lblExpTrap";
            lblExpTrap.Size = new Size(2, 17);
            lblExpTrap.TabIndex = 8;
            // 
            // lblAlturaTap
            // 
            lblAlturaTap.AutoSize = true;
            lblAlturaTap.Location = new Point(321, 293);
            lblAlturaTap.Name = "lblAlturaTap";
            lblAlturaTap.Size = new Size(39, 15);
            lblAlturaTap.TabIndex = 7;
            lblAlturaTap.Text = "Altura";
            // 
            // lblBase2
            // 
            lblBase2.AutoSize = true;
            lblBase2.Location = new Point(174, 293);
            lblBase2.Name = "lblBase2";
            lblBase2.Size = new Size(49, 15);
            lblBase2.TabIndex = 6;
            lblBase2.Text = "Base (b)";
            // 
            // lblBase1
            // 
            lblBase1.AutoSize = true;
            lblBase1.Location = new Point(33, 290);
            lblBase1.Name = "lblBase1";
            lblBase1.Size = new Size(49, 15);
            lblBase1.TabIndex = 5;
            lblBase1.Text = "Base (B)";
            // 
            // txtAltTrap
            // 
            txtAltTrap.Location = new Point(321, 312);
            txtAltTrap.Name = "txtAltTrap";
            txtAltTrap.Size = new Size(100, 23);
            txtAltTrap.TabIndex = 4;
            txtAltTrap.KeyPress += txtAltTrap_KeyPress;
            // 
            // txtBase2
            // 
            txtBase2.Location = new Point(174, 312);
            txtBase2.Name = "txtBase2";
            txtBase2.Size = new Size(100, 23);
            txtBase2.TabIndex = 3;
            // 
            // txtBase1
            // 
            txtBase1.Location = new Point(33, 313);
            txtBase1.Name = "txtBase1";
            txtBase1.Size = new Size(100, 23);
            txtBase1.TabIndex = 2;
            // 
            // btnCalcularTrap
            // 
            btnCalcularTrap.Location = new Point(498, 372);
            btnCalcularTrap.Name = "btnCalcularTrap";
            btnCalcularTrap.Size = new Size(75, 23);
            btnCalcularTrap.TabIndex = 1;
            btnCalcularTrap.Text = "Calcular";
            btnCalcularTrap.UseVisualStyleBackColor = true;
            btnCalcularTrap.Click += btnCalcularTrap_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(28, 31);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(326, 211);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 0;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(202, 12);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(586, 426);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 12;
            pictureBox7.TabStop = false;
            // 
            // frmCalculadoraSimp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox7);
            Controls.Add(panelAreaTrap);
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
            panelAreaTri.ResumeLayout(false);
            panelAreaTri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panelAreaTrap.ResumeLayout(false);
            panelAreaTrap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
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
        private Panel panelAreaTri;
        private Label lblDescFormulaTri;
        private Label lblFormulaTri;
        private Label lblResultTri;
        private Label lblExpTri;
        private TextBox txtAlturaTri;
        private TextBox txtBaseTri;
        private Label lblAlturaTri;
        private Label lblBaseTri;
        private Button btnCalcularTri;
        private PictureBox pictureBox5;
        private Panel panelAreaTrap;
        private Label lblFormulaTrap;
        private Label lblDescFormTrap;
        private Label lblResultTrap;
        private Label lblExpTrap;
        private Label lblAlturaTap;
        private Label lblBase2;
        private Label lblBase1;
        private TextBox txtAltTrap;
        private TextBox txtBase2;
        private TextBox txtBase1;
        private Button btnCalcularTrap;
        private PictureBox pictureBox6;
        private Button btnLimpar;
        private PictureBox pictureBox7;
        private Button btnLimparTri;
        private Button btnLimparCirc;
        private Button btnLimparRet;
        private Button btnLimparQuad;
    }
}