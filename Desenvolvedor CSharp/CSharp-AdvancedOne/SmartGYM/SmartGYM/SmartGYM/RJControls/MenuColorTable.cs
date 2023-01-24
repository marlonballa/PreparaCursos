using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SmartGYM
{
    public class MenuColorTable : ProfessionalColorTable
    {
        //Atributos da Classe
        private Color backColor;
        private Color leftColumnColor;
        private Color borderColor;
        private Color menuItemBorderColor;
        private Color menuItemselectedColor;

        //Construtor
        public MenuColorTable(bool isMainMenu, Color primaryColor)
        {
            if (isMainMenu)
            {
                backColor = Color.FromArgb(73, 73, 73);
                leftColumnColor = Color.FromArgb(70, 77, 83);
                borderColor = Color.FromArgb(231, 128, 0);
                menuItemBorderColor = primaryColor;
                menuItemselectedColor = primaryColor;
            }
            else
            { 
                backColor = Color.White;
                leftColumnColor = Color.LightGray;
                borderColor = Color.LightGray;
                menuItemBorderColor = primaryColor;
                menuItemselectedColor = primaryColor;
            }
        }

        //Overrides
        public override Color ToolStripDropDownBackground { get { return backColor; } }
        public override Color MenuBorder { get { return menuItemBorderColor; } }
        public override Color MenuItemSelected { get { return menuItemselectedColor; } }
        public override Color ImageMarginGradientBegin { get { return leftColumnColor; } }
        public override Color ImageMarginGradientMiddle { get { return leftColumnColor; } }
        public override Color ImageMarginGradientEnd { get { return leftColumnColor; } }
    }
}
