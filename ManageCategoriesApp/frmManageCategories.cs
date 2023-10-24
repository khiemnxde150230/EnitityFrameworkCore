namespace ManageCategoriesApp
{
    public partial class frmManageCategories : Form
    {
        public frmManageCategories()
        {
            InitializeComponent();
        }

        private void LoadCategories()
        {
            var categories = ManageCategories.Instance.GetCategories();
            txtCategoryID.DataBindings.Clear();
            txtCategoryName.DataBindings.Clear();
            txtCategoryID.DataBindings.Add("Text", categories, "CategoryID");
            txtCategoryName.DataBindings.Add("Text", categories, "CategoryName");
            dgvCategories.DataSource = categories;
        }

        private void frmManageCategories_Load(object sender, EventArgs e) => LoadCategories();

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                var category = new Category { CategoryName = txtCategoryName.Text };
                ManageCategories.Instance.InsertCategory(category);
                LoadCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert Category");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var category = new Category { CategoryID = int.Parse(txtCategoryID.Text), CategoryName = txtCategoryName.Text };
                ManageCategories.Instance.UpdateCategory(category);
                LoadCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Upadate Category");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var category = new Category { CategoryID = int.Parse(txtCategoryID.Text) };
                ManageCategories.Instance.DeleteCategory(category);
                LoadCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Category");
            }
        }
    }
}