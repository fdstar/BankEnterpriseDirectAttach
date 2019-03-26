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
    /// 5.5.查询来证要素信息请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ5_5 : CMBBase<RQINFO>, IRequest<RS5_5>
    {
        /// <summary>
        /// NTLCBINF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTLCBINF";
        /// <summary>
        /// 5.5.查询来证要素信息请求集合
        /// </summary>
        [XmlElement("NTLCBINFX1")]
        public List<NTLCBINFX1> List { get; set; }
    }
    /// <summary>
    /// 5.5.查询来证要素信息请求内容
    /// </summary>
    public class NTLCBINFX1
    {
        /// <summary>
        /// 流程实例号	C(10)   从开证申请经办或者申请人查询开证申请信息的返回接口获得
        /// </summary>
        public string REQNBR { get; set; }
    }
}
