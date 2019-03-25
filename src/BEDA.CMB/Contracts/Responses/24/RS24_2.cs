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
    /// 24.2.网银对账明细数据查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS24_2 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTNSTQRY2
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTNSTQRY2";
        /// <summary>
        /// 24.2.网银对账明细数据查询响应内容
        /// </summary>
        public NTNSTQRYZ NTNSTQRYZ { get; set; }
    }
}
