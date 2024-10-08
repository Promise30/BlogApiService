﻿using BloggingAPI.Domain.Repositories;

namespace BloggingAPI.Persistence.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private ApplicationDbContext _applicationDbContext;
        private IPostRepository _postRepository;
        private ICommentRepository _commentRepository;
        private ICommentVoteRepository _commentVoteRepository;
        private ITagRepository _tagRepository;
        private IPostTagRepository _postTagRepository;

        public RepositoryManager(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public IPostRepository Post
        {
            get
            {
                if (_postRepository == null)
                {
                    _postRepository = new PostRepository(_applicationDbContext);
                }
                return _postRepository;
            }
        }
        public ICommentRepository Comment
        {
            get
            {
                if (_commentRepository == null)
                {
                    _commentRepository = new CommentRepository(_applicationDbContext);
                }

                return _commentRepository;
            }
        }
        public ICommentVoteRepository CommentVote
        {
            get
            {
                if (_commentVoteRepository == null)
                {
                    _commentVoteRepository = new CommentVoteRepository(_applicationDbContext);
                }

                return _commentVoteRepository;
            }
        }
        public ITagRepository Tag
        {
            get
            {
                if(_tagRepository == null)
                {
                    _tagRepository = new TagRepository(_applicationDbContext);
                }
                return _tagRepository;
            }
        }
        public IPostTagRepository PostTag
        {
            get
            {
                if(_postTagRepository == null)
                {
                    _postTagRepository = new PostTagRepository(_applicationDbContext);
                }
                return _postTagRepository;
            }
        }
        public async Task SaveAsync() => await _applicationDbContext.SaveChangesAsync();
    }
}
