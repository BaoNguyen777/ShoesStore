using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appbangiay
{
    public class NavigationButtons
    {
        List<Button> buttons;
        Color defailtColor;
        Color selectColor;
        public NavigationButtons(List<Button> buttons, Color defailtColor, Color selectColor)
        {
            this.buttons = buttons;
            this.defailtColor = defailtColor;
            this.selectColor = selectColor;
            SetButtonColor();
        }
        private void SetButtonColor()
        {
            foreach (Button button in buttons) 
            {
                button.BackColor = defailtColor;
            }
        }
        public void Highlight(Button selectButton)
        {
            foreach (Button button in buttons)
            {
                if (button == selectButton)
                {
                    selectButton.BackColor = selectColor; 
                }
                else
                {
                    button.BackColor = defailtColor;
                }
            }
        }
    }   
}
