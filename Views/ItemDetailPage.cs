using DevExpress.XtraEditors;

namespace ScrumTaskBoard
{
    /// <summary>
    /// A page that displays details for a single item within a group while allowing gestures to
    /// flip through other items belonging to the same group.
    /// </summary>
    public partial class ItemDetailPage : XtraUserControl
    {
        public ItemDetailPage(SampleDataItem item)
        {
            InitializeComponent();
            labelTitle.Text = item.Title;
            labelSubtitle.Text = item.Subtitle;
            imageControl.Image = DevExpress.Utils.ResourceImageHelper.CreateImageFromResources(item.ImagePath, typeof(ItemDetailPage).Assembly);
            labelContent.Text = item.Content;
        }
    }
}
