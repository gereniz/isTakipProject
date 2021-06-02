using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace isTakipProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnDepartmentList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmDepartments form = new Forms.FrmDepartments();
            form.MdiParent = this;
            form.Show();
        }

        private void BtnEmployeeList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmEmployees form = new Forms.FrmEmployees();
            form.MdiParent = this;
            form.Show();
        }

        private void BtnEmployeeSatistic_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmEmployeeStatistics form = new Forms.FrmEmployeeStatistics();
            form.MdiParent = this;
            form.Show();
        }

        Forms.FrmTaskList frmTaskList;
        private void BtnTaskList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmTaskList == null || frmTaskList.IsDisposed)
            {
                frmTaskList = new Forms.FrmTaskList();
                frmTaskList.MdiParent = this;
                frmTaskList.Show();
            }
            
        }

        private void BtnNewTask_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmTask form = new Forms.FrmTask();
            form.Show();
        }

        private void BtnTaskDetail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmTaskDetail form = new Forms.FrmTaskDetail();
            form.Show();
        }

        Forms.FrmMainForm frmMainForm;
        private void BtnMainPage_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frmTaskList == null || frmTaskList.IsDisposed)
            {
                frmMainForm = new Forms.FrmMainForm();
                frmMainForm.MdiParent = this;
                frmMainForm.Show();
            }
        }
    }

}
