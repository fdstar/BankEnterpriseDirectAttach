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
    /// 12.5.2.实时购结汇综合查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ12_5_2 : CMBBase<RQINFO>, IRequest<RS12_5_2>
    {
        /// <summary>
        /// NTLSTEXC
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTLSTEXC";
        /// <summary>
        /// 12.5.2.实时购结汇综合查询请求内容
        /// </summary>
        public NTLSTJSHY NTLSTJSHY { get; set; }
    }
}
