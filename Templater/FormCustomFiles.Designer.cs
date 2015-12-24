namespace Templater
{
    partial class FormCustomFiles
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
            this.labelJSFilename = new System.Windows.Forms.Label();
            this.textBoxJSFilename = new System.Windows.Forms.TextBox();
            this.groupBoxEditJSFilename = new System.Windows.Forms.GroupBox();
            this.labelCSSFilename = new System.Windows.Forms.Label();
            this.textBoxCSSFilename = new System.Windows.Forms.TextBox();
            this.groupBoxEditCSSFilename = new System.Windows.Forms.GroupBox();
            this.buttonDiscardChanges = new System.Windows.Forms.Button();
            this.buttonAcceptChanges = new System.Windows.Forms.Button();
            this.groupBoxEditJSFilename.SuspendLayout();
            this.groupBoxEditCSSFilename.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelJSFilename
            // 
            this.labelJSFilename.AutoSize = true;
            this.labelJSFilename.Location = new System.Drawing.Point(175, 27);
            this.labelJSFilename.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelJSFilename.Name = "labelJSFilename";
            this.labelJSFilename.Size = new System.Drawing.Size(17, 13);
            this.labelJSFilename.TabIndex = 6;
            this.labelJSFilename.Text = ".js";
            // 
            // textBoxJSFilename
            // 
            this.textBoxJSFilename.Location = new System.Drawing.Point(21, 25);
            this.textBoxJSFilename.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxJSFilename.Name = "textBoxJSFilename";
            this.textBoxJSFilename.Size = new System.Drawing.Size(142, 20);
            this.textBoxJSFilename.TabIndex = 5;
            // 
            // groupBoxEditJSFilename
            // 
            this.groupBoxEditJSFilename.Controls.Add(this.labelJSFilename);
            this.groupBoxEditJSFilename.Controls.Add(this.textBoxJSFilename);
            this.groupBoxEditJSFilename.Location = new System.Drawing.Point(225, 10);
            this.groupBoxEditJSFilename.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxEditJSFilename.Name = "groupBoxEditJSFilename";
            this.groupBoxEditJSFilename.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxEditJSFilename.Size = new System.Drawing.Size(210, 58);
            this.groupBoxEditJSFilename.TabIndex = 6;
            this.groupBoxEditJSFilename.TabStop = false;
            this.groupBoxEditJSFilename.Text = "Edit custom JS file name / path";
            // 
            // labelCSSFilename
            // 
            this.labelCSSFilename.AutoSize = true;
            this.labelCSSFilename.Location = new System.Drawing.Point(173, 27);
            this.labelCSSFilename.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCSSFilename.Name = "labelCSSFilename";
            this.labelCSSFilename.Size = new System.Drawing.Size(26, 13);
            this.labelCSSFilename.TabIndex = 1;
            this.labelCSSFilename.Text = ".css";
            // 
            // textBoxCSSFilename
            // 
            this.textBoxCSSFilename.Location = new System.Drawing.Point(23, 25);
            this.textBoxCSSFilename.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCSSFilename.Name = "textBoxCSSFilename";
            this.textBoxCSSFilename.Size = new System.Drawing.Size(142, 20);
            this.textBoxCSSFilename.TabIndex = 0;
            // 
            // groupBoxEditCSSFilename
            // 
            this.groupBoxEditCSSFilename.Controls.Add(this.labelCSSFilename);
            this.groupBoxEditCSSFilename.Controls.Add(this.textBoxCSSFilename);
            this.groupBoxEditCSSFilename.Location = new System.Drawing.Point(9, 10);
            this.groupBoxEditCSSFilename.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxEditCSSFilename.Name = "groupBoxEditCSSFilename";
            this.groupBoxEditCSSFilename.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxEditCSSFilename.Size = new System.Drawing.Size(210, 58);
            this.groupBoxEditCSSFilename.TabIndex = 5;
            this.groupBoxEditCSSFilename.TabStop = false;
            this.groupBoxEditCSSFilename.Text = "Edit custom CSS file name / path";
            // 
            // buttonDiscardChanges
            // 
            this.buttonDiscardChanges.Location = new System.Drawing.Point(264, 104);
            this.buttonDiscardChanges.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDiscardChanges.Name = "buttonDiscardChanges";
            this.buttonDiscardChanges.Size = new System.Drawing.Size(100, 27);
            this.buttonDiscardChanges.TabIndex = 8;
            this.buttonDiscardChanges.Text = "Discard Changes";
            this.buttonDiscardChanges.UseVisualStyleBackColor = true;
            // 
            // buttonAcceptChanges
            // 
            this.buttonAcceptChanges.Location = new System.Drawing.Point(83, 104);
            this.buttonAcceptChanges.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAcceptChanges.Name = "buttonAcceptChanges";
            this.buttonAcceptChanges.Size = new System.Drawing.Size(100, 27);
            this.buttonAcceptChanges.TabIndex = 7;
            this.buttonAcceptChanges.Text = "Accept Changes";
            this.buttonAcceptChanges.UseVisualStyleBackColor = true;
            // 
            // FormCustomFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 157);
            this.Controls.Add(this.buttonDiscardChanges);
            this.Controls.Add(this.buttonAcceptChanges);
            this.Controls.Add(this.groupBoxEditJSFilename);
            this.Controls.Add(this.groupBoxEditCSSFilename);
            this.Name = "FormCustomFiles";
            this.Text = "Edit Custom Files";
            this.groupBoxEditJSFilename.ResumeLayout(false);
            this.groupBoxEditJSFilename.PerformLayout();
            this.groupBoxEditCSSFilename.ResumeLayout(false);
            this.groupBoxEditCSSFilename.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelJSFilename;
        private System.Windows.Forms.TextBox textBoxJSFilename;
        private System.Windows.Forms.GroupBox groupBoxEditJSFilename;
        private System.Windows.Forms.Label labelCSSFilename;
        private System.Windows.Forms.TextBox textBoxCSSFilename;
        private System.Windows.Forms.GroupBox groupBoxEditCSSFilename;
        private System.Windows.Forms.Button buttonDiscardChanges;
        private System.Windows.Forms.Button buttonAcceptChanges;
    }
}