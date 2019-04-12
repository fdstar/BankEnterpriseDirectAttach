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
    /// 19.1.4.自动托收协议查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS19_1_4 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// SDKRCVLST
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKRCVLST";
        /// <summary>
        /// 19.1.4.自动托收协议查询响应集合
        /// </summary>
        [XmlElement("NTRCVLSTZ")]
        public List<NTRCVLSTZ> List { get; set; }
    }
    /// <summary>
    /// 19.1.4.自动托收协议查询响应内容
    /// </summary>
    public class NTRCVLSTZ
    {
        /// <summary>
        /// 维护（生效）日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? MNTDAT { get; set; }
        /// <summary>
        /// 维护（生效）日期	D, 对应<see cref="MNTDAT"/>
        /// </summary>
        [XmlElement("MNTDAT")]
        public string MNTDATStr
        {
            get
            {
                return this.MNTDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.MNTDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.MNTDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 客户编号	C(10)
        /// </summary>
        public string CTLNBR { get; set; }
        /// <summary>
        /// 业务类型	C(6)
        /// </summary>
        public string BUSCOD { get; set; }
        /// <summary>
        /// 收方分行号	C(2)
        /// </summary>
        public string CRTBBK { get; set; }
        /// <summary>
        /// 收款帐号	C(35)
        /// </summary>
        public string CRTACC { get; set; }
        /// <summary>
        /// 收方户名	Z(62)
        /// </summary>
        public string CRTNAM { get; set; }
        /// <summary>
        /// 收方行名称	Z(62)
        /// </summary>
        public string CRTBNK { get; set; }
        /// <summary>
        /// 维护状态	C(1)
        /// </summary>
        public string STSCOD { get; set; }
    }
}
