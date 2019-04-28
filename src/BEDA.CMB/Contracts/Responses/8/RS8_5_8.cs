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
    /// 8.5.8.智能定期存款协议查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_5_8 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTTCAQRY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTTCAQRY";
        /// <summary>
        /// 8.5.8.智能定期存款协议查询响应内容
        /// </summary>
        public NTTCAQRYZ1 NTTCAQRYZ1 { get; set; }
    }
    /// <summary>
    /// 8.5.8.智能定期存款协议查询响应内容
    /// </summary>
    public class NTTCAQRYZ1
    {
        /// <summary>
        /// 最高存期	C(6)
        /// </summary>
        public string HIVDUM { get; set; }
        /// <summary>
        /// 最低起存金额	M
        /// </summary>
        public decimal LCRAMT { get; set; }
        /// <summary>
        /// 最低部提金额	M
        /// </summary>
        public decimal LDBAMT { get; set; }
    }
}
