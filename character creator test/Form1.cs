using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace character_creator_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            //options are 'Point Buy' 'Standard Array' and 'Random roll'
            string selection = cmbType.Text;
            lblTest.Text = selection;

            if (selection == "Random roll")
            {
                //Character Test1 = new Character();
                //Character Test2 = new Character();
                Random random = new Random();

                //int rollA = random.Next(1, 7);
                //int rollB = random.Next(1, 7);
                //int rollC = random.Next(1, 7);
                //int total = rollA + rollB + rollC;

                int[] vs = new int[6];
                int rollA;
                int rollB;
                int rollC;
                int total;

                for (int i = 0; i < vs.Length; i++)
                {
                    rollA = random.Next(1, 7);
                    rollB = random.Next(1,7);
                    rollC = random.Next(1, 7);
                    total = rollA + rollB + rollC;
                    vs[i] = total;
                }

                txtSTR.Text = vs[0].ToString();
                txtDEX.Text = vs[1].ToString();
                txtCON.Text = vs[2].ToString();
                txtINT.Text = vs[3].ToString();
                txtWIS.Text = vs[4].ToString();
                txtCHA.Text = vs[5].ToString();

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string character = txtName.Text;
            int STR = int.Parse(txtSTR.Text);
            int DEX = int.Parse(txtDEX.Text);
            int CON = int.Parse(txtCON.Text);
            int INT = int.Parse(txtINT.Text);
            int WIS = int.Parse(txtWIS.Text);
            int CHA = int.Parse(txtCHA.Text);

            Character character1 = new Character();
            character1.Name = character;
            character1.STR = STR;
            character1.DEX = DEX;
            character1.CON = CON;
            character1.INT = INT;
            character1.WIS = WIS;
            character1.CHA = CHA;

            lsbCharacters.Items.Add((Character)character1);
            //lsbCharacters.SelectedItem = character1;
            //lsbCharacters.Text = character1.Name;
            
            //Character.UpdateListBoxItem(lsbCharacters, character1);

            foreach (Control control in grpBasic.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }
        }
    }
}
