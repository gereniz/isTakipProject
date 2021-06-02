using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using isTakipProje.Entity;

namespace isTakipProje.Forms
{
    public partial class FrmTaskDetail : Form
    {
        DbIsTakipEntities db = new DbIsTakipEntities();
        public FrmTaskDetail()
        {
            InitializeComponent();
        }

        private void FrmTaskDetail_Load(object sender, EventArgs e)
        {
            db.TaskDetail.Load();
            bindingSource1.DataSource = db.TaskDetail.Local;
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            db.SaveChanges();
        }

        private void görevDetaySilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent();
            db.SaveChanges();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
