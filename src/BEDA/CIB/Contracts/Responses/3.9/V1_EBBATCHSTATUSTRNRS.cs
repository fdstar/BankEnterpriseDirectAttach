using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.9.1.9电子商业汇票票据批量状态查询响应主体
    /// </summary>
    public class V1_EBBATCHSTATUSTRNRS : IResponse
    {
        /// <summary>
        /// 3.9.1.9电子商业汇票票据批量状态查询响应主体
        /// </summary>
        public EBBATCHSTATUSTRNRS EBBATCHSTATUSTRNRS { get; set; }
    }
    /// <summary>
    /// 3.9.1.9电子商业汇票票据批量状态查询响应主体
    /// </summary>
    public class EBBATCHSTATUSTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.9.1.9电子商业汇票票据批量状态查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBBATCHSTATUSTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.9.1.9电子商业汇票票据批量状态查询响应内容
    /// </summary>
    public class EBBATCHSTATUSTRN_RSBODY
    {
        /// <summary>
        /// 是否有下一页，Y有，N无
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 3.9.1.9电子商业汇票票据批量状态查询响应集合
        /// </summary>
        [XmlElement("CONTENT", Order = 1)]
        public List<EBBATCHSTATUSTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.9.1.9电子商业汇票票据批量状态查询响应明细
    /// </summary>
    public class EBBATCHSTATUSTRN_CONTENT
    {
        /// <summary>
        /// 小序号,4位
        /// </summary>
        [XmlElement(Order = 0)]
        public int INDX { get; set; }
        /// <summary>
        /// 票据号码,30位
        /// </summary>
        [XmlElement(Order = 1)]
        public string BILLCODE { get; set; }
        /// <summary>
        /// 票据状态,6位见附录3:票据状态表
        /// </summary>
        [XmlElement(Order = 2)]
        public string BILLSTATUS { get; set; }
        /// <summary>
        /// 人行处理码,8位
        /// </summary>
        [XmlElement(Order = 3)]
        public string RSLTID { get; set; }
        /// <summary>
        /// 人行处理信息,最大256位
        /// </summary>
        [XmlElement(Order = 4)]
        public string RSLTMSG { get; set; }
    }
}
