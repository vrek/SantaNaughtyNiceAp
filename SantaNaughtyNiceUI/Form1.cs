using SantaNaughtyNiceData.DataAccess;
using System.Drawing.Text;

namespace SantaNaughtyNiceUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            LoadInitialData.LoadInitialChildren();
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
    }
}
