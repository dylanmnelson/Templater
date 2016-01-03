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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInsertDependencies));
            this.radioButtonAddJQuery1x = new System.Windows.Forms.RadioButton();
            this.radioButtonAddJQuery2x = new System.Windows.Forms.RadioButton();
            this.radioButtonNoJQuery = new System.Windows.Forms.RadioButton();
            this.buttonAcceptChanges = new System.Windows.Forms.Button();
            this.buttonDiscardChanges = new System.Windows.Forms.Button();
            this.groupBoxJQuery = new System.Windows.Forms.GroupBox();
            this.groupBoxBootstrap = new System.Windows.Forms.GroupBox();
            this.radioButtonNoBootstrap = new System.Windows.Forms.RadioButton();
            this.radioButtonAddBootstrap3 = new System.Windows.Forms.RadioButton();
            this.groupBoxJQuery.SuspendLayout();
            this.groupBoxBootstrap.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonAddJQuery1x
            // 
            this.radioButtonAddJQuery1x.AutoSize = true;
            this.radioButtonAddJQuery1x.Location = new System.Drawing.Point(188, 40);
            this.radioButtonAddJQuery1x.Name = "radioButtonAddJQuery1x";
            this.radioButtonAddJQuery1x.Size = new System.Drawing.Size(151, 21);
            this.radioButtonAddJQuery1x.TabIndex = 0;
            this.radioButtonAddJQuery1x.Text = "Add jQuery v1.11.3";
            this.radioButtonAddJQuery1x.UseVisualStyleBackColor = true;
            // 
            // radioButtonAddJQuery2x
            // 
            this.radioButtonAddJQuery2x.AutoSize = true;
            this.radioButtonAddJQuery2x.Location = new System.Drawing.Point(379, 40);
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
            this.radioButtonNoJQuery.Location = new System.Drawing.Point(23, 40);
            this.radioButtonNoJQuery.Name = "radioButtonNoJQuery";
            this.radioButtonNoJQuery.Size = new System.Drawing.Size(93, 21);
            this.radioButtonNoJQuery.TabIndex = 2;
            this.radioButtonNoJQuery.TabStop = true;
            this.radioButtonNoJQuery.Text = "No jQuery";
            this.radioButtonNoJQuery.UseVisualStyleBackColor = true;
            // 
            // buttonAcceptChanges
            // 
            this.buttonAcceptChanges.Location = new System.Drawing.Point(107, 308);
            this.buttonAcceptChanges.Name = "buttonAcceptChanges";
            this.buttonAcceptChanges.Size = new System.Drawing.Size(133, 33);
            this.buttonAcceptChanges.TabIndex = 3;
            this.buttonAcceptChanges.Text = "Accept Changes";
            this.buttonAcceptChanges.UseVisualStyleBackColor = true;
            // 
            // buttonDiscardChanges
            // 
            this.buttonDiscardChanges.Location = new System.Drawing.Point(348, 308);
            this.buttonDiscardChanges.Name = "buttonDiscardChanges";
            this.buttonDiscardChanges.Size = new System.Drawing.Size(133, 33);
            this.buttonDiscardChanges.TabIndex = 4;
            this.buttonDiscardChanges.Text = "Discard Changes";
            this.buttonDiscardChanges.UseVisualStyleBackColor = true;
            // 
            // groupBoxJQuery
            // 
            this.groupBoxJQuery.Controls.Add(this.radioButtonNoJQuery);
            this.groupBoxJQuery.Controls.Add(this.radioButtonAddJQuery1x);
            this.groupBoxJQuery.Controls.Add(this.radioButtonAddJQuery2x);
            this.groupBoxJQuery.Location = new System.Drawing.Point(28, 17);
            this.groupBoxJQuery.Name = "groupBoxJQuery";
            this.groupBoxJQuery.Size = new System.Drawing.Size(539, 100);
            this.groupBoxJQuery.TabIndex = 5;
            this.groupBoxJQuery.TabStop = false;
            this.groupBoxJQuery.Text = "jQuery";
            // 
            // groupBoxBootstrap
            // 
            this.groupBoxBootstrap.Controls.Add(this.radioButtonNoBootstrap);
            this.groupBoxBootstrap.Controls.Add(this.radioButtonAddBootstrap3);
            this.groupBoxBootstrap.Location = new System.Drawing.Point(28, 136);
            this.groupBoxBootstrap.Name = "groupBoxBootstrap";
            this.groupBoxBootstrap.Size = new System.Drawing.Size(539, 100);
            this.groupBoxBootstrap.TabIndex = 6;
            this.groupBoxBootstrap.TabStop = false;
            this.groupBoxBootstrap.Text = "Bootstrap";
            // 
            // radioButtonNoBootstrap
            // 
            this.radioButtonNoBootstrap.AutoSize = true;
            this.radioButtonNoBootstrap.Checked = true;
            this.radioButtonNoBootstrap.Location = new System.Drawing.Point(102, 40);
            this.radioButtonNoBootstrap.Name = "radioButtonNoBootstrap";
            this.radioButtonNoBootstrap.Size = new System.Drawing.Size(112, 21);
            this.radioButtonNoBootstrap.TabIndex = 2;
            this.radioButtonNoBootstrap.TabStop = true;
            this.radioButtonNoBootstrap.Text = "No Bootstrap";
            this.radioButtonNoBootstrap.UseVisualStyleBackColor = true;
            // 
            // radioButtonAddBootstrap3
            // 
            this.radioButtonAddBootstrap3.AutoSize = true;
            this.radioButtonAddBootstrap3.Location = new System.Drawing.Point(334, 40);
            this.radioButtonAddBootstrap3.Name = "radioButtonAddBootstrap3";
            this.radioButtonAddBootstrap3.Size = new System.Drawing.Size(119, 21);
            this.radioButtonAddBootstrap3.TabIndex = 0;
            this.radioButtonAddBootstrap3.Text = "Add Bootstrap";
            this.radioButtonAddBootstrap3.UseVisualStyleBackColor = true;
            // 
            // FormInsertDependencies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 373);
            this.Controls.Add(this.groupBoxBootstrap);
            this.Controls.Add(this.groupBoxJQuery);
            this.Controls.Add(this.buttonDiscardChanges);
            this.Controls.Add(this.buttonAcceptChanges);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormInsertDependencies";
            this.Text = "Insert Dependencies";
            this.groupBoxJQuery.ResumeLayout(false);
            this.groupBoxJQuery.PerformLayout();
            this.groupBoxBootstrap.ResumeLayout(false);
            this.groupBoxBootstrap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonAddJQuery1x;
        private System.Windows.Forms.RadioButton radioButtonAddJQuery2x;
        private System.Windows.Forms.RadioButton radioButtonNoJQuery;
        private System.Windows.Forms.Button buttonAcceptChanges;
        private System.Windows.Forms.Button buttonDiscardChanges;
        private System.Windows.Forms.GroupBox groupBoxJQuery;
        private System.Windows.Forms.GroupBox groupBoxBootstrap;
        private System.Windows.Forms.RadioButton radioButtonNoBootstrap;
        private System.Windows.Forms.RadioButton radioButtonAddBootstrap3;
    }
}