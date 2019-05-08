using BEDA.CMB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Requests
{
    /// <summary>
    /// 28.2.6.按业务参考号查询结果请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ28_2_6 : CMBBase<RQINFO>, IRequest<RS28_2_6>
    {
        /// <summary>
        /// NTDUMRED
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDUMRED";
        /// <summary>
        /// 28.2.6.按业务参考号查询结果请求内容
        /// </summary>
        public NTDUMREDX1 NTDUMREDX1 { get; set; }
    }
    /// <summary>
    /// 28.2.6.按业务参考号查询结果请求内容
    /// </summary>
    public class NTDUMREDX1
    {
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 开始日期	D   经办日期查询范围不能超过7天，只能查3个月内的请求
        /// </summary>
        [XmlIgnore]
        public DateTime BGNDAT { get; set; }
        /// <summary>
        /// 开始日期	D, 对应<see cref="BGNDAT"/>
        /// </summary>
        [XmlElement("BGNDAT")]
        public string BGNDATStr
        {
            get
            {
                return this.BGNDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.BGNDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 结束日期	D   开始日期和结束日期必须早于当日
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDAT { get; set; }
        /// <summary>
        /// 结束日期	D, 对应<see cref="ENDDAT"/>
        /// </summary>
        [XmlElement("ENDDAT")]
        public string ENDDATStr
        {
            get
            {
                return this.ENDDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ENDDAT = tmp;
                }
            }
        }
    }
}
