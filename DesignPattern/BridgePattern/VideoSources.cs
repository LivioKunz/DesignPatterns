namespace BridgePattern
{
    //https://www.codeproject.com/Articles/434352/Understanding-and-Implementing-Bridge-Pattern-in-C

    public interface IVideoSource
    {
        string GetTvGuide();
        string PlayVideo();
    }

    public class LocalCableTv : IVideoSource
    {
        public string GetTvGuide()
        {
            return $"Getting TV Guide From {nameof(LocalCableTv)}";
        }

        public string PlayVideo()
        {
            return $"Playing {nameof(LocalCableTv)}";
        }
    }

    public class LocalDishTv : IVideoSource
    {
        public string GetTvGuide()
        {
            return $"Getting Tv Guide from {nameof(LocalCableTv)}";
        }

        public string PlayVideo()
        {
            return $"Playing {nameof(LocalCableTv)}";
        }
    }

    public class InternetTv : IVideoSource
    {
        public string GetTvGuide()
        {
            return $"Getting tv guide from {nameof(InternetTv)}";
        }

        public string PlayVideo()
        {
            return $"playing {nameof(InternetTv)}";
        }
    }
}