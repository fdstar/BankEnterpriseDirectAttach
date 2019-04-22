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
    /// 8.8.3.查询券商保证金余额响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_8_3 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTSECBAL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTSECBAL";
        /// <summary>
        /// 8.8.3.查询券商保证金余额响应集合
        /// </summary>
        [XmlElement("NTSECBALZ")]
        public List<NTSECBALZ> List { get; set; }
    }
    /// <summary>
    /// 8.8.3.查询券商保证金余额响应内容
    /// </summary>
    public class NTSECBALZ
    {
        /// <summary>
        /// 交易请求码	C(4)
        /// </summary>
        public string REQCOD { get; set; }
        /// <summary>
        /// 簿记昨日余额	M
        /// </summary>
        public decimal BOKAMT { get; set; }
        /// <summary>
        /// 保证金余额	M
        /// </summary>
        public decimal STKAMT { get; set; }
        /// <summary>
        /// 可用余额	M
        /// </summary>
        public decimal STKUSE { get; set; }
        /// <summary>
        /// 响应代码	C(7)
        /// </summary>
        public string RSPCOD { get; set; }
        /// <summary>
        /// 错误信息	C(80)
        /// </summary>
        public string ERRMSG { get; set; }
    }
}
