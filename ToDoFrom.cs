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
        TileControl tileControl = new TileControl();
        public ToDoFrom()
        {
            InitializeComponent();
            tileControl.BackColor = Color.FromArgb(60, 60, 60);
            tileControl.Dock = DockStyle.Fill; 
            this.Controls.Add(tileControl);
        }
        
        public void addNew()
        {

            GroupControl grpcnt = new GroupControl();
            grpcnt.Size= new Size(320,150);
            grpcnt.Anchor = AnchorStyles.Left;
            grpcnt.Anchor = AnchorStyles.Right;
            grpcnt.Dock = DockStyle.None;
            grpcnt.Location = new Point(47, 50);
            grpcnt.Text = "DENEME";
            grpcnt.CaptionImageOptions.SvgImage = DevExpress.Utils.Svg.SvgImage.FromResources("next.svg", typeof(DevExpress.Utils.Svg.SvgImageCache).Assembly);
            //System.Drawing.Bitmap, SvgImage = DevExpress.Utils.Svg.SvgImage

            tileControl.Controls.Add(grpcnt);
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
