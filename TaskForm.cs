using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ScrumTaskBoard
{
    public partial class TaskForm : DevExpress.XtraEditors.XtraForm
    {
        public TaskForm()
        {
            InitializeComponent();
        }

        private void TaskForm_Load(object sender, EventArgs e)
        {
            string date = "07-10-1999";
            dateStart.DateTime = DateTime.Parse(date);
            MessageBox.Show(dateStart.DateTime.ToShortDateString());
        }
    }
}