﻿using CryptoExchange.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BingX.Net.Enums
{
    /// <summary>
    /// Order type
    /// </summary>
    public enum OrderType
    {
        /// <summary>
        /// Market order
        /// </summary>
        [Map("MARKET")]
        Market,
        /// <summary>
        /// Limit order
        /// </summary>
        [Map("LIMIT")]
        Limit,
        /// <summary>
        /// Stop limit order
        /// </summary>
        [Map("TAKE_STOP_LIMIT")]
        StopLimit,
        /// <summary>
        /// Stop market order
        /// </summary>
        [Map("TAKE_STOP_MARKET")]
        StopMarket,
        /// <summary>
        /// Trigger limit order
        /// </summary>
        [Map("TRIGGER_LIMIT")]
        TriggerLimit,
        /// <summary>
        /// Trigger market order
        /// </summary>
        [Map("TRIGGER_MARKET")]
        TriggerMarket
    }
}
