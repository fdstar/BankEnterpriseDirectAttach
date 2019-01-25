using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.13.5手动归集响应主体
    /// </summary>
    public class V1_HWKSUMUPTRNRS : IResponse
    {
        /// <summary>
        /// 3.13.5手动归集响应主体
        /// </summary>
        public HWKSUMUPTRNRS HWKSUMUPTRNRS { get; set; }
    }
    /// <summary>
    /// 3.13.5手动归集响应主体
    /// </summary>
    public class HWKSUMUPTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 如果客户端发送COOKIE，同步的历史记录不包括原有的CLTCOOKIE	非必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string CLTCOOKIE { get; set; }
        /// <summary>
        /// 3.13.5手动归集响应内容
        /// </summary>
        [XmlElement(Order = 3)]
        public HWKSUMUPRS HWKSUMUPRS { get; set; }
    }
    /// <summary>
    /// 3.13.5手动归集响应内容
    /// </summary>
    public class HWKSUMUPRS
    {
        /// <summary>
        /// 3.13.5手工归集响应细节	必回
        /// </summary>
        [XmlElement(Order = 1)]
        public HWKSUMUPINFORS HWKSUMUPINFO { get; set; }
    }
    /// <summary>
    /// 3.13.5手动归集响应细节
    /// </summary>
    public class HWKSUMUPINFORS
    {
        /// <summary>
        /// 结算中心账号,长度18 必回
        /// </summary>
        [XmlElement(Order = 1)]
        public string CENTERACCTID { get; set; }
        /// <summary>
        /// 归集响应信息
        /// </summary>
        [XmlArray("MEMBERACCTS", Order = 2)]
        [XmlArrayItem("MEMBERACCT")]
        public List<MEMBERACCTRS> List { get; set; }
    }
    /// <summary>
    /// 账户归集信息
    /// </summary>
    public class MEMBERACCTRS : Requests.MEMBERACCT
    {
        /// <summary>
        /// 归集结果金额	非必回
        /// </summary>
        [XmlElement(Order = 3)]
        public decimal? SUMUPAMOUNT { get; set; }
        /// <summary>
        /// 交易类型（借(调拨/归集)贷类型）	非必回
        /// </summary>
        [XmlElement(Order = 4)]
        public string TRNTYPE { get; set; }
        /// <summary>
        /// 成员单位额度	非必回
        /// </summary>
        [XmlElement(Order = 5)]
        public decimal? QUOTA { get; set; }
        /// <summary>
        /// 如果归集失败，可能的出错原因	非必回
        /// </summary>
        [XmlElement(Order = 6)]
        public string ERRORINFO { get; set; }
    }
}
