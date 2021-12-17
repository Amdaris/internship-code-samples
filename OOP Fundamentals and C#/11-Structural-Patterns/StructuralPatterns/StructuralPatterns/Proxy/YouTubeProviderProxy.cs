using System;

namespace StructuralPatterns.Facade
{
    public class YouTubeProviderProxy : IYoutubeProvider
    {
        private YouTubeThirdPartyLibrary _youTubeLibrary;

        public YouTubeProviderProxy()
        {
            _youTubeLibrary = new YouTubeThirdPartyLibrary();
        }

        public void DownloadVideo()
        {
            if (IsAuthorized())
            {
                _youTubeLibrary.DownloadVideo();
            }
        }

        public void GetVideo(int id)
        {
            if (IsAuthorized())
            {
                _youTubeLibrary.GetVideo(id);
            }
        }

        public void ListVideos()
        {
            _youTubeLibrary.ListVideos();
        }

        private bool IsAuthorized()
        {
            //some logic here
            return false;
        }
    }
}
