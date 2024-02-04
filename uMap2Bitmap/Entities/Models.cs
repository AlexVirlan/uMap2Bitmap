using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uMap2Bitmap.Entities
{
    /// <summary>
    /// For more info see <see href="https://chromedevtools.github.io/devtools-protocol/tot/Page/#method-captureScreenshot">this article.</see>
    /// </summary>
    public class PageCapture
    {
        #region Properties
        /// <summary>
        /// Image compression format (defaults to png). Allowed Values: jpeg, png, webp.
        /// </summary>
        [JsonProperty("format")]
        [JsonConverter(typeof(StringEnumConverter), converterParameters: typeof(CamelCaseNamingStrategy))]
        public PageCaptureType Format { get; set; }

        /// <summary>
        /// Compression quality from range [0..100] (jpeg only).
        /// </summary>
        [JsonProperty("quality")]
        public int Quality { get; set; }

        /// <summary>
        /// Capture the screenshot of a given region only.
        /// </summary>
        [JsonIgnore]
        [JsonProperty("clip")]
        public PageClip Clip { get; set; }

        /// <summary>
        /// Capture the screenshot from the surface, rather than the view. Defaults to true. EXPERIMENTAL
        /// </summary>
        [JsonProperty("fromSurface")]
        public bool FromSurface { get; set; }

        /// <summary>
        /// Capture the screenshot beyond the viewport. Defaults to false. EXPERIMENTAL
        /// </summary>
        [JsonProperty("captureBeyondViewport")]
        public bool CaptureBeyondViewport { get; set; }

        /// <summary>
        /// Optimize image encoding for speed, not for resulting size (defaults to false). EXPERIMENTAL
        /// </summary>
        [JsonProperty("optimizeForSpeed")]
        public bool OptimizeForSpeed { get; set; }
        #endregion

        #region Constructors

        #endregion
    }

    public class PageClip
    {
        #region Properties
        /// <summary>
        /// X offset in device independent pixels (dip).
        /// </summary>
        [JsonProperty("x")]
        public int X { get; set; }

        /// <summary>
        /// Y offset in device independent pixels (dip).
        /// </summary>
        [JsonProperty("y")]
        public int Y { get; set; }

        /// <summary>
        /// Rectangle width in device independent pixels (dip).
        /// </summary>
        [JsonProperty("width")]
        public int Width { get; set; }

        /// <summary>
        /// Rectangle height in device independent pixels (dip).
        /// </summary>
        [JsonProperty("height")]
        public int Height { get; set; }

        /// <summary>
        /// Page scale factor.
        /// </summary>
        [JsonProperty("scale")]
        public int Scale { get; set; }
        #endregion
    }

    public class Tag
    {
        #region Properties
        public string Name { get; set; }
        public string Value { get; set; }
        #endregion

        #region Constructors
        public Tag(string name, string value)
        {
            Name = name;
            Value = value;
        }
        #endregion
    }

    public class FunctionResponse
    {
        #region Properties
        public bool Error { get; set; }
        public string? Message { get; set; }
        public string? StackTrace { get; set; }
        #endregion

        #region Constructors
        public FunctionResponse()
        {
            Error = false;
        }

        public FunctionResponse(bool error)
        {
            Error = error;
        }

        public FunctionResponse(bool error, string message)
        {
            Error = error;
            Message = message;
        }

        public FunctionResponse(bool error, string message, string stackTrace)
        {
            Error = error;
            Message = message;
            StackTrace = stackTrace;
        }

        public FunctionResponse(Exception exception)
        {
            Error = true;
            Message = exception.Message;
            StackTrace = exception.StackTrace;
        }
        #endregion

        #region Methods
        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.None);
        #endregion
    }

    public class TextEditor
    {
        #region Properties
        public string Name { get; set; }
        public bool Exists { get; set; }
        public string? Path { get; set; }
        #endregion

        #region Constructors
        public TextEditor(string name, bool exists)
        {
            Name = name;
            Exists = exists;
        }

        public TextEditor(string name, bool exists, string path)
        {
            Name = name;
            Exists = exists;
            Path = path;
        }
        #endregion
    }

    public class ComboboxItem
    {
        #region Properties
        public string Text { get; set; }
        public string Value { get; set; }
        #endregion

        #region Constructors
        public ComboboxItem(string text, string value)
        {
            Text = text;
            Value = value;
        }

        public override string ToString()
        {
            return Text;
        }
        #endregion
    }
}
