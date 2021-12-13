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
            gbxAdd.Text        = "Araç Ekleme";
            lblId.Text         = "Araç No";
            lblBrand.Text      = "Markasý";
            lblModel.Text      = "Modeli";
            lblModelYear.Text  = "Model Yýlý";
            lblDailyPrice.Text = "Günlük Kiralama Ücreti";
            lblCity.Text       = "Aracýn Bulunduðu Þehir";
            btnAdd.Text        = "Araç Ekle";

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

            MessageBox.Show("Araç sisteme kayýt edilmiþtir.");
        }
    }
}