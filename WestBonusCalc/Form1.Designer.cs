namespace WestBonusCalc
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.calculateButton = new System.Windows.Forms.Button();
            this.baseDropValueText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.goldenPickaxe = new System.Windows.Forms.Label();
            this.goldenPickaxeCheckbox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gearAndBuffTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.worldBonusText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.higherIncomeCheckbox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.adventurerCheckbox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.silverJobCheckbox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.goldJobCheckbox = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hpRegenSwitchMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.energyRegenSwitchMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moneyXPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.SystemColors.Control;
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.calculateButton.Location = new System.Drawing.Point(508, 77);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(121, 306);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // baseDropValueText
            // 
            this.baseDropValueText.Location = new System.Drawing.Point(326, 96);
            this.baseDropValueText.Name = "baseDropValueText";
            this.baseDropValueText.Size = new System.Drawing.Size(158, 22);
            this.baseDropValueText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(15, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Base job drop value";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // goldenPickaxe
            // 
            this.goldenPickaxe.AutoSize = true;
            this.goldenPickaxe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.goldenPickaxe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.goldenPickaxe.Location = new System.Drawing.Point(15, 130);
            this.goldenPickaxe.Name = "goldenPickaxe";
            this.goldenPickaxe.Size = new System.Drawing.Size(175, 25);
            this.goldenPickaxe.TabIndex = 3;
            this.goldenPickaxe.Text = "5 Golden Pickaxes";
            // 
            // goldenPickaxeCheckbox
            // 
            this.goldenPickaxeCheckbox.AutoSize = true;
            this.goldenPickaxeCheckbox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.goldenPickaxeCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.goldenPickaxeCheckbox.Location = new System.Drawing.Point(326, 136);
            this.goldenPickaxeCheckbox.Name = "goldenPickaxeCheckbox";
            this.goldenPickaxeCheckbox.Size = new System.Drawing.Size(55, 22);
            this.goldenPickaxeCheckbox.TabIndex = 4;
            this.goldenPickaxeCheckbox.Text = "Yes";
            this.goldenPickaxeCheckbox.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(15, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Gear bonus and buff bonus";
            // 
            // gearAndBuffTextbox
            // 
            this.gearAndBuffTextbox.Location = new System.Drawing.Point(326, 170);
            this.gearAndBuffTextbox.Name = "gearAndBuffTextbox";
            this.gearAndBuffTextbox.Size = new System.Drawing.Size(158, 22);
            this.gearAndBuffTextbox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(15, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "World Bonus";
            // 
            // worldBonusText
            // 
            this.worldBonusText.Location = new System.Drawing.Point(326, 207);
            this.worldBonusText.Name = "worldBonusText";
            this.worldBonusText.Size = new System.Drawing.Size(158, 22);
            this.worldBonusText.TabIndex = 8;
            this.worldBonusText.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(15, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Higher Income premium";
            // 
            // higherIncomeCheckbox
            // 
            this.higherIncomeCheckbox.AutoSize = true;
            this.higherIncomeCheckbox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.higherIncomeCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.higherIncomeCheckbox.Location = new System.Drawing.Point(326, 245);
            this.higherIncomeCheckbox.Name = "higherIncomeCheckbox";
            this.higherIncomeCheckbox.Size = new System.Drawing.Size(55, 22);
            this.higherIncomeCheckbox.TabIndex = 10;
            this.higherIncomeCheckbox.Text = "Yes";
            this.higherIncomeCheckbox.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(15, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Adventurer class";
            // 
            // adventurerCheckbox
            // 
            this.adventurerCheckbox.AutoSize = true;
            this.adventurerCheckbox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.adventurerCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.adventurerCheckbox.Location = new System.Drawing.Point(326, 279);
            this.adventurerCheckbox.Name = "adventurerCheckbox";
            this.adventurerCheckbox.Size = new System.Drawing.Size(55, 22);
            this.adventurerCheckbox.TabIndex = 12;
            this.adventurerCheckbox.Text = "Yes";
            this.adventurerCheckbox.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(15, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Silver job";
            // 
            // silverJobCheckbox
            // 
            this.silverJobCheckbox.AutoSize = true;
            this.silverJobCheckbox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.silverJobCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.silverJobCheckbox.Location = new System.Drawing.Point(326, 315);
            this.silverJobCheckbox.Name = "silverJobCheckbox";
            this.silverJobCheckbox.Size = new System.Drawing.Size(55, 22);
            this.silverJobCheckbox.TabIndex = 14;
            this.silverJobCheckbox.Text = "Yes";
            this.silverJobCheckbox.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(15, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Gold job";
            // 
            // goldJobCheckbox
            // 
            this.goldJobCheckbox.AutoSize = true;
            this.goldJobCheckbox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.goldJobCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.goldJobCheckbox.Location = new System.Drawing.Point(326, 351);
            this.goldJobCheckbox.Name = "goldJobCheckbox";
            this.goldJobCheckbox.Size = new System.Drawing.Size(55, 22);
            this.goldJobCheckbox.TabIndex = 16;
            this.goldJobCheckbox.Text = "Yes";
            this.goldJobCheckbox.UseVisualStyleBackColor = false;
            this.goldJobCheckbox.CheckedChanged += new System.EventHandler(this.goldJobCheckbox_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(4, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(527, 46);
            this.label8.TabIndex = 17;
            this.label8.Text = "Job drop chance calculator";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resultLabel.Location = new System.Drawing.Point(6, 392);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(331, 32);
            this.resultLabel.TabIndex = 18;
            this.resultLabel.Text = "Waiting for user input...";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(12, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 306);
            this.panel1.TabIndex = 19;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(634, 28);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hpRegenSwitchMenu,
            this.energyRegenSwitchMenu,
            this.moneyXPToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(142, 24);
            this.toolStripMenuItem1.Text = "Change calculator";
            // 
            // hpRegenSwitchMenu
            // 
            this.hpRegenSwitchMenu.Name = "hpRegenSwitchMenu";
            this.hpRegenSwitchMenu.Size = new System.Drawing.Size(224, 26);
            this.hpRegenSwitchMenu.Text = "HP Regen";
            this.hpRegenSwitchMenu.Click += new System.EventHandler(this.hpRegenSwitchMenu_Click);
            // 
            // energyRegenSwitchMenu
            // 
            this.energyRegenSwitchMenu.Enabled = false;
            this.energyRegenSwitchMenu.Name = "energyRegenSwitchMenu";
            this.energyRegenSwitchMenu.Size = new System.Drawing.Size(224, 26);
            this.energyRegenSwitchMenu.Text = "Energy Regen";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // moneyXPToolStripMenuItem
            // 
            this.moneyXPToolStripMenuItem.Name = "moneyXPToolStripMenuItem";
            this.moneyXPToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.moneyXPToolStripMenuItem.Text = "Money and XP";
            this.moneyXPToolStripMenuItem.Click += new System.EventHandler(this.moneyXPToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(634, 433);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.goldJobCheckbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.silverJobCheckbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.adventurerCheckbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.higherIncomeCheckbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.worldBonusText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gearAndBuffTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.goldenPickaxeCheckbox);
            this.Controls.Add(this.goldenPickaxe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.baseDropValueText);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TheWest Calculator 0.3 | developed by ra1g";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox baseDropValueText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label goldenPickaxe;
        private System.Windows.Forms.CheckBox goldenPickaxeCheckbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox gearAndBuffTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox worldBonusText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox higherIncomeCheckbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox adventurerCheckbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox silverJobCheckbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox goldJobCheckbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hpRegenSwitchMenu;
        private System.Windows.Forms.ToolStripMenuItem energyRegenSwitchMenu;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moneyXPToolStripMenuItem;
    }
}

