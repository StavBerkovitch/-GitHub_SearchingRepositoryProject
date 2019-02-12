using GitHub_SearchingRepository_StavProject.Adapter;
using Octokit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GitHub_SearchingRepository_StavProject
{
    public partial class SearchRepositoryResultsForm : Form
    {

        Octokit.GitHubClient m_GithubClient=null;
       private Thread m_SearchingValueThread;
       private bool m_PresentingResults=false;
        bool m_InProcess = false;
        String m_searchRepositoryName = null;

        private List<IRepositoryGalleryItem> m_AdapterRepositoriesList = new List<IRepositoryGalleryItem>();
        private List<IRepositoryGalleryItem> m_AdapterBookmarkedRepositoriesList = new List<IRepositoryGalleryItem>();
        
        public SearchRepositoryResultsForm(Octokit.GitHubClient i_GithubClient, String i_searchRepositoryName)
        {
            m_searchRepositoryName = i_searchRepositoryName;
            m_GithubClient=i_GithubClient;

            InitializeComponent();

            m_SearchingValueThread = new Thread(() => searchingRepositoryValue(m_searchRepositoryName));
            m_SearchingValueThread.Start();

            m_SearchRepositoryNameLabel.Text = m_searchRepositoryName;
        }


        private async void searchingRepositoryValue(String i_searchingStringValue)
        {
            this.m_InProcess = true;

            this.progressBarWithLabel.updateLabel("Searching...");

            try
            {
                var request = new SearchRepositoriesRequest(i_searchingStringValue);


                progressBarWithLabel.initProgressBar();
                progressBarWithLabel.updateAddtionProgressBar(30);

                SearchRepositoryResult searchRepositoryResult = await m_GithubClient.Search.SearchRepo(request);

                
                progressBarWithLabel.updateLabel("Loading The resultes...");
                progressBarWithLabel.updateAddtionProgressBar(20);

                if (searchRepositoryResult != null)
                {
                    initAdaptedRepositoryList(searchRepositoryResult);

                    m_InProcess = false;          
                    if (m_AdapterRepositoriesList != null)
                    {
                        progressBarWithLabel.updateLabel("Presenting The resultes...");
                        progressBarWithLabel.updateAddtionProgressBar(20);


                        this.dataGridView1.Invoke( new Action(() =>
                        {
                            m_PresentingResults = true;
                            this.dataGridView1.Visible = true;
                            this.repositoryAdapterBindingSource.DataSource = m_AdapterRepositoriesList;
                            this.m_BookmarkButton.Visible = true;
                            this.m_BookmarkedRepositoryTextBox.Visible = true;
                            this.m_BookmarkLabel.Visible = true;
                        }));

                        
                        progressBarWithLabel.updateNewValueProgressBar(100);
                        progressBarWithLabel.updateLabel("Finished The Search!");
                        
                    } 
                }
                else
                {
                    m_LabelErrorMessage.Text = "There Is No Results For your searching Repository Word!";
                    m_LabelErrorMessage.Visible = true;
                }
                m_InProcess = false;
                m_PresentingResults = false;
                m_SearchingValueThread.Abort();
            }
                
            catch (Exception excption)
            {
                String excptionErrorMessage = excption.Message;
                MessageBox.Show("Error!, There is a problem to get the results!, please exit form and try again");
            }
        }


        private void initAdaptedRepositoryList(SearchRepositoryResult i_searchRepositoryResult)
        {

            foreach(Repository repository in i_searchRepositoryResult.Items)
            {
                m_AdapterRepositoriesList.Add(new RepositoryAdapter(repository));//it is 
            }

        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (this.m_InProcess == true)
            {
                DialogResult dialogResult = MessageBox.Show("Would you like to stop the search?", "Stop Searcing", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    if (m_PresentingResults==true)
                    {
                        MessageBox.Show("It is Presenting the Results, Please Wait");
                    }

                    this.m_SearchingValueThread.Abort();

                    this.m_InProcess = false;
                    base.OnClosing(e);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Would you like to exit Searching Repository Results?", "Exit Searching Repository Results", MessageBoxButtons.YesNo);
                base.OnClosing(e);
            }
        }

        private void SearchRepositoryResultsForm_Load(object sender, EventArgs e)
        {
            this.dataGridView1.Visible = false;
            this.m_LabelErrorMessage.Visible = false;
            this.m_BookmarkButton.Visible = false;
            this.m_BookmarkedRepositoryTextBox.Visible = false;
            this.m_BookmarkLabel.Visible=false;
        }

        private void m_bookmarkButton_Click_1(object sender, EventArgs e)
        {

            m_AdapterBookmarkedRepositoriesList.Clear();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(row.Cells[Bookmark.Name].Value) == true)
                {
                    m_AdapterBookmarkedRepositoriesList.Add((IRepositoryGalleryItem)row.DataBoundItem);
                }
            }

            if (this.m_AdapterBookmarkedRepositoriesList.Count == 0)
            {
                MessageBox.Show("You didn't bookmark repositories");
            }
            else
            {
                MessageBox.Show(String.Format("The {0} Bookmarked Repositories are saved",m_AdapterBookmarkedRepositoriesList.Count));
            }
        }
    }
}
