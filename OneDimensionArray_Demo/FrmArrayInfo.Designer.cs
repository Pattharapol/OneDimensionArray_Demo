namespace OneDimensionArray_Demo
{
    partial class FrmArrayInfo
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("LstInfo");
            this.btnAssignment = new System.Windows.Forms.Button();
            this.btnDirect = new System.Windows.Forms.Button();
            this.btnInputBox = new System.Windows.Forms.Button();
            this.btnDataFile = new System.Windows.Forms.Button();
            this.btnAverageApp = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.LstInfo = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnAssignment
            // 
            this.btnAssignment.Location = new System.Drawing.Point(29, 55);
            this.btnAssignment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAssignment.Name = "btnAssignment";
            this.btnAssignment.Size = new System.Drawing.Size(282, 52);
            this.btnAssignment.TabIndex = 0;
            this.btnAssignment.Text = "Assignment Statements";
            this.btnAssignment.UseVisualStyleBackColor = true;
            this.btnAssignment.Click += new System.EventHandler(this.btnAssignment_Click);
            // 
            // btnDirect
            // 
            this.btnDirect.Location = new System.Drawing.Point(367, 55);
            this.btnDirect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDirect.Name = "btnDirect";
            this.btnDirect.Size = new System.Drawing.Size(282, 52);
            this.btnDirect.TabIndex = 1;
            this.btnDirect.Text = "Direct Instantiation";
            this.btnDirect.UseVisualStyleBackColor = true;
            this.btnDirect.Click += new System.EventHandler(this.btnDirect_Click);
            // 
            // btnInputBox
            // 
            this.btnInputBox.Location = new System.Drawing.Point(29, 153);
            this.btnInputBox.Margin = new System.Windows.Forms.Padding(4);
            this.btnInputBox.Name = "btnInputBox";
            this.btnInputBox.Size = new System.Drawing.Size(282, 52);
            this.btnInputBox.TabIndex = 0;
            this.btnInputBox.Text = "Input Box";
            this.btnInputBox.UseVisualStyleBackColor = true;
            // 
            // btnDataFile
            // 
            this.btnDataFile.Location = new System.Drawing.Point(367, 153);
            this.btnDataFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnDataFile.Name = "btnDataFile";
            this.btnDataFile.Size = new System.Drawing.Size(282, 52);
            this.btnDataFile.TabIndex = 0;
            this.btnDataFile.Text = "Data File";
            this.btnDataFile.UseVisualStyleBackColor = true;
            // 
            // btnAverageApp
            // 
            this.btnAverageApp.Location = new System.Drawing.Point(203, 231);
            this.btnAverageApp.Margin = new System.Windows.Forms.Padding(4);
            this.btnAverageApp.Name = "btnAverageApp";
            this.btnAverageApp.Size = new System.Drawing.Size(282, 52);
            this.btnAverageApp.TabIndex = 0;
            this.btnAverageApp.Text = "Average - Application";
            this.btnAverageApp.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(311, 501);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // LstInfo
            // 
            this.LstInfo.HideSelection = false;
            this.LstInfo.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.LstInfo.Location = new System.Drawing.Point(152, 307);
            this.LstInfo.Name = "LstInfo";
            this.LstInfo.Size = new System.Drawing.Size(405, 153);
            this.LstInfo.TabIndex = 3;
            this.LstInfo.UseCompatibleStateImageBehavior = false;
            this.LstInfo.View = System.Windows.Forms.View.List;
            // 
            // FrmArrayInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 548);
            this.Controls.Add(this.LstInfo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDirect);
            this.Controls.Add(this.btnDataFile);
            this.Controls.Add(this.btnAverageApp);
            this.Controls.Add(this.btnInputBox);
            this.Controls.Add(this.btnAssignment);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmArrayInfo";
            this.Text = "Array Info";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAssignment;
        private System.Windows.Forms.Button btnDirect;
        private System.Windows.Forms.Button btnInputBox;
        private System.Windows.Forms.Button btnDataFile;
        private System.Windows.Forms.Button btnAverageApp;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListView LstInfo;
    }
}

