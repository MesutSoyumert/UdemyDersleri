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

            var projectNameText       = "Soyumert Araç Kiralama";
            var carsText              = "Kiralýk araçlarýmýz";
            var cartText              = "Ýlgilendiðiniz araçlar";

            var btnAddToCartText      = "Seçtiðim aracý ilgilendiðim araçlara ekle";
            var btnRemoveFromCartText = "Seçtiðim aracý ilgilendiðim araçlardan çýkar";

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
                MessageBox.Show("Ýlgilendiðiniz araçlara araç eklemek için araçlar listesinden bir araç seçmelisiniz");
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
                MessageBox.Show("Ýlgilendiðiniz araçlardan araç çýkarmanýz için Ýlgilendiðiniz araçlar listesinden bir araç seçmelisiniz");
            }
            if (lbxCart.Items.Count == 0)
            {
                btnRemoveFromCart.Enabled = false;
            }
        }
    }
}