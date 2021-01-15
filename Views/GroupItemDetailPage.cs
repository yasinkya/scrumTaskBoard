using System;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraBars.Docking2010;

namespace ScrumTaskBoard
{
    /// <summary>
    /// A page that displays a grouped collection of items.
    /// </summary>
    public partial class GroupItemDetailPage : DevExpress.XtraEditors.XtraUserControl
    {
        PageGroup pageGroupCore;
        int indexCore;
        public GroupItemDetailPage(SampleDataItem item, PageGroup child, int index)
        {
            InitializeComponent();
            pageGroupCore = child;
            indexCore = index;
            labelTitle.Text = item.Title;
            labelSubtitle.Text = item.Subtitle;
            imageControl.Image = DevExpress.Utils.ResourceImageHelper.CreateImageFromResources(item.ImagePath, typeof(ItemDetailPage).Assembly);
            labelDescription.Text = item.Description;
        }
        private void imageControlClick(object sender, EventArgs e)
        {
            BaseContentContainer documentContainer = pageGroupCore.Parent as BaseContentContainer;
            if (documentContainer != null) ActivateContainer(documentContainer.Manager);
        }
        void ActivateContainer(DocumentManager manager)
        {
            WindowsUIView view = manager.View as WindowsUIView;
            if (view != null)
            {
                pageGroupCore.Parent = this.Tag as IContentContainer;
                pageGroupCore.SetSelected(pageGroupCore.Items[indexCore]);
                view.ActivateContainer(pageGroupCore);
            }
        }
    }
}
