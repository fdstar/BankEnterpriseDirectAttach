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
    /// 3.9.1.10电子商业汇票实付金额查询请求主体
    /// </summary>
    public class V1_EBREALPAYTRNRQ : IRequest<V1_EBREALPAYTRNRS>
    {
        /// <summary>
        /// 3.9.1.10电子商业汇票实付金额查询请求主体
        /// </summary>
        public EBREALPAYTRNRQ EBREALPAYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.9.1.10电子商业汇票实付金额查询请求主体
    /// </summary>
    public class EBREALPAYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.9.1.10电子商业汇票实付金额查询请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBREALPAYTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.9.1.10电子商业汇票实付金额查询请求内容
    /// </summary>
    public class EBREALPAYTRN_RQBODY
    {
        /// <summary>
        /// 操作账户代号	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 3.9.1.10电子商业汇票实付金额查询请求集合
        /// </summary>
        [XmlElement("CONTENT", Order = 2)]
        public List<EBREALPAYTRNRQ_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.9.1.10电子商业汇票实付金额查询请求明细
    /// </summary>
    public class EBREALPAYTRNRQ_CONTENT
    {
        /// <summary>
        /// 小序号,4位	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public int INDX { get; set; }
        /// <summary>
        /// 票据类型(AC01:银票,AC02:商票)	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string BILLTYPE { get; set; }
        /// <summary>
        /// 贴现类型,4位(RM00:买断式,RM01回购式)	必输
        /// </summary>
        [XmlElement(Order = 3)]
        public string DISCNTTYPE { get; set; }
        /// <summary>
        /// 票据金额,17位(15整数位,2小数位)	必输
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal BILLAMT { get; set; }
        /// <summary>
        /// 计息起始日, YYYY-MM-DD	必输
        /// </summary>
        [XmlIgnore]
        public DateTime DTSTART { get; set; }
        /// <summary>
        /// 计息起始日, YYYY-MM-DD ,对应<see cref="DTSTART"/> 必输
        /// </summary>
        [XmlElement("DTSTART", Order = 5)]
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
        /// 计息截止日 YYYY-MM-DD	必输
        /// </summary>
        [XmlIgnore]
        public DateTime DTEND { get; set; }
        /// <summary>
        /// 计息截止日 YYYY-MM-DD ,对应<see cref="DTEND"/>	必输
        /// </summary>
        [XmlElement("DTEND", Order = 6)]
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
        /// <summary>
        /// 利率,7位百分数不含百分号(2位整数,5位小数)	必输
        /// </summary>
        [XmlElement(Order = 7)]
        public decimal INTRST { get; set; }
        /// <summary>
        /// 贴现申请付息方式：非必输
        /// 1－卖方付息 2－买方付息 转贴现申请与再贴现申请不必输入
        /// </summary>
        [XmlElement(Order = 8)]
        public string PAYINTRMODE { get; set; }
    }
}
