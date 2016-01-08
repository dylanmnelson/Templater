namespace Templater
{
    partial class FormBodyContent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBodyContent));
            this.groupBoxBodyContent = new System.Windows.Forms.GroupBox();
            this.richTextBoxBody = new System.Windows.Forms.RichTextBox();
            this.buttonDiscardChanges = new System.Windows.Forms.Button();
            this.buttonAcceptChanges = new System.Windows.Forms.Button();
            this.groupBoxBodyContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxBodyContent
            // 
            this.groupBoxBodyContent.Controls.Add(this.richTextBoxBody);
            this.groupBoxBodyContent.Location = new System.Drawing.Point(17, 16);
            this.groupBoxBodyContent.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxBodyContent.Name = "groupBoxBodyContent";
            this.groupBoxBodyContent.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxBodyContent.Size = new System.Drawing.Size(561, 359);
            this.groupBoxBodyContent.TabIndex = 0;
            this.groupBoxBodyContent.TabStop = false;
            this.groupBoxBodyContent.Text = "Add your template body content";
            // 
            // richTextBoxBody
            // 
            this.richTextBoxBody.AcceptsTab = true;
            this.richTextBoxBody.Location = new System.Drawing.Point(9, 25);
            this.richTextBoxBody.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxBody.Name = "richTextBoxBody";
            this.richTextBoxBody.Size = new System.Drawing.Size(543, 326);
            this.richTextBoxBody.TabIndex = 0;
            this.richTextBoxBody.Text = "";
            // 
            // buttonDiscardChanges
            // 
            this.buttonDiscardChanges.Location = new System.Drawing.Point(352, 389);
            this.buttonDiscardChanges.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDiscardChanges.Name = "buttonDiscardChanges";
            this.buttonDiscardChanges.Size = new System.Drawing.Size(133, 33);
            this.buttonDiscardChanges.TabIndex = 6;
            this.buttonDiscardChanges.Text = "Discard Changes";
            this.buttonDiscardChanges.UseVisualStyleBackColor = true;
            // 
            // buttonAcceptChanges
            // 
            this.buttonAcceptChanges.Location = new System.Drawing.Point(111, 389);
            this.buttonAcceptChanges.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAcceptChanges.Name = "buttonAcceptChanges";
            this.buttonAcceptChanges.Size = new System.Drawing.Size(133, 33);
            this.buttonAcceptChanges.TabIndex = 5;
            this.buttonAcceptChanges.Text = "Accept Changes";
            this.buttonAcceptChanges.UseVisualStyleBackColor = true;
            // 
            // FormBodyContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 437);
            this.Controls.Add(this.buttonDiscardChanges);
            this.Controls.Add(this.buttonAcceptChanges);
            this.Controls.Add(this.groupBoxBodyContent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormBodyContent";
            this.Text = "Edit Body Content";
            this.groupBoxBodyContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBodyContent;
        private System.Windows.Forms.RichTextBox richTextBoxBody;
        private System.Windows.Forms.Button buttonDiscardChanges;
        private System.Windows.Forms.Button buttonAcceptChanges;
    }
}