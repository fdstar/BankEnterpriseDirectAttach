using BEDA.CIB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 3.10.4跨行账户他行账户明细查询请求主体
    /// </summary>
    public class V1_CRSSTMTTRNRQ : IRequest<V1_CRSSTMTTRNRS>
    {
        /// <summary>
        /// 3.10.4跨行账户他行账户明细查询请求主体
        /// </summary>
        public CRSSTMTTRNRQ CRSSTMTTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.10.4跨行账户他行账户明细查询请求主体
    /// </summary>
    public class CRSSTMTTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.10.4跨行账户他行账户明细查询请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public CRSSTMTTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.10.4跨行账户他行账户明细查询请求内容
    /// </summary>
    public class CRSSTMTTRN_RQBODY
    {
        /// <summary>
        /// PAGE查询页码，每页100笔，不输默认第1页，必输
        /// </summary>
        [XmlAttribute]
        public int PAGE { get; set; } = 1;
        /// <summary>
        /// 3.10.4跨行账户他行账户明细查询 (发起请求)
        /// </summary>
        [XmlElement(Order = 0)]
        public CRSSTMTTRN_QUERYCOND QUERYCOND { get; set; }
        /// <summary>
        /// 第一次查询时用的交易流水号（TRNUID），最长30位 (查询)
        /// </summary>
        [XmlElement(Order = 1)]
        public string CLIENTREF { get; set; }
    }
    /// <summary>
    /// 3.10.4跨行账户他行账户明细查询
    /// </summary>
    public class CRSSTMTTRN_QUERYCOND
    {
        /// <summary>
        /// 协议号，最长140位	必输 
        /// </summary>
        [XmlElement(Order = 0)]
        public string AGRM { get; set; }
        /// <summary>
        /// 发起账户代号(兴业账户代号)，最长32位
        /// </summary>
        [XmlElement(Order = 1)]
        public string OPERACCTID { get; set; }
        /// <summary>
        /// 开始日期，格式yyyy-MM-dd 必输
        /// </summary>
        [XmlIgnore]
        public DateTime DTSTART { get; set; }
        /// <summary>
        /// 开始日期，格式yyyy-MM-dd ,对应<see cref="DTSTART"/> 必输
        /// </summary>
        [XmlElement("DTSTART", Order = 2)]
        public string DTSTARTStr
        {
            get
            {
                return this.DTSTART.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DTSTART = tmp;
                }
            }
        }
        /// <summary>
        /// 截止日期，格式yyyy-MM-dd 必输
        /// </summary>
        [XmlIgnore]
        public DateTime DTEND { get; set; }
        /// <summary>
        /// 截止日期，格式yyyy-MM-dd ,对应<see cref="DTEND"/> 必输
        /// </summary>
        [XmlElement("DTEND", Order = 3)]
        public string DTENDStr
        {
            get
            {
                return this.DTEND.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DTEND = tmp;
                }
            }
        }
    }
}
