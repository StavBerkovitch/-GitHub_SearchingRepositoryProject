using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GitHub_SearchingRepository_StavProject
{
    public partial class ProgressBarWithLabel : UserControl
    {
        private Label LabelCurrentLoadState;
        private ProgressBar progressBar1;
    
        public ProgressBarWithLabel()
        {

            InitializeComponent();
            this.LabelCurrentLoadState.Text = string.Empty;
        }

        public void updateAddtionProgressBar(int presentToAdd)
        {
            progressBar1.BeginInvoke(new Action(() => progressBar1.Value += presentToAdd));
        }

        public void updateLabel(string informationToPresent)
        {
            LabelCurrentLoadState.Invoke(new Action(() => LabelCurrentLoadState.Text = informationToPresent));
        }

        public void initProgressBar()
        {
            progressBar1.Invoke(new Action(() =>
            {
                progressBar1.Value = 0;
                progressBar1.Visible = true;
            }));
        }

        public void updateNewValueProgressBar(int presentToLoad)
        {
            this.progressBar1.BeginInvoke(new Action(() => progressBar1.Value = 100));
        }

        private void InitializeComponent()
        {
            this.LabelCurrentLoadState = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // LabelCurrentLoadState
            // 
            this.LabelCurrentLoadState.AutoSize = true;
            this.LabelCurrentLoadState.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelCurrentLoadState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCurrentLoadState.Location = new System.Drawing.Point(0, 0);
            this.LabelCurrentLoadState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelCurrentLoadState.Name = "LabelCurrentLoadState";
            this.LabelCurrentLoadState.Size = new System.Drawing.Size(203, 20);
            this.LabelCurrentLoadState.TabIndex = 32;
            this.LabelCurrentLoadState.Text = "LabelCurrentLoadState";
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 27);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(811, 28);
            this.progressBar1.TabIndex = 33;
            // 
            // ProgressBarWithLabel
            // 
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.LabelCurrentLoadState);
            this.Name = "ProgressBarWithLabel";
            this.Size = new System.Drawing.Size(811, 55);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}