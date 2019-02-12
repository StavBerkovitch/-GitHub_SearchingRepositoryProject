namespace GitHub_SearchingRepository_StavProject
{
    partial class MainForm
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
            this.m_label1 = new System.Windows.Forms.Label();
            this.m_repositorySearchTextBox = new System.Windows.Forms.TextBox();
            this.m_repositorySearchbottun = new System.Windows.Forms.Button();
            this.m_loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_label1
            // 
            this.m_label1.AutoSize = true;
            this.m_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_label1.ForeColor = System.Drawing.Color.Navy;
            this.m_label1.Location = new System.Drawing.Point(36, 45);
            this.m_label1.Name = "m_label1";
            this.m_label1.Size = new System.Drawing.Size(344, 36);
            this.m_label1.TabIndex = 0;
            this.m_label1.Text = "GitHub Repository App";
            // 
            // m_repositorySearchTextBox
            // 
            this.m_repositorySearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_repositorySearchTextBox.Location = new System.Drawing.Point(42, 184);
            this.m_repositorySearchTextBox.Name = "m_repositorySearchTextBox";
            this.m_repositorySearchTextBox.Size = new System.Drawing.Size(552, 38);
            this.m_repositorySearchTextBox.TabIndex = 1;
            // 
            // m_repositorySearchbottun
            // 
            this.m_repositorySearchbottun.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_repositorySearchbottun.Location = new System.Drawing.Point(620, 184);
            this.m_repositorySearchbottun.Name = "m_repositorySearchbottun";
            this.m_repositorySearchbottun.Size = new System.Drawing.Size(165, 79);
            this.m_repositorySearchbottun.TabIndex = 2;
            this.m_repositorySearchbottun.Text = "Start Searching";
            this.m_repositorySearchbottun.UseVisualStyleBackColor = true;
            this.m_repositorySearchbottun.Click += new System.EventHandler(this.m_repositorySearchBottun_Click);
            // 
            // m_loginButton
            // 
            this.m_loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_loginButton.Location = new System.Drawing.Point(416, 45);
            this.m_loginButton.Name = "m_loginButton";
            this.m_loginButton.Size = new System.Drawing.Size(141, 58);
            this.m_loginButton.TabIndex = 3;
            this.m_loginButton.Text = "Login";
            this.m_loginButton.UseVisualStyleBackColor = true;
            this.m_loginButton.Click += new System.EventHandler(this.m_loginButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::GitHub_SearchingRepository_StavProject.Properties.Resources.BlueBackground;
            this.ClientSize = new System.Drawing.Size(842, 284);
            this.Controls.Add(this.m_loginButton);
            this.Controls.Add(this.m_repositorySearchbottun);
            this.Controls.Add(this.m_repositorySearchTextBox);
            this.Controls.Add(this.m_label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label m_label1;
        private System.Windows.Forms.TextBox m_repositorySearchTextBox;
        private System.Windows.Forms.Button m_repositorySearchbottun;
        private System.Windows.Forms.Button m_loginButton;
    }
}

