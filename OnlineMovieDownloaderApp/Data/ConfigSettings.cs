using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OnlineMovieDownloaderApp.Data
{
    static class ConfigSettings
    {
        // 
        // returns Database Connection String
        //
        public static string GetConnectionString()
        {
            return Program.config.GetConnectionString("defaultDb");
        }
        //
        // returns logged in user id
        //
        public static string GetUserId()
        {
            string filePath = Program.config.GetSection("UserSecretPath").Value;
            string text = File.ReadAllText(filePath);
            var result = System.Text.Json.JsonSerializer.Deserialize<IdentityUser>(text);

            return result.UserId;

        }
        //
        // set user id to file
        //
        public static void SetUserId(string id)
        {
            string filePath = Program.config.GetSection("UserSecretPath").Value;
            var json = File.ReadAllText(filePath);

            var jsonSettings = new JsonSerializerSettings();
            jsonSettings.Converters.Add(new ExpandoObjectConverter());
            jsonSettings.Converters.Add(new StringEnumConverter());

            var config = JsonConvert.DeserializeObject<IdentityUser>(json, jsonSettings);
            config.UserId = id;

            var newJson = JsonConvert.SerializeObject(config, Formatting.Indented, jsonSettings);

            File.WriteAllText(filePath, newJson);
        }
        //
        // returns Movies directory
        //
        public static string GetMovieDir()
        {
            return Program.config.GetSection("UploadedFilesDir")["movieDir"];
        }
        //
        // returns Thumbnail directory
        //
        public static string GetThumbnailDir()
        {
            return Program.config.GetSection("UploadedFilesDir")["thumbnailDir"];
        }
    }
    class IdentityUser
    {
        public string UserId { get; set; }
    }
}
