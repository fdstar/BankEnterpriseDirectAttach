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
    /// 3.9.2.2电子商业汇票通用保证申请请求主体
    /// </summary>
    public class V1_EBGUARNTTRNRQ : IRequest<V1_EBGUARNTTRNRS>
    {
        /// <summary>
        /// 3.9.2.2电子商业汇票通用保证申请请求主体
        /// </summary>
        public EBGUARNTTRNRQ EBGUARNTTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.9.2.2电子商业汇票通用保证申请请求主体
    /// </summary>
    public class EBGUARNTTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.9.2.2电子商业汇票通用保证申请请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBGUARNTTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.9.2.2电子商业汇票通用保证申请请求内容
    /// </summary>
    public class EBGUARNTTRN_RQBODY
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
        /// 保证类型,2位(01:出票人提示保证,02:承兑人提示保证,03:背书保证)	必输
        /// </summary>
        [XmlElement(Order = 5)]
        public string GUARNTTYPE { get; set; }
        /// <summary>
        /// 保证申请日期 YYYY-MM-DD
        /// </summary>
        [XmlIgnore]
        public DateTime APPDATE { get; set; }
        /// <summary>
        /// 保证申请日期 YYYY-MM-DD, 对应<see cref="APPDATE"/>
        /// </summary>
        [XmlElement("APPDATE", Order = 6)]
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
        /// 被保证人帐号	必输
        /// </summary>
        [XmlElement(Order = 7)]
        public string APPACCTID { get; set; }
        /// <summary>
        /// 保证人是否兴业账户代号,1位(Y:是,N:否)	必输
        /// </summary>
        [XmlElement(Order = 8)]
        public string ISCIB { get; set; }
        /// <summary>
        /// 保证人账户信息	必输  注意不传递 BANKDESC
        /// </summary>
        [XmlElement(Order = 9)]
        public CORRELATEACCT GUARNTRACCT { get; set; }
        /// <summary>
        /// 备注,最大256位	非必输
        /// </summary>
        [XmlElement(Order = 10)]
        public string MEMO { get; set; }
        /// <summary>
        /// 3.9.2.2电子商业汇票通用保证申请请求集合
        /// </summary>
        [XmlElement("CONTENT", Order = 11)]
        public List<EBGUARNTTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.9.2.2电子商业汇票通用保证申请请求明细
    /// </summary>
    public class EBGUARNTTRN_CONTENT
    {
        /// <summary>
        /// 小序号,4位	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public int INDX { get; set; }
        /// <summary>
        /// 票据号码	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string BILLCODE { get; set; }
        /// <summary>
        /// 票据金额,17位(15整数位,2小数位)	必输
        /// </summary>
        [XmlElement(Order = 3)]
        public decimal BILLAMT { get; set; }
    }
}
