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
    /// 3.9.3.4电子商业汇票出票申请请求主体
    /// </summary>
    public class V1_EBPOUTBILLTRNRQ : IRequest<V1_EBPOUTBILLTRNRS>
    {
        /// <summary>
        /// 3.9.3.4电子商业汇票出票申请请求主体
        /// </summary>
        public EBPOUTBILLTRNRQ EBPOUTBILLTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.9.3.4电子商业汇票出票申请请求主体
    /// </summary>
    public class EBPOUTBILLTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.9.3.4电子商业汇票出票申请请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBPOUTBILLTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.9.3.4电子商业汇票出票申请请求内容
    /// </summary>
    public class EBPOUTBILLTRN_RQBODY
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
        /// 3.9.3.4电子商业汇票出票申请请求集合
        /// </summary>
        [XmlElement("CONTENT", Order = 30)]
        public List<EBPOUTBILLTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.9.3.4电子商业汇票出票申请请求明细
    /// </summary>
    public class EBPOUTBILLTRN_CONTENT
    {
        /// <summary>
        /// 小序号,4位	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public int INDX { get; set; }
        /// <summary>
        /// 票据金额(18,2)	必输
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal BILLAMT { get; set; }
        /// <summary>
        /// 票据类型，AC01银承 AC02商承	必输
        /// </summary>
        [XmlElement(Order = 5)]
        public string BILLTYPE { get; set; }
        /// <summary>
        /// 出票日 YYYY-MM-DD 必输
        /// </summary>
        [XmlIgnore]
        public DateTime OUTDATE { get; set; }
        /// <summary>
        /// 出票日 YYYY-MM-DD, 对应<see cref="OUTDATE"/> 必输
        /// </summary>
        [XmlElement("OUTDATE", Order = 6)]
        public string OUTDATEStr
        {
            get
            {
                return this.OUTDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OUTDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 到日期 YYYY-MM-DD 必输
        /// </summary>
        [XmlIgnore]
        public DateTime DUEDATE { get; set; }
        /// <summary>
        /// 到日期 YYYY-MM-DD, 对应<see cref="DUEDATE"/> 必输
        /// </summary>
        [XmlElement("DUEDATE", Order = 7)]
        public string DUEDATEStr
        {
            get
            {
                return this.DUEDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DUEDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 收款人名称	必输
        /// </summary>
        [XmlElement(Order = 12)]
        public string PAYEENAME { get; set; }
        /// <summary>
        /// 收款人账号	必输
        /// </summary>
        [XmlElement(Order = 13)]
        public string PAYEEACCTNO { get; set; }
        /// <summary>
        /// 收款人开户行名称	必输
        /// </summary>
        [XmlElement(Order = 14)]
        public string PAYEEBANKNAME { get; set; }
        /// <summary>
        /// 收款人开户行行号 必输
        /// </summary>
        [XmlElement(Order = 15)]
        public string PAYEEBANKCODE { get; set; }
    }
}
