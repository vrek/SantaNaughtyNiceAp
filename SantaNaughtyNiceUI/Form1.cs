using SantaNaughtyNiceData.DataAccess;
using System.Drawing.Text;

namespace SantaNaughtyNiceUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadInitialData.LoadInitialChildren();
        }

        private void btnLookUpChild_Click(object sender, EventArgs e)
        {
            string _firstName = FirstNameEntry.Text;
            string _lastName = LastNameEntry.Text;
        }
    }
}
