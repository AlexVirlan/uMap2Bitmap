using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uMap2Bitmap.Entities
{
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
