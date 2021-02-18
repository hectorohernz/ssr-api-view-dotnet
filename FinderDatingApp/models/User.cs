using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FinderDatingApp.models
{
    public class User
    {
        public int Id { get; set; }
        public string email { get; set; }
        public string fullName { get; set; }
        public string jobTitle { get; set; }
        public string quote { get; set; }
        public string race  { get; set; }
        public string job  { get; set; }

        [JsonPropertyName("img")]
        public string userProfileImage { get; set; }


        public override string ToString() => JsonSerializer.Serialize<User>(this);
  

    }
}
