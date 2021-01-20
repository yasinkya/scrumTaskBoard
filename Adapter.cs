﻿using DevExpress.XtraBars.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrumTaskBoard
{
    class Adapter
    {
        private DataBase.FetchData fetchData = new DataBase.FetchData();


        public List<AccordionControlElement> Projects()
        {
            List<AccordionControlElement> elements = new List<AccordionControlElement>();
            AccordionControlElement acEl = new AccordionControlElement();
            
            foreach(Structures.Project project in fetchData.ProjectList())
            {
                acEl.Text = project.ProjectId + "-" + project.ProjectName;
                acEl.Style = ElementStyle.Item;
                elements.Add(acEl);
                
            }
            
            return elements;
        }



    }
}
