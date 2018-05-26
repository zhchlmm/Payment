using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingAdvertisingQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingAdvertisingQueryModel : AlipayObject
    {
        /// <summary>
        /// 广告Id，唯一标识一条广告
        /// </summary>
        [JsonProperty("ad_id")]
        [XmlElement("ad_id")]
        public string AdId { get; set; }
    }
}
