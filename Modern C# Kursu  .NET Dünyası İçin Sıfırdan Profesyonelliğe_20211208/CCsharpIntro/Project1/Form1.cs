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
            lblProducts.Text = "Ürünler";
            lbxProducts.Items.Add("Laptop");
            lbxProducts.Items.Add("Masaüstü PC");
            lbxProducts.Items.Add("Klavye");
        }

        private void lblProducts_Click(object sender, EventArgs e)
        {

        }
    }
}