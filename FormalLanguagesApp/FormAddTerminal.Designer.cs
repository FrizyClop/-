namespace FormalLanguagesApp
{
    partial class FormAddTerminal
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
            this.textBoxAddTerminal = new System.Windows.Forms.TextBox();
            this.buttonAddTerminal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxAddTerminal
            // 
            this.textBoxAddTerminal.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAddTerminal.Location = new System.Drawing.Point(12, 12);
            this.textBoxAddTerminal.MaxLength = 1;
            this.textBoxAddTerminal.Name = "textBoxAddTerminal";
            this.textBoxAddTerminal.Size = new System.Drawing.Size(183, 36);
            this.textBoxAddTerminal.TabIndex = 0;
            // 
            // buttonAddTerminal
            // 
            this.buttonAddTerminal.Location = new System.Drawing.Point(12, 54);
            this.buttonAddTerminal.Name = "buttonAddTerminal";
            this.buttonAddTerminal.Size = new System.Drawing.Size(183, 33);
            this.buttonAddTerminal.TabIndex = 1;
            this.buttonAddTerminal.Text = "Добавить терминал";
            this.buttonAddTerminal.UseVisualStyleBackColor = true;
            this.buttonAddTerminal.Click += new System.EventHandler(this.buttonAddTerminal_Click);
            // 
            // FormAddTerminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 92);
            this.Controls.Add(this.buttonAddTerminal);
            this.Controls.Add(this.textBoxAddTerminal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddTerminal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAddTerminal;
        private System.Windows.Forms.Button buttonAddTerminal;
    }
}