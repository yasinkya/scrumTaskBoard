using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ScrumTaskBoard
{
    public partial class ToDoFrom : DevExpress.XtraEditors.XtraUserControl
    {
        public ToDoFrom()
        {
            InitializeComponent();
            GroupControl grpcnt = new GroupControl();
            int x = groupControl1.Location.X;
            int y = groupControl1.Location.Y;
            grpcnt.Size = groupControl1.Size;
            grpcnt.Location = new Point(0, groupControl1.Height*2);
            tileControl1.Controls.Add(grpcnt);
        }

        private void tileControl1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {
            Button btn = new Button();
            btn.Text = "BOTTOONN";
            btn.Location = new Point(groupControl1.Location.X + 50, groupControl1.Location.Y + 50);
            groupControl1.Controls.Add(btn);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }
    }
}
