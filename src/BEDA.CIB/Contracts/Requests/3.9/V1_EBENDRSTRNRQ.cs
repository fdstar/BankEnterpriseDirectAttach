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
    /// 3.9.2.6电子商业汇票背书转让申请请求主体
    /// </summary>
    public class V1_EBENDRSTRNRQ : IRequest<V1_EBENDRSTRNRS>
    {
        /// <summary>
        /// 3.9.2.6电子商业汇票背书转让申请请求主体
        /// </summary>
        public EBENDRSTRNRQ EBENDRSTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.9.2.6电子商业汇票背书转让申请请求主体
    /// </summary>
    public class EBENDRSTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.9.2.6电子商业汇票背书转让申请请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBENDRSTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.9.2.6电子商业汇票背书转让申请请求内容
    /// </summary>
    public class EBENDRSTRN_RQBODY
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
        /// 背书申请日期 YYYY-MM-DD
        /// </summary>
        [XmlIgnore]
        public DateTime APPDATE { get; set; }
        /// <summary>
        /// 背书申请日期 YYYY-MM-DD, 对应<see cref="APPDATE"/>
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
        /// 票据类型,4位(AC01:银票,AC02:商票)	必输
        /// </summary>
        [XmlElement(Order = 6)]
        public string BILLTYPE { get; set; }
        /// <summary>
        /// 背书人账户代号,最大32位	必输
        /// </summary>
        [XmlElement(Order = 7)]
        public string ENDRSRACCTID { get; set; }
        /// <summary>
        /// 被背书人账户代号是否兴业账户代号,1位(Y:是,N:否)	必输
        /// </summary>
        [XmlElement(Order = 8)]
        public string ENDRSEISCIB { get; set; }
        /// <summary>
        /// 被背书人账户信息	必输  不传递 BANKDESC
        /// </summary>
        [XmlElement(Order = 9)]
        public CORRELATEACCT ENDRSEACCT { get; set; }
        /// <summary>
        /// 转让标识 4位(EM00:可再转让,EM01:不可再转让) 必输
        /// </summary>
        [XmlElement(Order = 10)]
        public string NEGTBL { get; set; }
        /// <summary>
        /// 备注,最大256位	非必输
        /// </summary>
        [XmlElement(Order = 11)]
        public string MEMO { get; set; }
        /// <summary>
        /// 3.9.2.6电子商业汇票背书转让申请请求集合
        /// </summary>
        [XmlElement("CONTENT", Order = 12)]
        public List<EBENDRSTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.9.2.6电子商业汇票背书转让申请请求明细
    /// </summary>
    public class EBENDRSTRN_CONTENT
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
    }
}
