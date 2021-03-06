using Newtonsoft.Json;
using OmniSharp.Json;

namespace OmniSharp.Models
{
    public abstract class CodeActionRequest : Request
    {
        public int CodeAction { get; set; }
        public bool WantsTextChanges { get; set; }
        [JsonConverter(typeof(ZeroBasedIndexConverter))]
        public int? SelectionStartColumn { get; set; }
        [JsonConverter(typeof(ZeroBasedIndexConverter))]
        public int? SelectionStartLine { get; set; }
        [JsonConverter(typeof(ZeroBasedIndexConverter))]
        public int? SelectionEndColumn { get; set; }
        [JsonConverter(typeof(ZeroBasedIndexConverter))]
        public int? SelectionEndLine { get; set; }
    }
}
