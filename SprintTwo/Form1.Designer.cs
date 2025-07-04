﻿namespace SprintOne
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
            this.components = new System.ComponentModel.Container();
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
            this.meanBTN = new System.Windows.Forms.Button();
            this.medianBTN = new System.Windows.Forms.Button();
            this.modeBTN = new System.Windows.Forms.Button();
            this.rangeBTN = new System.Windows.Forms.Button();
            this.sequentialSearchBTN = new System.Windows.Forms.Button();
            this.meanDataOutput = new System.Windows.Forms.TextBox();
            this.medianDataOutput = new System.Windows.Forms.TextBox();
            this.modeDataOutput = new System.Windows.Forms.TextBox();
            this.rangeDataOutput = new System.Windows.Forms.TextBox();
            this.sequentialSearchInput = new System.Windows.Forms.TextBox();
            this.GeneralToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.midExtremeBTN = new System.Windows.Forms.Button();
            this.midExtremeDataOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DataInput
            // 
            this.DataInput.Location = new System.Drawing.Point(132, 58);
            this.DataInput.Name = "DataInput";
            this.DataInput.Size = new System.Drawing.Size(103, 20);
            this.DataInput.TabIndex = 0;
            this.GeneralToolTip.SetToolTip(this.DataInput, "Values in this field will be added with the add button.");
            // 
            // BTNAddData
            // 
            this.BTNAddData.Location = new System.Drawing.Point(24, 55);
            this.BTNAddData.Name = "BTNAddData";
            this.BTNAddData.Size = new System.Drawing.Size(102, 23);
            this.BTNAddData.TabIndex = 1;
            this.BTNAddData.Text = "Add Data Point";
            this.GeneralToolTip.SetToolTip(this.BTNAddData, "Click here to add the value from the input box.");
            this.BTNAddData.UseVisualStyleBackColor = true;
            this.BTNAddData.Click += new System.EventHandler(this.BTNAddData_Click);
            // 
            // DataEditInput
            // 
            this.DataEditInput.Location = new System.Drawing.Point(132, 94);
            this.DataEditInput.Name = "DataEditInput";
            this.DataEditInput.Size = new System.Drawing.Size(103, 20);
            this.DataEditInput.TabIndex = 2;
            this.GeneralToolTip.SetToolTip(this.DataEditInput, "Selected values will be displayed here for editing.");
            // 
            // BTNEditData
            // 
            this.BTNEditData.Location = new System.Drawing.Point(24, 94);
            this.BTNEditData.Name = "BTNEditData";
            this.BTNEditData.Size = new System.Drawing.Size(102, 23);
            this.BTNEditData.TabIndex = 3;
            this.BTNEditData.Text = "Edit Data Point";
            this.GeneralToolTip.SetToolTip(this.BTNEditData, "Press this after selecting and changing a value to make an edit");
            this.BTNEditData.UseVisualStyleBackColor = true;
            this.BTNEditData.Click += new System.EventHandler(this.BTNEditData_Click);
            // 
            // BTNSearch
            // 
            this.BTNSearch.BackColor = System.Drawing.Color.LightSalmon;
            this.BTNSearch.Location = new System.Drawing.Point(291, 256);
            this.BTNSearch.Name = "BTNSearch";
            this.BTNSearch.Size = new System.Drawing.Size(102, 27);
            this.BTNSearch.TabIndex = 4;
            this.BTNSearch.Text = "Sort and Search";
            this.GeneralToolTip.SetToolTip(this.BTNSearch, "Click to sort the data before searching the data for the entered value.");
            this.BTNSearch.UseVisualStyleBackColor = false;
            this.BTNSearch.Click += new System.EventHandler(this.BTNSearch_Click);
            // 
            // BTNSortAsc
            // 
            this.BTNSortAsc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BTNSortAsc.Location = new System.Drawing.Point(76, 159);
            this.BTNSortAsc.Name = "BTNSortAsc";
            this.BTNSortAsc.Size = new System.Drawing.Size(117, 42);
            this.BTNSortAsc.TabIndex = 5;
            this.BTNSortAsc.Text = "Sort Data Asc";
            this.GeneralToolTip.SetToolTip(this.BTNSortAsc, "Click to sort the data in ascending order.");
            this.BTNSortAsc.UseVisualStyleBackColor = false;
            this.BTNSortAsc.Click += new System.EventHandler(this.BTNSortAsc_Click);
            // 
            // BTNSortDesc
            // 
            this.BTNSortDesc.BackColor = System.Drawing.Color.Lime;
            this.BTNSortDesc.Location = new System.Drawing.Point(76, 207);
            this.BTNSortDesc.Name = "BTNSortDesc";
            this.BTNSortDesc.Size = new System.Drawing.Size(117, 42);
            this.BTNSortDesc.TabIndex = 6;
            this.BTNSortDesc.Text = "Sort Data Desc";
            this.GeneralToolTip.SetToolTip(this.BTNSortDesc, "Click to sort the data in descending order.");
            this.BTNSortDesc.UseVisualStyleBackColor = false;
            this.BTNSortDesc.Click += new System.EventHandler(this.BTNSortDesc_Click);
            // 
            // DataListBox
            // 
            this.DataListBox.FormattingEnabled = true;
            this.DataListBox.HorizontalScrollbar = true;
            this.DataListBox.Location = new System.Drawing.Point(24, 302);
            this.DataListBox.MultiColumn = true;
            this.DataListBox.Name = "DataListBox";
            this.DataListBox.Size = new System.Drawing.Size(502, 186);
            this.DataListBox.TabIndex = 7;
            this.DataListBox.SelectedIndexChanged += new System.EventHandler(this.DataListBox_SelectedIndexChanged);
            // 
            // DataSearch
            // 
            this.DataSearch.Location = new System.Drawing.Point(409, 260);
            this.DataSearch.Name = "DataSearch";
            this.DataSearch.Size = new System.Drawing.Size(102, 20);
            this.DataSearch.TabIndex = 8;
            this.GeneralToolTip.SetToolTip(this.DataSearch, "Enter a search value for the sort and search button.");
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
            this.GenerateRandomData.Location = new System.Drawing.Point(201, 12);
            this.GenerateRandomData.Name = "GenerateRandomData";
            this.GenerateRandomData.Size = new System.Drawing.Size(117, 23);
            this.GenerateRandomData.TabIndex = 10;
            this.GenerateRandomData.Text = "Generate Data";
            this.GenerateRandomData.UseVisualStyleBackColor = true;
            this.GenerateRandomData.Click += new System.EventHandler(this.GenerateRandomData_Click);
            // 
            // meanBTN
            // 
            this.meanBTN.BackColor = System.Drawing.Color.MediumTurquoise;
            this.meanBTN.Location = new System.Drawing.Point(291, 44);
            this.meanBTN.Name = "meanBTN";
            this.meanBTN.Size = new System.Drawing.Size(102, 23);
            this.meanBTN.TabIndex = 11;
            this.meanBTN.Text = "Mean";
            this.GeneralToolTip.SetToolTip(this.meanBTN, "Click to calculate the mean of the data set.");
            this.meanBTN.UseVisualStyleBackColor = false;
            this.meanBTN.Click += new System.EventHandler(this.meanBTN_Click);
            // 
            // medianBTN
            // 
            this.medianBTN.BackColor = System.Drawing.Color.MediumTurquoise;
            this.medianBTN.Location = new System.Drawing.Point(291, 105);
            this.medianBTN.Name = "medianBTN";
            this.medianBTN.Size = new System.Drawing.Size(102, 23);
            this.medianBTN.TabIndex = 12;
            this.medianBTN.Text = "Median";
            this.GeneralToolTip.SetToolTip(this.medianBTN, "Click to calculate the median of the data set.");
            this.medianBTN.UseVisualStyleBackColor = false;
            this.medianBTN.Click += new System.EventHandler(this.medianBTN_Click);
            // 
            // modeBTN
            // 
            this.modeBTN.BackColor = System.Drawing.Color.MediumTurquoise;
            this.modeBTN.Location = new System.Drawing.Point(291, 137);
            this.modeBTN.Name = "modeBTN";
            this.modeBTN.Size = new System.Drawing.Size(102, 23);
            this.modeBTN.TabIndex = 13;
            this.modeBTN.Text = "Mode";
            this.GeneralToolTip.SetToolTip(this.modeBTN, "Click to calculate the mode of the data set.");
            this.modeBTN.UseVisualStyleBackColor = false;
            this.modeBTN.Click += new System.EventHandler(this.modeBTN_Click);
            // 
            // rangeBTN
            // 
            this.rangeBTN.BackColor = System.Drawing.Color.MediumTurquoise;
            this.rangeBTN.Location = new System.Drawing.Point(291, 169);
            this.rangeBTN.Name = "rangeBTN";
            this.rangeBTN.Size = new System.Drawing.Size(102, 23);
            this.rangeBTN.TabIndex = 14;
            this.rangeBTN.Text = "Range";
            this.GeneralToolTip.SetToolTip(this.rangeBTN, "Click to calculate the range of the data set.");
            this.rangeBTN.UseVisualStyleBackColor = false;
            this.rangeBTN.Click += new System.EventHandler(this.rangeBTN_Click);
            // 
            // sequentialSearchBTN
            // 
            this.sequentialSearchBTN.BackColor = System.Drawing.Color.LightSalmon;
            this.sequentialSearchBTN.Location = new System.Drawing.Point(291, 226);
            this.sequentialSearchBTN.Name = "sequentialSearchBTN";
            this.sequentialSearchBTN.Size = new System.Drawing.Size(102, 23);
            this.sequentialSearchBTN.TabIndex = 15;
            this.sequentialSearchBTN.Text = "Search";
            this.GeneralToolTip.SetToolTip(this.sequentialSearchBTN, "Click to search for the input value without sorting the data.");
            this.sequentialSearchBTN.UseVisualStyleBackColor = false;
            this.sequentialSearchBTN.Click += new System.EventHandler(this.sequentialSearchBTN_Click);
            // 
            // meanDataOutput
            // 
            this.meanDataOutput.Location = new System.Drawing.Point(409, 47);
            this.meanDataOutput.Name = "meanDataOutput";
            this.meanDataOutput.ReadOnly = true;
            this.meanDataOutput.Size = new System.Drawing.Size(102, 20);
            this.meanDataOutput.TabIndex = 16;
            this.GeneralToolTip.SetToolTip(this.meanDataOutput, "Display box for calculating the mean.");
            // 
            // medianDataOutput
            // 
            this.medianDataOutput.Location = new System.Drawing.Point(409, 107);
            this.medianDataOutput.Name = "medianDataOutput";
            this.medianDataOutput.ReadOnly = true;
            this.medianDataOutput.Size = new System.Drawing.Size(102, 20);
            this.medianDataOutput.TabIndex = 17;
            this.GeneralToolTip.SetToolTip(this.medianDataOutput, "Display box for calculating the median.");
            // 
            // modeDataOutput
            // 
            this.modeDataOutput.Location = new System.Drawing.Point(409, 140);
            this.modeDataOutput.Name = "modeDataOutput";
            this.modeDataOutput.ReadOnly = true;
            this.modeDataOutput.Size = new System.Drawing.Size(102, 20);
            this.modeDataOutput.TabIndex = 18;
            this.GeneralToolTip.SetToolTip(this.modeDataOutput, "Display box for calculating the mode.");
            // 
            // rangeDataOutput
            // 
            this.rangeDataOutput.Location = new System.Drawing.Point(409, 172);
            this.rangeDataOutput.Name = "rangeDataOutput";
            this.rangeDataOutput.ReadOnly = true;
            this.rangeDataOutput.Size = new System.Drawing.Size(102, 20);
            this.rangeDataOutput.TabIndex = 19;
            this.GeneralToolTip.SetToolTip(this.rangeDataOutput, "Display box for calculating the range.");
            // 
            // sequentialSearchInput
            // 
            this.sequentialSearchInput.Location = new System.Drawing.Point(409, 228);
            this.sequentialSearchInput.Name = "sequentialSearchInput";
            this.sequentialSearchInput.Size = new System.Drawing.Size(102, 20);
            this.sequentialSearchInput.TabIndex = 20;
            this.GeneralToolTip.SetToolTip(this.sequentialSearchInput, "Enter a search value to search without sorting data.");
            // 
            // midExtremeBTN
            // 
            this.midExtremeBTN.BackColor = System.Drawing.Color.MediumTurquoise;
            this.midExtremeBTN.Location = new System.Drawing.Point(291, 76);
            this.midExtremeBTN.Name = "midExtremeBTN";
            this.midExtremeBTN.Size = new System.Drawing.Size(102, 23);
            this.midExtremeBTN.TabIndex = 21;
            this.midExtremeBTN.Text = "Mid-Extreme";
            this.GeneralToolTip.SetToolTip(this.midExtremeBTN, "Click to calculate the mid-extreme of the data set.");
            this.midExtremeBTN.UseVisualStyleBackColor = false;
            this.midExtremeBTN.Click += new System.EventHandler(this.midExtremeBTN_Click);
            // 
            // midExtremeDataOutput
            // 
            this.midExtremeDataOutput.Location = new System.Drawing.Point(409, 78);
            this.midExtremeDataOutput.Name = "midExtremeDataOutput";
            this.midExtremeDataOutput.ReadOnly = true;
            this.midExtremeDataOutput.Size = new System.Drawing.Size(102, 20);
            this.midExtremeDataOutput.TabIndex = 22;
            this.GeneralToolTip.SetToolTip(this.midExtremeDataOutput, "Display box for calculating the mid-extreme.");
            // 
            // NeutrinoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 511);
            this.Controls.Add(this.midExtremeDataOutput);
            this.Controls.Add(this.midExtremeBTN);
            this.Controls.Add(this.sequentialSearchInput);
            this.Controls.Add(this.rangeDataOutput);
            this.Controls.Add(this.modeDataOutput);
            this.Controls.Add(this.medianDataOutput);
            this.Controls.Add(this.meanDataOutput);
            this.Controls.Add(this.sequentialSearchBTN);
            this.Controls.Add(this.rangeBTN);
            this.Controls.Add(this.modeBTN);
            this.Controls.Add(this.medianBTN);
            this.Controls.Add(this.meanBTN);
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
        private System.Windows.Forms.Button meanBTN;
        private System.Windows.Forms.Button medianBTN;
        private System.Windows.Forms.Button modeBTN;
        private System.Windows.Forms.Button rangeBTN;
        private System.Windows.Forms.Button sequentialSearchBTN;
        private System.Windows.Forms.TextBox meanDataOutput;
        private System.Windows.Forms.TextBox medianDataOutput;
        private System.Windows.Forms.TextBox modeDataOutput;
        private System.Windows.Forms.TextBox rangeDataOutput;
        private System.Windows.Forms.TextBox sequentialSearchInput;
        private System.Windows.Forms.ToolTip GeneralToolTip;
        private System.Windows.Forms.Button midExtremeBTN;
        private System.Windows.Forms.TextBox midExtremeDataOutput;
    }
}

