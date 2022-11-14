using Microsoft.Extensions.Logging;
using PTI.Microservices.Library.Configuration;
using PTI.Microservices.Library.Interceptors;
using PTI.Microservices.Library.Models.YoutubeService.GetPlayListItems;
using PTI.Microservices.Library.YouTube.Models.GetChannelLatestVideos;
using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace PTI.Microservices.Library.Services
{
    /// <summary>
    /// Service in cahrge of exposing access to Youtube functionality
    /// </summary>
    public sealed class YoutubeService
    {
        private ILogger<YoutubeService> Logger { get; }
        private YoutubeConfiguration YoutubeConfiguration { get; }
        private CustomHttpClient CustomHttpClient { get; }

        /// <summary>
        /// Creates a new instance of <see cref="YoutubeService"/>
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="youtubeConfiguration"></param>
        /// <param name="customHttpClient"></param>
        public YoutubeService(ILogger<YoutubeService> logger, YoutubeConfiguration youtubeConfiguration,
            CustomHttpClient customHttpClient)
        {
            this.Logger = logger;
            this.YoutubeConfiguration = youtubeConfiguration;
            this.CustomHttpClient = customHttpClient;
        }

        /// <summary>
        /// Gets the items in a given playlist
        /// </summary>
        /// <param name="playListId"></param>
        /// <param name="maxResults"></param>
        /// <param name="pageToken"></param>
        /// <returns></returns>
        public async Task<GetPlayListItemsResponse> GetPlayListItemsAsync(string playListId, int maxResults = 50,
            string pageToken = null)
        {
            try
            {
                string requestUrl = $"https://www.googleapis.com/youtube/v3/playlistItems" +
                    $"?part=contentDetails,snippet" +
                    $"&playlistId={playListId}" +
                    $"&maxResults={maxResults}" +
                    $"&key={this.YoutubeConfiguration.Key}";
                if (!string.IsNullOrWhiteSpace(pageToken))
                    requestUrl += $"&pageToken={pageToken}";
                var result = await this.CustomHttpClient.GetFromJsonAsync<GetPlayListItemsResponse>(requestUrl);
                return result;
            }
            catch (Exception ex)
            {
                this.Logger?.LogError(ex, ex.Message);
                throw;
            }

        }

        public async Task<GetChannelLatestVideosResponse> GetChannelLatestVideosAsync(string channelId, int maxResults = 50, string pageToken = null)
        {
            try
            {
                string requestUrl = $"https://youtube.googleapis.com/youtube/v3/search" +
                    $"?part=snippet" +
                    $"&channelId={channelId}&order=date" +
                    $"&maxResults={maxResults}" +
                    $"&type=video" +
                    $"&key={this.YoutubeConfiguration.Key}";
                if (!string.IsNullOrWhiteSpace(pageToken))
                    requestUrl += $"&pageToken={pageToken}";
                var result = await this.CustomHttpClient
                    .GetFromJsonAsync<GetChannelLatestVideosResponse>(requestUrl);
                return result;
            }
            catch (Exception ex)
            {
                this.Logger?.LogError(ex.Message, ex);
                throw;
            }
        }

    }
}
