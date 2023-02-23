namespace TestWinAlexander
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string author = "";
            string title = "";
            string izdatelstvo = "";
            string janr = "";
            string korica = "";
            if(string.IsNullOrEmpty(cmbIzdatel.Text)) 
            {
                MessageBox.Show("Не си избрал издател");
                cmbIzdatel.Focus();
                return;
                izdatelstvo = cmbIzdatel.Text;
                izdatelstvo = cmbIzdatel.Text;
            }
            else
            {
                izdatelstvo = cmbIzdatel.Text;
            }
            if (rbHudojestvena.Checked) janr = rbHudojestvena.Text;
            if (rbNauchna.Checked) janr = rbNauchna.Text;
            if (rbSpravochna.Checked) janr = rbSpravochna.Text;

            if(chbTvurda.Checked)
            {
                korica = chbTvurda.Text;
            }

            if (string.IsNullOrEmpty(author))
            {
                author = txtAutor.Text;
            }
            else 
            {
                MessageBox.Show("Не си написъл Автор");
            }
            if (string.IsNullOrEmpty(txtTitle.Text)) 
            {
                MessageBox.Show("Не си написъл заглавие");
            }
            else
            {
                title = txtAutor.Text;
            }
            MessageBox.Show($"Вие въведохте {title} с автор {author}, {janr} " +
              $"литература с {korica} корица от издателство {izdatelstvo}. Потвърждавате ли?");
        }
    }
}