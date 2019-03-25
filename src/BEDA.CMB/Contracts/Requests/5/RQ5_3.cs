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
    /// 5.3.查询开证申请详细信息请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ5_3 : CMBBase<RQINFO>, IRequest<RS5_3>
    {
        /// <summary>
        /// NTLCAINF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTLCAINF";
        /// <summary>
        /// 5.3.查询开证申请详细信息请求集合
        /// </summary>
        [XmlElement("NTLCAINFX1")]
        public List<NTLCAINFX1> List { get; set; }
    }
    /// <summary>
    /// 5.3.查询开证申请详细信息请求内容
    /// </summary>
    public class NTLCAINFX1
    {
        /// <summary>
        /// 流程实例号	C(10)   从开证申请经办或者申请人查询开证申请信息的返回接口获得
        /// </summary>
        public string REQNBR { get; set; }
    }
}
