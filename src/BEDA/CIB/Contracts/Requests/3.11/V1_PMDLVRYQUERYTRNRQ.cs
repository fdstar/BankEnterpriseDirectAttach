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
    /// 3.11.1.5提货申请查询请求主体
    /// </summary>
    public class V1_PMDLVRYQUERYTRNRQ : IRequest<V1_PMDLVRYQUERYTRNRS>
    {
        /// <summary>
        /// 3.11.1.5提货申请查询请求主体
        /// </summary>
        public PMDLVRYQUERYTRNRQ PMDLVRYQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.11.1.5提货申请查询请求主体
    /// </summary>
    public class PMDLVRYQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.11.1.5提货申请查询请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public PMDLVRYQUERYTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.11.1.5提货申请查询请求内容
    /// </summary>
    public class PMDLVRYQUERYTRN_RQBODY : PAGED_RQACCT
    {
        /// <summary>
        /// 提货日期 YYYY-MM-DD 必输
        /// </summary>
        [XmlIgnore]
        public DateTime OPERDATE { get; set; }
        /// <summary>
        /// 提货日期 YYYY-MM-DD, 对应<see cref="OPERDATE"/> 必输
        /// </summary>
        [XmlElement("OPERDATE", Order = 3)]
        public string OPERDATEStr
        {
            get
            {
                return this.OPERDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OPERDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 提货流水号，最长16位	非必输
        /// </summary>
        [XmlElement(Order = 4)]
        public string SEQ { get; set; }
    }
}
