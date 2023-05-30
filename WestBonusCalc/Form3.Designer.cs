namespace WestBonusCalc
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.changeCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dropChanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hPRegenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.energyRegenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultMoneyLabel = new System.Windows.Forms.Label();
            this.calcMoneyButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.worldBonusMoneyTextBox = new System.Windows.Forms.TextBox();
            this.gearMoneyTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.baseMoneyTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.calcXPButton = new System.Windows.Forms.Button();
            this.silverMoneyCheck = new System.Windows.Forms.CheckBox();
            this.goldMoneyCheck = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.goldXPCheck = new System.Windows.Forms.CheckBox();
            this.silverXPCheck = new System.Windows.Forms.CheckBox();
            this.worldBonusXPTextBox = new System.Windows.Forms.TextBox();
            this.gearXPTextBox = new System.Windows.Forms.TextBox();
            this.baseXPTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.resultXPLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.premiumMoneyCheck = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeCalculatorToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(634, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // changeCalculatorToolStripMenuItem
            // 
            this.changeCalculatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dropChanceToolStripMenuItem,
            this.hPRegenToolStripMenuItem,
            this.energyRegenToolStripMenuItem});
            this.changeCalculatorToolStripMenuItem.Name = "changeCalculatorToolStripMenuItem";
            this.changeCalculatorToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.changeCalculatorToolStripMenuItem.Text = "Change calculator";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // dropChanceToolStripMenuItem
            // 
            this.dropChanceToolStripMenuItem.Name = "dropChanceToolStripMenuItem";
            this.dropChanceToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dropChanceToolStripMenuItem.Text = "Drop chance";
            this.dropChanceToolStripMenuItem.Click += new System.EventHandler(this.dropChanceToolStripMenuItem_Click);
            // 
            // hPRegenToolStripMenuItem
            // 
            this.hPRegenToolStripMenuItem.Name = "hPRegenToolStripMenuItem";
            this.hPRegenToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.hPRegenToolStripMenuItem.Text = "HP Regen";
            this.hPRegenToolStripMenuItem.Click += new System.EventHandler(this.hPRegenToolStripMenuItem_Click);
            // 
            // energyRegenToolStripMenuItem
            // 
            this.energyRegenToolStripMenuItem.Enabled = false;
            this.energyRegenToolStripMenuItem.Name = "energyRegenToolStripMenuItem";
            this.energyRegenToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.energyRegenToolStripMenuItem.Text = "Energy Regen";
            // 
            // resultMoneyLabel
            // 
            this.resultMoneyLabel.AutoSize = true;
            this.resultMoneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resultMoneyLabel.Location = new System.Drawing.Point(12, 392);
            this.resultMoneyLabel.Name = "resultMoneyLabel";
            this.resultMoneyLabel.Size = new System.Drawing.Size(235, 25);
            this.resultMoneyLabel.TabIndex = 27;
            this.resultMoneyLabel.Text = "Waiting for user input...";
            // 
            // calcMoneyButton
            // 
            this.calcMoneyButton.BackColor = System.Drawing.SystemColors.Control;
            this.calcMoneyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.calcMoneyButton.Location = new System.Drawing.Point(509, 77);
            this.calcMoneyButton.Name = "calcMoneyButton";
            this.calcMoneyButton.Size = new System.Drawing.Size(121, 140);
            this.calcMoneyButton.TabIndex = 26;
            this.calcMoneyButton.Text = "Calculate Money";
            this.calcMoneyButton.UseVisualStyleBackColor = false;
            this.calcMoneyButton.Click += new System.EventHandler(this.calcMoneyButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(5, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(497, 46);
            this.label8.TabIndex = 24;
            this.label8.Text = "Money and XP Calculator";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.premiumMoneyCheck);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.goldXPCheck);
            this.panel1.Controls.Add(this.silverXPCheck);
            this.panel1.Controls.Add(this.worldBonusXPTextBox);
            this.panel1.Controls.Add(this.gearXPTextBox);
            this.panel1.Controls.Add(this.baseXPTextBox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.goldMoneyCheck);
            this.panel1.Controls.Add(this.silverMoneyCheck);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.worldBonusMoneyTextBox);
            this.panel1.Controls.Add(this.gearMoneyTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.baseMoneyTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(13, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 304);
            this.panel1.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(3, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Gold Job";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(3, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Silver Job";
            // 
            // worldBonusMoneyTextBox
            // 
            this.worldBonusMoneyTextBox.Location = new System.Drawing.Point(288, 114);
            this.worldBonusMoneyTextBox.Name = "worldBonusMoneyTextBox";
            this.worldBonusMoneyTextBox.Size = new System.Drawing.Size(71, 22);
            this.worldBonusMoneyTextBox.TabIndex = 5;
            this.worldBonusMoneyTextBox.Text = "1";
            // 
            // gearMoneyTextBox
            // 
            this.gearMoneyTextBox.Location = new System.Drawing.Point(288, 79);
            this.gearMoneyTextBox.Name = "gearMoneyTextBox";
            this.gearMoneyTextBox.Size = new System.Drawing.Size(71, 22);
            this.gearMoneyTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(3, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "World Bonus:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(3, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gear bonus and buffs:";
            // 
            // baseMoneyTextBox
            // 
            this.baseMoneyTextBox.Location = new System.Drawing.Point(288, 45);
            this.baseMoneyTextBox.Name = "baseMoneyTextBox";
            this.baseMoneyTextBox.Size = new System.Drawing.Size(71, 22);
            this.baseMoneyTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(3, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base money value:";
            // 
            // calcXPButton
            // 
            this.calcXPButton.BackColor = System.Drawing.SystemColors.Control;
            this.calcXPButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.calcXPButton.Location = new System.Drawing.Point(509, 241);
            this.calcXPButton.Name = "calcXPButton";
            this.calcXPButton.Size = new System.Drawing.Size(121, 140);
            this.calcXPButton.TabIndex = 28;
            this.calcXPButton.Text = "Calculate XP";
            this.calcXPButton.UseVisualStyleBackColor = false;
            this.calcXPButton.Click += new System.EventHandler(this.calcXPButton_Click);
            // 
            // silverMoneyCheck
            // 
            this.silverMoneyCheck.AutoSize = true;
            this.silverMoneyCheck.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.silverMoneyCheck.ForeColor = System.Drawing.SystemColors.ControlText;
            this.silverMoneyCheck.Location = new System.Drawing.Point(297, 153);
            this.silverMoneyCheck.Name = "silverMoneyCheck";
            this.silverMoneyCheck.Size = new System.Drawing.Size(53, 20);
            this.silverMoneyCheck.TabIndex = 9;
            this.silverMoneyCheck.Text = "Yes";
            this.silverMoneyCheck.UseVisualStyleBackColor = false;
            // 
            // goldMoneyCheck
            // 
            this.goldMoneyCheck.AutoSize = true;
            this.goldMoneyCheck.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.goldMoneyCheck.ForeColor = System.Drawing.SystemColors.ControlText;
            this.goldMoneyCheck.Location = new System.Drawing.Point(297, 191);
            this.goldMoneyCheck.Name = "goldMoneyCheck";
            this.goldMoneyCheck.Size = new System.Drawing.Size(53, 20);
            this.goldMoneyCheck.TabIndex = 10;
            this.goldMoneyCheck.Text = "Yes";
            this.goldMoneyCheck.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(379, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 241);
            this.panel2.TabIndex = 11;
            // 
            // goldXPCheck
            // 
            this.goldXPCheck.AutoSize = true;
            this.goldXPCheck.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.goldXPCheck.ForeColor = System.Drawing.SystemColors.ControlText;
            this.goldXPCheck.Location = new System.Drawing.Point(415, 191);
            this.goldXPCheck.Name = "goldXPCheck";
            this.goldXPCheck.Size = new System.Drawing.Size(53, 20);
            this.goldXPCheck.TabIndex = 16;
            this.goldXPCheck.Text = "Yes";
            this.goldXPCheck.UseVisualStyleBackColor = false;
            // 
            // silverXPCheck
            // 
            this.silverXPCheck.AutoSize = true;
            this.silverXPCheck.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.silverXPCheck.ForeColor = System.Drawing.SystemColors.ControlText;
            this.silverXPCheck.Location = new System.Drawing.Point(415, 154);
            this.silverXPCheck.Name = "silverXPCheck";
            this.silverXPCheck.Size = new System.Drawing.Size(53, 20);
            this.silverXPCheck.TabIndex = 15;
            this.silverXPCheck.Text = "Yes";
            this.silverXPCheck.UseVisualStyleBackColor = false;
            // 
            // worldBonusXPTextBox
            // 
            this.worldBonusXPTextBox.Location = new System.Drawing.Point(406, 114);
            this.worldBonusXPTextBox.Name = "worldBonusXPTextBox";
            this.worldBonusXPTextBox.Size = new System.Drawing.Size(71, 22);
            this.worldBonusXPTextBox.TabIndex = 14;
            this.worldBonusXPTextBox.Text = "1";
            // 
            // gearXPTextBox
            // 
            this.gearXPTextBox.Location = new System.Drawing.Point(406, 79);
            this.gearXPTextBox.Name = "gearXPTextBox";
            this.gearXPTextBox.Size = new System.Drawing.Size(71, 22);
            this.gearXPTextBox.TabIndex = 13;
            // 
            // baseXPTextBox
            // 
            this.baseXPTextBox.Location = new System.Drawing.Point(406, 45);
            this.baseXPTextBox.Name = "baseXPTextBox";
            this.baseXPTextBox.Size = new System.Drawing.Size(71, 22);
            this.baseXPTextBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(283, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 29);
            this.label6.TabIndex = 29;
            this.label6.Text = "Money";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(401, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 29);
            this.label7.TabIndex = 30;
            this.label7.Text = "XP";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultXPLabel
            // 
            this.resultXPLabel.AutoSize = true;
            this.resultXPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resultXPLabel.Location = new System.Drawing.Point(395, 392);
            this.resultXPLabel.Name = "resultXPLabel";
            this.resultXPLabel.Size = new System.Drawing.Size(235, 25);
            this.resultXPLabel.TabIndex = 29;
            this.resultXPLabel.Text = "Waiting for user input...";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(3, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(217, 25);
            this.label9.TabIndex = 31;
            this.label9.Text = "Higher income premium";
            // 
            // premiumMoneyCheck
            // 
            this.premiumMoneyCheck.AutoSize = true;
            this.premiumMoneyCheck.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.premiumMoneyCheck.ForeColor = System.Drawing.SystemColors.ControlText;
            this.premiumMoneyCheck.Location = new System.Drawing.Point(297, 230);
            this.premiumMoneyCheck.Name = "premiumMoneyCheck";
            this.premiumMoneyCheck.Size = new System.Drawing.Size(53, 20);
            this.premiumMoneyCheck.TabIndex = 32;
            this.premiumMoneyCheck.Text = "Yes";
            this.premiumMoneyCheck.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 433);
            this.Controls.Add(this.resultXPLabel);
            this.Controls.Add(this.calcXPButton);
            this.Controls.Add(this.resultMoneyLabel);
            this.Controls.Add(this.calcMoneyButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TheWest Calculator 0.3 | developed by ra1g";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem changeCalculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dropChanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hPRegenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem energyRegenToolStripMenuItem;
        private System.Windows.Forms.Label resultMoneyLabel;
        private System.Windows.Forms.Button calcMoneyButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox worldBonusMoneyTextBox;
        private System.Windows.Forms.TextBox gearMoneyTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox baseMoneyTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calcXPButton;
        private System.Windows.Forms.CheckBox silverMoneyCheck;
        private System.Windows.Forms.CheckBox goldMoneyCheck;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox goldXPCheck;
        private System.Windows.Forms.CheckBox silverXPCheck;
        private System.Windows.Forms.TextBox worldBonusXPTextBox;
        private System.Windows.Forms.TextBox gearXPTextBox;
        private System.Windows.Forms.TextBox baseXPTextBox;
        private System.Windows.Forms.Label resultXPLabel;
        private System.Windows.Forms.CheckBox premiumMoneyCheck;
        private System.Windows.Forms.Label label9;
    }
}