﻿using Newtonsoft.Json;

namespace InstagramApi.ResponseWrappers
{
    public class InstaFeedResponse
    {
        public bool IsFirstResponse { get; set; } = true;

        [JsonProperty("feed")]
        public InstaFeedResponseItem Feed { get; set; }

        [JsonProperty("suggestedUsersList")]
        public InstaResponseSuggestedUsers SuggestedUsers { get; set; }
    }
}