namespace PesoIdeal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtAltura.Clear();
            cbSexo.Text = "";
            txtNome.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesoIdeal_Click(object sender, EventArgs e)
        {
            try //Tente calcular o peso ideal 
            {
                double Altura = 0, Pesoideal = 0;
                Altura = double.Parse(txtAltura.Text);

                if (cbSexo.Text == "Feminino")
                {
                    Pesoideal = (62.7 * Altura) - 44.7;
                    MessageBox.Show(txtNome.Text + ", Seu peso ideal é " + Pesoideal.ToString("f2") + " Kg",
                        "Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cbSexo.Text == "Masculino")
                {
                    Pesoideal = (72.7 * Altura) - 58;
                    MessageBox.Show(txtNome.Text + ", Seu peso ideal é " + Pesoideal.ToString("f2") + " Kg",
                        "Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Escolha o sexo", "Peso Ideal", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Verifique os valores informados", "Peso Ideal",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}