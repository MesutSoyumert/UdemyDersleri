namespace Odev7
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        List<string> cars;

        private void Form1_Load(object sender, EventArgs e)
        {

            var projectNameText = "Soyumert Ara� Kiralama";
            var carsListText = "Kiral�k ara�lar�m�z";
            var btnAddToCarsListText = "Arac� ekle";
            var btnRemoveFromCarsListText = "Se�ti�im arac� sil";

            lblProjectName.Text = projectNameText;
            lblCarsListText.Text = carsListText;
            
            btnAddCar.Text = btnAddToCarsListText;
            btnRemoveFromCars.Text = btnRemoveFromCarsListText;

            cars = new List<string>()
            {
                "Fabia",
                "Rapid",
                "Octavia",
                "Superb"
            };

            foreach (var car in cars)
            {
                lbxCarsList.Items.Add(car);
            }

            

            
            

            
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            if (tbxCarName.Text.Length >= 2)
            {
                cars.Add(tbxCarName.Text);

                lbxCarsList.Items.Clear();

                foreach (var car in cars)
                {
                    lbxCarsList.Items.Add(car);
                }

                tbxCarName.Text = "";
            }
            else
            {
                MessageBox.Show("L�tfen en az iki karakter uzunlu�unda Ara� Ad�n� giriniz");
            }
        }

        private void btnRemoveFromCars_Click(object sender, EventArgs e)
        {
            cars.Remove(lbxCarsList.SelectedItem.ToString());

            lbxCarsList.Items.Clear();

            foreach (var car in cars)
            {
                lbxCarsList.Items.Add(car);
            }
        }
    }
}