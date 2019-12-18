namespace KSU.CIS300.BTrees
{
    partial class NameLookup
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
            this.uxMinLabel = new System.Windows.Forms.Label();
            this.uxNumItemsLabel = new System.Windows.Forms.Label();
            this.uxMinDegree = new System.Windows.Forms.NumericUpDown();
            this.uxCount = new System.Windows.Forms.NumericUpDown();
            this.uxMakeTree = new System.Windows.Forms.Button();
            this.uxOpen = new System.Windows.Forms.Button();
            this.uxLookup = new System.Windows.Forms.Button();
            this.uxNameLabel = new System.Windows.Forms.Label();
            this.uxName = new System.Windows.Forms.TextBox();
            this.uxFrequencyLabel = new System.Windows.Forms.Label();
            this.uxRankLabel = new System.Windows.Forms.Label();
            this.uxFrequency = new System.Windows.Forms.TextBox();
            this.uxRank = new System.Windows.Forms.TextBox();
            this.uxOpenDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.uxMinDegree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxCount)).BeginInit();
            this.SuspendLayout();
            // 
            // uxMinLabel
            // 
            this.uxMinLabel.AutoSize = true;
            this.uxMinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uxMinLabel.Location = new System.Drawing.Point(24, 29);
            this.uxMinLabel.Name = "uxMinLabel";
            this.uxMinLabel.Size = new System.Drawing.Size(198, 29);
            this.uxMinLabel.TabIndex = 0;
            this.uxMinLabel.Text = "Minimum Degree";
            // 
            // uxNumItemsLabel
            // 
            this.uxNumItemsLabel.AutoSize = true;
            this.uxNumItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uxNumItemsLabel.Location = new System.Drawing.Point(23, 70);
            this.uxNumItemsLabel.Name = "uxNumItemsLabel";
            this.uxNumItemsLabel.Size = new System.Drawing.Size(190, 29);
            this.uxNumItemsLabel.TabIndex = 1;
            this.uxNumItemsLabel.Text = "Number of Items";
            // 
            // uxMinDegree
            // 
            this.uxMinDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uxMinDegree.Location = new System.Drawing.Point(228, 27);
            this.uxMinDegree.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.uxMinDegree.Name = "uxMinDegree";
            this.uxMinDegree.Size = new System.Drawing.Size(104, 35);
            this.uxMinDegree.TabIndex = 2;
            this.uxMinDegree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.uxMinDegree.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // uxCount
            // 
            this.uxCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uxCount.Location = new System.Drawing.Point(228, 68);
            this.uxCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uxCount.Name = "uxCount";
            this.uxCount.Size = new System.Drawing.Size(104, 35);
            this.uxCount.TabIndex = 3;
            this.uxCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.uxCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // uxMakeTree
            // 
            this.uxMakeTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.uxMakeTree.Location = new System.Drawing.Point(352, 31);
            this.uxMakeTree.Name = "uxMakeTree";
            this.uxMakeTree.Size = new System.Drawing.Size(222, 63);
            this.uxMakeTree.TabIndex = 4;
            this.uxMakeTree.Text = "Make Tree";
            this.uxMakeTree.UseVisualStyleBackColor = true;
            this.uxMakeTree.Click += new System.EventHandler(this.UxMakeTree_Click);
            // 
            // uxOpen
            // 
            this.uxOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.uxOpen.Location = new System.Drawing.Point(29, 121);
            this.uxOpen.Name = "uxOpen";
            this.uxOpen.Size = new System.Drawing.Size(545, 51);
            this.uxOpen.TabIndex = 5;
            this.uxOpen.Text = "Open Data File";
            this.uxOpen.UseVisualStyleBackColor = true;
            this.uxOpen.Click += new System.EventHandler(this.UxOpen_Click);
            // 
            // uxLookup
            // 
            this.uxLookup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.uxLookup.Location = new System.Drawing.Point(29, 244);
            this.uxLookup.Name = "uxLookup";
            this.uxLookup.Size = new System.Drawing.Size(545, 51);
            this.uxLookup.TabIndex = 6;
            this.uxLookup.Text = "Get Statistics";
            this.uxLookup.UseVisualStyleBackColor = true;
            this.uxLookup.Click += new System.EventHandler(this.UxLookup_Click);
            // 
            // uxNameLabel
            // 
            this.uxNameLabel.AutoSize = true;
            this.uxNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.uxNameLabel.Location = new System.Drawing.Point(23, 190);
            this.uxNameLabel.Name = "uxNameLabel";
            this.uxNameLabel.Size = new System.Drawing.Size(115, 33);
            this.uxNameLabel.TabIndex = 7;
            this.uxNameLabel.Text = "Name: ";
            // 
            // uxName
            // 
            this.uxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.uxName.Location = new System.Drawing.Point(144, 187);
            this.uxName.Name = "uxName";
            this.uxName.Size = new System.Drawing.Size(430, 40);
            this.uxName.TabIndex = 8;
            // 
            // uxFrequencyLabel
            // 
            this.uxFrequencyLabel.AutoSize = true;
            this.uxFrequencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.uxFrequencyLabel.Location = new System.Drawing.Point(23, 310);
            this.uxFrequencyLabel.Name = "uxFrequencyLabel";
            this.uxFrequencyLabel.Size = new System.Drawing.Size(171, 33);
            this.uxFrequencyLabel.TabIndex = 9;
            this.uxFrequencyLabel.Text = "Frequency:";
            // 
            // uxRankLabel
            // 
            this.uxRankLabel.AutoSize = true;
            this.uxRankLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.uxRankLabel.Location = new System.Drawing.Point(23, 370);
            this.uxRankLabel.Name = "uxRankLabel";
            this.uxRankLabel.Size = new System.Drawing.Size(96, 33);
            this.uxRankLabel.TabIndex = 10;
            this.uxRankLabel.Text = "Rank:";
            // 
            // uxFrequency
            // 
            this.uxFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.uxFrequency.Location = new System.Drawing.Point(200, 307);
            this.uxFrequency.Name = "uxFrequency";
            this.uxFrequency.ReadOnly = true;
            this.uxFrequency.Size = new System.Drawing.Size(374, 40);
            this.uxFrequency.TabIndex = 11;
            // 
            // uxRank
            // 
            this.uxRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.uxRank.Location = new System.Drawing.Point(125, 367);
            this.uxRank.Name = "uxRank";
            this.uxRank.ReadOnly = true;
            this.uxRank.Size = new System.Drawing.Size(449, 40);
            this.uxRank.TabIndex = 12;
            // 
            // uxOpenDialog
            // 
            this.uxOpenDialog.FileName = "openFileDialog1";
            // 
            // NameLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 434);
            this.Controls.Add(this.uxRank);
            this.Controls.Add(this.uxFrequency);
            this.Controls.Add(this.uxRankLabel);
            this.Controls.Add(this.uxFrequencyLabel);
            this.Controls.Add(this.uxName);
            this.Controls.Add(this.uxNameLabel);
            this.Controls.Add(this.uxLookup);
            this.Controls.Add(this.uxOpen);
            this.Controls.Add(this.uxMakeTree);
            this.Controls.Add(this.uxCount);
            this.Controls.Add(this.uxMinDegree);
            this.Controls.Add(this.uxNumItemsLabel);
            this.Controls.Add(this.uxMinLabel);
            this.Name = "NameLookup";
            this.Text = "B Trees";
            ((System.ComponentModel.ISupportInitialize)(this.uxMinDegree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxMinLabel;
        private System.Windows.Forms.Label uxNumItemsLabel;
        private System.Windows.Forms.NumericUpDown uxMinDegree;
        private System.Windows.Forms.NumericUpDown uxCount;
        private System.Windows.Forms.Button uxMakeTree;
        private System.Windows.Forms.Button uxOpen;
        private System.Windows.Forms.Button uxLookup;
        private System.Windows.Forms.Label uxNameLabel;
        private System.Windows.Forms.TextBox uxName;
        private System.Windows.Forms.Label uxFrequencyLabel;
        private System.Windows.Forms.Label uxRankLabel;
        private System.Windows.Forms.TextBox uxFrequency;
        private System.Windows.Forms.TextBox uxRank;
        private System.Windows.Forms.OpenFileDialog uxOpenDialog;
    }
}

