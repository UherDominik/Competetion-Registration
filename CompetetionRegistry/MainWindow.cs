using System.Drawing.Text;

namespace CompetetionRegistry
{
    public partial class MainWindow : Form
    {
        Database database = new Database();
        BindingSource compBind = new BindingSource();

        public MainWindow()
        {


            InitializeComponent();
            ReloadCompetitorsListBox();


        }
        private void ReloadCompetitorsListBox()
        {
            CompetitorsListBox.DataSource = null;
            compBind.DataSource = database.LoadData();
            CompetitorsListBox.DataSource = compBind;
            CompetitorsListBox.DisplayMember = "Display";
            CompetitorsListBox.ValueMember = "Display";
        }



        private void Insertbutton_Click_1(object sender, EventArgs e)
        {
            string name = NametextBox.Text;
            string surname = SurnametextBox.Text;
            string category = CategorytextBox.Text;
            database.InsertNewCopetitor(name, surname, category);
            ReloadCompetitorsListBox();

        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            database.UpdateCopetitor(UpdateNametextBox.Text, UpdateSurnametextBox.Text, UpdateCategorytextBox.Text, ((Competitor)CompetitorsListBox.SelectedItem).Id);
            ReloadCompetitorsListBox();
        }

        private void CompetitorsListBox_Click(object sender, EventArgs e)
        {

            UpdateNametextBox.Text = ((Competitor)CompetitorsListBox.SelectedItem).Name;
            UpdateSurnametextBox.Text = ((Competitor)CompetitorsListBox.SelectedItem).Surname;
            UpdateCategorytextBox.Text = ((Competitor)CompetitorsListBox.SelectedItem).Category;
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            database.DeleteCopetitor(((Competitor)CompetitorsListBox.SelectedItem).Id);
            ReloadCompetitorsListBox();
        }
    }
}