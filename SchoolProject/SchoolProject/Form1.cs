namespace SchoolProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SchoolDal _schoolDal = new SchoolDal();
        public void Form1_Load(object sender, EventArgs e)
        {
            LoadSchools();
        }

        private void LoadSchools()
        {
            dgwSchool.DataSource = _schoolDal.GetAll();
        }

        public void btnAdd_Click(object sender, EventArgs e)
        {
            _schoolDal.Add(new School
            {
                Name = tbxName.Text,
                City = tbxCity.Text,
                District = tbxDistrict.Text,
                Type = tbxType.Text
            });
            LoadSchools();
            MessageBox.Show("School added!");
        }

        public void dgwSchool_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUName.Text = dgwSchool.CurrentRow.Cells[1].Value.ToString();
            tbxUCity.Text = dgwSchool.CurrentRow.Cells[2].Value.ToString();
            tbxUDistrict.Text = dgwSchool.CurrentRow.Cells[3].Value.ToString();
            tbxUType.Text = dgwSchool.CurrentRow.Cells[4].Value.ToString();
        }

        public void btnUpdate_Click(object sender, EventArgs e)
        {
            School school = new School{
                Id = Convert.ToInt32(dgwSchool.CurrentRow.Cells[0].Value),
                Name = tbxUName.Text,
                City = tbxUCity.Text,
                District = tbxUDistrict.Text,
                Type = tbxUType.Text
            };
            _schoolDal.Update(school);
            LoadSchools();
            MessageBox.Show("Scchool updated!");

        }

        public void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwSchool.CurrentRow.Cells[0].Value);
            _schoolDal.Delete(id);
            LoadSchools();
            MessageBox.Show("School deleted!");
        }
    }
}