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
    /// 3.9.2.11电子商业汇票提示付款申请请求主体
    /// </summary>
    public class V1_EBCUEPAYTRNRQ : IRequest<V1_EBCUEPAYTRNRS>
    {
        /// <summary>
        /// 3.9.2.11电子商业汇票提示付款申请请求主体
        /// </summary>
        public EBCUEPAYTRNRQ EBCUEPAYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.9.2.11电子商业汇票提示付款申请请求主体
    /// </summary>
    public class EBCUEPAYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.9.2.11电子商业汇票提示付款申请请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBCUEPAYTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.9.2.11电子商业汇票提示付款申请请求内容
    /// </summary>
    public class EBCUEPAYTRN_RQBODY
    {
        /// <summary>
        /// 票据总笔数,8位整数	必输
        /// </summary>
        [XmlElement(Order = 3)]
        public int TOTALCOUNT
        {
            get
            {
                return this.List?.Count ?? 0;
            }
            set { }
        }
        /// <summary>
        /// 票据总金额, 17位(15整数位,2小数位) 	必输
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal TOTALAMT
        {
            get
            {
                return this.List?.Sum(c => c.BILLAMT) ?? 0;
            }
            set { }
        }
        /// <summary>
        /// 提示付款申请日期 YYYY-MM-DD 必输
        /// </summary>
        [XmlIgnore]
        public DateTime APPDATE { get; set; }
        /// <summary>
        /// 提示付款申请日期 YYYY-MM-DD, 对应<see cref="APPDATE"/> 必输
        /// </summary>
        [XmlElement("APPDATE", Order = 5)]
        public string APPDATEStr
        {
            get
            {
                return this.APPDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.APPDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 提示付款申请人账户代号,最大60位	必输
        /// </summary>
        [XmlElement(Order = 6)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 提示付款类型,2位 (01:正常提示付款,02:逾期提示付款)	必输
        /// </summary>
        [XmlElement(Order = 7)]
        public string CUETYPE { get; set; }
        /// <summary>
        /// 票据类型,4位(AC01:银票,AC02:商票)	必输
        /// </summary>
        [XmlElement(Order = 8)]
        public string BILLTYPE { get; set; }
        /// <summary>
        /// 清算模式,4位 (SM00:线上清算,SM01:线下清算)	必输
        /// </summary>
        [XmlElement(Order = 9)]
        public string LQMODE { get; set; }
        /// <summary>
        /// 备注,最大256位	非必输
        /// </summary>
        [XmlElement(Order = 10)]
        public string MEMO { get; set; }
        /// <summary>
        /// 逾期说明,1-256位	非必输
        /// </summary>
        [XmlElement(Order = 11)]
        public string OVERDUEREM { get; set; }
        /// <summary>
        /// 3.9.2.11电子商业汇票提示付款申请请求集合
        /// </summary>
        [XmlElement("CONTENT", Order = 30)]
        public List<EBCUEPAYTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.9.2.11电子商业汇票提示付款申请请求明细
    /// </summary>
    public class EBCUEPAYTRN_CONTENT
    {
        /// <summary>
        /// 小序号,4位	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public int INDX { get; set; }
        /// <summary>
        /// 票据号码,30位	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string BILLCODE { get; set; }
        /// <summary>
        /// 票据金额,17位(15整数位,2小数位)	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public decimal BILLAMT { get; set; }
        /// <summary>
        /// 提示付款金额,17位(15整数位,2小数位)	必输
        /// </summary>
        [XmlElement(Order = 3)]
        public decimal CUEAMT { get; set; }
        /// <summary>
        /// 代理申请标识,4位(固定值PP01)	必输
        /// </summary>
        [XmlElement(Order = 4)]
        public string AGENTFLAG { get; set; } = "PP01";
    }
}
