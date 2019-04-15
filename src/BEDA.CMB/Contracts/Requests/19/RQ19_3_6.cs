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
    /// 19.3.6.电子商票托收经办请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ19_3_6 : CMBBase<RQINFO>, IRequest<RS19_3_6>
    {
        /// <summary>
        /// SDKRMCHOR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKRMCHOR";
        /// <summary>
        /// 19.3.6.电子商票托收经办请求内容
        /// </summary>
        public NTRCVOPRX NTRCVOPRX { get; set; }
        /// <summary>
        /// 19.3.6.电子商票托收经办请求集合
        /// </summary>
        [XmlElement("NTTKTINFX")]
        public List<NTTKTINFX> List { get; set; }
    }
}
