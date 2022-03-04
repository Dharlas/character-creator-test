using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace character_creator_test
{
    public class Character
    {
        public string Name;

        public int STR;
        public int DEX;
        public int CON;
        public int WIS;
        public int INT;
        public int CHA;

        static public void UpdateListBoxItem(ListBox listBox, Character character)
        {
            int index = listBox.Items.IndexOf(character);
            int currIndex = listBox.SelectedIndex;
            listBox.BeginUpdate();
            try
            {
                listBox.ClearSelected();
                listBox.Items[index] = character;
                listBox.SelectedIndex = currIndex;
            }
            finally
            { listBox.EndUpdate(); }
        }
    }
}
