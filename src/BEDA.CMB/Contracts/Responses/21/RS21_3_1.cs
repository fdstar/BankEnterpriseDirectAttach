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
    /// 21.3.1.网银贷记协议签订经办响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS21_3_1 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTSGNCBC
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTSGNCBC";
        /// <summary>
        /// 21.3.1.网银贷记协议签订经办响应内容   等待时间
        /// </summary>
        public NTOPRDRTZ NTOPRDRTZ { get; set; }
        /// <summary>
        /// 21.3.1.网银贷记协议签订经办响应内容
        /// 响应不包含 SQRNBR
        /// </summary>
        public NTOPRRTNZ NTOPRRTNZ { get; set; }
    }
}
