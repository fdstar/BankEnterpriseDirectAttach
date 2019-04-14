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
    /// 19.2.8.质押开票经办请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ19_2_8 : CMBBase<RQINFO>, IRequest<RS19_2_8>
    {
        /// <summary>
        /// SDKGEPOPR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKGEPOPR";
        /// <summary>
        /// 19.2.8.质押开票经办请求内容
        /// </summary>
        public NTGAGOPRX NTGAGOPRX { get; set; }
        /// <summary>
        /// 19.2.8.质押开票经办请求内容
        /// </summary>
        public NTOPNINFX NTOPNINFX { get; set; }
        /// <summary>
        /// 19.2.8.质押开票经办请求集合
        /// </summary>
        [XmlElement("NTTKTINFX")]
        public List<NTTKTINFX> List { get; set; }
    }
}
