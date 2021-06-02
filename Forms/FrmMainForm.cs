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
    
    public partial class FrmMainForm : Form
    {
        DbIsTakipEntities db = new DbIsTakipEntities();

        public FrmMainForm()
        {
            InitializeComponent();
        }

        private void FrmMainForm_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.Tasks
                                       select new
                                       {
                                           x.Description,
                                           nameSurname = x.Employee.Name + " " + x.Employee.Surname
                                       }).ToList();
        }
    }
}
