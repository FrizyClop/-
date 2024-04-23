namespace FormalLanguagesApp
{
    partial class FormAddNonTerminal
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
            this.buttonAddNonTerminal = new System.Windows.Forms.Button();
            this.textBoxAddNonTerminal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAddNonTerminal
            // 
            this.buttonAddNonTerminal.Location = new System.Drawing.Point(12, 51);
            this.buttonAddNonTerminal.Name = "buttonAddNonTerminal";
            this.buttonAddNonTerminal.Size = new System.Drawing.Size(183, 33);
            this.buttonAddNonTerminal.TabIndex = 3;
            this.buttonAddNonTerminal.Text = "Добавить нетерминал";
            this.buttonAddNonTerminal.UseVisualStyleBackColor = true;
            this.buttonAddNonTerminal.Click += new System.EventHandler(this.buttonAddNonTerminal_Click);
            // 
            // textBoxAddNonTerminal
            // 
            this.textBoxAddNonTerminal.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAddNonTerminal.Location = new System.Drawing.Point(12, 9);
            this.textBoxAddNonTerminal.MaxLength = 1;
            this.textBoxAddNonTerminal.Name = "textBoxAddNonTerminal";
            this.textBoxAddNonTerminal.Size = new System.Drawing.Size(183, 36);
            this.textBoxAddNonTerminal.TabIndex = 2;
            // 
            // FormAddNonTerminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 92);
            this.Controls.Add(this.buttonAddNonTerminal);
            this.Controls.Add(this.textBoxAddNonTerminal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddNonTerminal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddNonTerminal;
        private System.Windows.Forms.TextBox textBoxAddNonTerminal;
    }
}