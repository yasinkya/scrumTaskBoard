using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Navigation;

namespace ScrumTaskBoard
{
    public partial class MainScreen : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {

        Adapter adapter = new Adapter();
        bool insertedProj;

        public MainScreen()
        {
            InitializeComponent();

        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

            if (!insertedProj)
            {
                DataBase.FetchData fetchData = new DataBase.FetchData();
                AccordionControlElement acEl;

                foreach (Structures.Project project in fetchData.ProjectList())
                {
                    acEl = new AccordionControlElement();
                    acEl.Text = project.ProjectId + "-" + project.ProjectName;
                    acEl.Style = ElementStyle.Group;
                    acEl.Click += ProjectsClick;
                    projectElements.Elements.Add(acEl);
                }


                insertedProj = true;
            }

            ToDoFrom toDoFrom = new ToDoFrom();
            toDoFrom.Dock = DockStyle.Fill;
            toDoFrom.BorderStyle = BorderStyle.None;



            toDoFrom.addNew();
            TodoPanel.Controls.Add(toDoFrom);
            toDoFrom.Show();


        }

        internal void ProjectsClick(object sender, EventArgs e)
        {
            string name = (sender as AccordionControlElement).Text;
            MessageBox.Show(name);

        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void fluentDesignFormContainer1_Click(object sender, EventArgs e)
        {

        }

        private void toDoGroup_Paint(object sender, PaintEventArgs e)
        {

        }



        internal void taskClick(object sender, EventArgs e)
        {
            MessageBox.Show("oleeeyy");

        }


        private void prokectElements_Click(object sender, EventArgs e)
        {
        }
    }
}
