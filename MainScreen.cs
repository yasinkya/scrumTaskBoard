﻿using DevExpress.XtraBars;
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
        public MainScreen()
        {
            InitializeComponent();
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

        private void MainScreen_Load(object sender, EventArgs e)
        {

            ToDoFrom toDoFrom = new ToDoFrom();
            toDoFrom.Dock = DockStyle.Fill;
            toDoFrom.BorderStyle = BorderStyle.None;



            toDoFrom.addNew();
            TodoPanel.Controls.Add(toDoFrom);
            toDoFrom.Show();


        }

        internal void taskClick(object sender, EventArgs e)
        {
            MessageBox.Show("oleeeyy");

        }

       bool inserted;
        AccordionControlElement acEl = new AccordionControlElement();
        private void prokectElements_Click(object sender, EventArgs e)
        {

            if (inserted) 
            {
                
                acEl.Text = "asdfa";
                acEl.Click += taskClick;
                inserted = true;
                projectElements.Elements.Add(acEl);
            }



            
        }
    }
}
