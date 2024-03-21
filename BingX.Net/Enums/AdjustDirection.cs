﻿using CryptoExchange.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BingX.Net.Enums
{
    /// <summary>
    /// Direction to adjust in
    /// </summary>
    public enum AdjustDirection
    {
        /// <summary>
        /// Increase
        /// </summary>
        [Map("1")]
        Increase,
        /// <summary>
        /// Decrease
        /// </summary>
        [Map("2")]
        Decrease
    }
}
