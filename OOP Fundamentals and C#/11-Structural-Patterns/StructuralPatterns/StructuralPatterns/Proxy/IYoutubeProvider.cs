namespace StructuralPatterns.Facade
{
    public interface IYoutubeProvider
    {
        public void ListVideos();

        public void GetVideo(int id);

        public void DownloadVideo();
    }
}