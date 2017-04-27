namespace Dice_Simulator
{
    partial class DiceSim
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
            this.log = new System.Windows.Forms.TabControl();
            this.Current = new System.Windows.Forms.TabPage();
            this.currBox = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.numBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cumuBox = new System.Windows.Forms.TextBox();
            this.log.SuspendLayout();
            this.Current.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // log
            // 
            this.log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.log.Controls.Add(this.Current);
            this.log.Controls.Add(this.tabPage2);
            this.log.Location = new System.Drawing.Point(12, 85);
            this.log.Name = "log";
            this.log.SelectedIndex = 0;
            this.log.Size = new System.Drawing.Size(196, 107);
            this.log.TabIndex = 4;
            // 
            // Current
            // 
            this.Current.Controls.Add(this.currBox);
            this.Current.Location = new System.Drawing.Point(4, 22);
            this.Current.Name = "Current";
            this.Current.Padding = new System.Windows.Forms.Padding(3);
            this.Current.Size = new System.Drawing.Size(187, 105);
            this.Current.TabIndex = 0;
            this.Current.Text = "Current";
            this.Current.UseVisualStyleBackColor = true;
            // 
            // currBox
            // 
            this.currBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currBox.Location = new System.Drawing.Point(3, 3);
            this.currBox.Name = "currBox";
            this.currBox.ReadOnly = true;
            this.currBox.Size = new System.Drawing.Size(181, 99);
            this.currBox.TabIndex = 0;
            this.currBox.TabStop = false;
            this.currBox.Text = "";
            this.currBox.TextChanged += new System.EventHandler(this.currBox_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.logBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(188, 81);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Log";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(137, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Roll!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox
            // 
            this.comboBox.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "d2",
            "d4",
            "d6",
            "d8",
            "d10",
            "d12",
            "d20",
            "d100"});
            this.comboBox.Location = new System.Drawing.Point(80, 25);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(51, 21);
            this.comboBox.TabIndex = 2;
            // 
            // numBox
            // 
            this.numBox.Location = new System.Drawing.Point(12, 26);
            this.numBox.Name = "numBox";
            this.numBox.Size = new System.Drawing.Size(62, 20);
            this.numBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number";
            // 
            // logBox
            // 
            this.logBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logBox.Location = new System.Drawing.Point(3, 3);
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.Size = new System.Drawing.Size(182, 75);
            this.logBox.TabIndex = 0;
            this.logBox.TabStop = false;
            this.logBox.Text = "";
            this.logBox.TextChanged += new System.EventHandler(this.logBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cumulative: ";
            // 
            // cumuBox
            // 
            this.cumuBox.Location = new System.Drawing.Point(80, 53);
            this.cumuBox.Name = "cumuBox";
            this.cumuBox.ReadOnly = true;
            this.cumuBox.Size = new System.Drawing.Size(100, 20);
            this.cumuBox.TabIndex = 2;
            // 
            // DiceSim
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 204);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cumuBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numBox);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.log);
            this.Name = "DiceSim";
            this.Text = "Dice Simulator";
            this.Load += new System.EventHandler(this.DiceSim_Load);
            this.log.ResumeLayout(false);
            this.Current.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl log;
        private System.Windows.Forms.TabPage Current;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.RichTextBox currBox;
        private System.Windows.Forms.TextBox numBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cumuBox;
    }
}

