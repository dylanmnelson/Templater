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
            this.radioButtonHTML4 = new System.Windows.Forms.RadioButton();
            this.radioButtonHTML5 = new System.Windows.Forms.RadioButton();
            this.buttonCreateTemplate = new System.Windows.Forms.Button();
            this.radioButtonXHTML = new System.Windows.Forms.RadioButton();
            this.groupBoxSelectTemplate.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSelectTemplate
            // 
            this.groupBoxSelectTemplate.Controls.Add(this.radioButtonXHTML);
            this.groupBoxSelectTemplate.Controls.Add(this.radioButtonHTML4);
            this.groupBoxSelectTemplate.Controls.Add(this.radioButtonHTML5);
            this.groupBoxSelectTemplate.Location = new System.Drawing.Point(13, 12);
            this.groupBoxSelectTemplate.Name = "groupBoxSelectTemplate";
            this.groupBoxSelectTemplate.Size = new System.Drawing.Size(569, 100);
            this.groupBoxSelectTemplate.TabIndex = 0;
            this.groupBoxSelectTemplate.TabStop = false;
            this.groupBoxSelectTemplate.Text = "Select a standard";
            // 
            // radioButtonHTML4
            // 
            this.radioButtonHTML4.AutoSize = true;
            this.radioButtonHTML4.Location = new System.Drawing.Point(249, 42);
            this.radioButtonHTML4.Name = "radioButtonHTML4";
            this.radioButtonHTML4.Size = new System.Drawing.Size(75, 21);
            this.radioButtonHTML4.TabIndex = 1;
            this.radioButtonHTML4.TabStop = true;
            this.radioButtonHTML4.Text = "HTML4";
            this.radioButtonHTML4.UseVisualStyleBackColor = true;
            // 
            // radioButtonHTML5
            // 
            this.radioButtonHTML5.AutoSize = true;
            this.radioButtonHTML5.Location = new System.Drawing.Point(68, 42);
            this.radioButtonHTML5.Name = "radioButtonHTML5";
            this.radioButtonHTML5.Size = new System.Drawing.Size(75, 21);
            this.radioButtonHTML5.TabIndex = 0;
            this.radioButtonHTML5.TabStop = true;
            this.radioButtonHTML5.Text = "HTML5";
            this.radioButtonHTML5.UseVisualStyleBackColor = true;
            // 
            // buttonCreateTemplate
            // 
            this.buttonCreateTemplate.Location = new System.Drawing.Point(262, 196);
            this.buttonCreateTemplate.Name = "buttonCreateTemplate";
            this.buttonCreateTemplate.Size = new System.Drawing.Size(75, 33);
            this.buttonCreateTemplate.TabIndex = 1;
            this.buttonCreateTemplate.Text = "Create";
            this.buttonCreateTemplate.UseVisualStyleBackColor = true;
            // 
            // radioButtonXHTML
            // 
            this.radioButtonXHTML.AutoSize = true;
            this.radioButtonXHTML.Location = new System.Drawing.Point(429, 42);
            this.radioButtonXHTML.Name = "radioButtonXHTML";
            this.radioButtonXHTML.Size = new System.Drawing.Size(76, 21);
            this.radioButtonXHTML.TabIndex = 2;
            this.radioButtonXHTML.TabStop = true;
            this.radioButtonXHTML.Text = "XHTML";
            this.radioButtonXHTML.UseVisualStyleBackColor = true;
            // 
            // FormNewTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 251);
            this.Controls.Add(this.buttonCreateTemplate);
            this.Controls.Add(this.groupBoxSelectTemplate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormNewTemplate";
            this.Text = "New Template";
            this.groupBoxSelectTemplate.ResumeLayout(false);
            this.groupBoxSelectTemplate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSelectTemplate;
        private System.Windows.Forms.RadioButton radioButtonHTML4;
        private System.Windows.Forms.RadioButton radioButtonHTML5;
        private System.Windows.Forms.Button buttonCreateTemplate;
        private System.Windows.Forms.RadioButton radioButtonXHTML;
    }
}