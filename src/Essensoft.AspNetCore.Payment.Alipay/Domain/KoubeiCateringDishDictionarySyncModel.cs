﻿using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringDishDictionarySyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringDishDictionarySyncModel : AlipayObject
    {
        /// <summary>
        /// 业务字典类型. 定义如下: catetory 分类 ;unit 单位;spec 规格 。
        /// </summary>
        [JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 字典类
        /// </summary>
        [JsonProperty("kb_dish_dictionary")]
        public KbdishDictionary KbDishDictionary { get; set; }

        /// <summary>
        /// 同步类型: add 新增;update 修改;stateChange 状态变更;del删除
        /// </summary>
        [JsonProperty("syn_type")]
        public string SynType { get; set; }
    }
}
