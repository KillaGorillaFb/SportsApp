namespace SportsEx5App
{
    partial class FormList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormList));
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lstBxSports = new System.Windows.Forms.ListBox();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblSportInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Tennis ",
            "Football"});
            this.cmbType.Location = new System.Drawing.Point(85, 50);
            this.cmbType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(209, 28);
            this.cmbType.TabIndex = 0;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // lstBxSports
            // 
            this.lstBxSports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBxSports.FormattingEnabled = true;
            this.lstBxSports.ItemHeight = 20;
            this.lstBxSports.Location = new System.Drawing.Point(85, 112);
            this.lstBxSports.Margin = new System.Windows.Forms.Padding(2);
            this.lstBxSports.Name = "lstBxSports";
            this.lstBxSports.Size = new System.Drawing.Size(209, 204);
            this.lstBxSports.TabIndex = 1;
            this.lstBxSports.SelectedIndexChanged += new System.EventHandler(this.lstBxSports_SelectedIndexChanged);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(28, 378);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(209, 37);
            this.lblHeading.TabIndex = 2;
            this.lblHeading.Text = "Sport Details:";
            // 
            // lblSportInfo
            // 
            this.lblSportInfo.AutoSize = true;
            this.lblSportInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSportInfo.Location = new System.Drawing.Point(32, 444);
            this.lblSportInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSportInfo.Name = "lblSportInfo";
            this.lblSportInfo.Size = new System.Drawing.Size(65, 20);
            this.lblSportInfo.TabIndex = 3;
            this.lblSportInfo.Text = "Details";
            // 
            // FormList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(383, 538);
            this.Controls.Add(this.lblSportInfo);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.lstBxSports);
            this.Controls.Add(this.cmbType);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormList";
            this.Text = "Sport Info List";
            this.Load += new System.EventHandler(this.FormList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.ListBox lstBxSports;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblSportInfo;
    }
}

