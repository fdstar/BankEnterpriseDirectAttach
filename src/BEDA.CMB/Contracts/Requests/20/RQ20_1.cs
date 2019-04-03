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
    /// 20.1.查询可经办帐号列表请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ20_1 : CMBBase<RQINFO>, IRequest<RS20_1>
    {
        /// <summary>
        /// NTLKPCTL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTLKPCTL";
        /// <summary>
        /// 20.1.查询可经办帐号列表请求内容
        /// </summary>
        public NTLKPCTLX1 NTLKPCTLX1 { get; set; }
    }
    /// <summary>
    /// 20.1.查询可经办帐号列表请求内容
    /// </summary>
    public class NTLKPCTLX1
    {
        /// <summary>
        /// 业务模式编号	C(5)    不能同时为空，必须填一个。（如果两者都不为空以BUSMOD为准）
        /// </summary>
        public string BUSCOD { get; set; }
        /// <summary>
        /// 业务模式名称	Z(62)
        /// </summary>
        public string MODALS { get; set; }
        /// <summary>
        /// 授权类型	C(1)	1：联动支付 2：联动代发
        /// </summary>
        public string AUTTYP { get; set; }
    }
}
