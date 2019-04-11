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
    /// 18.4.删除境外账户经办请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ18_4 : CMBBase<RQINFO>, IRequest<RS18_4>
    {
        /// <summary>
        /// NTDLTCAC
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDLTCAC";
        /// <summary>
        /// 18.4.删除境外账户经办请求内容
        /// </summary>
        public NTOPRMODX NTOPRMODX { get; set; }
        /// <summary>
        /// 18.4.删除境外账户经办请求集合
        /// </summary>
        [XmlElement("NTOPRCACX1")]
        public List<NTOPRCACX1> List { get; set; }
    }
}
