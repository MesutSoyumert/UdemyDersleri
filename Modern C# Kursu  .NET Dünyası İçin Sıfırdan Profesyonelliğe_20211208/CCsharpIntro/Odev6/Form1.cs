namespace Odev6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            var projectNameText       = "Soyumert Ara� Kiralama";
            var carsText              = "Kiral�k ara�lar�m�z";
            var cartText              = "�lgilendi�iniz ara�lar";

            var btnAddToCartText      = "Se�ti�im arac� ilgilendi�im ara�lara ekle";
            var btnRemoveFromCartText = "Se�ti�im arac� ilgilendi�im ara�lardan ��kar";

            lblProjectName.Text    = projectNameText;
            lblCars.Text           = carsText;
            lblCart.Text           = cartText;

            btnAddToCart.Text      = btnAddToCartText;
            btnRemoveFromCart.Text = btnRemoveFromCartText;

            string[] cars = new string[] {"Octavia", "Superb", "Fabia", "Rapid" };

            foreach (var car in cars)
            {
                lbxCars.Items.Add(car);
            }

            if (lbxCart.Items.Count == 0)
            {
                btnRemoveFromCart.Enabled = false;
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (lbxCars.SelectedItem != null)
            {
                lbxCart.Items.Add(lbxCars.SelectedItem);
                btnRemoveFromCart.Enabled = true;
            }
            else
            {
                MessageBox.Show("�lgilendi�iniz ara�lara ara� eklemek i�in ara�lar listesinden bir ara� se�melisiniz");
            }
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (lbxCart.SelectedItem != null)
            {
                lbxCart.Items.Remove(lbxCart.SelectedItem);
            }
            else
            {
                MessageBox.Show("�lgilendi�iniz ara�lardan ara� ��karman�z i�in �lgilendi�iniz ara�lar listesinden bir ara� se�melisiniz");
            }
            if (lbxCart.Items.Count == 0)
            {
                btnRemoveFromCart.Enabled = false;
            }
        }
    }
}