﻿using JsonSubTypes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Notion.Client
{
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(RichTextText), RichTextType.Text)]
    [JsonSubtypes.KnownSubType(typeof(RichTextEquation), RichTextType.Equation)]
    [JsonSubtypes.KnownSubType(typeof(RichTextMention), RichTextType.Mention)]
    public class RichTextBase
    {
        [JsonProperty("plain_text")]
        public string PlainText { get; set; }

        public string Href { get; set; }

        public Annotations Annotations { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public virtual RichTextType Type { get; set; }
    }

    public class Annotations
    {
        [JsonProperty("bold")]
        public bool IsBold { get; set; }

        [JsonProperty("italic")]
        public bool IsItalic { get; set; }

        [JsonProperty("strikethrough")]
        public bool IsStrikeThrough { get; set; }

        [JsonProperty("underline")]
        public bool IsUnderline { get; set; }

        [JsonProperty("code")]
        public bool IsCode { get; set; }

        // color: Color | BackgroundColor
        public string Color { get; set; }
    }
}
