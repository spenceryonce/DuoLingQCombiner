using DuoLingQCombiner.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuoLingQCombiner
{
    

    

    public class DuolingoUserConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(DuolingoUser);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var duolingoUser = value as DuolingoUser;

            writer.WriteStartObject();
            writer.WritePropertyName("id");
            writer.WriteValue(duolingoUser.id);
            writer.WritePropertyName("username");
            writer.WriteValue(duolingoUser.username);
            writer.WritePropertyName("email");
            writer.WriteValue(duolingoUser.email);
            writer.WritePropertyName("rupees");
            writer.WriteValue(duolingoUser.rupees);
            writer.WritePropertyName("created");
            writer.WriteValue(duolingoUser.created);
            writer.WritePropertyName("learning_language");
            writer.WriteValue(duolingoUser.learning_language);

            foreach (var item in duolingoUser.last_streak)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteValue(item.Value);
            }
            writer.WriteEndObject();

            foreach (var item in duolingoUser.fields)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteValue(item.Value);
            }
            writer.WriteEndObject();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var duoUser = existingValue as DuolingoUser ?? new DuolingoUser();

            while (reader.Read())
            {
                if (reader.TokenType == JsonToken.EndObject) continue;

                var value = reader.Value.ToString();
                switch (value)
                {
                    case "id":
                        duoUser.id = reader.ReadAsString();
                        break;
                    case "username":
                         duoUser.username = reader.ReadAsString();
                        break;
                    case "email":
                        duoUser.email = reader.ReadAsString();
                        break;
                    case "rupees":
                        duoUser.rupees = (int)reader.ReadAsInt32();
                        break;
                    case "created":
                        duoUser.created = reader.ReadAsString();
                        break;
                    case "learning_language":
                        duoUser.learning_language = reader.ReadAsString();
                        break;
                    case "last_streak":
                        duoUser.last_streak.Add(value, reader.ReadAsString());
                        break;
                    default:
                        duoUser.fields.Add(value, reader.ReadAsString());
                        break;
                }

            }

            return duoUser;
        }
    }
}
