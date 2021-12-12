namespace Odev8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Car car1 = new Car();
            car1.Brand = "Skoda";
            car1.Model = "Octavia";
            car1.ModelYear = 2016;
            car1.DailyPrice = 350;

            Car car2 = new Car();
            car2.Brand = "Skoda";
            car2.Model = "Fabia";
            car2.ModelYear = 2018;
            car2.DailyPrice = 250;

            Car car3 = new Car();
            car3.Brand = "Skoda";
            car3.Model = "Rapid";
            car3.ModelYear = 2017;
            car3.DailyPrice = 300;

            Car car4 = new Car();
            car4.Brand = "Skoda";
            car4.Model = "Superb";
            car4.ModelYear = 2022;
            car4.DailyPrice = 600;

            Car car5 = new Car();
            car5.Brand = "Volswagen";
            car5.Model = "Jetta";
            car5.ModelYear = 2019;
            car5.DailyPrice = 400;

            List<Car> cars = new List<Car>() { car1, car2, car3, car4, car5};
            dgrvCars.DataSource = cars;
        }
    }
}