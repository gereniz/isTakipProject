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
    public partial class FrmDepartments : Form
    {
        public FrmDepartments()
        {
            InitializeComponent();
        }

        
        DbIsTakipEntities db = new DbIsTakipEntities();
        
        void List()
        {
            var values = (from d in db.Departments
                            select new
                            {
                                d.Id,
                                d.Name
                            }).ToList();
            gridControl1.DataSource = values;
        }

        private void Btn_List(object sender, EventArgs e)
        {
            List();
        }

        private void Btn_Add(object sender, EventArgs e)
        {
            Departments departments = new Departments();
            departments.Name = textName.Text;

            db.Departments.Add(departments);
            db.SaveChanges();
            XtraMessageBox.Show("Departman başarılı bir şekilde sisteme kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List();
        }

        private void Btn_Delete(object sender, EventArgs e)
        {
            int id = int.Parse(textId.Text);
            var value = db.Departments.Find(id);
            db.Departments.Remove(value);
            db.SaveChanges();
            XtraMessageBox.Show("Departman başarılı bir şekilde sistemden silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            List();
        }
        private void Btn_Edit(object sender, EventArgs e)
        {
            int id = int.Parse(textId.Text);
            var value = db.Departments.Find(id);
            value.Name= textName.Text;
            db.SaveChanges();
            XtraMessageBox.Show("Departman başarılı bir şekilde sistemde güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            List();
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            textId.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
            textName.Text = gridView1.GetFocusedRowCellValue("Name").ToString();
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void Text_Id(object sender, EventArgs e)
        {

        }

        private void Text_Name(object sender, EventArgs e)
        {

        }

        private void FrmDepartments_Load(object sender, EventArgs e)
        {

        }
    }
}
