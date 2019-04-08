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
    /// 17.10.查询虚拟户余额和当月积数请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ17_10 : CMBBase<RQINFO>, IRequest<RS17_10>
    {
        /// <summary>
        /// NTDMABAL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDMABAL";
        /// <summary>
        /// 17.10.查询虚拟户余额和当月积数请求内容
        /// </summary>
        public NTDMABALX NTDMABALX { get; set; }
    }
    /// <summary>
    /// 17.10.查询虚拟户余额和当月积数请求内容
    /// </summary>
    public class NTDMABALX
    {
        /// <summary>
        /// 账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 虚拟户编号	C(20)   填空表示查询该账号下所有虚拟户信息
        /// </summary>
        public string DMANBR { get; set; }
    }
}
