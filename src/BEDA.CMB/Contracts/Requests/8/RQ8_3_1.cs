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
    /// 8.3.1.查询有权经办账号列表请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_3_1 : CMBBase<RQINFO>, IRequest<RS8_3_1>
    {
        /// <summary>
        /// NTQDIACC
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQDIACC";
        /// <summary>
        /// 8.3.1.查询有权经办账号列表请求内容
        /// </summary>
        public NTQACBUSX NTQACBUSX { get; set; }
    }
    /// <summary>
    /// 8.3.1.查询有权经办账号列表请求内容
    /// </summary>
    public class NTQACBUSX
    {
        /// <summary>
        /// 业务模式编号	C(5)    不能同时为空，必须填一个。（如果两者都不为空以BUSMOD为准）
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 业务模式名称	Z(200)  不能同时为空，必须填一个。（如果两者都不为空以BUSMOD为准）
        /// </summary>
        public string MODALS { get; set; }
    }
}
