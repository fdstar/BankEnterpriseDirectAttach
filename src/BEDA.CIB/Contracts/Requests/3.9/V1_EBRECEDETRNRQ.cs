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
    /// 3.9.2.14电子商业汇票通用撤回请求主体
    /// </summary>
    public class V1_EBRECEDETRNRQ : IRequest<V1_EBRECEDETRNRS>
    {
        /// <summary>
        /// 3.9.2.14电子商业汇票通用撤回请求主体
        /// </summary>
        public EBRECEDETRNRQ EBRECEDETRNRQ { get; set; }
    }
    /// <summary>
    /// 3.9.2.14电子商业汇票通用撤回请求主体
    /// </summary>
    public class EBRECEDETRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.9.2.14电子商业汇票通用撤回请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBRECEDETRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.9.2.14电子商业汇票通用撤回请求内容
    /// </summary>
    public class EBRECEDETRN_RQBODY
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
        /// 业务撤回申请人账户代号,最大32位	必输
        /// </summary>
        [XmlElement(Order = 5)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 3.9.2.14电子商业汇票通用撤回请求集合
        /// </summary>
        [XmlElement("CONTENT", Order = 30)]
        public List<EBRECEDETRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.9.2.14电子商业汇票通用撤回请求明细
    /// </summary>
    public class EBRECEDETRN_CONTENT
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
        /// 业务标识码,2位,见:附录3-业务类型对照表	必输
        /// </summary>
        [XmlElement(Order = 3)]
        public string BUSINESSTYPE { get; set; }
        /// <summary>
        /// 业务标识号,1-35位	必输
        /// </summary>
        [XmlElement(Order = 4)]
        public string BIZFLAG { get; set; }
        /// <summary>
        /// 业务流水号(可操作票据查询返回),1-20位	必输
        /// </summary>
        [XmlElement(Order = 5)]
        public string SEQ { get; set; }
        /// <summary>
        /// 撤回申请日期 YYYY-MM-DD 必输
        /// </summary>
        [XmlIgnore]
        public DateTime APPDATE { get; set; }
        /// <summary>
        /// 撤回申请日期 YYYY-MM-DD, 对应<see cref="APPDATE"/> 必输
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
    }
}
