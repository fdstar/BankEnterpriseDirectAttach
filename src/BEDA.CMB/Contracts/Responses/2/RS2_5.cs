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
    /// 2.5.查询账户历史余额响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS2_5 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// SDKNTQABINF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKNTQABINF";
        /// <summary>
        /// 2.5.查询账户历史余额响应集合
        /// </summary>
        [XmlElement("NTQABINFZ")]
        public List<NTQABINFZ> List { get; set; }
    }
    /// <summary>
    /// 2.5.查询账户历史余额响应内容
    /// </summary>
    public class NTQABINFZ
    {
        /// <summary>
        /// 分行号	C（2）	附录A.1
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 帐号	C（35）
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 交易日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime TRSDAT { get; set; }
        /// <summary>
        /// 交易日期	D, 对应<see cref="TRSDAT"/>
        /// </summary>
        [XmlElement("TRSDAT")]
        public string TRSDATStr
        {
            get
            {
                return this.TRSDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.TRSDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 可用余额	M
        /// </summary>
        public decimal BALAMT { get; set; }
        /// <summary>
        /// 保留字段	C（30）
        /// </summary>
        public string RSV30Z { get; set; }
    }
}
