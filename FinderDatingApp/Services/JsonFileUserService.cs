using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using FinderDatingApp.models;
using Microsoft.AspNetCore.Hosting;

namespace FinderDatingApp.Services
{
    public class JsonFileUserService
    {
        // Constructor || Allows us to retrive the json file
        // IWebHostEnvironment
        public JsonFileUserService(IWebHostEnvironment webHostEnvironment)
            {
                WebHostEnvironment = webHostEnvironment;
            }

            public IWebHostEnvironment WebHostEnvironment { get; }

            // Get's the path to the json file in the wwwRoot path
            private string JsonFileName => Path.Combine(WebHostEnvironment.WebRootPath, "data", "FinderData.json");

            // IEnumerable => is stuff you can foreach over
            // Deserialize => Convert to a CSharp Object
            // SERIALIZE => Object to Json
            public IEnumerable<User> GetUsers()
            {
                using (var jsonFileReader = File.OpenText(JsonFileName))
                {
                    return JsonSerializer.Deserialize<User[]>(jsonFileReader.ReadToEnd(),
                        new JsonSerializerOptions
                        {
                          PropertyNameCaseInsensitive = true
                        });
                }
        }

    }
}
