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
            string expressao;
            double lado = double.Parse(txtLadoQuad.Text);
            double resultado = lado * lado;

            lblExpressao.Text = lado.ToString() + " x " + lado.ToString();
            //$"{lado.ToString()} x {lado.ToString()}"; = Template string

            lblResultado.Text = resultado.ToString();


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

        //Area Retangulo

        private void rdbAreaRet_CheckedChanged(object sender, EventArgs e)
        {
            panelAreaRet.BringToFront();
        }

        private void btnCalcularRet_Click(object sender, EventArgs e)
        {
            double ladoa = double.Parse(txtLadoA.Text);
            double ladob = double.Parse(txtLadoB.Text);
            double resultado = ladoa * ladob;
            string expressao;

            lblResultadoRet.Text = resultado.ToString();
            lblExpressaoRet.Text = $"{ladoa.ToString()} x {ladob.ToString()}";
        }

        private void txtLadoB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnCalcularRet.PerformClick();
            }
        }

        //Area Circulo
        private void rdbAreaCirc_CheckedChanged(object sender, EventArgs e)
        {
            panelAreaCirc.BringToFront();
        }

        private void btnCalcularCirc_Click(object sender, EventArgs e)
        {
            double raio = double.Parse(txtRaioCirc.Text);
            double resultado = Math.PI * raio;
            string expressao;

            lblExpressaoCirc.Text = $"{raio.ToString()} x {Math.PI}";
            lblResultadoCirc.Text = resultado.ToString("n2");
        }

        private void txtRaioCirc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnCalcularCirc.PerformClick();
            }
        }
    }
}