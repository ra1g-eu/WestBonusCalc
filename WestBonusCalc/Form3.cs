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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show("- Use numbers only \n- Base value: base job value without any bonuses \n- Gear bonus and buffs: number in % from clothes and buffs together. Includes character bonus from Worker class (5% or 10%). (For example: 100% xp from clothes, 25% from circus ticket = 125) \n- World Bonus: temporary buff in %. Leave at 1 if not applicable.", "Help", buttons, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                return;
            }
        }

        private void dropChanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void hPRegenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void calcMoneyButton_Click(object sender, EventArgs e)
        {
            double baseMoneyValue = double.Parse(baseMoneyTextBox.Text);
            double gearMoneyValue = (double.Parse(gearMoneyTextBox.Text) / 100) + 1;
            double worldBonusMoneyValue = double.Parse(worldBonusMoneyTextBox.Text);
            bool isSilverJob = silverMoneyCheck.Checked;
            bool isGoldJob = goldMoneyCheck.Checked;
            bool isPremium = premiumMoneyCheck.Checked;
            double resultMoney = 0f;

            resultMoney = baseMoneyValue * gearMoneyValue;

            if(isGoldJob && isSilverJob)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show("Select only Gold or Silver job, not both.", "Error", buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    return;
                }
            }
            if (isPremium)
            {
                resultMoney = resultMoney * 1.5f;
            }
            if (isSilverJob)
            {
                resultMoney = resultMoney * 1.5f;
            }
            if (isGoldJob)
            {
                resultMoney = resultMoney * 2f;
            }
            if(worldBonusMoneyValue > 1)
            {
                resultMoney = resultMoney * ((worldBonusMoneyValue / 100) + 1);
            }

            resultMoneyLabel.Text = "Money earned: $" + Math.Round((resultMoney), 0).ToString();

        }

        private void calcXPButton_Click(object sender, EventArgs e)
        {
            double baseXPValue = double.Parse(baseXPTextBox.Text);
            double gearXPValue = (double.Parse(gearXPTextBox.Text) / 100) + 1;
            double worldBonusXPValue = double.Parse(worldBonusXPTextBox.Text);
            bool isSilverJob = silverXPCheck.Checked;
            bool isGoldJob = goldXPCheck.Checked;
            double resultXP = 0f;

            resultXP = baseXPValue * gearXPValue;

            if (isGoldJob && isSilverJob)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show("Select only Gold or Silver job, not both.", "Error", buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    return;
                }
            }
            if (isSilverJob)
            {
                resultXP = resultXP * 1.5f;
            }
            if (isGoldJob)
            {
                resultXP = resultXP * 2f;
            }
            if (worldBonusXPValue > 1)
            {
                resultXP = resultXP * ((worldBonusXPValue / 100) + 1);
            }

            resultXPLabel.Text = "XP earned: " + Math.Round((resultXP), 0).ToString();
        }
    }
}
