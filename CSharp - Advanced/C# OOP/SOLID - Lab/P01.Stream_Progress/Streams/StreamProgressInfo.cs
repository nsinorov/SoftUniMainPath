using P01.Stream_Progress.Interfaces;
using P01.Stream_Progress.Models;

namespace P01.Stream_Progress.Streams
{
    public class StreamProgressInfo : StreamProgressor
    {
        public StreamProgressInfo(IStreamable file) : base(file)
        {
        }
    }
}
