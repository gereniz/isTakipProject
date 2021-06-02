using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using isTakipProje.Entity;

namespace isTakipProje.Forms
{
    public partial class FrmEmployeeStatistics : Form
    {
        DbIsTakipEntities db = new DbIsTakipEntities();
        public FrmEmployeeStatistics()
        {
            InitializeComponent();
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl10_Click(object sender, EventArgs e)
        {

        }

        private void labelControl22_Click(object sender, EventArgs e)
        {

        }

        private void panelControl7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmEmployeeStatistics_Load(object sender, EventArgs e)
        {
            lblTotalDepartment.Text = db.Departments.Count().ToString();
            lblTotalEmployee.Text = db.Employee.Count().ToString();
            lblTotalCompany.Text = db.Companies.Count().ToString();
            lblTotalSector.Text = db.Sector.Count().ToString();

            lblTotalCity.Text = db.Companies.Select(c => c.CityId).Distinct().Count().ToString();
            DateTime today = DateTime.Today;
            lblTodayTasks.Text = db.Tasks.Count(t => t.Date == today).ToString();
            lblActiveBusiness.Text = db.Tasks.Count(t => t.Status == true).ToString();
            lblPassiveBusiness.Text = db.Tasks.Count(t => t.Status == false).ToString();

            lblLastTask.Text = db.Tasks.OrderByDescending(t => t.Id).Select(s => s.Description).FirstOrDefault();
            lblLastTaskDate.Text = db.Tasks.OrderByDescending(o => o.Id).Select(s => s.Date).FirstOrDefault().ToString();
            var empOfMonth = db.Tasks.GroupBy(t => t.AssignorId).OrderByDescending(o => o.Count()).Select(s => s.Key).FirstOrDefault();
            lblEmpOfMonth.Text = db.Employee.Where(w => w.Id == empOfMonth).Select(s => s.Name + " " + s.Surname).FirstOrDefault().ToString();
            lblDeparOfMonth.Text = db.Departments.Where(w => w.Id == (db.Employee.Where(t => t.Id == empOfMonth).Select(s => s.DepartmentId).FirstOrDefault())).Select(s => s.Name).FirstOrDefault().ToString();
        }
    }
}
