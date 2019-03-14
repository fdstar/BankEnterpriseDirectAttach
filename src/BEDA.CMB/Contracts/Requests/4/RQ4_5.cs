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
    /// 4.5.代发工资额度查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ4_5 : CMBBase<RQINFO>, IRequest<RS4_5>
    {
        /// <summary>
        /// NTAGCLMT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTAGCLMT";
        /// <summary>
        /// 4.5.代发工资额度查询请求内容
        /// </summary>
        public NTAGCLMTX1 NTAGCLMTX1 { get; set; }
    }
    /// <summary>
    /// 4.5.代发工资额度查询请求内容
    /// </summary>
    public class NTAGCLMTX1
    {
        /// <summary>
        /// 账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
    }
}
