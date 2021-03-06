﻿using Newtonsoft.Json;

namespace Steam.ApiObjects
{
    internal class ApiLibrary
    {
        [JsonProperty("game_count")]
        public int GameCount { get; private set; }
        [JsonProperty("games")]
        public ApiGame[] Games { get; private set; }

        internal ApiLibrary() { }
    }
}
