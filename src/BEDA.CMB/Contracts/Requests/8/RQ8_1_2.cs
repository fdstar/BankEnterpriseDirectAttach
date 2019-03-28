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
    /// 8.1.2.查询登记机构NTFNDTAA请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_1_2 : CMBBase<RQINFO>, IRequest<RS8_1_2>
    {
        /// <summary>
        /// NTFNDTAA
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTFNDTAA";
        /// <summary>
        /// 8.1.2.查询登记机构NTFNDTAA请求内容 已默认初始化
        /// </summary>
        public NTFNDTAAY NTFNDTAAY { get; set; } = new NTFNDTAAY();
    }
    /// <summary>
    /// 8.1.2.查询登记机构NTFNDTAA请求内容
    /// </summary>
    public class NTFNDTAAY
    {
    }
}
