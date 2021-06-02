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
    public partial class FrmTaskList : Form
    {
        public FrmTaskList()
        {
            InitializeComponent();
        }

        DbIsTakipEntities db = new DbIsTakipEntities();
        private void chartControl1_Click(object sender, EventArgs e)
        {

        }

        private void FrmTaskList_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.Tasks
                                       select new
                                       {
                                           x.Description
                                       }).ToList();
            lblActiveTask.Text = db.Tasks.Where(w => w.Status == true).Count().ToString();
            lblPassiveTask.Text = db.Tasks.Where(w => w.Status == false).Count().ToString();
            lblTotalDepartment.Text = db.Departments.Count().ToString();
            
            chartControl1.Series["Status"].Points.AddPoint("Aktif Görevler" ,int.Parse(lblActiveTask.Text));
            chartControl1.Series["Status"].Points.AddPoint("Passive Görevler", int.Parse(lblPassiveTask.Text));
            

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
