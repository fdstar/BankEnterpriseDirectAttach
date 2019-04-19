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
    /// 8.5.7.智能定期业务成功交易查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_5_7 : CMBBase<RQINFO>, IRequest<RS8_5_7>
    {
        /// <summary>
        /// NTTCATRX
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTTCATRX";
        /// <summary>
        /// 8.5.7.智能定期业务成功交易查询请求内容
        /// </summary>
        public NTTCATRXX1 NTTCATRXX1 { get; set; }
    }
    /// <summary>
    /// 8.5.7.智能定期业务成功交易查询请求内容
    /// </summary>
    public class NTTCATRXX1
    {
        /// <summary>
        /// 流程实例号	C(10)   只能查询交易成功的业务
        /// </summary>
        public string REQNBR { get; set; }
    }
}
