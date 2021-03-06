using System.Collections.Generic;

namespace StoryLine.Rest.Services.Http
{
    public interface IRequest
    {
        string Service { get; set; }
        string Method { get; set; }
        string Url { get; set; }
        IReadOnlyDictionary<string, string[]> Headers { get; }
        byte[] Body { get; set; }

        IDictionary<string, object> Properties { get; set; }
    }
}