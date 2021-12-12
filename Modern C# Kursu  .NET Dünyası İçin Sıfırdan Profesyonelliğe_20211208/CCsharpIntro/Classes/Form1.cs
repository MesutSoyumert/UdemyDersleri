namespace Classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            List<string> isimler = new List<string>()
            {
                "Mesut",
                "Deniz",
                "Nazlý",
                "Halet"
            };

            List<int> yaslar = new List<int>()
            {
                61,
                12,
                54,
                35
            };

            List<string> mailler = new List<string>()
            {
                "mesut@soyumert.com",
                "deniz@soyumert.com",
                "nazlý@soyumert.com",
                "halet@tunali.com"
            };

            //for (int i = 0; i < 4; i++)
            //{
            //    MessageBox.Show(
            //        isimler[i] + " " +
            //        yaslar[i] + " " +
            //        mailler[i]
            //        );
            //}

            //Doðru kullaným aþaðýdaki gibi olmalý
            Student ogrenci1 = new();
            ogrenci1.FirstName = "Mesut";
            ogrenci1.Age = 61;
            ogrenci1.Mail = "mesut@soyumert.com";

            Student ogrenci2 = new();
            ogrenci2.FirstName = "Deniz";
            ogrenci2.Age = 12;
            ogrenci2.Mail = "deniz@soyumert.com";

            Student ogrenci3 = new();
            ogrenci3.FirstName = "Nazlý";
            ogrenci3.Age = 54;
            ogrenci3.Mail = "nazli@soyumert.com";

            Student ogrenci4 = new();
            ogrenci4.FirstName = "Halet";
            ogrenci4.Age = 35;
            ogrenci4.Mail = "halet@tunali.com";

            List<Student> students = new List<Student>()
            { ogrenci1, ogrenci2, ogrenci3, ogrenci4};

            foreach (var student in students)
            {
                //MessageBox.Show(
                //    student.FirstName + " " +
                //    student.Age + " " +
                //    student.Mail
                //    );
                lbxStudents.Items.Add(student.FirstName);
            }

            dgrvStudents.DataSource = students;
        }

        private void dgrvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}