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
            tileControl = new TileControl();
            tileControl.BackColor = Color.FromArgb(60, 60, 60);
            tileControl.Dock = DockStyle.Fill; 
            this.Controls.Add(tileControl);
        }

        private void ToDoFrom_Load(object sender, EventArgs e)
        {

        }

        public void addNew()
        {
            Size size = new Size(315, 150);
            Point point = new Point(50, -60);   // point.Y+=160
            
            GroupControl grpcnt = new GroupControl();
            grpcnt.Size= new Size(315,150);
            grpcnt.Anchor = AnchorStyles.Left;
            grpcnt.Anchor = AnchorStyles.Right;
            grpcnt.Dock = DockStyle.None;
            grpcnt.Location = new Point(50, -60);
            grpcnt.Text = "DENEME";
            grpcnt.AppearanceCaption.Font = new Font("Sitka Small", 9, FontStyle.Bold);
            grpcnt.CaptionImageOptions.SvgImage = DevExpress.Utils.Svg.SvgImage.FromFile(@"C:\Users\Kaya\Desktop\ScrumTaskBoard\ScrumTaskBoard\Assets\svg\alarm.svg");
            grpcnt.CaptionImageOptions.SvgImageSize = new Size(30, 30);
            grpcnt.Appearance.BorderColor = Color.Turquoise;
            grpcnt.Click += groupControl1_Click;
            //System.Drawing.Bitmap, SvgImage = DevExpress.Utils.Svg.SvgImage
            GroupControl grp2 = new GroupControl();
            point.Y += 160;
            grp2.Text = "denme2";
            grp2.Size = size;
            grp2.Location = point;
            grp2.Anchor = AnchorStyles.Left;
            grp2.Anchor = AnchorStyles.Right;
            grp2.Dock = DockStyle.None;
            grp2.Click += mainScreen.taskClick;
            tileControl.Controls.Add(grp2);

            tileControl.Controls.Add(grpcnt);
        }
        MainScreen mainScreen = new MainScreen();


        private void groupControl1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sdfgdsgdsfg");

        }

        
    }
}
