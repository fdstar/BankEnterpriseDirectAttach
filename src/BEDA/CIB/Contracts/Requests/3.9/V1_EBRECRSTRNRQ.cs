using BEDA.CIB.Contracts.Responses;
using BEDA.Utils;
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
    /// 3.9.2.12电子商业汇票追索通知申请请求主体
    /// </summary>
    public class V1_EBRECRSTRNRQ : IRequest<V1_EBRECRSTRNRS>
    {
        /// <summary>
        /// 3.9.2.12电子商业汇票追索通知申请请求主体
        /// </summary>
        public EBRECRSTRNRQ EBRECRSTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.9.2.12电子商业汇票追索通知申请请求主体
    /// </summary>
    public class EBRECRSTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.9.2.12电子商业汇票追索通知申请请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBRECRSTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.9.2.12电子商业汇票追索通知申请请求内容
    /// </summary>
    public class EBRECRSTRN_RQBODY
    {
        /// <summary>
        /// 追索申请日期 YYYY-MM-DD 必输
        /// </summary>
        [XmlIgnore]
        public DateTime APPDATE { get; set; }
        /// <summary>
        /// 追索申请日期 YYYY-MM-DD, 对应<see cref="APPDATE"/> 必输
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
        /// 追索人账户代号	必输
        /// </summary>
        [XmlElement(Order = 6)]
        public RQACCT ACCTFROM { get; set; }
        /// <summary>
        /// 追索类型,4位(RT00:拒付追索,RT01:非拒付追索)	必输
        /// </summary>
        [XmlElement(Order = 7)]
        public string RECRSTYPE { get; set; }
        /// <summary>
        /// 追索金额,17位(15整数位,2小数位)	非必输
        /// </summary>
        [XmlIgnore]
        public decimal? RECRSAMT { get; set; }
        /// <summary>
        /// 追索金额,17位(15整数位,2小数位) 对应<see cref="RECRSAMT"/>	非必输
        /// </summary>
        [XmlElement("RECRSAMT", Order = 8)]
        public string RECRSAMTStr
        {
            get
            {
                return this.RECRSAMT?.ToString();
            }
            set
            {
                this.RECRSAMT = value.TryConvert<decimal>();
            }
        }
        /// <summary>
        /// 被追索人信息 必输 不传递 CUSTTYPE
        /// </summary>
        [XmlElement(Order = 9)]
        public ORGACCT ACCTTO { get; set; }
        /// <summary>
        /// 追索理由代码,4位(RC00:承兑人被依法宣告破产, RC01:承兑人因违法被责令终止活动) 非必填字段但不填会报错
        /// </summary>
        [XmlElement(Order = 10)]
        public string RSNCODE { get; set; }
        /// <summary>
        /// 追索理由备注,最大256位	非必输
        /// </summary>
        [XmlElement(Order = 11)]
        public string MEMO { get; set; }
        /// <summary>
        /// 小序号,4位	必输
        /// </summary>
        [XmlElement(Order = 12)]
        public int INDX { get; set; } = 1;
        /// <summary>
        /// 票据号码,30位	必输
        /// </summary>
        [XmlElement(Order = 13)]
        public string BILLCODE { get; set; }
        /// <summary>
        /// 票据金额,17位(15整数位,2小数位)	必输
        /// </summary>
        [XmlElement(Order = 14)]
        public decimal BILLAMT { get; set; }
    }
}
