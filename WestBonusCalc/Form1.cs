using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!IsDigitsOnly(baseDropValueText.Text) || !IsDigitsOnly(gearAndBuffTextbox.Text) || !IsDigitsOnly(worldBonusText.Text))
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show("Please insert numbers only.", "Error", buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    return;
                }
            } else
            {
                double baseDropValue = double.Parse(baseDropValueText.Text);
                double baseDropValueOriginal = double.Parse(baseDropValueText.Text);
                bool isGoldenPickaxe = goldenPickaxeCheckbox.Checked;
                double gearAndBuffBonus = (double.Parse(gearAndBuffTextbox.Text) / 100) + 1;
                double worldBonus = double.Parse(worldBonusText.Text) == 1 ? 1 : (double.Parse(worldBonusText.Text) / 100) + 1;
                bool isHigherIncome = higherIncomeCheckbox.Checked;
                bool isAdventurer = adventurerCheckbox.Checked;
                bool isSilverJob = silverJobCheckbox.Checked;
                bool isGoldJob = goldJobCheckbox.Checked;
                if (isGoldenPickaxe)
                {
                    baseDropValue *= 1.5;
                }

                baseDropValue = baseDropValue * gearAndBuffBonus * worldBonus;

                if (isHigherIncome)
                {
                    baseDropValue *= 1.5;
                }
                if (isAdventurer)
                {
                    baseDropValue *= 1.2;
                }

                if (isSilverJob && isGoldJob)
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show("Please check only Silver or Gold job and not both.", "Error", buttons, MessageBoxIcon.Warning);
                    if (result == DialogResult.OK)
                    {
                        return;
                    }
                }

                if (isSilverJob && !isGoldJob)
                {
                    if (isSilverJob && isGoldenPickaxe)
                    {
                        baseDropValue = baseDropValue + (baseDropValueOriginal * 1.5 * 0.5);

                    }
                    else if (isSilverJob && !isGoldenPickaxe)
                    {
                        baseDropValue = baseDropValue + (baseDropValueOriginal * 0.5);
                    }
                }
                if (isGoldJob && !isSilverJob)
                {
                    if (isGoldJob && isGoldenPickaxe)
                    {
                        baseDropValue = baseDropValue + (baseDropValueOriginal * 1.5 * 1);

                    }
                    else if (isGoldJob && !isGoldenPickaxe)
                    {
                        baseDropValue = baseDropValue + (baseDropValueOriginal * 1);
                    }
                }

                resultLabel.Text = "Calculated drop chance: " + Math.Round(baseDropValue).ToString() + " %";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                return str.All(char.IsDigit);
            }
            return false;
        }

        private void goldJobCheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void hpRegenSwitchMenu_Click(object sender, EventArgs e)
        {   
            this.Hide();
            Form2 form2 = new Form2();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show("- Use numbers only \n- Base job drop value: base % drop chance on a product on a job (mouse over in game to see) \n- 5 Golden Pickaxes: check this if you have 5 golden pickaxes (adds 50% more drop) \n- Gear & buff bonus: add your drop chance from clothes and buffs (Fisherman clothes + ratatouille = 115 + 50) \n- World bonus: leave at 1 if no bonus active (enter 20 if world bonus is 20%)", "Help", buttons, MessageBoxIcon.Question);
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
