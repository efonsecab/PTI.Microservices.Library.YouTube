# PTI.Microservices.Library.YouTube

This is part of PTI.Microservices.Library set of packages

The purpose of this package is to facilitate the calls to YouTube APIs, while maintaining a consistent usage pattern among the different services in the group

**Examples:**

## Get Channel LatestVideos
    CustomHttpClient customHttpClient = new CustomHttpClient(new CustomHttpClientHandler(null));
    YoutubeService youtubeService = new YoutubeService(null, this.YoutubeConfiguration, customHttpClient);
    var result = await youtubeService.GetChannelLatestVideosAsync(this.TestYoutubeChannelId);

## Get PlayList Items
    CustomHttpClient customHttpClient = new CustomHttpClient(new CustomHttpClientHandler(null));
    YoutubeService youtubeService = new YoutubeService(null, this.YoutubeConfiguration, customHttpClient);
    var result = await youtubeService.GetPlayListItemsAsync(this.TestYoutubePlayListId);