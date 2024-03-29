﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ForumApp.Data.Models;

namespace ForumApp.Data
{
    public interface IForum
    {
        Forum GetById(int id);
        IEnumerable<Forum> GetAllForums();
        IEnumerable<ApplicationUser> GetAllApplicationUsers();

        Task Create(Forum forum);
        Task Delete(int forumId);
        Task UpdateForumTitle(int forumId, string newTitle);
        Task UpdateForumDescription(int forumId, string newDescription);
    }
}
