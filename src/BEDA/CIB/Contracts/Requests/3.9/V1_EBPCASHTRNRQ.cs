using BEDA.CIB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 3.9.3.6电子商业汇票贴现申请请求主体
    /// </summary>
    public class V1_EBPCASHTRNRQ : IRequest<V1_EBPCASHTRNRS>
    {
        /// <summary>
        /// 3.9.3.6电子商业汇票贴现申请请求主体
        /// </summary>
        public EBPCASHTRNRQ EBPCASHTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.9.3.6电子商业汇票贴现申请请求主体
    /// </summary>
    public class EBPCASHTRNRQ : BIZRQBASE
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
        /// 3.9.3.6电子商业汇票贴现申请请求集合
        /// </summary>
        [XmlElement("CONTENT", Order = 30)]
        public List<EBPCASHTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.9.3.6电子商业汇票贴现申请请求明细
    /// </summary>
    public class EBPCASHTRN_CONTENT : EBPCONVERTTRN_CONTENT
    {
    }
}
