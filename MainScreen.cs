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
        DataBase.FetchData fetchData = new DataBase.FetchData();
        bool insertedProj;

        public MainScreen()
        {
            InitializeComponent();

        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

            if (!insertedProj)
            {
                foreach (AccordionControlElement acEl in adapter.Projects())
                {
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
            //toDoFrom.Enabled = false;

        }

        internal void ProjectsClick(object sender, EventArgs e)
        {
            string name = (sender as AccordionControlElement).Text;
            MessageBox.Show(name);

        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {

        }
        string clicked;
        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            clicked = "00";
            MessageBox.Show("Test");
        }

        private void fluentDesignFormContainer1_Click(object sender, EventArgs e)
        {

        }

        private void toDoGroup_Paint(object sender, PaintEventArgs e)
        {

        }



        public async void taskClick(object sender, EventArgs e)
        {
            
            if (clicked == "00")
            {
                 MessageBox.Show("oleeeyy");
                
            }

        }


        private void prokectElements_Click(object sender, EventArgs e)
        {
        }
    }
}
