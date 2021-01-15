using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using System.Collections.ObjectModel;

// The data model defined by this file serves as a representative example of a strongly-typed
// model that supports notification when members are added, removed, or modified.  The property
// names chosen coincide with data bindings in the standard item WindowsUIViewApplications.
//
// Applications may use this model as a starting point and build on it, or discard it entirely and
// replace it with something appropriate to their needs.

namespace ScrumTaskBoard
{
    /// <summary>
    /// Base class for <see cref="SampleDataItem"/> and <see cref="SampleDataGroup"/> that
    /// defines properties common to both.
    /// </summary>
    public class SampleDataCommon
    {
        string subtitleCore, imagePathCore, descriptionCore, titleCore;
        public string Title { get { return titleCore; } }
        public string Subtitle { get { return subtitleCore; } }
        public string ImagePath { get { return imagePathCore; } }
        public string Description { get { return descriptionCore; } }
        public SampleDataCommon(string title, string subtitle, string imagePath, string description)
        {
            titleCore = title;
            subtitleCore = subtitle;
            imagePathCore = imagePath;
            descriptionCore = description;
        }
        public SampleDataCommon() { }
    }
    /// <summary>
    /// Generic item data model.
    /// </summary>
    public class SampleDataItem : SampleDataCommon
    {
        string contentCore, groupNameCore;
        public SampleDataItem(string title, string subtitle, string imagePath, string description, string content, string groupName)
            : base(title, subtitle, imagePath, description)
        {
            contentCore = content;
            groupNameCore = groupName;
        }
        public string Content { get { return contentCore; } }
        public string GroupName { get { return groupNameCore; } }
    }
    /// <summary>
    /// Generic group data model.
    /// </summary>
    public class SampleDataGroup : SampleDataCommon
    {
        string nameCore;
        Collection<SampleDataItem> itemsCore;
        public SampleDataGroup(string name)
            : base()
        {
            this.nameCore = name;
            itemsCore = new Collection<SampleDataItem>();
        }
        public SampleDataGroup(string name, string title, string subtitle, string imagePath, string description)
            : base(title, subtitle, imagePath, description)
        {
            this.nameCore = name;
            itemsCore = new Collection<SampleDataItem>();
        }
        public string Name { get { return nameCore; } }
        public Collection<SampleDataItem> Items { get { return itemsCore; } }
        public bool AddItem(SampleDataItem tile)
        {
            if (!itemsCore.Contains(tile))
            {
                itemsCore.Add(tile);
                return true;
            }
            return false;
        }
    }
    /// <summary>
    /// Generic data model.
    /// </summary>
    class SampleDataModel
    {
        Collection<SampleDataGroup> groupsCore;
        public SampleDataModel()
        {
            groupsCore = new Collection<SampleDataGroup>();
        }
        public Collection<SampleDataGroup> Groups { get { return groupsCore; } }
        SampleDataGroup GetGroup(string name)
        {
            foreach (var group in groupsCore)
                if (group.Name == name) return group;
            return null;
        }
        public bool AddItem(SampleDataItem tile)
        {
            if (tile == null) return false;
            string groupName = tile.GroupName == null ? "" : tile.GroupName;
            SampleDataGroup thisGroup = GetGroup(groupName);
            if (thisGroup == null)
            {
                thisGroup = new SampleDataGroup(groupName);
                groupsCore.Add(thisGroup);
            }
            return thisGroup.AddItem(tile);
        }
        bool ContainsGroup(string name)
        {
            return GetGroup(name) != null;
        }
        public void CreateGroup(string name, string title, string subtitle, string imagePath, string description)
        {
            if (ContainsGroup(name)) return;
            SampleDataGroup group = new SampleDataGroup(name, title, subtitle, imagePath, description);
            groupsCore.Add(group);
        }
    }
    /// <summary>
    /// Creates a collection of groups and items with hard-coded content.
    /// 
    /// SampleDataSource initializes with placeholder data rather than live production
    /// data so that sample data is provided at both design-time and run-time.
    /// </summary>
    class SampleDataSource
    {
        SampleDataModel dataCore;
        public SampleDataSource()
        {
            dataCore = new SampleDataModel();
            String ITEM_CONTENT = String.Format("Item Content: {0}\n\n{0}\n\n{0}\n\n{0}\n\n{0}\n\n{0}",
                        "Curabitur class aliquam vestibulum nam curae maecenas sed integer cras phasellus suspendisse quisque donec dis praesent accumsan bibendum pellentesque condimentum adipiscing etiam consequat vivamus dictumst aliquam duis convallis scelerisque est parturient ullamcorper aliquet fusce suspendisse nunc hac eleifend amet blandit facilisi condimentum commodo scelerisque faucibus aenean ullamcorper ante mauris dignissim consectetuer nullam lorem vestibulum habitant conubia elementum pellentesque morbi facilisis arcu sollicitudin diam cubilia aptent vestibulum auctor eget dapibus pellentesque inceptos leo egestas interdum nulla consectetuer suspendisse adipiscing pellentesque proin lobortis sollicitudin augue elit mus congue fermentum parturient fringilla euismod feugiat");
            dataCore.CreateGroup("Group-1",
                    "Group Title: 1",
                    "Group Subtitle: 1",
                    typeof(MainForm).Namespace + ".Assets.DarkGray.png",
                    "Group Description: Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus tempor scelerisque lorem in vehicula. Aliquam tincidunt, lacus ut sagittis tristique, turpis massa volutpat augue, eu rutrum ligula ante a ante");
            dataCore.AddItem(new SampleDataItem("Item Title: 1",
                    "Item Subtitle: 1",
                    typeof(MainForm).Namespace + ".Assets.LightGray.png",
                    "Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
                    ITEM_CONTENT,
                    "Group-1"));
            dataCore.AddItem(new SampleDataItem("Item Title: 2",
                    "Item Subtitle: 2",
                    typeof(MainForm).Namespace + ".Assets.DarkGray.png",
                    "Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
                    ITEM_CONTENT,
                    "Group-1"));
            dataCore.AddItem(new SampleDataItem("Item Title: 3",
                    "Item Subtitle: 3",
                    typeof(MainForm).Namespace + ".Assets.MediumGray.png",
                    "Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
                    ITEM_CONTENT,
                    "Group-1"));
            dataCore.AddItem(new SampleDataItem("Item Title: 4",
                    "Item Subtitle: 4",
                    typeof(MainForm).Namespace + ".Assets.DarkGray.png",
                    "Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
                    ITEM_CONTENT,
                    "Group-1"));
            dataCore.AddItem(new SampleDataItem("Item Title: 5",
                    "Item Subtitle: 5",
                    typeof(MainForm).Namespace + ".Assets.MediumGray.png",
                    "Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
                    ITEM_CONTENT,
                    "Group-1"));

            dataCore.CreateGroup("Group-2",
                    "Group Title: 2",
                    "Group Subtitle: 2",
                    typeof(MainForm).Namespace + ".Assets.LightGray.png",
                    "Group Description: Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus tempor scelerisque lorem in vehicula. Aliquam tincidunt, lacus ut sagittis tristique, turpis massa volutpat augue, eu rutrum ligula ante a ante");
            dataCore.AddItem(new SampleDataItem("Item Title: 1",
                    "Item Subtitle: 1",
                    typeof(MainForm).Namespace + ".Assets.DarkGray.png",
                    "Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
                    ITEM_CONTENT,
                    "Group-2"));
            dataCore.AddItem(new SampleDataItem("Item Title: 2",
                    "Item Subtitle: 2",
                    typeof(MainForm).Namespace + ".Assets.MediumGray.png",
                    "Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
                    ITEM_CONTENT,
                    "Group-2"));
            dataCore.AddItem(new SampleDataItem("Item Title: 3",
                    "Item Subtitle: 3",
                    typeof(MainForm).Namespace + ".Assets.LightGray.png",
                    "Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
                    ITEM_CONTENT,
                    "Group-2"));

            dataCore.CreateGroup("Group-3",
                    "Group Title: 3",
                    "Group Subtitle: 3",
                    typeof(MainForm).Namespace + ".Assets.MediumGray.png",
                    "Group Description: Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus tempor scelerisque lorem in vehicula. Aliquam tincidunt, lacus ut sagittis tristique, turpis massa volutpat augue, eu rutrum ligula ante a ante");
            dataCore.AddItem(new SampleDataItem("Item Title: 1",
                    "Item Subtitle: 1",
                    typeof(MainForm).Namespace + ".Assets.MediumGray.png",
                    "Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
                    ITEM_CONTENT,
                    "Group-3"));
            dataCore.AddItem(new SampleDataItem("Item Title: 2",
                    "Item Subtitle: 2",
                    typeof(MainForm).Namespace + ".Assets.LightGray.png",
                    "Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
                    ITEM_CONTENT,
                    "Group-3"));
            dataCore.AddItem(new SampleDataItem("Item Title: 3",
                    "Item Subtitle: 3",
                    typeof(MainForm).Namespace + ".Assets.DarkGray.png",
                    "Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
                    ITEM_CONTENT,
                    "Group-3"));
            dataCore.AddItem(new SampleDataItem("Item Title: 4",
                    "Item Subtitle: 4",
                    typeof(MainForm).Namespace + ".Assets.LightGray.png",
                    "Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
                    ITEM_CONTENT,
                       "Group-3"));
            dataCore.AddItem(new SampleDataItem("Item Title: 5",
                    "Item Subtitle: 5",
                    typeof(MainForm).Namespace + ".Assets.MediumGray.png",
                    "Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
                    ITEM_CONTENT,
                       "Group-3"));
            dataCore.AddItem(new SampleDataItem("Item Title: 6",
                    "Item Subtitle: 6",
                    typeof(MainForm).Namespace + ".Assets.DarkGray.png",
                    "Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
                    ITEM_CONTENT,
                        "Group-3"));
            dataCore.AddItem(new SampleDataItem("Item Title: 7",
                    "Item Subtitle: 7",
                    typeof(MainForm).Namespace + ".Assets.MediumGray.png",
                    "Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
                    ITEM_CONTENT,
                         "Group-3"));

            dataCore.CreateGroup("Group-4",
                    "Group Title: 4",
                    "Group Subtitle: 4",
                    typeof(MainForm).Namespace + ".Assets.LightGray.png",
                    "Group Description: Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus tempor scelerisque lorem in vehicula. Aliquam tincidunt, lacus ut sagittis tristique, turpis massa volutpat augue, eu rutrum ligula ante a ante");
            dataCore.AddItem(new SampleDataItem("Item Title: 1",
                    "Item Subtitle: 1",
                    typeof(MainForm).Namespace + ".Assets.DarkGray.png",
                    "Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
                    ITEM_CONTENT,
                          "Group-4"));
            dataCore.AddItem(new SampleDataItem("Item Title: 2",
                    "Item Subtitle: 2",
                    typeof(MainForm).Namespace + ".Assets.LightGray.png",
                    "Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
                    ITEM_CONTENT,
                          "Group-4"));
            dataCore.AddItem(new SampleDataItem("Item Title: 3",
                    "Item Subtitle: 3",
                    typeof(MainForm).Namespace + ".Assets.DarkGray.png",
                    "Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
                    ITEM_CONTENT,
                          "Group-4"));
            dataCore.AddItem(new SampleDataItem("Item Title: 4",
                    "Item Subtitle: 4",
                    typeof(MainForm).Namespace + ".Assets.LightGray.png",
                    "Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
                    ITEM_CONTENT,
                          "Group-4"));
            dataCore.AddItem(new SampleDataItem("Item Title: 5",
                    "Item Subtitle: 5",
                    typeof(MainForm).Namespace + ".Assets.MediumGray.png",
                    "Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
                    ITEM_CONTENT,
                          "Group-4"));
            dataCore.AddItem(new SampleDataItem("Item Title: 6",
                    "Item Subtitle: 6",
                    typeof(MainForm).Namespace + ".Assets.LightGray.png",
                    "Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
                    ITEM_CONTENT,
                          "Group-4"));

            dataCore.CreateGroup("Group-5",
                    "Group Title: 5",
                    "Group Subtitle: 5",
                    typeof(MainForm).Namespace + ".Assets.MediumGray.png",
                    "Group Description: Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus tempor scelerisque lorem in vehicula. Aliquam tincidunt, lacus ut sagittis tristique, turpis massa volutpat augue, eu rutrum ligula ante a ante");
            dataCore.AddItem(new SampleDataItem("Item Title: 1",
                    "Item Subtitle: 1",
                    typeof(MainForm).Namespace + ".Assets.LightGray.png",
                    "Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
                    ITEM_CONTENT,
                          "Group-5"));
            dataCore.AddItem(new SampleDataItem("Item Title: 2",
                    "Item Subtitle: 2",
                    typeof(MainForm).Namespace + ".Assets.DarkGray.png",
                    "Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
                    ITEM_CONTENT,
                          "Group-5"));
            dataCore.AddItem(new SampleDataItem("Item Title: 3",
                    "Item Subtitle: 3",
                    typeof(MainForm).Namespace + ".Assets.LightGray.png",
                    "Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
                    ITEM_CONTENT,
                          "Group-5"));
            dataCore.AddItem(new SampleDataItem("Item Title: 4",
                    "Item Subtitle: 4",
                    typeof(MainForm).Namespace + ".Assets.MediumGray.png",
                    "Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
                    ITEM_CONTENT,
                          "Group-5"));

            dataCore.CreateGroup("Group-6",
                    "Group Title: 6",
                    "Group Subtitle: 6",
                    typeof(MainForm).Namespace + ".Assets.DarkGray.png",
                    "Group Description: Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus tempor scelerisque lorem in vehicula. Aliquam tincidunt, lacus ut sagittis tristique, turpis massa volutpat augue, eu rutrum ligula ante a ante");
            dataCore.AddItem(new SampleDataItem("Item Title: 1",
                    "Item Subtitle: 1",
                    typeof(MainForm).Namespace + ".Assets.LightGray.png",
                    "Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
                    ITEM_CONTENT,
                          "Group-6"));
            dataCore.AddItem(new SampleDataItem("Item Title: 2",
                    "Item Subtitle: 2",
                    typeof(MainForm).Namespace + ".Assets.DarkGray.png",
                    "Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
                    ITEM_CONTENT,
                          "Group-6"));
            dataCore.AddItem(new SampleDataItem("Item Title: 3",
                    "Item Subtitle: 3",
                    typeof(MainForm).Namespace + ".Assets.MediumGray.png",
                    "Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
                    ITEM_CONTENT,
                          "Group-6"));
            dataCore.AddItem(new SampleDataItem("Item Title: 4",
                    "Item Subtitle: 4",
                    typeof(MainForm).Namespace + ".Assets.DarkGray.png",
                    "Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
                    ITEM_CONTENT,
                          "Group-6"));
            dataCore.AddItem(new SampleDataItem("Item Title: 5",
                    "Item Subtitle: 5",
                    typeof(MainForm).Namespace + ".Assets.LightGray.png",
                    "Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
                    ITEM_CONTENT,
                           "Group-6"));
            dataCore.AddItem(new SampleDataItem("Item Title: 6",
                    "Item Subtitle: 6",
                    typeof(MainForm).Namespace + ".Assets.MediumGray.png",
                    "Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
                    ITEM_CONTENT,
                          "Group-6"));
            dataCore.AddItem(new SampleDataItem("Item Title: 7",
                    "Item Subtitle: 7",
                    typeof(MainForm).Namespace + ".Assets.DarkGray.png",
                    "Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
                    ITEM_CONTENT,
                          "Group-6"));
            dataCore.AddItem(new SampleDataItem("Item Title: 8",
                    "Item Subtitle: 8",
                    typeof(MainForm).Namespace + ".Assets.LightGray.png",
                    "Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
                    ITEM_CONTENT,
                          "Group-6"));
        }
        public SampleDataModel Data { get { return dataCore; } }
    }
}
