// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Microsoft.Bot.Solutions;
using BlackEagleBot.TokenExchange;

namespace BlackEagleBot.Services
{
    public class BotSettings : BotSettingsBase
    {
        public TokenExchangeConfig TokenExchangeConfig { get; set; }
    }
}