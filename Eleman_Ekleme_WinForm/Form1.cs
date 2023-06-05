namespace Eleman_Ekleme_WinForm
{
    public partial class Form1 : Form
    {
        List<int> sayilar = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            sayilar.Add(Convert.ToInt32(sayiTextBox.Text));
            MessageBox.Show("Listeye " + sayiTextBox.Text + " eklenmistir.");
            sayiTextBox.Clear();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En Buyuk Say�: " + sayilar.Max()
                +Environment.NewLine + "En Kucuk Say�: " + sayilar.Min());
        }
    }
}