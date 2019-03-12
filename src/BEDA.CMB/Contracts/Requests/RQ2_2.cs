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
    /// 2.2.查询账户详细信息请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ2_2 : CMBBase<RQINFO>, IRequest<RS2_2>
    {
        /// <summary>
        /// GetAccInfo
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "GetAccInfo";
        /// <summary>
        /// 2.2.查询账户详细信息请求内容
        /// </summary>
        [XmlElement("SDKACINFX")]
        public List<SDKACINFX> List { get; set; }
    }
    /// <summary>
    /// 2.2.查询账户详细信息请求内容
    /// </summary>
    public class SDKACINFX
    {
        /// <summary>
        /// 分行号	N(2)	附录A.1
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 分行名称	Z(1,62)	附录A.1
        /// </summary>
        public string C_BBKNBR { get; set; }
        /// <summary>
        /// 账号	C(1,35)
        /// </summary>
        public string ACCNBR { get; set; }
    }
}
