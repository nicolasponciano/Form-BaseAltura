namespace Solucao02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBase.Clear();
            txtAltura.Clear();
            txtBase.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //var bas = float.Parse(txtBase.Text);
            //var alt = float.Parse(txtAltura.Text);

            //var resultado = bas * alt /2;
            //txtResultado.Text = resultado.ToString();


            //usando o formato primitivo
            //Triangulo triangulo = new Triangulo();
            //triangulo.setBas(txtBase.Text);
            //triangulo.setAlt(txtAltura.Text);
            //txtResultado.Text = triangulo.getArea();


            Triangulo triangulo = new Triangulo();
            triangulo.Bas = txtBase.Text;
            triangulo.Alt = txtAltura.Text;
            txtResultado.Text = triangulo.getArea();
        }
    }
}