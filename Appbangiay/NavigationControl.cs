using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appbangiay
{
    internal class NavigationControl
    {
        List<UserControl> UserControlList = new List<UserControl>();
        Panel panel;

        public NavigationControl(List<UserControl> userControlList, Panel panel)
        {
            this.UserControlList = userControlList;
            this.panel = panel;
            AddUsercontrols();
        }

        private void AddUsercontrols()
        {
            for(int i = 0; i < UserControlList.Count; i++)
            {
                UserControlList[i].Dock = DockStyle.Fill;
                panel.Controls.Add(UserControlList[i]);
            }
        }

        public void Display(int index) 
        {
            if (index < UserControlList.Count())
            {
                UserControlList[index].BringToFront();
            }
        }
    }
}
 