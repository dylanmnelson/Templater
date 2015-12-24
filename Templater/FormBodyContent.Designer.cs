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
            this.groupBoxBodyContent = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonDiscardChanges = new System.Windows.Forms.Button();
            this.buttonAcceptChanges = new System.Windows.Forms.Button();
            this.groupBoxBodyContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxBodyContent
            // 
            this.groupBoxBodyContent.Controls.Add(this.richTextBox1);
            this.groupBoxBodyContent.Location = new System.Drawing.Point(13, 13);
            this.groupBoxBodyContent.Name = "groupBoxBodyContent";
            this.groupBoxBodyContent.Size = new System.Drawing.Size(421, 292);
            this.groupBoxBodyContent.TabIndex = 0;
            this.groupBoxBodyContent.TabStop = false;
            this.groupBoxBodyContent.Text = "Add your template body content";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(7, 20);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(408, 266);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // buttonDiscardChanges
            // 
            this.buttonDiscardChanges.Location = new System.Drawing.Point(264, 316);
            this.buttonDiscardChanges.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDiscardChanges.Name = "buttonDiscardChanges";
            this.buttonDiscardChanges.Size = new System.Drawing.Size(100, 27);
            this.buttonDiscardChanges.TabIndex = 6;
            this.buttonDiscardChanges.Text = "Discard Changes";
            this.buttonDiscardChanges.UseVisualStyleBackColor = true;
            // 
            // buttonAcceptChanges
            // 
            this.buttonAcceptChanges.Location = new System.Drawing.Point(83, 316);
            this.buttonAcceptChanges.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAcceptChanges.Name = "buttonAcceptChanges";
            this.buttonAcceptChanges.Size = new System.Drawing.Size(100, 27);
            this.buttonAcceptChanges.TabIndex = 5;
            this.buttonAcceptChanges.Text = "Accept Changes";
            this.buttonAcceptChanges.UseVisualStyleBackColor = true;
            // 
            // FormBodyContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 355);
            this.Controls.Add(this.buttonDiscardChanges);
            this.Controls.Add(this.buttonAcceptChanges);
            this.Controls.Add(this.groupBoxBodyContent);
            this.Name = "FormBodyContent";
            this.Text = "Edit Body Content";
            this.groupBoxBodyContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBodyContent;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonDiscardChanges;
        private System.Windows.Forms.Button buttonAcceptChanges;
    }
}