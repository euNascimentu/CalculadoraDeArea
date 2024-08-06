//        private void panelAreaRet_Paint(object sender, PaintEventArgs e
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace CalculadoraSimples
{
    public partial class frmCalculadoraSimp : Form
    {
        public frmCalculadoraSimp()
        {
            InitializeComponent();
        }

        //Area Quadrado

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtLadoQuad.Text == "")
            {
                MessageBox.Show("Por favor, Complete todas as caixas!");
            }
            else
            {
                string expressao;
                double lado = double.Parse(txtLadoQuad.Text);
                double resultado = lado * lado;

                lblExpressao.Text = lado.ToString() + " x " + lado.ToString();
                //$"{lado.ToString()} x {lado.ToString()}"; = Template string

                lblResultado.Text = resultado.ToString();
            }
        }
        private void rdbAreaQuad_CheckedChanged(object sender, EventArgs e)
        {
            panelAreaQuad.BringToFront();
        }

        private void txtLadoQuad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnCalcular.PerformClick();
            }
        }

        private void btnLimparQuad_Click(object sender, EventArgs e)
        {
            txtLadoQuad.Text = "";
        }

        //Area Retangulo

        private void rdbAreaRet_CheckedChanged(object sender, EventArgs e)
        {
            panelAreaRet.BringToFront();
        }

        private void btnCalcularRet_Click(object sender, EventArgs e)
        {
            if (txtLadoA.Text == "" || txtLadoB.Text == "")
            {
                MessageBox.Show("Por favor, Complete todas as caixas!");
            }
            else
            {
                double ladoa = double.Parse(txtLadoA.Text);
                double ladob = double.Parse(txtLadoB.Text);
                double resultado = ladoa * ladob;
                string expressao;

                lblResultadoRet.Text = resultado.ToString();
                lblExpressaoRet.Text = $"{ladoa.ToString()} x {ladob.ToString()}";
            }
        }

        private void txtLadoB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnCalcularRet.PerformClick();
            }
        }

        private void btnLimparRet_Click(object sender, EventArgs e)
        {
            txtLadoB.Text = "";
            txtLadoA.Text = "";
        }

        //Area Circulo
        private void rdbAreaCirc_CheckedChanged(object sender, EventArgs e)
        {
            panelAreaCirc.BringToFront();
        }

        private void btnCalcularCirc_Click(object sender, EventArgs e)
        {
            if (txtRaioCirc.Text == "")
            {
                MessageBox.Show("Por favor, Complete todas as caixas!");
            }
            else
            {
                double raio = double.Parse(txtRaioCirc.Text);
                double resultado = Math.PI * raio;
                string expressao;

                lblExpressaoCirc.Text = $"{raio.ToString()} x {Math.PI}";
                lblResultadoCirc.Text = resultado.ToString("n2");
            }
        }

        private void txtRaioCirc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnCalcularCirc.PerformClick();
            }
        }

        private void btnLimparCirc_Click(object sender, EventArgs e)
        {
            txtRaioCirc.Text = "";
        }

        //Area Triangulo

        private void rdbAreaTri_CheckedChanged(object sender, EventArgs e)
        {
            panelAreaTri.BringToFront();
        }

        private void btnCalcularTri_Click(object sender, EventArgs e)
        {
            if (txtAlturaTri.Text == "" || txtBaseTri.Text == "")
            {
                MessageBox.Show("Por favor, Complete todas as caixas!");
            }
            else
            {
                double altura = double.Parse(txtAlturaTri.Text);
                double basee = double.Parse(txtBaseTri.Text);
                double conta = basee * altura;
                string expressao = $"{basee.ToString()} x {altura.ToString()}";

                lblResultTri.Text = conta.ToString();
                lblExpTri.Text = expressao.ToString();
            }
        }

        private void txtAlturaTri_keyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnCalcularTri.PerformClick();
            }
        }

        private void btnLimparClick_Click(object sender, EventArgs e)
        {
            txtAlturaTri.Text = "";
            txtBaseTri.Text = "";
        }

        //Area Trap
        private void rdbAreaTrap_CheckedChanged(object sender, EventArgs e)
        {
            panelAreaTrap.BringToFront();
        }

        private void btnCalcularTrap_Click(object sender, EventArgs e)
        {
            if (txtBase1.Text == "" || txtBase2.Text == "" || txtAltTrap.Text == "")
            {
                MessageBox.Show("Por favor, Complete todas as bases!");
            }

            else
            {
                double B = double.Parse(txtBase1.Text);
                double b = double.Parse(txtBase2.Text);
                double alt = double.Parse(txtAltTrap.Text);
                double conta = B + b * alt * 2;
                string expressao = $"{B.ToString()} + {b.ToString()} * {alt.ToString()} x 2";

                lblExpTrap.Text = expressao.ToString();
                lblResultTrap.Text = conta.ToString();
            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltTrap.Text = "";
            txtBase1.Text = "";
            txtBase2.Text = "";
        }

        private void txtAltTrap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnCalcularTri.PerformClick();
            }
        }


        //Excluido! (private void panelAreaTri_Paint(object sender, PaintEventArgs e))



    }
}