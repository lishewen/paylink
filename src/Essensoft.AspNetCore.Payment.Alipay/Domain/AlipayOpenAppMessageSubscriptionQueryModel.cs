﻿using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppMessageSubscriptionQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppMessageSubscriptionQueryModel : AlipayObject
    {
        /// <summary>
        /// 授权令牌
        /// </summary>
        [JsonProperty("auth_token")]
        public string AuthToken { get; set; }

        /// <summary>
        /// 授权类型，例如app_auth表示三方应用授权
        /// </summary>
        [JsonProperty("auth_type")]
        public string AuthType { get; set; }

        /// <summary>
        /// 消息主题名称
        /// </summary>
        [JsonProperty("topic")]
        public string Topic { get; set; }
    }
}
