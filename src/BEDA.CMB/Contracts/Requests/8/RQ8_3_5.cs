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
    /// 8.3.5.当前持仓信息查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_3_5 : CMBBase<RQINFO>, IRequest<RS8_3_5>
    {
        /// <summary>
        /// NTQDIACT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQDIACT";
        /// <summary>
        /// 8.3.5.当前持仓信息查询请求内容
        /// </summary>
        public NTQDIACCX NTQDIACCX { get; set; }
    }
    /// <summary>
    /// 8.3.5.当前持仓信息查询请求内容
    /// </summary>
    public class NTQDIACCX
    {
        /// <summary>
        /// 分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 账号	C(35)
        /// </summary>
        public string EACNBR { get; set; }
    }
}
