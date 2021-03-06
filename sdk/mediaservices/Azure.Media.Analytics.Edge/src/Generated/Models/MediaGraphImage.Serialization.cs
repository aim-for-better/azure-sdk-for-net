// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Media.Analytics.Edge.Models
{
    public partial class MediaGraphImage : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Scale))
            {
                writer.WritePropertyName("scale");
                writer.WriteObjectValue(Scale);
            }
            if (Optional.IsDefined(Format))
            {
                writer.WritePropertyName("format");
                writer.WriteObjectValue(Format);
            }
            writer.WriteEndObject();
        }

        internal static MediaGraphImage DeserializeMediaGraphImage(JsonElement element)
        {
            Optional<MediaGraphImageScale> scale = default;
            Optional<MediaGraphImageFormat> format = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scale"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    scale = MediaGraphImageScale.DeserializeMediaGraphImageScale(property.Value);
                    continue;
                }
                if (property.NameEquals("format"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    format = MediaGraphImageFormat.DeserializeMediaGraphImageFormat(property.Value);
                    continue;
                }
            }
            return new MediaGraphImage(scale.Value, format.Value);
        }
    }
}
