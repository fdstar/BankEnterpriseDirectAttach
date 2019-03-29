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
    /// 10.3.现金池账户额度历史查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ10_3 : CMBBase<RQINFO>, IRequest<RS10_3>
    {
        /// <summary>
        /// SDKNTCACHST
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKNTCACHST";
        /// <summary>
        /// 10.3.现金池账户额度历史查询请求内容
        /// </summary>
        public NTAUBLSTY NTAUBLSTY { get; set; }
    }
    /// <summary>
    /// 10.3.现金池账户额度历史查询请求内容
    /// </summary>
    public class NTAUBLSTY
    {
        /// <summary>
        /// 协议编号	C(10)
        /// </summary>
        public string CRSCOD { get; set; }
        /// <summary>
        /// 子公司协议序号	C(5)
        /// </summary>
        public string CRPSEQ { get; set; }
        /// <summary>
        /// 起始日期	C(8)    起止日期的间隔不能超过100天
        /// </summary>
        [XmlIgnore]
        public DateTime BEGDAT { get; set; }
        /// <summary>
        /// 起始日期	C(8), 对应<see cref="BEGDAT"/>
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
        /// 截止日期	C(8)
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDAT { get; set; }
        /// <summary>
        /// 截止日期	C(8), 对应<see cref="ENDDAT"/>
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
