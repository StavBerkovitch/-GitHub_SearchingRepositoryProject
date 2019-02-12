namespace GitHub_SearchingRepository_StavProject
{
    partial class SearchRepositoryResultsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Bookmark = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.m_TitleLabel1 = new System.Windows.Forms.Label();
            this.m_SearchRepositoryNameLabel = new System.Windows.Forms.Label();
            this.m_BookmarkButton = new System.Windows.Forms.Button();
            this.m_LabelErrorMessage = new System.Windows.Forms.Label();
            this.m_BookmarkedRepositoryTextBox = new System.Windows.Forms.TextBox();
            this.m_BookmarkLabel = new System.Windows.Forms.Label();
            this.progressBarWithLabel = new GitHub_SearchingRepository_StavProject.ProgressBarWithLabel();
            this.repositoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avatarOwnerImageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.repositoryAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryAdapterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Bookmark,
            this.repositoryNameDataGridViewTextBoxColumn,
            this.avatarOwnerImageDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.repositoryAdapterBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(267, 207);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.Height = 130;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.Size = new System.Drawing.Size(563, 517);
            this.dataGridView1.TabIndex = 20;
            // 
            // Bookmark
            // 
            this.Bookmark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Bookmark.HeaderText = "Bookmark";
            this.Bookmark.Name = "Bookmark";
            this.Bookmark.Width = 77;
            // 
            // m_TitleLabel1
            // 
            this.m_TitleLabel1.AutoSize = true;
            this.m_TitleLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_TitleLabel1.ForeColor = System.Drawing.Color.BlueViolet;
            this.m_TitleLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.m_TitleLabel1.Location = new System.Drawing.Point(33, 21);
            this.m_TitleLabel1.Name = "m_TitleLabel1";
            this.m_TitleLabel1.Size = new System.Drawing.Size(413, 29);
            this.m_TitleLabel1.TabIndex = 21;
            this.m_TitleLabel1.Text = "The Gallery Results for Searching:";
            // 
            // m_SearchRepositoryNameLabel
            // 
            this.m_SearchRepositoryNameLabel.AutoSize = true;
            this.m_SearchRepositoryNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_SearchRepositoryNameLabel.Location = new System.Drawing.Point(475, 21);
            this.m_SearchRepositoryNameLabel.Name = "m_SearchRepositoryNameLabel";
            this.m_SearchRepositoryNameLabel.Size = new System.Drawing.Size(355, 29);
            this.m_SearchRepositoryNameLabel.TabIndex = 22;
            this.m_SearchRepositoryNameLabel.Text = "SearchRepositoryNameLabel";
            // 
            // m_BookmarkButton
            // 
            this.m_BookmarkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.m_BookmarkButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.m_BookmarkButton.Location = new System.Drawing.Point(30, 466);
            this.m_BookmarkButton.Name = "m_BookmarkButton";
            this.m_BookmarkButton.Size = new System.Drawing.Size(162, 53);
            this.m_BookmarkButton.TabIndex = 23;
            this.m_BookmarkButton.Text = "Bookmark";
            this.m_BookmarkButton.UseVisualStyleBackColor = true;
            this.m_BookmarkButton.Click += new System.EventHandler(this.m_bookmarkButton_Click_1);
            // 
            // m_LabelErrorMessage
            // 
            this.m_LabelErrorMessage.AutoSize = true;
            this.m_LabelErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LabelErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.m_LabelErrorMessage.Location = new System.Drawing.Point(54, 84);
            this.m_LabelErrorMessage.Name = "m_LabelErrorMessage";
            this.m_LabelErrorMessage.Size = new System.Drawing.Size(183, 25);
            this.m_LabelErrorMessage.TabIndex = 35;
            this.m_LabelErrorMessage.Text = "LabelErrorMessage";
            // 
            // m_BookmarkedRepositoryTextBox
            // 
            this.m_BookmarkedRepositoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_BookmarkedRepositoryTextBox.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.m_BookmarkedRepositoryTextBox.Location = new System.Drawing.Point(12, 295);
            this.m_BookmarkedRepositoryTextBox.Multiline = true;
            this.m_BookmarkedRepositoryTextBox.Name = "m_BookmarkedRepositoryTextBox";
            this.m_BookmarkedRepositoryTextBox.ReadOnly = true;
            this.m_BookmarkedRepositoryTextBox.Size = new System.Drawing.Size(238, 153);
            this.m_BookmarkedRepositoryTextBox.TabIndex = 37;
            this.m_BookmarkedRepositoryTextBox.Text = "Please Check the Repository you would like to Bookmark and Click on Bookmark Butt" +
    "on";
            // 
            // m_BookmarkLabel
            // 
            this.m_BookmarkLabel.AutoSize = true;
            this.m_BookmarkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_BookmarkLabel.ForeColor = System.Drawing.Color.Red;
            this.m_BookmarkLabel.Location = new System.Drawing.Point(25, 264);
            this.m_BookmarkLabel.Name = "m_BookmarkLabel";
            this.m_BookmarkLabel.Size = new System.Drawing.Size(186, 25);
            this.m_BookmarkLabel.TabIndex = 38;
            this.m_BookmarkLabel.Text = "Bookmark option: ";
            // 
            // progressBarWithLabel
            // 
            this.progressBarWithLabel.Location = new System.Drawing.Point(59, 127);
            this.progressBarWithLabel.Name = "progressBarWithLabel";
            this.progressBarWithLabel.Size = new System.Drawing.Size(831, 63);
            this.progressBarWithLabel.TabIndex = 36;
            // 
            // repositoryNameDataGridViewTextBoxColumn
            // 
            this.repositoryNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.repositoryNameDataGridViewTextBoxColumn.DataPropertyName = "RepositoryName";
            this.repositoryNameDataGridViewTextBoxColumn.HeaderText = "RepositoryName";
            this.repositoryNameDataGridViewTextBoxColumn.Name = "repositoryNameDataGridViewTextBoxColumn";
            this.repositoryNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // avatarOwnerImageDataGridViewImageColumn
            // 
            this.avatarOwnerImageDataGridViewImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.avatarOwnerImageDataGridViewImageColumn.DataPropertyName = "AvatarOwnerImage";
            this.avatarOwnerImageDataGridViewImageColumn.FillWeight = 130F;
            this.avatarOwnerImageDataGridViewImageColumn.HeaderText = "AvatarOwnerImage";
            this.avatarOwnerImageDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.avatarOwnerImageDataGridViewImageColumn.Name = "avatarOwnerImageDataGridViewImageColumn";
            this.avatarOwnerImageDataGridViewImageColumn.ReadOnly = true;
            // 
            // repositoryAdapterBindingSource
            // 
            this.repositoryAdapterBindingSource.DataSource = typeof(GitHub_SearchingRepository_StavProject.Adapter.RepositoryAdapter);
            // 
            // SearchRepositoryResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1328, 799);
            this.Controls.Add(this.m_BookmarkLabel);
            this.Controls.Add(this.m_BookmarkedRepositoryTextBox);
            this.Controls.Add(this.progressBarWithLabel);
            this.Controls.Add(this.m_LabelErrorMessage);
            this.Controls.Add(this.m_BookmarkButton);
            this.Controls.Add(this.m_SearchRepositoryNameLabel);
            this.Controls.Add(this.m_TitleLabel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SearchRepositoryResultsForm";
            this.Text = "GalleryResultsForm";
            this.Load += new System.EventHandler(this.SearchRepositoryResultsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryAdapterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label m_TitleLabel1;
        private System.Windows.Forms.Label m_SearchRepositoryNameLabel;
        private System.Windows.Forms.BindingSource repositoryAdapterBindingSource;
        private System.Windows.Forms.Button m_BookmarkButton;
        private System.Windows.Forms.Label m_LabelErrorMessage;
        private ProgressBarWithLabel progressBarWithLabel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Bookmark;
        private System.Windows.Forms.DataGridViewTextBoxColumn repositoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn avatarOwnerImageDataGridViewImageColumn;
        private System.Windows.Forms.TextBox m_BookmarkedRepositoryTextBox;
        private System.Windows.Forms.Label m_BookmarkLabel;
    }
}