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
    /// 28.2.8.虚拟户内部转账请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ28_2_8 : CMBBase<RQINFO>, IRequest<RS28_2_8>
    {
        /// <summary>
        /// NTDMITRX
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDMITRX";
        /// <summary>
        /// 28.2.8.虚拟户内部转账请求内容
        /// </summary>
        public NTBUSMODY NTBUSMODY { get; set; }
        /// <summary>
        /// 28.2.8.虚拟户内部转账请求内容
        /// </summary>
        public NTDMITRXX1 NTDMITRXX1 { get; set; }
    }
    /// <summary>
    /// 28.2.8.虚拟户内部转账请求内容
    /// </summary>
    public class NTDMITRXX1
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
        /// 借方虚拟户编号	C(20)
        /// </summary>
        public string DMADBT { get; set; }
        /// <summary>
        /// 贷方虚拟户编号	C(20)
        /// </summary>
        public string DMACRT { get; set; }
        /// <summary>
        /// 交易金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 交易摘要	Z(42)
        /// </summary>
        public string TRSTXT { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
    }
}
