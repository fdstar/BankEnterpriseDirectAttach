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
    /// 31.2.内部户MT940业务综合查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ31_2 : CMBBase<RQINFO>, IRequest<RS31_2>
    {
        /// <summary>
        /// NTIAMQYD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTIAMQYD";
        /// <summary>
        /// 31.2.内部户MT940业务综合查询请求内容
        /// </summary>
        public NTIAMQYDY1 NTIAMQYDY1 { get; set; }
    }
    /// <summary>
    /// 31.2.内部户MT940业务综合查询请求内容
    /// </summary>
    public class NTIAMQYDY1
    {
        /// <summary>
        /// 业务模式 	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 起始日期 	D   开始、结束日期查询间隔范围7天内
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
