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
    /// 18.7.境外账户查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS18_7 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTQRYCAC
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQRYCAC";
        /// <summary>
        /// 18.7.境外账户查询响应集合
        /// </summary>
        [XmlElement("NTQRYCACZ")]
        public List<NTQRYCACZ> List { get; set; }
    }
    /// <summary>
    /// 18.7.境外账户查询响应内容
    /// </summary>
    public class NTQRYCACZ
    {
        /// <summary>
        /// 行内账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 境外账号	C(35)
        /// </summary>
        public string CRSACC { get; set; }
        /// <summary>
        /// 境外账号名称	Z(100)
        /// </summary>
        public string CRSACN { get; set; }
        /// <summary>
        /// 币种	C(3)	A.47国际业务货币代码表
        /// </summary>
        public string CRSCCY { get; set; }
        /// <summary>
        /// 发报行名称	Z(100)
        /// </summary>
        public string CRSBNK { get; set; }
        /// <summary>
        /// 发报行SWIFT地址	Z(11)
        /// </summary>
        public string SWFADR { get; set; }
        /// <summary>
        /// 开通日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime OPRDAT { get; set; }
        /// <summary>
        /// 开通日期	D, 对应<see cref="OPRDAT"/>
        /// </summary>
        [XmlElement("OPRDAT")]
        public string OPRDATStr
        {
            get
            {
                return this.OPRDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OPRDAT = tmp;
                }
            }
        }
    }
}
