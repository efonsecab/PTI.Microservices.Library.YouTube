using System;
using System.Collections.Generic;
using System.Text;

namespace PTI.Microservices.Library.Models.YoutubeService.GetPlayListItems
{
    /// <summary>
    /// 
    /// </summary>
    public class Default
    {
        /// <summary>
        /// 
        /// </summary>
        public string url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int width { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int height { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class Medium
    {
        /// <summary>
        /// 
        /// </summary>
        public string url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int width { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int height { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class High
    {
        /// <summary>
        /// 
        /// </summary>
        public string url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int width { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int height { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class Standard
    {
        /// <summary>
        /// 
        /// </summary>
        public string url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int width { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int height { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class Thumbnails
    {
        /// <summary>
        /// 
        /// </summary>
        public Default @default { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Medium medium { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public High high { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Standard standard { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class ResourceId
    {
        /// <summary>
        /// 
        /// </summary>
        public string kind { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string videoId { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class Snippet
    {
        /// <summary>
        /// 
        /// </summary>
        public DateTime publishedAt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string channelId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string description { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Thumbnails thumbnails { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string channelTitle { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string playlistId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int position { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public ResourceId resourceId { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class ContentDetails
    {
        /// <summary>
        /// 
        /// </summary>
        public string videoId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime videoPublishedAt { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class Item
    {
        /// <summary>
        /// 
        /// </summary>
        public string kind { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string etag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Snippet snippet { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public ContentDetails contentDetails { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class PageInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public int totalResults { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int resultsPerPage { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class GetPlayListItemsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public string kind { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string etag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string nextPageToken { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<Item> items { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public PageInfo pageInfo { get; set; }
    }
}
