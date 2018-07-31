using System;

namespace BridgePattern
{
    public class SuperSmartTv
    {
        private readonly IVideoSource currentVideoSource = null;

        public IVideoSource VideoSource { get; set; }

        public void ShowTvGuide()
        {
            if (this.currentVideoSource != null)
                Console.WriteLine(this.currentVideoSource.GetTvGuide());
            else
                Console.WriteLine("Please select a Video Source");
        }

        public void PlayTv()
        {
            if (this.currentVideoSource != null)
                Console.WriteLine(this.currentVideoSource.PlayVideo());
            else
                Console.WriteLine("Please select a Video Source");
        }
    }
}