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
    /// 17.13.虚拟户内部转账请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ17_13 : CMBBase<RQINFO>, IRequest<RS17_13>
    {
        /// <summary>
        /// NTDMATRX
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDMATRX";
        /// <summary>
        /// 17.13.虚拟户内部转账请求内容
        /// </summary>
        public NTDMATRXX1 NTDMATRXX1 { get; set; }
    }
    /// <summary>
    /// 17.13.虚拟户内部转账请求内容
    /// </summary>
    public class NTDMATRXX1
    {
        /// <summary>
        /// 账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 付款方虚拟户编号	C(20)
        /// </summary>
        public string DMADBT { get; set; }
        /// <summary>
        /// 收款方虚拟户编号	C(20)
        /// </summary>
        public string DMACRT { get; set; }
        /// <summary>
        /// 转账金额	M
        /// </summary>
        public decimal TRXAMT { get; set; }
        /// <summary>
        /// 交易摘要	Z(42)
        /// </summary>
        public string TRXTXT { get; set; }
    }
}
