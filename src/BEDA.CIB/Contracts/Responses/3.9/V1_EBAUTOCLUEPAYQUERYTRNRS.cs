using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.9.1.13电子商业汇票自动提示付款结果查询响应主体
    /// </summary>
    public class V1_EBAUTOCLUEPAYQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 3.9.1.13电子商业汇票自动提示付款结果查询响应主体
        /// </summary>
        public EBAUTOCLUEPAYQUERYTRNRS EBAUTOCLUEPAYQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.9.1.13电子商业汇票自动提示付款结果查询响应主体
    /// </summary>
    public class EBAUTOCLUEPAYQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.9.1.13电子商业汇票自动提示付款结果查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBAUTOCLUEPAYQUERYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.9.1.13电子商业汇票自动提示付款结果查询响应内容
    /// </summary>
    public class EBAUTOCLUEPAYQUERYTRN_RSBODY
    {
        /// <summary>
        /// MORE是否有下一页，Y有，N无
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 3.9.1.13电子商业汇票自动提示付款结果查询响应集合
        /// </summary>
        [XmlElement("CONTENT", Order = 0)]
        public List<EBAUTOCLUEPAYQUERYTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.9.1.13电子商业汇票自动提示付款结果查询响应明细
    /// </summary>
    public class EBAUTOCLUEPAYQUERYTRN_CONTENT
    {
        /// <summary>
        /// 查询账号
        /// </summary>
        [XmlElement(Order = 1)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 票据号码
        /// </summary>
        [XmlElement(Order = 2)]
        public string BILLCODE { get; set; }
        /// <summary>
        /// 票据金额
        /// </summary>
        [XmlElement(Order = 3)]
        public decimal BILLAMT { get; set; }
        /// <summary>
        /// 票据状态
        /// </summary>
        [XmlElement(Order = 4)]
        public string BILLSTATUS { get; set; }
        /// <summary>
        /// 人行处理结果
        /// </summary>
        [XmlElement(Order = 5)]
        public string RESULT { get; set; }
        /// <summary>
        /// 处理状态
        /// </summary>
        [XmlElement(Order = 6)]
        public string STATUS { get; set; }
    }
}
