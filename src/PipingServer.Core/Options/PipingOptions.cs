﻿using System;
using System.Text;

namespace PipingServer.Core.Options
{
    public class PipingOptions
    {
        /// <summary>
        /// Waiting Timeout Value.
        /// </summary>
        public TimeSpan? WaitingTimeout { get; set; } = null;
        public Encoding Encoding { get; set; } = Encoding.UTF8;
        public string Version { get; set; } = "1.0.0";
        public string EncodingName
        {
            get => Encoding.WebName;
            set => Encoding = Encoding.GetEncoding(value);
        }
        public int BufferSize { get; set; } = 1024 * 4;
        public string? SenderResponseMessageContentType { get; set; } = null;
        public bool EnableContentOfHeadMethod { get; set; } = true;
        public bool EnableContentOfOptionsMethod { get; set; } = true;
    }

}
