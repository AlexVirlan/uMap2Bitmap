namespace uMap2Bitmap.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public partial class UMapData
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("geometry")]
        public UMapDataGeometry Geometry { get; set; }

        [JsonProperty("properties")]
        public UMapDataProperties Properties { get; set; }

        [JsonProperty("uri")]
        public Uri Uri { get; set; }

        [JsonProperty("layers")]
        public List<Layer> Layers { get; set; }
    }

    public partial class UMapDataGeometry
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("coordinates")]
        public List<double> Coordinates { get; set; }
    }

    public partial class Layer
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("features")]
        public List<Feature> Features { get; set; }

        [JsonProperty("_umap_options")]
        public UmapOptions UmapOptions { get; set; }
    }

    public partial class Feature
    {
        [JsonProperty("type")]
        public FeatureType Type { get; set; }

        [JsonProperty("properties")]
        public JObject Properties { get; set; }
        //public FeatureProperties Properties { get; set; } // Switch to a JObject to allow access to custom properties from uMap

        [JsonProperty("geometry")]
        public FeatureGeometry Geometry { get; set; }
    }

    public partial class FeatureGeometry
    {
        [JsonProperty("type")]
        public GeometryType Type { get; set; }

        [JsonProperty("coordinates")]
        public List<List<List<Coordinate>>> Coordinates { get; set; }
    }

    [Obsolete("Replaced by a JObject")]
    public partial class FeatureProperties // Dynamic properties, manageable from uMap. Name & description should always be present.
    {
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        //[JsonProperty("Detalii", NullValueHandling = NullValueHandling.Ignore)]
        //public string Detalii { get; set; }

        //[JsonProperty("NrAproxLocuinte", NullValueHandling = NullValueHandling.Ignore)]
        //[JsonConverter(typeof(ParseStringConverter))]
        //public long? NrAproxLocuinte { get; set; }

        //[JsonProperty("NrAproxFirme", NullValueHandling = NullValueHandling.Ignore)]
        //[JsonConverter(typeof(ParseStringConverter))]
        //public long? NrAproxFirme { get; set; }

        //[JsonProperty("CustomField", NullValueHandling = NullValueHandling.Ignore)]
        //[JsonConverter(typeof(ParseStringConverter))]
        //public string? CustomField { get; set; }
    }

    public partial class UmapOptions
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("fill", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Fill { get; set; }

        [JsonProperty("heat", NullValueHandling = NullValueHandling.Ignore)]
        public Overlay Heat { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("cluster", NullValueHandling = NullValueHandling.Ignore)]
        public Overlay Cluster { get; set; }

        [JsonProperty("editMode")]
        public string EditMode { get; set; }

        [JsonProperty("browsable")]
        public bool Browsable { get; set; }

        [JsonProperty("fillColor", NullValueHandling = NullValueHandling.Ignore)]
        public string FillColor { get; set; }

        [JsonProperty("inCaption")]
        public bool InCaption { get; set; }

        [JsonProperty("remoteData")]
        public Overlay RemoteData { get; set; }

        [JsonProperty("fillOpacity", NullValueHandling = NullValueHandling.Ignore)]
        public double? FillOpacity { get; set; }

        [JsonProperty("permissions", NullValueHandling = NullValueHandling.Ignore)]
        public Permissions Permissions { get; set; }

        [JsonProperty("displayOnLoad")]
        public bool DisplayOnLoad { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }
    }

    public partial class Overlay
    {
    }

    public partial class Permissions
    {
        [JsonProperty("edit_status")]
        public long EditStatus { get; set; }
    }

    public partial class UMapDataProperties
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("zoom")]
        public long Zoom { get; set; }

        [JsonProperty("easing")]
        public bool Easing { get; set; }

        [JsonProperty("licence")]
        public Licence Licence { get; set; }

        [JsonProperty("miniMap")]
        public bool MiniMap { get; set; }

        [JsonProperty("overlay")]
        public Overlay Overlay { get; set; }

        [JsonProperty("showLabel")]
        public bool ShowLabel { get; set; }

        [JsonProperty("slideshow")]
        public Overlay Slideshow { get; set; }

        [JsonProperty("tilelayer")]
        public Tilelayer Tilelayer { get; set; }

        [JsonProperty("captionBar")]
        public bool CaptionBar { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("limitBounds")]
        public LimitBounds LimitBounds { get; set; }

        [JsonProperty("moreControl")]
        public bool MoreControl { get; set; }

        [JsonProperty("onLoadPanel")]
        public string OnLoadPanel { get; set; }

        [JsonProperty("shortCredit")]
        public string ShortCredit { get; set; }

        [JsonProperty("zoomControl")]
        public bool ZoomControl { get; set; }

        [JsonProperty("captionMenus")]
        public bool CaptionMenus { get; set; }

        [JsonProperty("embedControl")]
        public bool EmbedControl { get; set; }

        [JsonProperty("scaleControl")]
        public bool ScaleControl { get; set; }

        [JsonProperty("locateControl")]
        public bool LocateControl { get; set; }

        [JsonProperty("searchControl")]
        public bool SearchControl { get; set; }

        [JsonProperty("measureControl")]
        public bool MeasureControl { get; set; }

        [JsonProperty("scrollWheelZoom")]
        public bool ScrollWheelZoom { get; set; }

        [JsonProperty("editinosmControl")]
        public bool EditinosmControl { get; set; }

        [JsonProperty("datalayersControl")]
        public bool DatalayersControl { get; set; }

        [JsonProperty("fullscreenControl")]
        public bool FullscreenControl { get; set; }

        [JsonProperty("tilelayersControl")]
        public bool TilelayersControl { get; set; }

        [JsonProperty("displayPopupFooter")]
        public bool DisplayPopupFooter { get; set; }

        [JsonProperty("popupContentTemplate")]
        public string PopupContentTemplate { get; set; }

        [JsonProperty("permanentCreditBackground")]
        public bool PermanentCreditBackground { get; set; }
    }

    public partial class Licence
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public partial class LimitBounds
    {
        [JsonProperty("east")]
        public double East { get; set; }

        [JsonProperty("west")]
        public double West { get; set; }

        [JsonProperty("north")]
        public double North { get; set; }

        [JsonProperty("south")]
        public double South { get; set; }
    }

    public partial class Tilelayer
    {
        [JsonProperty("tms")]
        public bool Tms { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("maxZoom")]
        public long MaxZoom { get; set; }

        [JsonProperty("minZoom")]
        public long MinZoom { get; set; }

        [JsonProperty("attribution")]
        public string Attribution { get; set; }

        [JsonProperty("url_template")]
        public string UrlTemplate { get; set; }
    }

    public enum GeometryType { MultiPolygon, Polygon };

    public enum FeatureType { Feature };

    public partial struct Coordinate
    {
        public double? Double;
        public List<double> DoubleArray;

        public static implicit operator Coordinate(double Double) => new Coordinate { Double = Double };
        public static implicit operator Coordinate(List<double> DoubleArray) => new Coordinate { DoubleArray = DoubleArray };
    }

    public partial class UMapData
    {
        public static UMapData FromJson(string json) => JsonConvert.DeserializeObject<UMapData>(json, uMap2Bitmap.Entities.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this UMapData self) => JsonConvert.SerializeObject(self, uMap2Bitmap.Entities.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                CoordinateConverter.Singleton,
                GeometryTypeConverter.Singleton,
                FeatureTypeConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class CoordinateConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Coordinate) || t == typeof(Coordinate?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new Coordinate { Double = doubleValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<double>>(reader);
                    return new Coordinate { DoubleArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type Coordinate");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Coordinate)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.DoubleArray != null)
            {
                serializer.Serialize(writer, value.DoubleArray);
                return;
            }
            throw new Exception("Cannot marshal type Coordinate");
        }

        public static readonly CoordinateConverter Singleton = new CoordinateConverter();
    }

    internal class GeometryTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(GeometryType) || t == typeof(GeometryType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "MultiPolygon":
                    return GeometryType.MultiPolygon;
                case "Polygon":
                    return GeometryType.Polygon;
            }
            throw new Exception("Cannot unmarshal type GeometryType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (GeometryType)untypedValue;
            switch (value)
            {
                case GeometryType.MultiPolygon:
                    serializer.Serialize(writer, "MultiPolygon");
                    return;
                case GeometryType.Polygon:
                    serializer.Serialize(writer, "Polygon");
                    return;
            }
            throw new Exception("Cannot marshal type GeometryType");
        }

        public static readonly GeometryTypeConverter Singleton = new GeometryTypeConverter();
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }

    internal class FeatureTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(FeatureType) || t == typeof(FeatureType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "Feature")
            {
                return FeatureType.Feature;
            }
            throw new Exception("Cannot unmarshal type FeatureType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (FeatureType)untypedValue;
            if (value == FeatureType.Feature)
            {
                serializer.Serialize(writer, "Feature");
                return;
            }
            throw new Exception("Cannot marshal type FeatureType");
        }

        public static readonly FeatureTypeConverter Singleton = new FeatureTypeConverter();
    }
}
