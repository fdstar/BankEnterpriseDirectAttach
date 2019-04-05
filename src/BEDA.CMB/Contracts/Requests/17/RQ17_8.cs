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
    /// 17.8.查询虚拟户当天交易请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ17_8 : CMBBase<RQINFO>, IRequest<RS17_8>
    {
        /// <summary>
        /// NTDMTLST
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDMTLST";
        /// <summary>
        /// 17.8.查询虚拟户当天交易请求内容
        /// </summary>
        public NTDMTLSTY NTDMTLSTY { get; set; }
    }
    /// <summary>
    /// 17.8.查询虚拟户当天交易请求内容
    /// </summary>
    public class NTDMTLSTY
    {
        /// <summary>
        /// 账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 虚拟户编号	C(20)   填空表示查询该账号下所有虚拟户信息（包括默认虚拟户）
        /// </summary>
        public string DMANBR { get; set; }
    }
}
