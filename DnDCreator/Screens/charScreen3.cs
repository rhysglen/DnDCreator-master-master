using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDCreator
{
    public partial class charScreen3 : UserControl
    {
        public charScreen3()
        {
            InitializeComponent();

            if (athButton.Checked)
            {
                Character.skills.Add("Athletics");
            }
            if (acroButton.Checked)
            {
                Character.skills.Add("Acrobatics");
            }
            if (handButton.Checked)
            {
                Character.skills.Add("Sleight of Hand");
            }
            if (stealthButton.Checked)
            {
                Character.skills.Add("Stealth");
            }
            if (arcaButton.Checked)
            {
                Character.skills.Add("Arcana");
            }
            if (hisButton.Checked)
            {
                Character.skills.Add("History");
            }
            if (inveButton.Checked)
            {
                Character.skills.Add("Investigation");
            }
            if (natButton.Checked)
            {
                Character.skills.Add("Nature");
            }
            if (religButton.Checked)
            {
                Character.skills.Add("Religion");
            }
            if (aniButton.Checked)
            {
                Character.skills.Add("Animal Handling");
            }
            if (medButton.Checked)
            {
                Character.skills.Add("Medicine");
            }
            if (percButton.Checked)
            {
                Character.skills.Add("Perception");
            }
            if (survButton.Checked)
            {
                Character.skills.Add("Survival");
            }
            if (decButton.Checked)
            {
                Character.skills.Add("Deception");
            }
            if (intimButton.Checked)
            {
                Character.skills.Add("Intimidation");
            }
            if (perfButton.Checked)
            {
                Character.skills.Add("Performance");
            }
            if (persuaButton.Checked)
            {
                Character.skills.Add("Persuasion");
            }

        }
        
    }
    
}
