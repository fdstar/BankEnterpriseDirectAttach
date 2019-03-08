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
    /// 3.9.3.5电子商业汇票融资申请请求主体
    /// </summary>
    public class V1_EBPFINANCINGTRNRQ : IRequest<V1_EBPFINANCINGTRNRS>
    {
        /// <summary>
        /// 3.9.3.5电子商业汇票融资申请请求主体
        /// </summary>
        public EBPFINANCINGTRNRQ EBPFINANCINGTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.9.3.5电子商业汇票融资申请请求主体
    /// </summary>
    public class EBPFINANCINGTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.9.3.5电子商业汇票融资申请请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBPFINANCINGTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.9.3.5电子商业汇票融资申请请求内容
    /// </summary>
    public class EBPFINANCINGTRN_RQBODY
    {
        /// <summary>
        /// 业务到期日期 YYYY-MM-DD 必输
        /// </summary>
        [XmlIgnore]
        public DateTime DUEDATE { get; set; }
        /// <summary>
        /// 业务到期日期 YYYY-MM-DD, 对应<see cref="DUEDATE"/> 必输
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
        /// 融资方式  必输
        /// 01-流动资金贷款
        /// 02-国内信用证
        /// 03-法人账户透支
        /// 04-融资性保函
        /// 05-非融资性保函
        /// </summary>
        [XmlElement(Order = 10)]
        public string FINANCINGTYPE { get; set; }
        /// <summary>
        /// 额度使用方式 必输
        /// 1-票据池低风险额度
        /// 2-票据池非低风险额度
        /// </summary>
        [XmlElement(Order = 11)]
        public int LIMITUSETYPE { get; set; }
        /// <summary>
        /// 融资金额（18,2）	必输
        /// </summary>
        [XmlElement(Order = 12)]
        public decimal FINANCINGAMT { get; set; }
    }
}
