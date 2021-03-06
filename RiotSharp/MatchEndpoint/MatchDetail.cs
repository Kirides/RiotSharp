﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotSharp.MatchEndpoint
{
    /// <summary>
    /// Details about a match (Match API).
    /// </summary>
    public class MatchDetail : MatchSummary
    {
        internal MatchDetail() { }

        /// <summary>
        /// Team information.
        /// </summary>
        [JsonProperty("teams")]
        public List<TeamStats> Teams { get; set; }

        /// <summary>
        /// Match timeline data. Not included by default.
        /// </summary>
        [JsonProperty("timeline")]
        public Timeline Timeline { get; set; }
    }
}
