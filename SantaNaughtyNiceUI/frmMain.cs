using SantaNaughtyNiceData;
using SantaNaughtyNiceData.DataAccess;
using SantaNaughtyNiceData.Models;

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

        private void btnChristmasList_Click(object sender, EventArgs e)
        {
            using(var db = new ChildrenDBContext())
            {
                
                List<Children> goodChildren = GenerateGoodChildren.GenerateGoodChildrenList(db);
                GenerateGoodChildren.OutputChildren(goodChildren, db);
                ClearAllYearlyANNS(db);
            }
            
        }

        private void ClearAllYearlyANNS(ChildrenDBContext db)
        {
            MessageBox.Show("This will clear all Yearly ANNS values");
            foreach(var child in db.children)
            {
                child.Yearly_ANNS = 0;
            }
            db.SaveChanges();
        }
    }
}
