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
    /// 8.6.10.组合存款利息详细查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_6_10 : CMBBase<RQINFO>, IRequest<RS8_6_10>
    {
        /// <summary>
        /// NTCMAQIT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCMAQIT";
        /// <summary>
        /// 8.6.10.组合存款利息详细查询请求内容
        /// </summary>
        public NTCMAQITX1 NTCMAQITX1 { get; set; }
    }
    /// <summary>
    /// 8.6.10.组合存款利息详细查询请求内容
    /// </summary>
    public class NTCMAQITX1
    {
        /// <summary>
        /// 活期户口号 	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 交易套号	C(15)
        /// </summary>
        public string TRXSET { get; set; }
        /// <summary>
        /// 保留字段   	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
