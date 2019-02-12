using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Octokit;
using System.Drawing;

namespace GitHub_SearchingRepository_StavProject.Adapter
{
    interface IRepositoryGalleryItem
    {
        String RepositoryName { get; }
        Image AvatarOwnerImage { get; }
    }
}
