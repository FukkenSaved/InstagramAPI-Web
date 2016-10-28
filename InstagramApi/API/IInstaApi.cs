﻿using System.Threading.Tasks;
using InstagramApi.Classes;

namespace InstagramApi.API
{
    public interface IInstaApi
    {
        InstaUser GetUser();
        Task<InstaUser> GetUserAsync();
        InstaPostList GetUserPosts();
        Task<InstaPostList> GetUserPostsAsync();

        InstaMedia GetMediaByCode(string postCode);

        Task<InstaMedia> GetMediaByCodeAsync(string postCode);
    }
}