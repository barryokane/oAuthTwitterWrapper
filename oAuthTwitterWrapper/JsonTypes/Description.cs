﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace OAuthTwitterWrapper.JsonTypes
{

    public class Description
    {

        [JsonProperty("urls")]
        public object[] Urls { get; set; }
    }

}