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

            gbxAdd.Text         = "M��teri Ekleme";
            lblId.Text          = "M��teri No";
            lblFirstName.Text   = "M��teri Ad�";
            lblLastName.Text    = "M��teri Soyad�";
            lblCity.Text        = "�ehir";
            lblEmail.Text       = "E-posta Adresi";
            btnCustomerAdd.Text = "M��teri Ekle";

            
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

            MessageBox.Show("M��teri ba�ar�l� olarak sisteme kay�t edildi");

        }
    }
}