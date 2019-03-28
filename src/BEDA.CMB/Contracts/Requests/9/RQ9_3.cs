using BEDA.CMB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Requests
{
    /// <summary>
    /// 9.3.信用额度查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ9_3 : CMBBase<RQINFO>, IRequest<RS9_3>
    {
        /// <summary>
        /// NTNETDZC
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTNETDZC";
        /// <summary>
        /// 9.3.信用额度查询请求内容
        /// </summary>
        public NTNETDZCY1 NTNETDZCY1 { get; set; }
    }
}
