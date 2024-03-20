﻿using BingX.Net.Enums;
using BingX.Net.Objects.Models;
using CryptoExchange.Net.Objects;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace BingX.Net.Interfaces.Clients.PerpetualFuturesApi
{
    /// <summary>
    /// BingX futures trading endpoints, placing and mananging orders.
    /// </summary>
    public interface IBingXRestClientPerpetualFuturesApiTrading
    {
        /// <summary>
        /// Get positions
        /// <para><a href="https://bingx-api.github.io/docs/#/en-us/swapV2/account-api.html#Perpetual%20Swap%20Positions" /></para>
        /// </summary>
        /// <param name="symbol">Symbol</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<IEnumerable<BingXPosition>>> GetPositionsAsync(string? symbol = null, CancellationToken ct = default);

        /// <summary>
        /// Place a new test order. Order won't actually get placed
        /// </summary>
        /// <param name="symbol">Symbol</param>
        /// <param name="side">Order side</param>
        /// <param name="type">Order type</param>
        /// <param name="quantity">Quantity</param>
        /// <param name="price">Limit price</param>
        /// <param name="positionSide">Position side</param>
        /// <param name="reduceOnly">Reduce only</param>
        /// <param name="stopPrice">Stop price</param>
        /// <param name="priceRate">Trailing percentage (between 0 and 1)</param>
        /// <param name="stopLossType">Stop loss type</param>
        /// <param name="stopLossStopPrice">Stop loss trigger price</param>
        /// <param name="stopLossPrice">Stop loss order price</param>
        /// <param name="stopLossTriggerType">Stop loss trigger price type</param>
        /// <param name="stopLossStopGuaranteed">Stop loss stop guaranteed</param>
        /// <param name="takeProfitType">Take profit type</param>
        /// <param name="takeProfitStopPrice">Take profit trigger price</param>
        /// <param name="takeProfitPrice">Take profit order price</param>
        /// <param name="takeProfitTriggerType">Take profit trigger price type</param>
        /// <param name="takeProfitStopGuaranteed">Take profit stop guaranteed</param>
        /// <param name="timeInForce">Time in force</param>
        /// <param name="closePosition">Close the position</param>
        /// <param name="triggerPrice">Trigger price</param>
        /// <param name="stopGuaranteed">Stop guaranteed</param>
        /// <param name="clientOrderId">Client order id</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<BingXFuturesOrder>> PlaceTestOrderAsync(
            string symbol,
            OrderSide side,
            FuturesOrderType type,
            PositionSide positionSide,
            decimal? quantity = null,
            decimal? price = null,
            bool? reduceOnly = null,
            decimal? stopPrice = null,
            decimal? priceRate = null,

            TakeProfitStopLossMode? stopLossType = null,
            decimal? stopLossStopPrice = null,
            decimal? stopLossPrice = null,
            TriggerType? stopLossTriggerType = null,
            bool? stopLossStopGuaranteed = null,

            TakeProfitStopLossMode? takeProfitType = null,
            decimal? takeProfitStopPrice = null,
            decimal? takeProfitPrice = null,
            TriggerType? takeProfitTriggerType = null,
            bool? takeProfitStopGuaranteed = null,

            TimeInForce? timeInForce = null,
            bool? closePosition = null,
            decimal? triggerPrice = null,
            bool? stopGuaranteed = null,
            string? clientOrderId = null,
            CancellationToken ct = default);


        /// <summary>
        /// Place a new order
        /// </summary>
        /// <param name="symbol">Symbol</param>
        /// <param name="side">Order side</param>
        /// <param name="type">Order type</param>
        /// <param name="quantity">Quantity</param>
        /// <param name="price">Limit price</param>
        /// <param name="positionSide">Position side</param>
        /// <param name="reduceOnly">Reduce only</param>
        /// <param name="stopPrice">Stop price</param>
        /// <param name="priceRate">Trailing percentage (between 0 and 1)</param>
        /// <param name="stopLossType">Stop loss type</param>
        /// <param name="stopLossStopPrice">Stop loss trigger price</param>
        /// <param name="stopLossPrice">Stop loss order price</param>
        /// <param name="stopLossTriggerType">Stop loss trigger price type</param>
        /// <param name="stopLossStopGuaranteed">Stop loss stop guaranteed</param>
        /// <param name="takeProfitType">Take profit type</param>
        /// <param name="takeProfitStopPrice">Take profit trigger price</param>
        /// <param name="takeProfitPrice">Take profit order price</param>
        /// <param name="takeProfitTriggerType">Take profit trigger price type</param>
        /// <param name="takeProfitStopGuaranteed">Take profit stop guaranteed</param>
        /// <param name="timeInForce">Time in force</param>
        /// <param name="closePosition">Close the position</param>
        /// <param name="triggerPrice">Trigger price</param>
        /// <param name="stopGuaranteed">Stop guaranteed</param>
        /// <param name="clientOrderId">Client order id</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<BingXFuturesOrder>> PlaceOrderAsync(
            string symbol,
            OrderSide side,
            FuturesOrderType type,
            PositionSide positionSide,
            decimal? quantity = null,
            decimal? price = null,
            bool? reduceOnly = null,
            decimal? stopPrice = null,
            decimal? priceRate = null,

            TakeProfitStopLossMode? stopLossType = null,
            decimal? stopLossStopPrice = null,
            decimal? stopLossPrice = null,
            TriggerType? stopLossTriggerType = null,
            bool? stopLossStopGuaranteed = null,

            TakeProfitStopLossMode? takeProfitType = null,
            decimal? takeProfitStopPrice = null,
            decimal? takeProfitPrice = null,
            TriggerType? takeProfitTriggerType = null,
            bool? takeProfitStopGuaranteed = null,

            TimeInForce? timeInForce = null,
            bool? closePosition = null,
            decimal? triggerPrice = null,
            bool? stopGuaranteed = null,
            string? clientOrderId = null,
            CancellationToken ct = default);

        /// <summary>
        /// Get an order
        /// </summary>
        /// <param name="symbol">Symbol</param>
        /// <param name="orderId">Order id. Either this or clientOrderId should be provided</param>
        /// <param name="clientOrderId">Client order id. Either this or orderId should be provided</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<BingXFuturesOrder>> GetOrderAsync(string symbol, long? orderId = null, string? clientOrderId = null, CancellationToken ct = default);

        /// <summary>
        /// Cancel an order
        /// </summary>
        /// <param name="symbol">Symbol</param>
        /// <param name="orderId">Order id. Either this or clientOrderId should be provided</param>
        /// <param name="clientOrderId">Client order id. Either this or orderId should be provided</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<BingXFuturesOrder>> CancelOrderAsync(string symbol, long? orderId = null, string? clientOrderId = null, CancellationToken ct = default);
    }
}