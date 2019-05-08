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
    /// 28.1.7.根据业务参考号查询业务结果请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ28_1_7 : CMBBase<RQINFO>, IRequest<RS28_1_7>
    {
        /// <summary>
        /// NTGMTRED
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTGMTRED";
        /// <summary>
        /// 28.1.7.根据业务参考号查询业务结果请求内容
        /// </summary>
        public NTGMTREDX1 NTGMTREDX1 { get; set; }
    }
    /// <summary>
    /// 28.1.7.根据业务参考号查询业务结果请求内容
    /// </summary>
    public class NTGMTREDX1
    {
        /// <summary>
        /// 业务编码	C(6)	附录A.4
        /// </summary>
        public string BUSCOD { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 起始日期	D   查询日期间隔不能大于7天, 查询开始日期不能早于当前日期90天
        /// </summary>
        [XmlIgnore]
        public DateTime BGNDAT { get; set; }
        /// <summary>
        /// 起始日期	D, 对应<see cref="BGNDAT"/>
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
