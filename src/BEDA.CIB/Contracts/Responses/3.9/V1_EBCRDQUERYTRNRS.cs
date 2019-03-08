using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.9.1.7电子商业汇票支付信用信息查询响应主体
    /// </summary>
    public class V1_EBCRDQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 3.9.1.7电子商业汇票支付信用信息查询响应主体
        /// </summary>
        public EBCRDQUERYTRNRS EBCRDQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.9.1.7电子商业汇票支付信用信息查询响应主体
    /// </summary>
    public class EBCRDQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.9.1.7电子商业汇票支付信用信息查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBCRDQUERYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.9.1.7电子商业汇票支付信用信息查询响应内容
    /// </summary>
    public class EBCRDQUERYTRN_RSBODY
    {
        /// <summary>
        /// MORE是否有下一页，Y有，N无
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 3.9.1.7电子商业汇票支付信用信息查询响应集合
        /// </summary>
        [XmlElement("CONTENT", Order = 0)]
        public List<EBCRDQUERYTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.9.1.7电子商业汇票支付信用信息查询响应明细
    /// </summary>
    public class EBCRDQUERYTRN_CONTENT
    {
        /// <summary>
        /// 被查询人名称,最大60位
        /// </summary>
        [XmlElement(Order = 1)]
        public string NAME { get; set; }
        /// <summary>
        /// 被查询人组织机构代码,最大10位
        /// </summary>
        [XmlElement(Order = 2)]
        public string ORGID { get; set; }
        /// <summary>
        /// 承兑票据总笔数,8位整数
        /// </summary>
        [XmlElement(Order = 3)]
        public int ACPTCNT { get; set; }
        /// <summary>
        /// 承兑票据总金额,17位(15整数位,2小数位)
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal ACPTAMT { get; set; }
        /// <summary>
        /// 结清票据总笔数,8位整数
        /// </summary>
        [XmlElement(Order = 5)]
        public int CLRDCNT { get; set; }
        /// <summary>
        /// 结清票据总金额,17位(15整数位,2小数位)
        /// </summary>
        [XmlElement(Order = 6)]
        public decimal CLRDAMT { get; set; }
        /// <summary>
        /// 未结清票据总笔数,8位整数
        /// </summary>
        [XmlElement(Order = 7)]
        public int UCLRDCNT { get; set; }
        /// <summary>
        /// 未结清票据总金额,17位(15整数位,2小数位)
        /// </summary>
        [XmlElement(Order = 8)]
        public decimal UCLRDAMT { get; set; }
        /// <summary>
        /// 拒付票据总笔数,8位整数
        /// </summary>
        [XmlElement(Order = 9)]
        public int REPDTCNT { get; set; }
        /// <summary>
        /// 拒付票据总金额,17位(15整数位,2小数位)
        /// </summary>
        [XmlElement(Order = 10)]
        public decimal REPDTAMT { get; set; }
        /// <summary>
        /// 今年拒付总笔数,8位整数
        /// </summary>
        [XmlElement(Order = 11)]
        public int TREPDTCNT { get; set; }
        /// <summary>
        /// 今年拒付总金额,17位(15整数位,2小数位)
        /// </summary>
        [XmlElement(Order = 12)]
        public decimal TREPDTAMT { get; set; }
        /// <summary>
        /// 去年拒付总笔数,8位整数
        /// </summary>
        [XmlElement(Order = 13)]
        public int LREPDTCNT { get; set; }
        /// <summary>
        /// 去年拒付总金额,17位(15整数位,2小数位)
        /// </summary>
        [XmlElement(Order = 14)]
        public decimal LREPDTAMT { get; set; }
    }
}
