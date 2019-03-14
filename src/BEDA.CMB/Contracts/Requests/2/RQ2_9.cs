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
    /// 2.9.批量查询余额请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ2_9 : CMBBase<RQINFO>, IRequest<RS2_9>
    {
        /// <summary>
        /// NTQADINF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQADINF";
        /// <summary>
        /// 2.9.批量查询余额请求内容  重复次数1~30
        /// </summary>
        [XmlElement("NTQADINFX")]
        public List<NTQADINFX> List { get; set; }
    }
    /// <summary>
    /// 2.9.批量查询余额请求内容
    /// </summary>
    public class NTQADINFX
    {
        /// <summary>
        /// 分行号	N(2)	附录A.1
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 账号	C(1,35)
        /// </summary>
        public string ACCNBR { get; set; }
    }
}
