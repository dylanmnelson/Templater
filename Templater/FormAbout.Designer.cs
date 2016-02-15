namespace Templater
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.labelAboutInfo = new System.Windows.Forms.Label();
            this.buttonGoToSourceCode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAboutInfo
            // 
            this.labelAboutInfo.Location = new System.Drawing.Point(43, 28);
            this.labelAboutInfo.Name = "labelAboutInfo";
            this.labelAboutInfo.Size = new System.Drawing.Size(400, 58);
            this.labelAboutInfo.TabIndex = 0;
            this.labelAboutInfo.Text = "This program was created by Dylan Nelson in 2015 / 2016.\r\nIt is released under th" +
    "e MIT license and the source code is publicly available on GitHub.";
            this.labelAboutInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonGoToSourceCode
            // 
            this.buttonGoToSourceCode.Location = new System.Drawing.Point(130, 115);
            this.buttonGoToSourceCode.Name = "buttonGoToSourceCode";
            this.buttonGoToSourceCode.Size = new System.Drawing.Size(221, 33);
            this.buttonGoToSourceCode.TabIndex = 1;
            this.buttonGoToSourceCode.Text = "View source code and license";
            this.buttonGoToSourceCode.UseVisualStyleBackColor = true;
            this.buttonGoToSourceCode.Click += new System.EventHandler(this.buttonGoToSourceCode_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 191);
            this.Controls.Add(this.buttonGoToSourceCode);
            this.Controls.Add(this.labelAboutInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAbout";
            this.Text = "About Templater";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelAboutInfo;
        private System.Windows.Forms.Button buttonGoToSourceCode;
    }
}