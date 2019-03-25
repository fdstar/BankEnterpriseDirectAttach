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
    /// 24.2.网银对账明细数据查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ24_2 : CMBBase<RQINFO>, IRequest<RS24_2>
    {
        /// <summary>
        /// NTNSTQRY2
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTNSTQRY2";
        /// <summary>
        /// 24.2.网银对账明细数据查询请求内容
        /// 此处不传递<see cref="NTNSTQRYX.BUSMOD"/>
        /// </summary>
        public NTNSTQRYX NTNSTQRYX { get; set; }
    }
}
