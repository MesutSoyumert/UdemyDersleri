namespace Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> students;

        private void Form1_Load(object sender, EventArgs e)
        {
            students = new List<string>()
            {
                "Mesut Soyumert",
                "Nazlý Soyumert",
                "Deniz Soyumert"
            };

            foreach (var student in students)
            {
                lbxStudentList.Items.Add(student);
            }
        }

        private void lblStudentList_Click(object sender, EventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (tbxStudentName.Text.Length >= 2)
            {
                students.Add(tbxStudentName.Text);

                lbxStudentList.Items.Clear();

                foreach (var student in students)
                {
                    lbxStudentList.Items.Add(student);
                }

                tbxStudentName.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen en az iki karakter uzunluðunda Öðrenci Adýný giriniz");
            }
        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            students.Remove(lbxStudentList.SelectedItem.ToString());

            lbxStudentList.Items.Clear();

            foreach (var student in students)
            {
                lbxStudentList.Items.Add(student);
            }
        }
    }
}