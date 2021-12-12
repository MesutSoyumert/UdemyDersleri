namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var productsText = "Ürünler";
            var addToCartButtonText = "Sepete Ekle";
            var cartText = "Sepetiniz";
            var removeFromCartButtonText = "Sepetten Çýkar";

            lblProducts.Text = productsText;
            btnAddToCart.Text = addToCartButtonText;
            lblCart.Text = cartText;
            btnRemoveFromCart.Text = removeFromCartButtonText;
            string [] products = new string[]
                {"Laptop","Masaüstü PC","Klavye"};

            //for (int i = 0; i < products.Length; i++)
            //{
            //    lbxProducts.Items.Add(products[i]);
            //}

            foreach (var product in products)
            {
                lbxProducts.Items.Add(product);
            }

            if (lbxCart.Items.Count == 0)
            {
                btnRemoveFromCart.Enabled = false;
            }
        }

        private void lblProducts_Click(object sender, EventArgs e)
        {

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(lbxProducts.SelectedItem.ToString());

            if (lbxProducts.SelectedItem != null)
            {
                lbxCart.Items.Add(lbxProducts.SelectedItem);
                btnRemoveFromCart.Enabled = true;
            }
            else
            {
                MessageBox.Show("Sepetinize ürün eklemek için ürünlerden bir ürün seçmelisiniz");
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lbxCart.SelectedItem != null)
            {
                lbxCart.Items.Remove(lbxCart.SelectedItem);
            }
            else
            {
                MessageBox.Show("Sepetten ürün çýkarmanýz için sepetinizden bir ürün seçmelisiniz");
            }
            if (lbxCart.Items.Count == 0)
            {
                btnRemoveFromCart.Enabled = false;
            }
        }
    }
}