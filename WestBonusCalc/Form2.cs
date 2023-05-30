using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WestBonusCalc
{
    public partial class Form2 : Form
    {
        Form1 formOne = new Form1();
        public Form2()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            Hashtable accomodationTable = new Hashtable();
            accomodationTable.Add("0", 0.001333333); //hotel lvl 1
            accomodationTable.Add("1", 0.0015); //hotel lvl 2
            accomodationTable.Add("2", 0.00166667); //hotel lvl 3
            accomodationTable.Add("3", 0.00183333); //hotel lvl 4
            accomodationTable.Add("4", 0.002); //hotel lvl 5
            accomodationTable.Add("5", 0.0018417); //barracks lvl 1
            accomodationTable.Add("6", 0.00235); //barracks lvl 2
            accomodationTable.Add("7", 0.0025); //barracks lvl 3
            accomodationTable.Add("8", 0.0026333); //barracks lvl 4
            accomodationTable.Add("9", 0.0027667); //barracks lvl 5
            accomodationTable.Add("10", 0.0027667); //barracks lvl 6
            int sleepingBuilding = sleepBuildingComboBox.SelectedIndex;

            if (!formOne.IsDigitsOnly(maxHpTextBox.Text) || !formOne.IsDigitsOnly(currHpTextBox.Text) || !formOne.IsDigitsOnly(targetHpTextBox.Text) || !formOne.IsDigitsOnly(regenBonusTextBox.Text) || sleepingBuilding == -1)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show("Please insert numbers only.", "Error", buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    return;
                }
            } else
            {
                double maxHp = double.Parse(maxHpTextBox.Text);
                double currHp = double.Parse(currHpTextBox.Text);
                double targetHp = double.Parse(targetHpTextBox.Text);
                double regenBonus = regenBonusTextBox.Text == "1" ? 1.0f : (double.Parse(regenBonusTextBox.Text) / 100) +1;
                double resultInMinutes = 0;
                resultInMinutes = (targetHp-currHp) / (maxHp * double.Parse(accomodationTable[sleepingBuilding.ToString()].ToString()) * regenBonus);
               
                Console.WriteLine(resultInMinutes);
                resultLabel.Text = "HP will regen in: " + Math.Round((resultInMinutes / 60), 2).ToString() + " hrs (" + Math.Round(resultInMinutes, 2).ToString() + " mins)";
            }
        }

        private void dropChanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show("- Use numbers only \n- Maximum HP: your max HP with regen set \n- Current HP: your current HP in game \n- Target HP: how much HP you want to have after sleeping \n- Regen bonus: bonus % from gear and buffs (Santa set: 240)", "Help", buttons, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                return;
            }
        }

        private void moneyXPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }
    }
}
