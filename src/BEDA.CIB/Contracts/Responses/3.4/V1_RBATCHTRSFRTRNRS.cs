using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.4.8实时批量支付与批量费用(最多100笔)响应主体
    /// </summary>
    public class V1_RBATCHTRSFRTRNRS : IResponse
    {
        /// <summary>
        /// 3.4.8实时批量支付与批量费用(最多100笔)响应
        /// </summary>
        public RBATCHTRSFRTRNRS RBATCHTRSFRTRNRS { get; set; }
    }
    /// <summary>
    /// 3.4.8实时批量支付与批量费用(最多100笔)响应
    /// </summary>
    public class RBATCHTRSFRTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.4.8实时批量支付与批量费用(最多100笔)响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public RBATCHTRSFRTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.4.8实时批量支付与批量费用(最多100笔)响应内容
    /// </summary>
    public class RBATCHTRSFRTRN_RSBODY : Requests.RBATCHTRSFRTRN_RQBODY<RBATCHTRSFRTRNRS_XFERINFO>
    {
        /// <summary>
        /// 批量支付指令处理状态
        /// </summary>
        [XmlElement(Order = 11)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
    /// <summary>
    /// 3.4.8批量收款人信息
    /// </summary>
    public class RBATCHTRSFRTRNRS_XFERINFO : Requests.RBATCHTRSFRTRNRQ_XFERINFO
    {
        /// <summary>
        /// 核心交易处理结果
        /// </summary>
        [XmlElement(Order = 5)]
        public XFERPRCCODEEnum STATUS { get; set; }
        /// <summary>
        /// 核心交易处理结果信息
        /// </summary>
        [XmlElement(Order = 6)]
        public string ERRMSG { get; set; }
    }
}
