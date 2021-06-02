using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using isTakipProje.Entity;

namespace isTakipProje.Forms
{
    public partial class FrmTask : Form
    {
        DbIsTakipEntities db = new DbIsTakipEntities();
        public FrmTask()
        {
            InitializeComponent();
        }

        private void btnGiveUp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Tasks task = new Tasks();
            task.Description = textDescription.Text;
            task.Status = true;
            task.Date = DateTime.Parse(textDate.Text);
            task.InChargeId = int.Parse(lookUpInCharge.EditValue.ToString());
            task.AssignorId = int.Parse(textAssignor.Text);

            db.Tasks.Add(task);
            db.SaveChanges();
            XtraMessageBox.Show("Görev başarılı bir şekilde sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void FrmTask_Load(object sender, EventArgs e)
        {
            var employee = (from d in db.Employee
                               select new
                               {
                                   d.Id,
                                   NameSurname = d.Name + " " + d.Surname
                               }).ToList();
            lookUpInCharge.Properties.ValueMember = "Id";
            lookUpInCharge.Properties.DisplayMember = "NameSurname";
            lookUpInCharge.Properties.DataSource = employee;
        }
    }
}
