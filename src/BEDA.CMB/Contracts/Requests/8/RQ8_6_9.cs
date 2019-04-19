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
    /// 8.6.9.组合存款利息批次列表查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_6_9 : CMBBase<RQINFO>, IRequest<RS8_6_9>
    {
        /// <summary>
        /// NTCMAQLS
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCMAQLS";
        /// <summary>
        /// 8.6.9.组合存款利息批次列表查询请求内容
        /// </summary>
        public NTCMAQLSY1 NTCMAQLSY1 { get; set; }
    }
    /// <summary>
    /// 8.6.9.组合存款利息批次列表查询请求内容
    /// </summary>
    public class NTCMAQLSY1
    {
        /// <summary>
        /// 活期户口号 	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 协议编号	C(8)
        /// </summary>
        public string CSTNBR { get; set; }
        /// <summary>
        /// 付息批次号	C(10)
        /// </summary>
        public string ITTNBR { get; set; }
        /// <summary>
        /// 保留字段   	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
