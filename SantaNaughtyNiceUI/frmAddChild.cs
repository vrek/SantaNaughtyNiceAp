using SantaNaughtyNiceData;
using SantaNaughtyNiceData.Models;

namespace SantaNaughtyNiceUI
{
    public partial class frmAddChild : Form
    {
        public frmAddChild()
        {
            InitializeComponent();
        }

        public void OK_Click(object sender, EventArgs e)
        {
            int _houseNumber = 0;
            int _yearlyANNS = 0;
            int _historicalANNS = 0;
            Children child = new Children();
            child.FirstName = lblFirstName.Text.Trim();
            child.LastName = lblLastName.Text.Trim();
            bool houseNumSuccess = int.TryParse(lblHouseNum.Text.Trim(), out _houseNumber);
            if (houseNumSuccess)
            {
                child.House_Number = _houseNumber;
            }
            else
            {
                MessageBox.Show("The House Number must be an integer");
            }
            child.StreetName = lblStreet.Text.Trim();
            child.CityName = lblCity.Text.Trim();
            child.PostalCode = lblZipCode.Text.Trim();
            child.CountryName = lblCountry.Text.Trim();
            bool yearlyANNSSuccess = int.TryParse(lblYearlyANNS.Text.Trim(), out _yearlyANNS);
            if (yearlyANNSSuccess)
            {
                child.Yearly_ANNS = _yearlyANNS;
            }
            else
            {
                MessageBox.Show("The Yearly ANNS must be an integer");
            }
            bool historicalANNSSuccess = int.TryParse(lblHistoryANNS.Text.Trim(), out _historicalANNS);
            if (historicalANNSSuccess)
            {
                child.Historical_ANNS = _historicalANNS;
            }
            else
            {
                MessageBox.Show("The Historical ANNS must be an integer");
            }
            using (var db = new ChildrenDBContext())
            {
                db.children.Add(child);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"The child was not added. {ex}");
                }
            }
            this.Close();
        }
    }
}
