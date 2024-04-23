namespace FormalLanguagesApp
{
    partial class FormDeleteRule
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
            this.comboBoxRules = new System.Windows.Forms.ComboBox();
            this.buttonDeleteRule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxRules
            // 
            this.comboBoxRules.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxRules.FormattingEnabled = true;
            this.comboBoxRules.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxRules.Location = new System.Drawing.Point(12, 12);
            this.comboBoxRules.Name = "comboBoxRules";
            this.comboBoxRules.Size = new System.Drawing.Size(223, 30);
            this.comboBoxRules.TabIndex = 0;
            // 
            // buttonDeleteRule
            // 
            this.buttonDeleteRule.Location = new System.Drawing.Point(27, 48);
            this.buttonDeleteRule.Name = "buttonDeleteRule";
            this.buttonDeleteRule.Size = new System.Drawing.Size(193, 32);
            this.buttonDeleteRule.TabIndex = 1;
            this.buttonDeleteRule.Text = "Удалить правило";
            this.buttonDeleteRule.UseVisualStyleBackColor = true;
            this.buttonDeleteRule.Click += new System.EventHandler(this.buttonDeleteRule_Click);
            // 
            // FormDeleteRule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 92);
            this.Controls.Add(this.buttonDeleteRule);
            this.Controls.Add(this.comboBoxRules);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDeleteRule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удаление правила";
            this.Load += new System.EventHandler(this.FormDeleteRule_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxRules;
        private System.Windows.Forms.Button buttonDeleteRule;
    }
}