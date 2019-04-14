using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Responses
{
    /// <summary>
    /// 19.2.14.票据背书信息查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS19_2_14 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// SDKCUSWRT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKCUSWRT";
        /// <summary>
        /// 19.2.14.票据背书信息查询响应集合
        /// </summary>
        [XmlElement("NTWRTINQZ")]
        public List<NTWRTINQZ> List { get; set; }
    }
    /// <summary>
    /// 19.2.14.票据背书信息查询响应内容
    /// </summary>
    public class NTWRTINQZ
    {
        /// <summary>
        /// 票据流水号	C(10)
        /// </summary>
        public string SEQNBR { get; set; }
        /// <summary>
        /// 背书序号	C(6)
        /// </summary>
        public string WRTCNT { get; set; }
        /// <summary>
        /// 背书日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? WRTDAT { get; set; }
        /// <summary>
        /// 背书日期	D, 对应<see cref="WRTDAT"/>
        /// </summary>
        [XmlElement("WRTDAT")]
        public string WRTDATStr
        {
            get
            {
                return this.WRTDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.WRTDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.WRTDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 被背书人客户编号	C(10)
        /// </summary>
        public string WRTCLT { get; set; }
        /// <summary>
        /// 被背书人名称 	Z(62)
        /// </summary>
        public string WRTNAM { get; set; }
        /// <summary>
        /// 背书摘要	Z(62)
        /// </summary>
        public string WRTDSP { get; set; }
    }
}
