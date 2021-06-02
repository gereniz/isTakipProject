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
    public partial class FrmEmployees : Form
    {
        public FrmEmployees()
        {
            InitializeComponent();
        }

        DbIsTakipEntities db = new DbIsTakipEntities();
        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
        void List()
        {
            var values = from x in db.Employee
                         select new
                         {
                             x.Id,
                             x.Name,
                             x.Surname,
                             x.Mail,
                             x.Telephone,
                             DepartmentName = x.Departments.Name,
                             x.Status
                         };
            gridControl1.DataSource = values.Where(v => v.Status == true).ToList();
        }
        private void FrmEmployees_Load(object sender, EventArgs e)
        {
            List();
            var departments = (from d in db.Departments
                               select new { 
                                    d.Id,
                                    d.Name
                               }).ToList();
            lookUpEditDepartment.Properties.ValueMember = "Id";
            lookUpEditDepartment.Properties.DisplayMember = "Name";
            lookUpEditDepartment.Properties.DataSource = departments;
            
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            List();
        }
        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        

        private void lookUpEditDepartment_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var id = int.Parse(textId.Text);
            var value = db.Employee.Find(id);
            value.Status = false;
            db.SaveChanges();
            XtraMessageBox.Show("Personel başarılı bir şekilde sistemden silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            List();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

            Employee employee = new Employee();
            employee.Name = textName.Text;
            employee.Surname = textSurname.Text;
            employee.Mail = textMail.Text;
            employee.Telephone = textTelephone.Text;
            employee.Image = textImage.Text;
            employee.DepartmentId = int.Parse(lookUpEditDepartment.EditValue.ToString());

            db.Employee.Add(employee);
            db.SaveChanges();
            XtraMessageBox.Show("Personel başarılı bir şekilde sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textId.Text);
            var value = db.Employee.Find(id);
            value.Name = textName.Text;
            value.Surname = textSurname.Text;
            value.Mail = textMail.Text;
            value.Telephone = textTelephone.Text;
            value.Image = textImage.Text;
            value.DepartmentId = int.Parse(lookUpEditDepartment.EditValue.ToString());

            db.SaveChanges();
            XtraMessageBox.Show("Personel başarılı bir şekilde sistemde güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            List();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            textId.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
            textName.Text = gridView1.GetFocusedRowCellValue("Name").ToString();
            textSurname.Text = gridView1.GetFocusedRowCellValue("Surname").ToString();
            textMail.Text = gridView1.GetFocusedRowCellValue("Mail").ToString();
            textTelephone.Text = gridView1.GetFocusedRowCellValue("Telephone").ToString();
            // textImage.Text = gridView1.GetFocusedRowCellValue("Image").ToString();
            lookUpEditDepartment.Text = gridView1.GetFocusedRowCellValue("DepartmentName").ToString();
        }
    }
}
