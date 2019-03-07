using ForumApp.Data;
using ForumApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ForumApp.Service
{
    public class ForumAppService : IForum
    {

        private readonly ApplicationDbContext _context;

        public ForumAppService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task Create(Forum forum)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int forumId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ApplicationUser> GetAllApplicationUsers()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Forum> GetAllForums()
        {
            return _context.Forums
                .Include(forum => forum.Posts);
        }

        public Forum GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateForumDescription(int forumId, string newDescription)
        {
            throw new NotImplementedException();
        }

        public Task UpdateForumTitle(int forumId, string newTitle)
        {
            throw new NotImplementedException();
        }
    }
}
