namespace WinFormsIMC
{
    public partial class FrmImc : Form
    {
        //Variáveis Globais
        float imc = 0;
        public FrmImc()
        {
            InitializeComponent();
        }


        private float CalculoImc(float peso, float altura)
        {
            imc = peso / (altura * altura);
            return imc;

        }

        private void btnImc_Click(object sender, EventArgs e)
        {
            string grau;
            float peso;
            float altura;

            if (!float.TryParse(txtPeso.Text, out peso))
            {
                MessageBox.Show("Digite um peso válido.", "IMC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!float.TryParse(txtAltura.Text, out altura))
            {
                MessageBox.Show("Digite uma altura válida.", "IMC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            CalculoImc(float.Parse(txtPeso.Text), float.Parse(txtAltura.Text));

            switch (imc)
            {
                case >= 40:
                    grau = "Obesidade grau III - Mórbida";
                    break;

                case >= 35:
                    grau = "Obesidade grau II - Severa";
                    break;

                case >= 30:
                    grau = "Obesidade grau I";
                    break;

                case >= 25:
                    grau = "Levemente acima do peso";
                    break;

                case >= 19:
                    grau = "Peso ideal - Parabéns";
                    break;

                default:
                    grau = "Abaixo do peso";
                    break;

            }

            MessageBox.Show($"IMC: {imc:F2} \n Grau: {grau}", "IMC", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
