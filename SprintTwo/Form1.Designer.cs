namespace SprintOne
{
    partial class NeutrinoForm
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
            this.DataInput = new System.Windows.Forms.TextBox();
            this.BTNAddData = new System.Windows.Forms.Button();
            this.DataEditInput = new System.Windows.Forms.TextBox();
            this.BTNEditData = new System.Windows.Forms.Button();
            this.BTNSearch = new System.Windows.Forms.Button();
            this.BTNSortAsc = new System.Windows.Forms.Button();
            this.BTNSortDesc = new System.Windows.Forms.Button();
            this.DataListBox = new System.Windows.Forms.ListBox();
            this.DataSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GenerateRandomData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DataInput
            // 
            this.DataInput.Location = new System.Drawing.Point(132, 36);
            this.DataInput.Name = "DataInput";
            this.DataInput.Size = new System.Drawing.Size(197, 20);
            this.DataInput.TabIndex = 0;
            // 
            // BTNAddData
            // 
            this.BTNAddData.Location = new System.Drawing.Point(24, 33);
            this.BTNAddData.Name = "BTNAddData";
            this.BTNAddData.Size = new System.Drawing.Size(102, 23);
            this.BTNAddData.TabIndex = 1;
            this.BTNAddData.Text = "Add Data Point";
            this.BTNAddData.UseVisualStyleBackColor = true;
            this.BTNAddData.Click += new System.EventHandler(this.BTNAddData_Click);
            // 
            // DataEditInput
            // 
            this.DataEditInput.Location = new System.Drawing.Point(132, 74);
            this.DataEditInput.Name = "DataEditInput";
            this.DataEditInput.Size = new System.Drawing.Size(197, 20);
            this.DataEditInput.TabIndex = 2;
            // 
            // BTNEditData
            // 
            this.BTNEditData.Location = new System.Drawing.Point(24, 72);
            this.BTNEditData.Name = "BTNEditData";
            this.BTNEditData.Size = new System.Drawing.Size(102, 23);
            this.BTNEditData.TabIndex = 3;
            this.BTNEditData.Text = "Edit Data Point";
            this.BTNEditData.UseVisualStyleBackColor = true;
            this.BTNEditData.Click += new System.EventHandler(this.BTNEditData_Click);
            // 
            // BTNSearch
            // 
            this.BTNSearch.Location = new System.Drawing.Point(24, 115);
            this.BTNSearch.Name = "BTNSearch";
            this.BTNSearch.Size = new System.Drawing.Size(102, 27);
            this.BTNSearch.TabIndex = 4;
            this.BTNSearch.Text = "Search Data";
            this.BTNSearch.UseVisualStyleBackColor = true;
            this.BTNSearch.Click += new System.EventHandler(this.BTNSearch_Click);
            // 
            // BTNSortAsc
            // 
            this.BTNSortAsc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BTNSortAsc.Location = new System.Drawing.Point(24, 160);
            this.BTNSortAsc.Name = "BTNSortAsc";
            this.BTNSortAsc.Size = new System.Drawing.Size(117, 42);
            this.BTNSortAsc.TabIndex = 5;
            this.BTNSortAsc.Text = "Sort Data Asc";
            this.BTNSortAsc.UseVisualStyleBackColor = false;
            this.BTNSortAsc.Click += new System.EventHandler(this.BTNSortAsc_Click);
            // 
            // BTNSortDesc
            // 
            this.BTNSortDesc.BackColor = System.Drawing.Color.Lime;
            this.BTNSortDesc.Location = new System.Drawing.Point(24, 225);
            this.BTNSortDesc.Name = "BTNSortDesc";
            this.BTNSortDesc.Size = new System.Drawing.Size(117, 42);
            this.BTNSortDesc.TabIndex = 6;
            this.BTNSortDesc.Text = "Sort Data Desc";
            this.BTNSortDesc.UseVisualStyleBackColor = false;
            this.BTNSortDesc.Click += new System.EventHandler(this.BTNSortDesc_Click);
            // 
            // DataListBox
            // 
            this.DataListBox.FormattingEnabled = true;
            this.DataListBox.Location = new System.Drawing.Point(24, 302);
            this.DataListBox.Name = "DataListBox";
            this.DataListBox.Size = new System.Drawing.Size(305, 186);
            this.DataListBox.TabIndex = 7;
            this.DataListBox.SelectedIndexChanged += new System.EventHandler(this.DataListBox_SelectedIndexChanged);
            // 
            // DataSearch
            // 
            this.DataSearch.Location = new System.Drawing.Point(133, 121);
            this.DataSearch.Name = "DataSearch";
            this.DataSearch.Size = new System.Drawing.Size(196, 20);
            this.DataSearch.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Click on a data point to edit above.";
            // 
            // GenerateRandomData
            // 
            this.GenerateRandomData.Location = new System.Drawing.Point(118, 4);
            this.GenerateRandomData.Name = "GenerateRandomData";
            this.GenerateRandomData.Size = new System.Drawing.Size(117, 23);
            this.GenerateRandomData.TabIndex = 10;
            this.GenerateRandomData.Text = "Generate Data";
            this.GenerateRandomData.UseVisualStyleBackColor = true;
            this.GenerateRandomData.Click += new System.EventHandler(this.GenerateRandomData_Click);
            // 
            // NeutrinoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 511);
            this.Controls.Add(this.GenerateRandomData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataSearch);
            this.Controls.Add(this.DataListBox);
            this.Controls.Add(this.BTNSortDesc);
            this.Controls.Add(this.BTNSortAsc);
            this.Controls.Add(this.BTNSearch);
            this.Controls.Add(this.BTNEditData);
            this.Controls.Add(this.DataEditInput);
            this.Controls.Add(this.BTNAddData);
            this.Controls.Add(this.DataInput);
            this.Name = "NeutrinoForm";
            this.Text = "Neutrino Data Processing App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DataInput;
        private System.Windows.Forms.Button BTNAddData;
        private System.Windows.Forms.TextBox DataEditInput;
        private System.Windows.Forms.Button BTNEditData;
        private System.Windows.Forms.Button BTNSearch;
        private System.Windows.Forms.Button BTNSortAsc;
        private System.Windows.Forms.Button BTNSortDesc;
        private System.Windows.Forms.ListBox DataListBox;
        private System.Windows.Forms.TextBox DataSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GenerateRandomData;
    }
}

