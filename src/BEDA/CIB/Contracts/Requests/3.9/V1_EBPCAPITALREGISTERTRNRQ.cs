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
    /// 3.9.3.18电子商业汇票资产业务登记薄请求主体
    /// </summary>
    public class V1_EBPCAPITALREGISTERTRNRQ : IRequest<V1_EBPCAPITALREGISTERTRNRS>
    {
        /// <summary>
        /// 3.9.3.18电子商业汇票资产业务登记薄请求主体
        /// </summary>
        public EBPCAPITALREGISTERTRNRQ EBPCAPITALREGISTERTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.9.3.18电子商业汇票资产业务登记薄请求主体
    /// </summary>
    public class EBPCAPITALREGISTERTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.9.3.18电子商业汇票资产业务登记薄请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBPCAPITALREGISTERTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.9.3.18电子商业汇票资产业务登记薄请求内容
    /// </summary>
    public class EBPCAPITALREGISTERTRN_RQBODY
    {
        /// <summary>
        /// 查询页数默认为1
        /// </summary>
        [XmlAttribute]
        public int PAGE { get; set; } = 1;
        /// <summary>
        /// 起始日期 YYYY-MM-DD 必输
        /// </summary>
        [XmlIgnore]
        public DateTime BEGINDATE { get; set; }
        /// <summary>
        /// 起始日期，格式yyyy-MM-dd ,对应<see cref="BEGINDATE"/> 必输
        /// </summary>
        [XmlElement("BEGINDATE", Order = 1)]
        public string BEGINDATEStr
        {
            get
            {
                return this.BEGINDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.BEGINDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 终止日期 YYYY-MM-DD 必输
        /// </summary>
        [XmlIgnore]
        public DateTime DUEDATE { get; set; }
        /// <summary>
        /// 终止日期，格式yyyy-MM-dd ,对应<see cref="DUEDATE"/> 必输
        /// </summary>
        [XmlElement("DUEDATE", Order = 2)]
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
        /// 业务类型 非必输
        /// 01-流动资金贷款
        /// 02-国内信用证
        /// 03-法人账户透支
        /// 04-融资性保函
        /// 05-非融资性保函
        /// </summary>
        [XmlElement(Order = 3)]
        public string BIZTYPE { get; set; }
    }
}
