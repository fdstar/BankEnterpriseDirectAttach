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
    /// 3.20.2进口信用证修改请求主体
    /// </summary>
    public class V1_LCAMENDAPPLYTRNRQ : IRequest<V1_LCAMENDAPPLYTRNRS>
    {
        /// <summary>
        /// 3.20.2进口信用证修改请求主体
        /// </summary>
        public LCAMENDAPPLYTRNRQ LCAMENDAPPLYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.20.2进口信用证修改请求主体
    /// </summary>
    public class LCAMENDAPPLYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.20.2进口信用证修改请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public LCAMENDAPPLYTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.20.2进口信用证修改请求内容
    /// </summary>
    public class LCAMENDAPPLYTRN_RQBODY
    {
        /// <summary>
        /// 地区机构	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string BRANCHNO { get; set; }
        /// <summary>
        /// 信用证号 长度：16	必输
        /// </summary>
        [XmlElement(Order = 3)]
        public string LCREFNO { get; set; }
        /// <summary>
        /// 申请人 长度：4*35	必输
        /// </summary>
        [XmlElement(Order = 4)]
        public string APPLICANT { get; set; }
        /// <summary>
        /// 受益人 长度：4*35	必输
        /// </summary>
        [XmlElement(Order = 5)]
        public string BENEFICIARY { get; set; }
        /// <summary>
        /// 申请事项  允许中文 150*65	必输
        /// </summary>
        [XmlElement(Order = 6)]
        public string APPLYDTL { get; set; }
        /// <summary>
        /// 备注 允许中文 6*35	非必输
        /// </summary>
        [XmlElement(Order = 7)]
        public string COMMENT { get; set; }
        /// <summary>
        /// 申请日期, yyyy-MM-dd	必输 
        /// </summary>
        [XmlIgnore]
        public DateTime APPLYDATE { get; set; }
        /// <summary>
        /// 申请日期 yyyy-MM-dd, 对应<see cref="APPLYDATE"/>	必输 
        /// </summary>
        [XmlElement("APPLYDATE", Order = 8)]
        public string APPLYDATEStr
        {
            get
            {
                return this.APPLYDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.APPLYDATE = tmp;
                }
            }
        }
    }
}
