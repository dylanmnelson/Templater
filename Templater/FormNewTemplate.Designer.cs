namespace Templater
{
    partial class FormNewTemplate
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
            this.groupBoxSelectTemplate = new System.Windows.Forms.GroupBox();
            this.radioButtonXHTML = new System.Windows.Forms.RadioButton();
            this.radioButtonHTML4 = new System.Windows.Forms.RadioButton();
            this.radioButtonHTML5 = new System.Windows.Forms.RadioButton();
            this.buttonCreateTemplate = new System.Windows.Forms.Button();
            this.groupBoxSetTitle = new System.Windows.Forms.GroupBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelSelectStandard = new System.Windows.Forms.Label();
            this.groupBoxSelectTemplate.SuspendLayout();
            this.groupBoxSetTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSelectTemplate
            // 
            this.groupBoxSelectTemplate.Controls.Add(this.labelSelectStandard);
            this.groupBoxSelectTemplate.Controls.Add(this.radioButtonXHTML);
            this.groupBoxSelectTemplate.Controls.Add(this.radioButtonHTML4);
            this.groupBoxSelectTemplate.Controls.Add(this.radioButtonHTML5);
            this.groupBoxSelectTemplate.Location = new System.Drawing.Point(10, 10);
            this.groupBoxSelectTemplate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxSelectTemplate.Name = "groupBoxSelectTemplate";
            this.groupBoxSelectTemplate.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxSelectTemplate.Size = new System.Drawing.Size(427, 101);
            this.groupBoxSelectTemplate.TabIndex = 0;
            this.groupBoxSelectTemplate.TabStop = false;
            this.groupBoxSelectTemplate.Text = "Select a standard";
            // 
            // radioButtonXHTML
            // 
            this.radioButtonXHTML.AutoSize = true;
            this.radioButtonXHTML.Location = new System.Drawing.Point(322, 34);
            this.radioButtonXHTML.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonXHTML.Name = "radioButtonXHTML";
            this.radioButtonXHTML.Size = new System.Drawing.Size(62, 17);
            this.radioButtonXHTML.TabIndex = 2;
            this.radioButtonXHTML.TabStop = true;
            this.radioButtonXHTML.Text = "XHTML";
            this.radioButtonXHTML.UseVisualStyleBackColor = true;
            // 
            // radioButtonHTML4
            // 
            this.radioButtonHTML4.AutoSize = true;
            this.radioButtonHTML4.Location = new System.Drawing.Point(187, 34);
            this.radioButtonHTML4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonHTML4.Name = "radioButtonHTML4";
            this.radioButtonHTML4.Size = new System.Drawing.Size(61, 17);
            this.radioButtonHTML4.TabIndex = 1;
            this.radioButtonHTML4.TabStop = true;
            this.radioButtonHTML4.Text = "HTML4";
            this.radioButtonHTML4.UseVisualStyleBackColor = true;
            // 
            // radioButtonHTML5
            // 
            this.radioButtonHTML5.AutoSize = true;
            this.radioButtonHTML5.Location = new System.Drawing.Point(51, 34);
            this.radioButtonHTML5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonHTML5.Name = "radioButtonHTML5";
            this.radioButtonHTML5.Size = new System.Drawing.Size(61, 17);
            this.radioButtonHTML5.TabIndex = 0;
            this.radioButtonHTML5.TabStop = true;
            this.radioButtonHTML5.Text = "HTML5";
            this.radioButtonHTML5.UseVisualStyleBackColor = true;
            // 
            // buttonCreateTemplate
            // 
            this.buttonCreateTemplate.Location = new System.Drawing.Point(196, 190);
            this.buttonCreateTemplate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCreateTemplate.Name = "buttonCreateTemplate";
            this.buttonCreateTemplate.Size = new System.Drawing.Size(56, 27);
            this.buttonCreateTemplate.TabIndex = 1;
            this.buttonCreateTemplate.Text = "Create";
            this.buttonCreateTemplate.UseVisualStyleBackColor = true;
            // 
            // groupBoxSetTitle
            // 
            this.groupBoxSetTitle.Controls.Add(this.textBoxTitle);
            this.groupBoxSetTitle.Location = new System.Drawing.Point(10, 115);
            this.groupBoxSetTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxSetTitle.Name = "groupBoxSetTitle";
            this.groupBoxSetTitle.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxSetTitle.Size = new System.Drawing.Size(427, 58);
            this.groupBoxSetTitle.TabIndex = 2;
            this.groupBoxSetTitle.TabStop = false;
            this.groupBoxSetTitle.Text = "Set a title";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(23, 26);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(384, 20);
            this.textBoxTitle.TabIndex = 0;
            // 
            // labelSelectStandard
            // 
            this.labelSelectStandard.AutoSize = true;
            this.labelSelectStandard.Location = new System.Drawing.Point(58, 76);
            this.labelSelectStandard.Name = "labelSelectStandard";
            this.labelSelectStandard.Size = new System.Drawing.Size(315, 13);
            this.labelSelectStandard.TabIndex = 3;
            this.labelSelectStandard.Text = "TIP: If you are unsure of what to select, HTML5 is recommended.";
            // 
            // FormNewTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 234);
            this.Controls.Add(this.groupBoxSetTitle);
            this.Controls.Add(this.buttonCreateTemplate);
            this.Controls.Add(this.groupBoxSelectTemplate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormNewTemplate";
            this.Text = "New Template";
            this.groupBoxSelectTemplate.ResumeLayout(false);
            this.groupBoxSelectTemplate.PerformLayout();
            this.groupBoxSetTitle.ResumeLayout(false);
            this.groupBoxSetTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSelectTemplate;
        private System.Windows.Forms.RadioButton radioButtonHTML4;
        private System.Windows.Forms.RadioButton radioButtonHTML5;
        private System.Windows.Forms.Button buttonCreateTemplate;
        private System.Windows.Forms.RadioButton radioButtonXHTML;
        private System.Windows.Forms.GroupBox groupBoxSetTitle;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelSelectStandard;
    }
}