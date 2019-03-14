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
    /// 1.5.取系统信息请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ1_5 : CMBBase<RQINFO>, IRequest<RS1_5>
    {
        /// <summary>
        /// GetSysInfo
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "GetSysInfo";
        /// <summary>
        /// 1.5.取系统信息请求内容
        /// </summary>
        public SDKSYINFX SDKSYINFX { get; set; }
    }
    /// <summary>
    /// 1.5.取系统信息请求内容
    /// </summary>
    public class SDKSYINFX
    {
        /// <summary>
        /// 系统信息类别	C(6)  目前只支持取用户信息USRINF
        /// </summary>
        public string SYSTYP { get; set; } = "USRINF";
    }
}
