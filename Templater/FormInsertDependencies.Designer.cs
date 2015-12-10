namespace Templater
{
    partial class FormInsertDependencies
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
            this.radioButtonAddJQuery1x = new System.Windows.Forms.RadioButton();
            this.radioButtonAddJQuery2x = new System.Windows.Forms.RadioButton();
            this.radioButtonNoJQuery = new System.Windows.Forms.RadioButton();
            this.buttonAcceptChanges = new System.Windows.Forms.Button();
            this.buttonDiscardChanges = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButtonAddJQuery1x
            // 
            this.radioButtonAddJQuery1x.AutoSize = true;
            this.radioButtonAddJQuery1x.Location = new System.Drawing.Point(198, 26);
            this.radioButtonAddJQuery1x.Name = "radioButtonAddJQuery1x";
            this.radioButtonAddJQuery1x.Size = new System.Drawing.Size(151, 21);
            this.radioButtonAddJQuery1x.TabIndex = 0;
            this.radioButtonAddJQuery1x.Text = "Add jQuery v1.11.3";
            this.radioButtonAddJQuery1x.UseVisualStyleBackColor = true;
            // 
            // radioButtonAddJQuery2x
            // 
            this.radioButtonAddJQuery2x.AutoSize = true;
            this.radioButtonAddJQuery2x.Location = new System.Drawing.Point(404, 26);
            this.radioButtonAddJQuery2x.Name = "radioButtonAddJQuery2x";
            this.radioButtonAddJQuery2x.Size = new System.Drawing.Size(143, 21);
            this.radioButtonAddJQuery2x.TabIndex = 1;
            this.radioButtonAddJQuery2x.Text = "Add jQuery v2.1.4";
            this.radioButtonAddJQuery2x.UseVisualStyleBackColor = true;
            // 
            // radioButtonNoJQuery
            // 
            this.radioButtonNoJQuery.AutoSize = true;
            this.radioButtonNoJQuery.Checked = true;
            this.radioButtonNoJQuery.Location = new System.Drawing.Point(51, 26);
            this.radioButtonNoJQuery.Name = "radioButtonNoJQuery";
            this.radioButtonNoJQuery.Size = new System.Drawing.Size(93, 21);
            this.radioButtonNoJQuery.TabIndex = 2;
            this.radioButtonNoJQuery.TabStop = true;
            this.radioButtonNoJQuery.Text = "No jQuery";
            this.radioButtonNoJQuery.UseVisualStyleBackColor = true;
            // 
            // buttonAcceptChanges
            // 
            this.buttonAcceptChanges.Location = new System.Drawing.Point(107, 260);
            this.buttonAcceptChanges.Name = "buttonAcceptChanges";
            this.buttonAcceptChanges.Size = new System.Drawing.Size(133, 33);
            this.buttonAcceptChanges.TabIndex = 3;
            this.buttonAcceptChanges.Text = "Accept Changes";
            this.buttonAcceptChanges.UseVisualStyleBackColor = true;
            // 
            // buttonDiscardChanges
            // 
            this.buttonDiscardChanges.Location = new System.Drawing.Point(348, 260);
            this.buttonDiscardChanges.Name = "buttonDiscardChanges";
            this.buttonDiscardChanges.Size = new System.Drawing.Size(133, 33);
            this.buttonDiscardChanges.TabIndex = 4;
            this.buttonDiscardChanges.Text = "Discard Changes";
            this.buttonDiscardChanges.UseVisualStyleBackColor = true;
            // 
            // FormInsertDependencies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 321);
            this.Controls.Add(this.buttonDiscardChanges);
            this.Controls.Add(this.buttonAcceptChanges);
            this.Controls.Add(this.radioButtonNoJQuery);
            this.Controls.Add(this.radioButtonAddJQuery2x);
            this.Controls.Add(this.radioButtonAddJQuery1x);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormInsertDependencies";
            this.Text = "Insert Dependencies";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonAddJQuery1x;
        private System.Windows.Forms.RadioButton radioButtonAddJQuery2x;
        private System.Windows.Forms.RadioButton radioButtonNoJQuery;
        private System.Windows.Forms.Button buttonAcceptChanges;
        private System.Windows.Forms.Button buttonDiscardChanges;
    }
}