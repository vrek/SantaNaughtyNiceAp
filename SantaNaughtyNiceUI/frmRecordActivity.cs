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
using System.Windows.Forms;

namespace SantaNaughtyNiceUI
{
    public partial class frmRecordActivity : Form
    {
        List<string> childFirstNames = new List<string> { };
        List<string> childLastNames = new List<string> { };
        List<string> activities = new List<string> { };

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

                addChildHistory(_FirstName, _LastName, _Activity, db);
                updateChild(_FirstName, _LastName, _Activity, db);

            }
        }

        private void updateChild(string firstName, string lastName, string activity, ChildrenDBContext db)
        {
            throw new NotImplementedException();
        }

        private void addChildHistory(string firstName, string lastName, string activity, ChildrenDBContext db)
        {
            int childID = getChildID(firstName, lastName, db);
            if (childID == -1)
            {
                throw new Exception("No Child Found");
            }
            int activityID = getActivityID(activity, db);
            int DeltaANNS = getDeltaANNS(activityID, db);
            ChildsHistory history = new ChildsHistory();
            history.ChildID = childID;
            history.ActivityID = activityID;
            history.DeltaANNS = DeltaANNS;

            db.childsHistory.Add(history);
            db.SaveChanges();
        }

        private int getDeltaANNS(int activityID, ChildrenDBContext db)
        {

            foreach (var activityDelta in db.activities)
            {
                if (activityDelta.Id == activityID)
                    return activityDelta.Id;
            }
            return -1;
        }

        private int getActivityID(string activity, ChildrenDBContext db)
        {
            foreach (var activityID in db.activities)
            {
                if (activityID.Description == activity)
                    return activityID.Id;
            }
            return -1;
        }

        private int getChildID(string firstName, string lastName, ChildrenDBContext db)
        {
            foreach(var child in db.children)
            {
                if (child.FirstName == firstName && child.LastName == lastName)
                    return child.Id;
            }
            return -1;
        }
    }
}
