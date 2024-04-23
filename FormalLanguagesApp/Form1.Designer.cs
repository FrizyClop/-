namespace FormalLanguagesApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TextBoxGrammar = new System.Windows.Forms.RichTextBox();
            this.TextBoxStateMachine = new System.Windows.Forms.RichTextBox();
            this.contextMenuForUpdateGrammar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemAddNonTerminal = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAddTerminal = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSetStartSymbol = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAddRule = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDeleteRule = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemUpdateRule = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDeleteTerminal = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDeleteNonTerminal = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.грамматикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьНетерминалToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьТерминалToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.установитьСтартовыйНетерминалToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьПравилоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьПравилоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьПравилоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьТерминалToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьНетерминалToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonGrammarToStateMachine = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuForUpdateGrammar.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxGrammar
            // 
            this.TextBoxGrammar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.TextBoxGrammar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxGrammar.Location = new System.Drawing.Point(12, 61);
            this.TextBoxGrammar.Name = "TextBoxGrammar";
            this.TextBoxGrammar.ReadOnly = true;
            this.TextBoxGrammar.Size = new System.Drawing.Size(364, 377);
            this.TextBoxGrammar.TabIndex = 0;
            this.TextBoxGrammar.Text = "";
            this.TextBoxGrammar.WordWrap = false;
            // 
            // TextBoxStateMachine
            // 
            this.TextBoxStateMachine.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.TextBoxStateMachine.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxStateMachine.Location = new System.Drawing.Point(428, 61);
            this.TextBoxStateMachine.Name = "TextBoxStateMachine";
            this.TextBoxStateMachine.ReadOnly = true;
            this.TextBoxStateMachine.Size = new System.Drawing.Size(360, 377);
            this.TextBoxStateMachine.TabIndex = 1;
            this.TextBoxStateMachine.Text = "";
            this.TextBoxStateMachine.WordWrap = false;
            // 
            // contextMenuForUpdateGrammar
            // 
            this.contextMenuForUpdateGrammar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemAddNonTerminal,
            this.MenuItemAddTerminal,
            this.MenuItemSetStartSymbol,
            this.MenuItemAddRule,
            this.MenuItemDeleteRule,
            this.MenuItemUpdateRule,
            this.MenuItemDeleteTerminal,
            this.MenuItemDeleteNonTerminal});
            this.contextMenuForUpdateGrammar.Name = "contextMenuForUpdateGrammar";
            this.contextMenuForUpdateGrammar.Size = new System.Drawing.Size(268, 180);
            // 
            // MenuItemAddNonTerminal
            // 
            this.MenuItemAddNonTerminal.Name = "MenuItemAddNonTerminal";
            this.MenuItemAddNonTerminal.Size = new System.Drawing.Size(267, 22);
            this.MenuItemAddNonTerminal.Text = "Добавить нетерминал";
            this.MenuItemAddNonTerminal.Click += new System.EventHandler(this.MenuItemAddNonTerminal_Click);
            // 
            // MenuItemAddTerminal
            // 
            this.MenuItemAddTerminal.Name = "MenuItemAddTerminal";
            this.MenuItemAddTerminal.Size = new System.Drawing.Size(267, 22);
            this.MenuItemAddTerminal.Text = "Добавить терминал";
            this.MenuItemAddTerminal.Click += new System.EventHandler(this.MenuItemAddTerminal_Click);
            // 
            // MenuItemSetStartSymbol
            // 
            this.MenuItemSetStartSymbol.Name = "MenuItemSetStartSymbol";
            this.MenuItemSetStartSymbol.Size = new System.Drawing.Size(267, 22);
            this.MenuItemSetStartSymbol.Text = "Установить стартовый нетерминал";
            this.MenuItemSetStartSymbol.Click += new System.EventHandler(this.MenuItemSetStartSymbol_Click);
            // 
            // MenuItemAddRule
            // 
            this.MenuItemAddRule.Name = "MenuItemAddRule";
            this.MenuItemAddRule.Size = new System.Drawing.Size(267, 22);
            this.MenuItemAddRule.Text = "Добавить правило";
            this.MenuItemAddRule.Click += new System.EventHandler(this.MenuItemAddRule_Click);
            // 
            // MenuItemDeleteRule
            // 
            this.MenuItemDeleteRule.Name = "MenuItemDeleteRule";
            this.MenuItemDeleteRule.Size = new System.Drawing.Size(267, 22);
            this.MenuItemDeleteRule.Text = "Удалить правило";
            this.MenuItemDeleteRule.Click += new System.EventHandler(this.MenuItemDeleteRule_Click);
            // 
            // MenuItemUpdateRule
            // 
            this.MenuItemUpdateRule.Name = "MenuItemUpdateRule";
            this.MenuItemUpdateRule.Size = new System.Drawing.Size(267, 22);
            this.MenuItemUpdateRule.Text = "Изменить правило";
            this.MenuItemUpdateRule.Click += new System.EventHandler(this.MenuItemUpdateRule_Click);
            // 
            // MenuItemDeleteTerminal
            // 
            this.MenuItemDeleteTerminal.Name = "MenuItemDeleteTerminal";
            this.MenuItemDeleteTerminal.Size = new System.Drawing.Size(267, 22);
            this.MenuItemDeleteTerminal.Text = "Удалить терминал";
            this.MenuItemDeleteTerminal.Click += new System.EventHandler(this.MenuItemDeleteTerminal_Click);
            // 
            // MenuItemDeleteNonTerminal
            // 
            this.MenuItemDeleteNonTerminal.Name = "MenuItemDeleteNonTerminal";
            this.MenuItemDeleteNonTerminal.Size = new System.Drawing.Size(267, 22);
            this.MenuItemDeleteNonTerminal.Text = "Удалить нетерминал";
            this.MenuItemDeleteNonTerminal.Click += new System.EventHandler(this.MenuItemDeleteNonTerminal_Click);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.mainMenuStrip.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.грамматикаToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(800, 30);
            this.mainMenuStrip.TabIndex = 2;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // грамматикаToolStripMenuItem
            // 
            this.грамматикаToolStripMenuItem.BackColor = System.Drawing.Color.SpringGreen;
            this.грамматикаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьНетерминалToolStripMenuItem,
            this.добавитьТерминалToolStripMenuItem,
            this.установитьСтартовыйНетерминалToolStripMenuItem,
            this.добавитьПравилоToolStripMenuItem,
            this.удалитьПравилоToolStripMenuItem,
            this.изменитьПравилоToolStripMenuItem,
            this.удалитьТерминалToolStripMenuItem,
            this.удалитьНетерминалToolStripMenuItem});
            this.грамматикаToolStripMenuItem.Name = "грамматикаToolStripMenuItem";
            this.грамматикаToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.грамматикаToolStripMenuItem.Text = "Грамматика";
            // 
            // добавитьНетерминалToolStripMenuItem
            // 
            this.добавитьНетерминалToolStripMenuItem.Name = "добавитьНетерминалToolStripMenuItem";
            this.добавитьНетерминалToolStripMenuItem.Size = new System.Drawing.Size(390, 26);
            this.добавитьНетерминалToolStripMenuItem.Text = "Добавить нетерминал";
            this.добавитьНетерминалToolStripMenuItem.Click += new System.EventHandler(this.MenuItemAddNonTerminal_Click);
            // 
            // добавитьТерминалToolStripMenuItem
            // 
            this.добавитьТерминалToolStripMenuItem.Name = "добавитьТерминалToolStripMenuItem";
            this.добавитьТерминалToolStripMenuItem.Size = new System.Drawing.Size(390, 26);
            this.добавитьТерминалToolStripMenuItem.Text = "Добавить терминал";
            this.добавитьТерминалToolStripMenuItem.Click += new System.EventHandler(this.MenuItemAddTerminal_Click);
            // 
            // установитьСтартовыйНетерминалToolStripMenuItem
            // 
            this.установитьСтартовыйНетерминалToolStripMenuItem.Name = "установитьСтартовыйНетерминалToolStripMenuItem";
            this.установитьСтартовыйНетерминалToolStripMenuItem.Size = new System.Drawing.Size(390, 26);
            this.установитьСтартовыйНетерминалToolStripMenuItem.Text = "Установить стартовый нетерминал";
            this.установитьСтартовыйНетерминалToolStripMenuItem.Click += new System.EventHandler(this.MenuItemSetStartSymbol_Click);
            // 
            // добавитьПравилоToolStripMenuItem
            // 
            this.добавитьПравилоToolStripMenuItem.Name = "добавитьПравилоToolStripMenuItem";
            this.добавитьПравилоToolStripMenuItem.Size = new System.Drawing.Size(390, 26);
            this.добавитьПравилоToolStripMenuItem.Text = "Добавить правило";
            this.добавитьПравилоToolStripMenuItem.Click += new System.EventHandler(this.MenuItemAddRule_Click);
            // 
            // удалитьПравилоToolStripMenuItem
            // 
            this.удалитьПравилоToolStripMenuItem.Name = "удалитьПравилоToolStripMenuItem";
            this.удалитьПравилоToolStripMenuItem.Size = new System.Drawing.Size(390, 26);
            this.удалитьПравилоToolStripMenuItem.Text = "Удалить правило";
            this.удалитьПравилоToolStripMenuItem.Click += new System.EventHandler(this.MenuItemDeleteRule_Click);
            // 
            // изменитьПравилоToolStripMenuItem
            // 
            this.изменитьПравилоToolStripMenuItem.Name = "изменитьПравилоToolStripMenuItem";
            this.изменитьПравилоToolStripMenuItem.Size = new System.Drawing.Size(390, 26);
            this.изменитьПравилоToolStripMenuItem.Text = "Изменить правило";
            this.изменитьПравилоToolStripMenuItem.Click += new System.EventHandler(this.MenuItemUpdateRule_Click);
            // 
            // удалитьТерминалToolStripMenuItem
            // 
            this.удалитьТерминалToolStripMenuItem.Name = "удалитьТерминалToolStripMenuItem";
            this.удалитьТерминалToolStripMenuItem.Size = new System.Drawing.Size(390, 26);
            this.удалитьТерминалToolStripMenuItem.Text = "Удалить терминал";
            this.удалитьТерминалToolStripMenuItem.Click += new System.EventHandler(this.MenuItemDeleteTerminal_Click);
            // 
            // удалитьНетерминалToolStripMenuItem
            // 
            this.удалитьНетерминалToolStripMenuItem.Name = "удалитьНетерминалToolStripMenuItem";
            this.удалитьНетерминалToolStripMenuItem.Size = new System.Drawing.Size(390, 26);
            this.удалитьНетерминалToolStripMenuItem.Text = "Удалить нетерминал";
            this.удалитьНетерминалToolStripMenuItem.Click += new System.EventHandler(this.MenuItemDeleteNonTerminal_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.BackColor = System.Drawing.Color.SpringGreen;
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(92, 26);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // buttonGrammarToStateMachine
            // 
            this.buttonGrammarToStateMachine.BackColor = System.Drawing.Color.SpringGreen;
            this.buttonGrammarToStateMachine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGrammarToStateMachine.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGrammarToStateMachine.Location = new System.Drawing.Point(382, 61);
            this.buttonGrammarToStateMachine.Name = "buttonGrammarToStateMachine";
            this.buttonGrammarToStateMachine.Size = new System.Drawing.Size(40, 377);
            this.buttonGrammarToStateMachine.TabIndex = 3;
            this.buttonGrammarToStateMachine.Text = "->";
            this.buttonGrammarToStateMachine.UseVisualStyleBackColor = false;
            this.buttonGrammarToStateMachine.Click += new System.EventHandler(this.buttonGrammarToStateMachine_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(66, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Праволинейная грамматика";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(424, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(370, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Недетерминированный конечный автомат";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGrammarToStateMachine);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.TextBoxStateMachine);
            this.Controls.Add(this.TextBoxGrammar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.mainMenuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "From regular Grammar to State Machine";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuForUpdateGrammar.ResumeLayout(false);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox TextBoxGrammar;
        private System.Windows.Forms.RichTextBox TextBoxStateMachine;
        private System.Windows.Forms.ContextMenuStrip contextMenuForUpdateGrammar;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAddNonTerminal;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAddTerminal;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSetStartSymbol;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAddRule;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDeleteRule;
        private System.Windows.Forms.ToolStripMenuItem MenuItemUpdateRule;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDeleteTerminal;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDeleteNonTerminal;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem грамматикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьНетерминалToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьТерминалToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem установитьСтартовыйНетерминалToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьПравилоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьПравилоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьПравилоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьТерминалToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьНетерминалToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.Button buttonGrammarToStateMachine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

