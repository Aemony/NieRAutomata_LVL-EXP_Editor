namespace NieRAutomata_LVL_EXP_Editor
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
            this.buttonOpenSlot = new System.Windows.Forms.Button();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.textBoxExperience = new System.Windows.Forms.TextBox();
            this.labelExperience = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBoxLevel = new System.Windows.Forms.ComboBox();
            this.labelLevel = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOpenSlot
            // 
            this.buttonOpenSlot.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenSlot.Name = "buttonOpenSlot";
            this.buttonOpenSlot.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenSlot.TabIndex = 0;
            this.buttonOpenSlot.Text = "Open slot...";
            this.buttonOpenSlot.UseVisualStyleBackColor = true;
            this.buttonOpenSlot.Click += new System.EventHandler(this.buttonOpenSlot_Click);
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Location = new System.Drawing.Point(93, 14);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.ReadOnly = true;
            this.textBoxFilePath.Size = new System.Drawing.Size(255, 20);
            this.textBoxFilePath.TabIndex = 1;
            this.textBoxFilePath.Text = "No slot file loaded...";
            // 
            // textBoxExperience
            // 
            this.textBoxExperience.Enabled = false;
            this.textBoxExperience.Location = new System.Drawing.Point(93, 110);
            this.textBoxExperience.Name = "textBoxExperience";
            this.textBoxExperience.Size = new System.Drawing.Size(100, 20);
            this.textBoxExperience.TabIndex = 2;
            // 
            // labelExperience
            // 
            this.labelExperience.AutoSize = true;
            this.labelExperience.Location = new System.Drawing.Point(12, 113);
            this.labelExperience.Name = "labelExperience";
            this.labelExperience.Size = new System.Drawing.Size(60, 13);
            this.labelExperience.TabIndex = 3;
            this.labelExperience.Text = "Experience";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(12, 57);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(336, 34);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Level is calculated in-game from the experience, so the only way to change your l" +
    "evel is to change the experience stored in the save slot.";
            // 
            // comboBoxLevel
            // 
            this.comboBoxLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLevel.Enabled = false;
            this.comboBoxLevel.FormattingEnabled = true;
            this.comboBoxLevel.Items.AddRange(new object[] {
            "[unchanged]",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75",
            "80",
            "85",
            "90",
            "95",
            "99"});
            this.comboBoxLevel.Location = new System.Drawing.Point(261, 110);
            this.comboBoxLevel.Name = "comboBoxLevel";
            this.comboBoxLevel.Size = new System.Drawing.Size(87, 21);
            this.comboBoxLevel.TabIndex = 5;
            this.comboBoxLevel.SelectedIndexChanged += new System.EventHandler(this.comboBoxLevel_SelectedIndexChanged);
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Location = new System.Drawing.Point(222, 113);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(33, 13);
            this.labelLevel.TabIndex = 6;
            this.labelLevel.Text = "Level";
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(273, 157);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 199);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.comboBoxLevel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelExperience);
            this.Controls.Add(this.textBoxExperience);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.buttonOpenSlot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "NieR:Automata - Lvl & EXP Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenSlot;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.TextBox textBoxExperience;
        private System.Windows.Forms.Label labelExperience;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBoxLevel;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.Button buttonSave;
    }
}

