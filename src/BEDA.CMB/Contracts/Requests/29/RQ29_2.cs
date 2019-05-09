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
    /// 29.2.商户清分交易处理请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ29_2 : CMBBase<RQINFO>, IRequest<RS29_2>
    {
        /// <summary>
        /// NTSTMTRS
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTSTMTRS";
        /// <summary>
        /// 29.2.商户清分交易处理请求内容
        /// </summary>
        public NTSTMTRSX1 NTSTMTRSX1 { get; set; }
    }
    /// <summary>
    /// 29.2.商户清分交易处理请求内容
    /// </summary>
    public class NTSTMTRSX1
    {
        /// <summary>
        /// 业务模式	C(5)
        /// </summary>
        public string MODNBR { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string BUSREF { get; set; }
        /// <summary>
        /// 分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 行内商户号	C(20)
        /// </summary>
        public string MCHSID { get; set; }
        /// <summary>
        /// 收款账号	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 清分金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
    }
}
