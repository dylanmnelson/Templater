﻿namespace Templater
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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.buttonInsertDependencies = new System.Windows.Forms.Button();
            this.statusStripInfo = new System.Windows.Forms.StatusStrip();
            this.statusLabelFileSaved = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveFileDialogTemplate = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogTemplate = new System.Windows.Forms.OpenFileDialog();
            this.menuStripMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStripInfo.SuspendLayout();
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
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStripMain.Size = new System.Drawing.Size(851, 28);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTemplateToolStripMenuItem,
            this.openTemplateToolStripMenuItem,
            this.toolStripSeparator2,
            this.saveTemplateToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newTemplateToolStripMenuItem
            // 
            this.newTemplateToolStripMenuItem.Name = "newTemplateToolStripMenuItem";
            this.newTemplateToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.newTemplateToolStripMenuItem.Text = "New Template";
            this.newTemplateToolStripMenuItem.Click += new System.EventHandler(this.newTemplateToolStripMenuItem_Click);
            // 
            // openTemplateToolStripMenuItem
            // 
            this.openTemplateToolStripMenuItem.Name = "openTemplateToolStripMenuItem";
            this.openTemplateToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.openTemplateToolStripMenuItem.Text = "Open Template";
            this.openTemplateToolStripMenuItem.Click += new System.EventHandler(this.openTemplateToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(184, 6);
            // 
            // saveTemplateToolStripMenuItem
            // 
            this.saveTemplateToolStripMenuItem.Name = "saveTemplateToolStripMenuItem";
            this.saveTemplateToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.saveTemplateToolStripMenuItem.Text = "Save Template";
            this.saveTemplateToolStripMenuItem.Click += new System.EventHandler(this.saveTemplateToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(184, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.Controls.Add(this.richTextBoxOutput, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonInsertDependencies, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.statusStripInfo, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(851, 539);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.AcceptsTab = true;
            this.richTextBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxOutput.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxOutput.Location = new System.Drawing.Point(3, 2);
            this.richTextBoxOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.ReadOnly = true;
            this.richTextBoxOutput.Size = new System.Drawing.Size(645, 510);
            this.richTextBoxOutput.TabIndex = 0;
            this.richTextBoxOutput.Text = "";
            // 
            // buttonInsertDependencies
            // 
            this.buttonInsertDependencies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInsertDependencies.AutoSize = true;
            this.buttonInsertDependencies.Location = new System.Drawing.Point(654, 2);
            this.buttonInsertDependencies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInsertDependencies.Name = "buttonInsertDependencies";
            this.buttonInsertDependencies.Size = new System.Drawing.Size(194, 33);
            this.buttonInsertDependencies.TabIndex = 1;
            this.buttonInsertDependencies.Text = "Insert Dependencies";
            this.buttonInsertDependencies.UseVisualStyleBackColor = true;
            // 
            // statusStripInfo
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.statusStripInfo, 2);
            this.statusStripInfo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabelFileSaved});
            this.statusStripInfo.Location = new System.Drawing.Point(0, 517);
            this.statusStripInfo.Name = "statusStripInfo";
            this.statusStripInfo.Size = new System.Drawing.Size(851, 22);
            this.statusStripInfo.TabIndex = 2;
            this.statusStripInfo.Text = "statusStrip1";
            // 
            // statusLabelFileSaved
            // 
            this.statusLabelFileSaved.Name = "statusLabelFileSaved";
            this.statusLabelFileSaved.Size = new System.Drawing.Size(0, 17);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 567);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(599, 47);
            this.Name = "FormMain";
            this.Text = "Templater";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.statusStripInfo.ResumeLayout(false);
            this.statusStripInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTemplateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openTemplateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox richTextBoxOutput;
        private System.Windows.Forms.Button buttonInsertDependencies;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem saveTemplateToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialogTemplate;
        private System.Windows.Forms.StatusStrip statusStripInfo;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelFileSaved;
        private System.Windows.Forms.OpenFileDialog openFileDialogTemplate;
    }
}
