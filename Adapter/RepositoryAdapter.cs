using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Octokit;
using System.Drawing;
using System.IO;
using System.Net;

namespace GitHub_SearchingRepository_StavProject.Adapter
{
    class RepositoryAdapter: IRepositoryGalleryItem 
    {    
        private Repository m_Repository;
        public String RepositoryName 
        {
            get
            {
                
                return m_Repository.Name;
            }
        }


        public Image AvatarOwnerImage
        {
            get
            {
                if (String.IsNullOrEmpty(m_Repository.Owner.AvatarUrl))
                {
                    return null;
                }
                else
                {

                    try
                    {
                        WebClient wc = new WebClient();
                        byte[] bytes = wc.DownloadData(m_Repository.Owner.AvatarUrl);
                        MemoryStream ms = new MemoryStream(bytes);
                        System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
                        return img;
                    }
                    catch
                    {
                        return GitHub_SearchingRepository_StavProject.Properties.Resources.DefultAvatar;
                    }
                }

            }
        }

        public RepositoryAdapter(Repository i_Repository)
        {
            m_Repository = i_Repository;  
        }




    }
}
