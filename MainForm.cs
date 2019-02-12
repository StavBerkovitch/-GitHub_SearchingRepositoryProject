using Octokit;
using Octokit.Reactive;//for using the connect to gitHub

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace GitHub_SearchingRepository_StavProject
{
    public partial class MainForm : Form
    {

        Octokit.GitHubClient m_GithubClient = null;

        String m_deafultRepositoryTextBoxValue="Please Enter Repository Name here";
        private bool m_InProcess = false;

        public MainForm()
        {
            InitializeComponent();
            this.m_repositorySearchTextBox.Text = m_deafultRepositoryTextBoxValue;

            
        }

        private void m_repositorySearchBottun_Click(object sender, EventArgs e)
        {
            this.m_InProcess = true;

            String searchRepositoryName = m_repositorySearchTextBox.Text;
            if(searchRepositoryName.Equals(m_deafultRepositoryTextBoxValue)||(m_repositorySearchTextBox.Equals(String.Empty)))
            {
                 MessageBox.Show("Illegal Repository Name for searching!");
            }
            else
            {
                Form searchRepositoryResultsForm = new SearchRepositoryResultsForm(m_GithubClient, searchRepositoryName);
                searchRepositoryResultsForm.Show();

            }
        }


        private void loginAndInit()
        {

            try
            {
                m_GithubClient = new GitHubClient(new ProductHeaderValue("GitHubProject_Stav"));


                if (m_GithubClient != null)
                {

                    MessageBox.Show("The Login Successed!");
                    UserFormShown();

                }
            }

            catch (Exception excption)
            {
                MessageBox.Show("The Login Failed!,{0}", excption.Message);
            }
        }

        private void m_loginButton_Click(object sender, EventArgs e)
        {
            this.Invoke((Action)loginAndInit);
        }


        private void UserFormShown()
        {
            this.Invoke(new Action(() => LoginFormRepresent(true)));
        }
        private void LoginFormRepresent(bool I_RepresentUserForm)
        {
            if (I_RepresentUserForm==true)
            {
                m_repositorySearchTextBox.Visible = true;
                m_repositorySearchbottun.Visible = true;
                m_loginButton.Visible = false;
            }
            else
            {
                m_loginButton.Visible = true;
                m_repositorySearchTextBox.Visible = false;
                m_repositorySearchbottun.Visible = false;
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (this.m_InProcess == true)
            {
                DialogResult dialogResult = MessageBox.Show("Would you like to exit the Application?", "Exit Application", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    base.OnClosing(e);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                base.OnClosing(e);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if(m_GithubClient!=null)
            {
                LoginFormRepresent(true);
            }
            else
            {
                LoginFormRepresent(false);
            }
        }

    }
}
