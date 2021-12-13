namespace Odev9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CarManager carManager = new CarManager();

        private void Form1_Load(object sender, EventArgs e)
        {
            gbxAdd.Text        = "Ara� Ekleme";
            lblId.Text         = "Ara� No";
            lblBrand.Text      = "Markas�";
            lblModel.Text      = "Modeli";
            lblModelYear.Text  = "Model Y�l�";
            lblDailyPrice.Text = "G�nl�k Kiralama �creti";
            lblCity.Text       = "Arac�n Bulundu�u �ehir";
            btnAdd.Text        = "Ara� Ekle";

            dgrwCars.DataSource = carManager.GetAll();
            dgrwCars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Car car        = new Car();
            car.Id         = Convert.ToInt32(tbxId.Text);
            car.Brand      = tbxBrand.Text;
            car.Model      = tbxModel.Text;
            car.ModelYear  = Convert.ToInt32(tbxModelYear.Text);
            car.DailyPrice = Convert.ToInt32(tbxDailyPrice.Text);
            car.City       = tbxCity.Text;

            carManager.Add(car);

            dgrwCars.DataSource = null;
            dgrwCars.DataSource = carManager.GetAll();

            MessageBox.Show("Ara� sisteme kay�t edilmi�tir.");
        }
    }
}