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
    /// 8.7.1.归集存款协议账号查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_7_1 : CMBBase<RQINFO>, IRequest<RS8_7_1>
    {
        /// <summary>
        /// NTCMCQAC
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCMCQAC";
        /// <summary>
        /// 8.7.1.归集存款协议账号查询请求内容
        /// </summary>
        public NTCMCQACX1 NTCMCQACX1 { get; set; }
    }
    /// <summary>
    /// 8.7.1.归集存款协议账号查询请求内容
    /// </summary>
    public class NTCMCQACX1
    {
        /// <summary>
        /// 业务模式	C(5)    可通过前置机或者查询可经办的业务模式信息（ListMode）获得，业务代码为N36080
        /// </summary>
        public string BUSMOD { get; set; }
    }
}
