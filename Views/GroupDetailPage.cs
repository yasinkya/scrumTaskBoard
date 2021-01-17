using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;

namespace ScrumTaskBoard
{
    /// <summary>
    /// A page that displays an overview of a single group, including a preview of the items
    /// within the group.
    /// </summary>
    public partial class GroupDetailPage : XtraUserControl
    {
        PageGroup pageGroupCore;
        public PageGroup PageGroup { get { return pageGroupCore; } }
        
    }
}
