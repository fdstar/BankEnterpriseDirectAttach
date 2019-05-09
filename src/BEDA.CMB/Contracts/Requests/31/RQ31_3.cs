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
    /// 31.3.按参考号查询业务请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ31_3 : CMBBase<RQINFO>, IRequest<RS31_3>
    {
        /// <summary>
        /// NTIAMRED
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTIAMRED";
        /// <summary>
        /// 31.3.按参考号查询业务请求内容
        /// </summary>
        public NTIAMREDX1 NTIAMREDX1 { get; set; }
    }
    /// <summary>
    /// 31.3.按参考号查询业务请求内容
    /// </summary>
    public class NTIAMREDX1
    {
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 起始日期 	D   开始、结束日期查询间隔范围7天内 （本功能只提供90天内历史记录查询，超90天历史查询可使用综合查询功能）
        /// </summary>
        [XmlIgnore]
        public DateTime BEGDAT { get; set; }
        /// <summary>
        /// 起始日期	D, 对应<see cref="BEGDAT"/>
        /// </summary>
        [XmlElement("BEGDAT")]
        public string BEGDATStr
        {
            get
            {
                return this.BEGDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.BEGDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 结束日期	D
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
