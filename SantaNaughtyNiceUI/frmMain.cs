using SantaNaughtyNiceData.DataAccess;
using System.Drawing.Text;

namespace SantaNaughtyNiceUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            int values_changed = LoadInitialData.LoadInitialChildren();
            //MessageBox.Show($"You saved {values_changed} values");

        }

        private void btnLookUpChild_Click(object sender, EventArgs e)
        {
            string _firstName = FirstNameEntry.Text;
            string _lastName = LastNameEntry.Text;
            int yearlyANNS = ChildLookUp.getYearlyANNS(_firstName, _lastName);
            int historicalANNS = ChildLookUp.getHistoricalANNS(_firstName, _lastName);
            lblYearlyANNS.Text = yearlyANNS.ToString();
            lblHistoricalANNS.Text = historicalANNS.ToString();
        }

        private void btnRecordActivity_Click(object sender, EventArgs e)
        {
            frmRecordActivity frmRecordActivity = new frmRecordActivity();
            frmRecordActivity.Show();
        }

        private void btnAddChild_Click(object sender, EventArgs e)
        {
            frmAddChild frmAddChild = new frmAddChild();
            frmAddChild.Show();
        }
    }
}
