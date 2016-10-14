namespace WindowsFormsApplication2
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
            this.baseL = new System.Windows.Forms.Label();
            this.optionL = new System.Windows.Forms.Label();
            this.subL = new System.Windows.Forms.Label();
            this.taxL = new System.Windows.Forms.Label();
            this.totalL = new System.Windows.Forms.Label();
            this.tradeL = new System.Windows.Forms.Label();
            this.dueL = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CheckComp = new System.Windows.Forms.CheckBox();
            this.CheckLeather = new System.Windows.Forms.CheckBox();
            this.CheckStereo = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RadioCust = new System.Windows.Forms.RadioButton();
            this.RadioPearl = new System.Windows.Forms.RadioButton();
            this.RadioStandard = new System.Windows.Forms.RadioButton();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.OptionsBox = new System.Windows.Forms.TextBox();
            this.SubTBox = new System.Windows.Forms.TextBox();
            this.TaxBox = new System.Windows.Forms.TextBox();
            this.TotalBox = new System.Windows.Forms.TextBox();
            this.TradeInBox = new System.Windows.Forms.TextBox();
            this.AmountBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontBox = new System.Windows.Forms.FontDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // baseL
            // 
            this.baseL.AutoSize = true;
            this.baseL.Location = new System.Drawing.Point(42, 40);
            this.baseL.Name = "baseL";
            this.baseL.Size = new System.Drawing.Size(64, 13);
            this.baseL.TabIndex = 0;
            this.baseL.Text = "Base Price :";
            // 
            // optionL
            // 
            this.optionL.AutoSize = true;
            this.optionL.Location = new System.Drawing.Point(8, 75);
            this.optionL.Name = "optionL";
            this.optionL.Size = new System.Drawing.Size(98, 13);
            this.optionL.TabIndex = 1;
            this.optionL.Text = "Additional Options :";
            // 
            // subL
            // 
            this.subL.AutoSize = true;
            this.subL.Location = new System.Drawing.Point(47, 110);
            this.subL.Name = "subL";
            this.subL.Size = new System.Drawing.Size(59, 13);
            this.subL.TabIndex = 2;
            this.subL.Text = "Sub Total :";
            // 
            // taxL
            // 
            this.taxL.AutoSize = true;
            this.taxL.Location = new System.Drawing.Point(17, 145);
            this.taxL.Name = "taxL";
            this.taxL.Size = new System.Drawing.Size(89, 13);
            this.taxL.TabIndex = 3;
            this.taxL.Text = "Sales Tax (13%) :";
            // 
            // totalL
            // 
            this.totalL.AutoSize = true;
            this.totalL.Location = new System.Drawing.Point(69, 180);
            this.totalL.Name = "totalL";
            this.totalL.Size = new System.Drawing.Size(37, 13);
            this.totalL.TabIndex = 4;
            this.totalL.Text = "Total :";
            // 
            // tradeL
            // 
            this.tradeL.AutoSize = true;
            this.tradeL.Location = new System.Drawing.Point(2, 215);
            this.tradeL.Name = "tradeL";
            this.tradeL.Size = new System.Drawing.Size(104, 13);
            this.tradeL.TabIndex = 5;
            this.tradeL.Text = "Trade-in Allowance :";
            // 
            // dueL
            // 
            this.dueL.AutoSize = true;
            this.dueL.Location = new System.Drawing.Point(34, 250);
            this.dueL.Name = "dueL";
            this.dueL.Size = new System.Drawing.Size(72, 13);
            this.dueL.TabIndex = 6;
            this.dueL.Text = "Amount Due :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CheckComp);
            this.groupBox1.Controls.Add(this.CheckLeather);
            this.groupBox1.Controls.Add(this.CheckStereo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(231, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 120);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Additional Items";
            // 
            // CheckComp
            // 
            this.CheckComp.AutoSize = true;
            this.CheckComp.Location = new System.Drawing.Point(25, 85);
            this.CheckComp.Name = "CheckComp";
            this.CheckComp.Size = new System.Drawing.Size(153, 20);
            this.CheckComp.TabIndex = 2;
            this.CheckComp.Text = "Computer Navigation";
            this.CheckComp.UseVisualStyleBackColor = true;
            // 
            // CheckLeather
            // 
            this.CheckLeather.AutoSize = true;
            this.CheckLeather.Location = new System.Drawing.Point(25, 56);
            this.CheckLeather.Name = "CheckLeather";
            this.CheckLeather.Size = new System.Drawing.Size(115, 20);
            this.CheckLeather.TabIndex = 1;
            this.CheckLeather.Text = "Leather Interior";
            this.CheckLeather.UseVisualStyleBackColor = true;
            // 
            // CheckStereo
            // 
            this.CheckStereo.AutoSize = true;
            this.CheckStereo.Location = new System.Drawing.Point(25, 27);
            this.CheckStereo.Name = "CheckStereo";
            this.CheckStereo.Size = new System.Drawing.Size(115, 20);
            this.CheckStereo.TabIndex = 0;
            this.CheckStereo.Text = "Stereo System";
            this.CheckStereo.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RadioCust);
            this.groupBox2.Controls.Add(this.RadioPearl);
            this.groupBox2.Controls.Add(this.RadioStandard);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(231, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(191, 127);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exterior Finish";
            // 
            // RadioCust
            // 
            this.RadioCust.AutoSize = true;
            this.RadioCust.Location = new System.Drawing.Point(25, 82);
            this.RadioCust.Name = "RadioCust";
            this.RadioCust.Size = new System.Drawing.Size(152, 20);
            this.RadioCust.TabIndex = 2;
            this.RadioCust.TabStop = true;
            this.RadioCust.Text = "Customized Detailing";
            this.RadioCust.UseVisualStyleBackColor = true;
            // 
            // RadioPearl
            // 
            this.RadioPearl.AutoSize = true;
            this.RadioPearl.Location = new System.Drawing.Point(25, 56);
            this.RadioPearl.Name = "RadioPearl";
            this.RadioPearl.Size = new System.Drawing.Size(83, 20);
            this.RadioPearl.TabIndex = 1;
            this.RadioPearl.TabStop = true;
            this.RadioPearl.Text = "Pearlized";
            this.RadioPearl.UseVisualStyleBackColor = true;
            // 
            // RadioStandard
            // 
            this.RadioStandard.AutoSize = true;
            this.RadioStandard.Checked = true;
            this.RadioStandard.Location = new System.Drawing.Point(25, 30);
            this.RadioStandard.Name = "RadioStandard";
            this.RadioStandard.Size = new System.Drawing.Size(81, 20);
            this.RadioStandard.TabIndex = 0;
            this.RadioStandard.TabStop = true;
            this.RadioStandard.Text = "Standard";
            this.RadioStandard.UseVisualStyleBackColor = true;
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(123, 37);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(90, 20);
            this.PriceBox.TabIndex = 9;
            // 
            // OptionsBox
            // 
            this.OptionsBox.Location = new System.Drawing.Point(123, 72);
            this.OptionsBox.Name = "OptionsBox";
            this.OptionsBox.ReadOnly = true;
            this.OptionsBox.Size = new System.Drawing.Size(90, 20);
            this.OptionsBox.TabIndex = 10;
            // 
            // SubTBox
            // 
            this.SubTBox.Location = new System.Drawing.Point(123, 107);
            this.SubTBox.Name = "SubTBox";
            this.SubTBox.ReadOnly = true;
            this.SubTBox.Size = new System.Drawing.Size(90, 20);
            this.SubTBox.TabIndex = 11;
            // 
            // TaxBox
            // 
            this.TaxBox.Location = new System.Drawing.Point(123, 142);
            this.TaxBox.Name = "TaxBox";
            this.TaxBox.ReadOnly = true;
            this.TaxBox.Size = new System.Drawing.Size(90, 20);
            this.TaxBox.TabIndex = 12;
            // 
            // TotalBox
            // 
            this.TotalBox.Location = new System.Drawing.Point(123, 177);
            this.TotalBox.Name = "TotalBox";
            this.TotalBox.ReadOnly = true;
            this.TotalBox.Size = new System.Drawing.Size(90, 20);
            this.TotalBox.TabIndex = 13;
            // 
            // TradeInBox
            // 
            this.TradeInBox.Location = new System.Drawing.Point(123, 212);
            this.TradeInBox.Name = "TradeInBox";
            this.TradeInBox.Size = new System.Drawing.Size(90, 20);
            this.TradeInBox.TabIndex = 14;
            // 
            // AmountBox
            // 
            this.AmountBox.Location = new System.Drawing.Point(123, 247);
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.ReadOnly = true;
            this.AmountBox.Size = new System.Drawing.Size(90, 20);
            this.AmountBox.TabIndex = 15;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(5, 312);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(91, 30);
            this.CalculateButton.TabIndex = 16;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(164, 312);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(91, 30);
            this.ClearButton.TabIndex = 17;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(331, 312);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(91, 30);
            this.ExitButton.TabIndex = 18;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(427, 24);
            this.menu.TabIndex = 19;
            this.menu.Text = "menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.calculateToolStripMenuItem.Text = "&Calculate";
            this.calculateToolStripMenuItem.Click += new System.EventHandler(this.calculateToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.clearToolStripMenuItem.Text = "C&lear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.fontToolStripMenuItem.Text = "&Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.colorToolStripMenuItem.Text = "C&olor";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(427, 348);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.AmountBox);
            this.Controls.Add(this.TradeInBox);
            this.Controls.Add(this.TotalBox);
            this.Controls.Add(this.TaxBox);
            this.Controls.Add(this.SubTBox);
            this.Controls.Add(this.OptionsBox);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dueL);
            this.Controls.Add(this.tradeL);
            this.Controls.Add(this.totalL);
            this.Controls.Add(this.taxL);
            this.Controls.Add(this.subL);
            this.Controls.Add(this.optionL);
            this.Controls.Add(this.baseL);
            this.Controls.Add(this.menu);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HelpButton = true;
            this.MainMenuStrip = this.menu;
            this.Name = "Form1";
            this.Text = "Sharp Auto Center";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label baseL;
        private System.Windows.Forms.Label optionL;
        private System.Windows.Forms.Label subL;
        private System.Windows.Forms.Label taxL;
        private System.Windows.Forms.Label totalL;
        private System.Windows.Forms.Label tradeL;
        private System.Windows.Forms.Label dueL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.TextBox OptionsBox;
        private System.Windows.Forms.TextBox SubTBox;
        private System.Windows.Forms.TextBox TaxBox;
        private System.Windows.Forms.TextBox TotalBox;
        private System.Windows.Forms.TextBox TradeInBox;
        private System.Windows.Forms.TextBox AmountBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.CheckBox CheckComp;
        private System.Windows.Forms.CheckBox CheckLeather;
        private System.Windows.Forms.CheckBox CheckStereo;
        private System.Windows.Forms.RadioButton RadioCust;
        private System.Windows.Forms.RadioButton RadioPearl;
        private System.Windows.Forms.RadioButton RadioStandard;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.FontDialog FontBox;
    }
}

