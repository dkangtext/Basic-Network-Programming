using System;
using System.Drawing;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace WhiteboardClient
{
    public class PointConverter : JsonConverter<Point>
    {
        public override Point Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.StartObject)
            {
                int x = 0, y = 0;
                while (reader.Read())
                {
                    if (reader.TokenType == JsonTokenType.EndObject)
                        break;

                    if (reader.TokenType == JsonTokenType.PropertyName)
                    {
                        string propertyName = reader.GetString();
                        reader.Read();

                        switch (propertyName?.ToLower())
                        {
                            case "x":
                                x = reader.GetInt32();
                                break;
                            case "y":
                                y = reader.GetInt32();
                                break;
                        }
                    }
                }
                return new Point(x, y);
            }
            return new Point(0, 0);
        }

        public override void Write(Utf8JsonWriter writer, Point value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WriteNumber("x", value.X);
            writer.WriteNumber("y", value.Y);
            writer.WriteEndObject();
        }
    }

    public class SizeConverter : JsonConverter<Size>
    {
        public override Size Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.StartObject)
            {
                int width = 0, height = 0;
                while (reader.Read())
                {
                    if (reader.TokenType == JsonTokenType.EndObject)
                        break;

                    if (reader.TokenType == JsonTokenType.PropertyName)
                    {
                        string propertyName = reader.GetString();
                        reader.Read();

                        switch (propertyName?.ToLower())
                        {
                            case "width":
                                width = reader.GetInt32();
                                break;
                            case "height":
                                height = reader.GetInt32();
                                break;
                        }
                    }
                }
                return new Size(width, height);
            }
            return new Size(0, 0);
        }

        public override void Write(Utf8JsonWriter writer, Size value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WriteNumber("width", value.Width);
            writer.WriteNumber("height", value.Height);
            writer.WriteEndObject();
        }
    }
}