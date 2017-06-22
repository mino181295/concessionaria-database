using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBProject
{
    /*
     * Custom Button used to access the EntryForm from witch submit new instances
     * (i.e. rows of relation).
     */ 

    class EntryButton: Button
    {
        public Entry EntryPanel { get; set; }
        public string FormName { get; set; }
        
        public EntryButton(Entry panel, string formName)
        {
            this.EntryPanel = panel;
            this.FormName = formName;
        }

        public EntryButton()
        {
        }
    }
}
