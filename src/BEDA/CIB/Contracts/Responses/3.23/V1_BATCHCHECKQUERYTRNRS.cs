using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.23.2查询批量余额对账指令响应主体
    /// </summary>
    public class V1_BATCHCHECKQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 3.23.2查询批量余额对账指令响应主体
        /// </summary>
        public BATCHCHECKQUERYTRNRS BATCHCHECKQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.23.2查询批量余额对账指令响应主体
    /// </summary>
    public class BATCHCHECKQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.23.2查询批量余额对账指令响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public BATCHCHECKQUERYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.23.2查询批量余额对账指令响应内容
    /// </summary>
    public class BATCHCHECKQUERYTRN_RSBODY
    {
        /// <summary>
        /// 是否有下一页，Y有，N无
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 批次号	必回
        /// </summary>
        [XmlElement(Order = 0)]
        public string BATCHNUM { get; set; }
        /// <summary>
        /// 对账账期	必回
        /// </summary>
        [XmlElement(Order = 1)]
        public string RECONCILEDATE { get; set; }
        /// <summary>
        /// 执行时间	必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string EXCUTETIME { get; set; }
        /// <summary>
        /// 执行状态	必回
        /// </summary>
        [XmlElement(Order = 3)]
        public string EXCUTERESULT { get; set; }
        /// <summary>
        /// 3.23.2查询批量余额对账指令响应集合
        /// </summary>
        [XmlElement("CONTENT", Order = 4)]
        public List<BATCHCHECKQUERYTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.23.2查询批量余额对账指令响应明细
    /// </summary>
    public class BATCHCHECKQUERYTRN_CONTENT
    {
        /// <summary>
        /// 账户类型	非必回
        /// </summary>
        [XmlElement(Order = 0)]
        public string ACCTTYPE { get; set; }
        /// <summary>
        /// 对账账号	必回
        /// </summary>
        [XmlElement(Order = 1)]
        public string RECONCILEACCT { get; set; }
        /// <summary>
        /// 户名	非必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string ACCTNAME { get; set; }
        /// <summary>
        /// 币种	非必回
        /// </summary>
        [XmlElement(Order = 3)]
        public string CURRENCYTYPE { get; set; }
        /// <summary>
        /// 账户余额	必回
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal ACCTBALANCE { get; set; }
        /// <summary>
        /// 对账结果	必回
        /// </summary>
        [XmlElement(Order = 5)]
        public string RECONCILERESULT { get; set; }
    }
}
