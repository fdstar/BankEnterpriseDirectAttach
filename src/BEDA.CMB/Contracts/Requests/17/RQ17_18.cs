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
    /// 17.18.流水号查询虚拟户交易信息请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ17_18 : CMBBase<RQINFO>, IRequest<RS17_18>
    {
        /// <summary>
        /// NTDMTQR2
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDMTQR2";
        /// <summary>
        /// 17.18.流水号查询虚拟户交易信息请求内容
        /// </summary>
        public NTDMTQR2X1 NTDMTQR2X1 { get; set; }
    }
    /// <summary>
    /// 17.18.流水号查询虚拟户交易信息请求内容
    /// </summary>
    public class NTDMTQR2X1
    {
        /// <summary>
        /// 分行号	C(2) 
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 虚拟户编号	C (20)
        /// </summary>
        public string DMANBR { get; set; }
        /// <summary>
        /// 交易流水号	C (15)
        /// </summary>
        public string TRSNBR { get; set; }
    }
}
