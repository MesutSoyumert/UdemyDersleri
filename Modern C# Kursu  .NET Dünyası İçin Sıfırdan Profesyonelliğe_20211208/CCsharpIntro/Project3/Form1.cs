namespace Project3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CustomerManager customerManager = new CustomerManager();

        private void Form1_Load(object sender, EventArgs e)
        {

            gbxAdd.Text         = "Müþteri Ekleme";
            lblId.Text          = "Müþteri No";
            lblFirstName.Text   = "Müþteri Adý";
            lblLastName.Text    = "Müþteri Soyadý";
            lblCity.Text        = "Þehir";
            lblEmail.Text       = "E-posta Adresi";
            btnCustomerAdd.Text = "Müþteri Ekle";

            
            dgrwCustomers.DataSource = customerManager.GetAll();
            dgrwCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void gbxAdd_Enter(object sender, EventArgs e)
        {

        }

        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {

            Customer        customer        = new Customer();

            customer.Id        = Convert.ToInt32(tbxId.Text);
            customer.FirstName = tbxFirstName.Text;
            customer.LastName  = tbxLastName.Text;
            customer.City      = tbxCity.Text;
            customer.Email     = tbxEmail.Text;

            customerManager.Add(customer);

            dgrwCustomers.DataSource = null;
            dgrwCustomers.DataSource = customerManager.GetAll();

            MessageBox.Show("Müþteri baþarýlý olarak sisteme kayýt edildi");

        }
    }
}