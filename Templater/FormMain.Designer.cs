namespace Templater
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTemplateSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveTemplateSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportHTMLTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.statusStripInfo = new System.Windows.Forms.StatusStrip();
            this.statusLabelFileSaved = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonEditBodyContent = new System.Windows.Forms.Button();
            this.buttonEditCustomFiles = new System.Windows.Forms.Button();
            this.buttonInsertDependencies = new System.Windows.Forms.Button();
            this.saveFileDialogTemplate = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogTemplate = new System.Windows.Forms.OpenFileDialog();
            this.menuStripMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStripInfo.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStripMain.Size = new System.Drawing.Size(638, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTemplateToolStripMenuItem,
            this.loadTemplateSettingsToolStripMenuItem,
            this.toolStripSeparator2,
            this.saveTemplateSettingsToolStripMenuItem,
            this.exportHTMLTemplateToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newTemplateToolStripMenuItem
            // 
            this.newTemplateToolStripMenuItem.Name = "newTemplateToolStripMenuItem";
            this.newTemplateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newTemplateToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.newTemplateToolStripMenuItem.Text = "New Template";
            this.newTemplateToolStripMenuItem.Click += new System.EventHandler(this.newTemplateToolStripMenuItem_Click);
            // 
            // loadTemplateSettingsToolStripMenuItem
            // 
            this.loadTemplateSettingsToolStripMenuItem.Enabled = false;
            this.loadTemplateSettingsToolStripMenuItem.Name = "loadTemplateSettingsToolStripMenuItem";
            this.loadTemplateSettingsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.loadTemplateSettingsToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.loadTemplateSettingsToolStripMenuItem.Text = "Load Template Settings";
            this.loadTemplateSettingsToolStripMenuItem.Click += new System.EventHandler(this.loadTemplateSettingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(237, 6);
            // 
            // saveTemplateSettingsToolStripMenuItem
            // 
            this.saveTemplateSettingsToolStripMenuItem.Enabled = false;
            this.saveTemplateSettingsToolStripMenuItem.Name = "saveTemplateSettingsToolStripMenuItem";
            this.saveTemplateSettingsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveTemplateSettingsToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.saveTemplateSettingsToolStripMenuItem.Text = "Save Template Settings";
            this.saveTemplateSettingsToolStripMenuItem.Click += new System.EventHandler(this.saveTemplateSettingsToolStripMenuItem_Click);
            // 
            // exportHTMLTemplateToolStripMenuItem
            // 
            this.exportHTMLTemplateToolStripMenuItem.Enabled = false;
            this.exportHTMLTemplateToolStripMenuItem.Name = "exportHTMLTemplateToolStripMenuItem";
            this.exportHTMLTemplateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exportHTMLTemplateToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.exportHTMLTemplateToolStripMenuItem.Text = "Export HTML Template";
            this.exportHTMLTemplateToolStripMenuItem.Click += new System.EventHandler(this.exportHTMLTemplateToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(237, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.Controls.Add(this.richTextBoxOutput, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.statusStripInfo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelButtons, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(638, 437);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.AcceptsTab = true;
            this.richTextBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxOutput.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxOutput.Location = new System.Drawing.Point(2, 2);
            this.richTextBoxOutput.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.ReadOnly = true;
            this.richTextBoxOutput.Size = new System.Drawing.Size(484, 413);
            this.richTextBoxOutput.TabIndex = 0;
            this.richTextBoxOutput.Text = "";
            // 
            // statusStripInfo
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.statusStripInfo, 2);
            this.statusStripInfo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabelFileSaved});
            this.statusStripInfo.Location = new System.Drawing.Point(0, 417);
            this.statusStripInfo.Name = "statusStripInfo";
            this.statusStripInfo.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStripInfo.Size = new System.Drawing.Size(638, 20);
            this.statusStripInfo.TabIndex = 2;
            this.statusStripInfo.Text = "statusStrip1";
            // 
            // statusLabelFileSaved
            // 
            this.statusLabelFileSaved.Name = "statusLabelFileSaved";
            this.statusLabelFileSaved.Size = new System.Drawing.Size(0, 15);
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.buttonEditBodyContent);
            this.panelButtons.Controls.Add(this.buttonEditCustomFiles);
            this.panelButtons.Controls.Add(this.buttonInsertDependencies);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtons.Location = new System.Drawing.Point(490, 2);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(2);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(146, 413);
            this.panelButtons.TabIndex = 3;
            // 
            // buttonEditBodyContent
            // 
            this.buttonEditBodyContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditBodyContent.AutoSize = true;
            this.buttonEditBodyContent.Enabled = false;
            this.buttonEditBodyContent.Location = new System.Drawing.Point(0, 83);
            this.buttonEditBodyContent.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEditBodyContent.Name = "buttonEditBodyContent";
            this.buttonEditBodyContent.Size = new System.Drawing.Size(146, 27);
            this.buttonEditBodyContent.TabIndex = 4;
            this.buttonEditBodyContent.Text = "Edit Body Content";
            this.buttonEditBodyContent.UseVisualStyleBackColor = true;
            this.buttonEditBodyContent.Click += new System.EventHandler(this.buttonEditBodyContent_Click);
            // 
            // buttonEditCustomFiles
            // 
            this.buttonEditCustomFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditCustomFiles.AutoSize = true;
            this.buttonEditCustomFiles.Enabled = false;
            this.buttonEditCustomFiles.Location = new System.Drawing.Point(0, 41);
            this.buttonEditCustomFiles.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEditCustomFiles.Name = "buttonEditCustomFiles";
            this.buttonEditCustomFiles.Size = new System.Drawing.Size(146, 27);
            this.buttonEditCustomFiles.TabIndex = 3;
            this.buttonEditCustomFiles.Text = "Edit Custom CSS / JS Files";
            this.buttonEditCustomFiles.UseVisualStyleBackColor = true;
            this.buttonEditCustomFiles.Click += new System.EventHandler(this.buttonEditCustomFiles_Click);
            // 
            // buttonInsertDependencies
            // 
            this.buttonInsertDependencies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInsertDependencies.AutoSize = true;
            this.buttonInsertDependencies.Enabled = false;
            this.buttonInsertDependencies.Location = new System.Drawing.Point(0, 0);
            this.buttonInsertDependencies.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInsertDependencies.Name = "buttonInsertDependencies";
            this.buttonInsertDependencies.Size = new System.Drawing.Size(146, 27);
            this.buttonInsertDependencies.TabIndex = 2;
            this.buttonInsertDependencies.Text = "Insert Dependencies";
            this.buttonInsertDependencies.UseVisualStyleBackColor = true;
            this.buttonInsertDependencies.Click += new System.EventHandler(this.buttonInsertDependencies_Click);
            // 
            // saveFileDialogTemplate
            // 
            this.saveFileDialogTemplate.DefaultExt = "*.html";
            this.saveFileDialogTemplate.FileName = "template.html";
            this.saveFileDialogTemplate.Filter = "HTML File | *.html";
            // 
            // openFileDialogTemplate
            // 
            this.openFileDialogTemplate.FileName = "openFileDialog1";
            this.openFileDialogTemplate.Filter = "HTML Files (*.html)|*html|All Files (*)|*.*";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(452, 45);
            this.Name = "FormMain";
            this.Text = "Templater";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.statusStripInfo.ResumeLayout(false);
            this.statusStripInfo.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTemplateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadTemplateSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox richTextBoxOutput;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem saveTemplateSettingsToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialogTemplate;
        private System.Windows.Forms.StatusStrip statusStripInfo;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelFileSaved;
        private System.Windows.Forms.OpenFileDialog openFileDialogTemplate;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button buttonInsertDependencies;
        private System.Windows.Forms.Button buttonEditBodyContent;
        private System.Windows.Forms.Button buttonEditCustomFiles;
        private System.Windows.Forms.ToolStripMenuItem exportHTMLTemplateToolStripMenuItem;
    }
}

