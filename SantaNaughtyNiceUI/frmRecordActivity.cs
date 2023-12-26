using SantaNaughtyNiceData;
using SantaNaughtyNiceData.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace SantaNaughtyNiceUI
{
    public partial class frmRecordActivity : Form
    {
        List<string> childFirstNames = [];
        List<string> childLastNames = new() { };
        List<string> activities = [];

        public frmRecordActivity()
        {
            InitializeComponent();
            using (var db = new ChildrenDBContext())
            {
                foreach (var child in db.children)
                {
                    childFirstNames.Add(child.FirstName);
                    childLastNames.Add(child.LastName);
                }
                foreach (var activity in db.activities)
                {
                    activities.Add(activity.Description);
                }
            }
        }

        private void frmRecordActivityLoad(object sender, EventArgs e)
        {
            foreach (var name in childFirstNames)
            {
                cmbFirstName.Items.Add(name);
            }
            foreach (var name in childLastNames)
            {
                cmbLastName.Items.Add(name);
            }
            foreach (var activity in activities)
            {
                cmbActivity.Items.Add(activity);
            }

        }

        private void cngFirstName(object sender, EventArgs e)
        {
            cmbLastName.Items.Clear();
            using (var db = new ChildrenDBContext())
            {
                foreach (var child in db.children)
                {
                    if (child.FirstName == (string)cmbFirstName.SelectedItem)
                    {
                        cmbLastName.Items.Add(child.LastName);
                    }
                }
                if (cmbLastName.Items.Count <= 0)
                {
                    cmbFirstName.Items.Clear();
                    foreach (var child in db.children)
                    {
                        childFirstNames.Add(child.FirstName);
                        childLastNames.Add(child.LastName);
                    }
                }
            }
        }

        private void cngLastName(object sender, EventArgs e)
        {
            cmbFirstName.Items.Clear();
            using (var db = new ChildrenDBContext())
            {
                foreach (var child in db.children)
                {
                    if (child.LastName == (string)cmbLastName.SelectedItem)
                    {
                        cmbFirstName.Items.Add(child.FirstName);
                    }
                }
                if (cmbFirstName.Items.Count <= 0)
                {
                    cmbLastName.Items.Clear();
                    foreach (var child in db.children)
                    {
                        childFirstNames.Add(child.FirstName);
                        childLastNames.Add(child.LastName);
                    }
                }
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            using (var db = new ChildrenDBContext())
            {
                string _FirstName = cmbFirstName.Text;
                string _LastName = cmbLastName.Text;
                string _Activity = cmbActivity.Text;
                ChildsHistory newHistory = createChildHistory(_FirstName, _LastName, _Activity, db);
                Children child = createUpdatedChild(_FirstName, _LastName, _Activity, db);
                SendtoDB(newHistory, child, db);
            }
            this.Close();
        }

        private void SendtoDB(ChildsHistory newHistory, Children child, ChildrenDBContext db)
        {
            db.childsHistory.Add(newHistory);
            db.children.Update(child);
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"The changes were not saved. The exception was {ex}");
            }

        }

        private Children createUpdatedChild(string firstName, string lastName, string _Activity, ChildrenDBContext db)
        {
            int deltaANNS = getDeltaANNS(getActivityID(_Activity, db), db);
            foreach (var child in db.children)
            {
                if (child.LastName.Equals(lastName) && child.FirstName.Equals(firstName))
                {
                    child.Yearly_ANNS += deltaANNS;
                    child.Historical_ANNS += (int)(0.25 * deltaANNS);
                    return child;
                }
            }
            return new Children();
        }

        private ChildsHistory createChildHistory(string firstName, string lastName, string activity, ChildrenDBContext db)
        {
            int childID = getChildID(firstName, lastName, db);
            if (childID == -1)
            {
                throw new Exception("No Child Found");
            }
            int activityID = getActivityID(activity, db);
            int DeltaANNS = getDeltaANNS(activityID, db);
            DateTime dateTime = DateTime.Now;
            ChildsHistory history = new();
            history.ChildID = childID;
            history.ActivityID = activityID;
            history.DeltaANNS = DeltaANNS;
            history.DateTime = dateTime;
            return history;
        }


        private static int getDeltaANNS(int activityID, ChildrenDBContext db)
        {

            foreach (var activityDelta in db.activities)
            {
                if (activityDelta.Id == activityID)
                    return activityDelta.Value;
            }
            return -1;
        }

        private static int getActivityID(string activity, ChildrenDBContext db)
        {
            foreach (var activityID in db.activities)
            {
                if (activityID.Description == activity)
                    return activityID.Id;
            }
            return -1;
        }

        private static int getChildID(string firstName, string lastName, ChildrenDBContext db)
        {
            foreach (var child in db.children)
            {
                if (child.FirstName == firstName && child.LastName == lastName)
                    return child.Id;
            }
            return -1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
