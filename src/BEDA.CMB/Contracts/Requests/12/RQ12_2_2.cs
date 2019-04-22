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
    /// 12.2.2.支付机构经办实时结汇请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ12_2_2 : CMBBase<RQINFO>, IRequest<RS12_2_2>
    {
        /// <summary>
        /// NTOPREXS
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTOPREXS";
        /// <summary>
        /// 12.2.2.支付机构经办实时结汇请求内容
        /// </summary>
        public NTOPRMODX NTOPRMODX { get; set; }
        /// <summary>
        /// 12.2.2.支付机构经办实时结汇请求内容
        /// </summary>
        public NTOPREXCX1 NTOPREXCX1 { get; set; }
    }
}
