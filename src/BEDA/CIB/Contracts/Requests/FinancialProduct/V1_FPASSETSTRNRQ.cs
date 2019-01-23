using BEDA.CIB.Contracts.Responses;
using BEDA.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 3.8.5理产产品客户理财资产信息查询请求主体
    /// </summary>
    public class V1_FPASSETSTRNRQ : IRequest<V1_FPASSETSTRNRS>
    {
        /// <summary>
        /// 3.8.5理产产品客户理财资产信息查询请求主体
        /// </summary>
        public FPASSETSTRNRQ FPASSETSTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.8.5理产产品客户理财资产信息查询请求主体
    /// </summary>
    public class FPASSETSTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.8.5理产产品客户理财资产信息查询请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public FPASSETSTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.8.5理产产品客户理财资产信息查询请求内容
    /// </summary>
    public class FPASSETSTRN_RQBODY
    {
        /// <summary>
        /// PAGE查询页码，每页100笔，不输默认第1页，必输
        /// </summary>
        [XmlAttribute]
        public int PAGE { get; set; } = 1;
        /// <summary>
        /// 交易种类    
        /// 7 或 0产品余额查询  
        /// 8 或 1当日交易明细 
        /// 9 或 2历史交易明细 
        /// 6 可撤单交易查询 必输
        /// </summary>
        [XmlElement(Order = 0)]
        public int TRNTYPE { get; set; }
        /// <summary>
        /// 账户代号代号，最长32位	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 产品代码，8位	非必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string PRODNO { get; set; }
        /// <summary>
        /// 起始日期YYYY-MM-DD	非必输，当交易种类为2或9时输入
        /// </summary>
        [XmlIgnore]
        public DateTime? DTSTART { get; set; }
        /// <summary>
        /// 起始日期YYYY-MM-DD ,对应<see cref="DTSTART"/> 非必输，当交易种类为2或9时输入
        /// </summary>
        [XmlElement("DTSTART", Order = 3)]
        public string DTSTARTStr
        {
            get
            {
                return this.DTSTART?.ToString("yyyy-MM-dd");
            }
            set
            {
                this.DTSTART = value.TryConvert<DateTime>();
            }
        }
        /// <summary>
        /// 终止日期YYYY-MM-DD	非必输，当交易种类为2或9时输入
        /// </summary>
        [XmlIgnore]
        public DateTime? DTEND { get; set; }
        /// <summary>
        /// 终止日期YYYY-MM-DD ,对应<see cref="DTEND"/>	非必输，当交易种类为2或9时输入
        /// </summary>
        [XmlElement("DTEND", Order = 4)]
        public string DTENDStr
        {
            get
            {
                return this.DTEND?.ToString("yyyy-MM-dd");
            }
            set
            {
                this.DTEND = value.TryConvert<DateTime>();
            }
        }
    }
}
