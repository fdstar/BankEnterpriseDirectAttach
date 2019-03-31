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
    /// 11.3.查询代理清算申请详细信息请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ11_3 : CMBBase<RQINFO>, IRequest<RS11_3>
    {
        /// <summary>
        /// NTAGPINF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTAGPINF";
        /// <summary>
        /// 11.3.查询代理清算申请详细信息请求集合
        /// </summary>
        [XmlElement("NTAGPINFX1")]
        public List<NTAGPINFX1> List { get; set; }
    }
    /// <summary>
    /// 11.3.查询代理清算申请详细信息请求内容
    /// </summary>
    public class NTAGPINFX1
    {
        /// <summary>
        /// 流程实例号	C(10)   查询所有代理清算申请结果返回
        /// </summary>
        public string REQNBR { get; set; }
    }
}
