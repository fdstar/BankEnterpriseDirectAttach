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
    /// 8.7.4.归集存款协议明细查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_7_4 : CMBBase<RQINFO>, IRequest<RS8_7_4>
    {
        /// <summary>
        /// NTCMCINF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCMCINF";
        /// <summary>
        /// 8.7.4.归集存款协议明细查询请求内容
        /// </summary>
        public NTCMCINFX1 NTCMCINFX1 { get; set; }
    }
    /// <summary>
    /// 8.7.4.归集存款协议明细查询请求内容
    /// </summary>
    public class NTCMCINFX1
    {
        /// <summary>
        /// 活期帐号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
    }
}
