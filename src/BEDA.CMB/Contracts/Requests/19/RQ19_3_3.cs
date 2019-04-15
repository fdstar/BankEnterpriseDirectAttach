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
    /// 19.3.3.电子商票背书转让经办请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ19_3_3 : CMBBase<RQINFO>, IRequest<RS19_3_3>
    {
        /// <summary>
        /// SDKMWTOPR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKMWTOPR";
        /// <summary>
        /// 19.3.3.电子商票背书转让经办请求内容
        /// </summary>
        public NTWRTOPRX NTWRTOPRX { get; set; }
        /// <summary>
        /// 19.3.3.电子商票背书转让经办请求集合
        /// </summary>
        [XmlElement("NTTKTINFX")]
        public List<NTTKTINFX> List { get; set; }
    }
}
