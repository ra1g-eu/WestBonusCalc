namespace WestBonusCalc
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.regenBonusTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sleepBuildingComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.targetHpTextBox = new System.Windows.Forms.TextBox();
            this.currHpTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maxHpTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.changeCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dropChanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.energyRegenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultLabel = new System.Windows.Forms.Label();
            this.moneyXPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.regenBonusTextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.sleepBuildingComboBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.targetHpTextBox);
            this.panel1.Controls.Add(this.currHpTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.maxHpTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(12, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 304);
            this.panel1.TabIndex = 20;
            // 
            // regenBonusTextBox
            // 
            this.regenBonusTextBox.Location = new System.Drawing.Point(288, 163);
            this.regenBonusTextBox.Name = "regenBonusTextBox";
            this.regenBonusTextBox.Size = new System.Drawing.Size(186, 22);
            this.regenBonusTextBox.TabIndex = 9;
            this.regenBonusTextBox.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(3, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Regeneration bonus:";
            // 
            // sleepBuildingComboBox
            // 
            this.sleepBuildingComboBox.FormattingEnabled = true;
            this.sleepBuildingComboBox.Items.AddRange(new object[] {
            "Hotel Level 1",
            "Hotel Level 2",
            "Hotel Level 3",
            "Hotel Level 4",
            "Hotel Level 5",
            "Barracks Level 1",
            "Barracks Level 2",
            "Barracks Level 3",
            "Barracks Level 4",
            "Barracks Level 5",
            "Barracks Level 6"});
            this.sleepBuildingComboBox.Location = new System.Drawing.Point(288, 126);
            this.sleepBuildingComboBox.Name = "sleepBuildingComboBox";
            this.sleepBuildingComboBox.Size = new System.Drawing.Size(186, 24);
            this.sleepBuildingComboBox.TabIndex = 7;
            this.sleepBuildingComboBox.Text = "Select hotel or barracks";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(3, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sleeping accomodation:";
            // 
            // targetHpTextBox
            // 
            this.targetHpTextBox.Location = new System.Drawing.Point(288, 89);
            this.targetHpTextBox.Name = "targetHpTextBox";
            this.targetHpTextBox.Size = new System.Drawing.Size(186, 22);
            this.targetHpTextBox.TabIndex = 5;
            // 
            // currHpTextBox
            // 
            this.currHpTextBox.Location = new System.Drawing.Point(288, 54);
            this.currHpTextBox.Name = "currHpTextBox";
            this.currHpTextBox.Size = new System.Drawing.Size(186, 22);
            this.currHpTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(3, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Target HP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(3, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Current HP:";
            // 
            // maxHpTextBox
            // 
            this.maxHpTextBox.Location = new System.Drawing.Point(288, 20);
            this.maxHpTextBox.Name = "maxHpTextBox";
            this.maxHpTextBox.Size = new System.Drawing.Size(186, 22);
            this.maxHpTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maximum HP:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(4, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(415, 46);
            this.label8.TabIndex = 18;
            this.label8.Text = "HP Regen Calculator";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.SystemColors.Control;
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.calculateButton.Location = new System.Drawing.Point(508, 77);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(121, 304);
            this.calculateButton.TabIndex = 21;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeCalculatorToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(634, 28);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // changeCalculatorToolStripMenuItem
            // 
            this.changeCalculatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dropChanceToolStripMenuItem,
            this.energyRegenToolStripMenuItem,
            this.moneyXPToolStripMenuItem});
            this.changeCalculatorToolStripMenuItem.Name = "changeCalculatorToolStripMenuItem";
            this.changeCalculatorToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.changeCalculatorToolStripMenuItem.Text = "Change calculator";
            // 
            // dropChanceToolStripMenuItem
            // 
            this.dropChanceToolStripMenuItem.Name = "dropChanceToolStripMenuItem";
            this.dropChanceToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dropChanceToolStripMenuItem.Text = "Drop chance";
            this.dropChanceToolStripMenuItem.Click += new System.EventHandler(this.dropChanceToolStripMenuItem_Click);
            // 
            // energyRegenToolStripMenuItem
            // 
            this.energyRegenToolStripMenuItem.Enabled = false;
            this.energyRegenToolStripMenuItem.Name = "energyRegenToolStripMenuItem";
            this.energyRegenToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.energyRegenToolStripMenuItem.Text = "Energy Regen";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resultLabel.Location = new System.Drawing.Point(6, 392);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(331, 32);
            this.resultLabel.TabIndex = 23;
            this.resultLabel.Text = "Waiting for user input...";
            // 
            // moneyXPToolStripMenuItem
            // 
            this.moneyXPToolStripMenuItem.Name = "moneyXPToolStripMenuItem";
            this.moneyXPToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.moneyXPToolStripMenuItem.Text = "Money and XP";
            this.moneyXPToolStripMenuItem.Click += new System.EventHandler(this.moneyXPToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 433);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TheWest Calculator 0.3 | developed by ra1g";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem changeCalculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dropChanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem energyRegenToolStripMenuItem;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox maxHpTextBox;
        private System.Windows.Forms.TextBox targetHpTextBox;
        private System.Windows.Forms.TextBox currHpTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sleepBuildingComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox regenBonusTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moneyXPToolStripMenuItem;
    }
}