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
    /// 23.15.公司卡激活请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ23_15 : CMBBase<RQINFO>, IRequest<RS23_15>
    {
        /// <summary>
        /// NTCPRACT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCPRACT";
        /// <summary>
        /// 23.15.公司卡激活请求内容
        /// </summary>
        public NTCPRCRDX NTCPRCRDX { get; set; }
        /// <summary>
        /// 23.15.公司卡激活请求内容
        /// </summary>
        public NTCPRACTX NTCPRACTX { get; set; }
    }
    /// <summary>
    /// 23.15.公司卡激活请求内容
    /// </summary>
    public class NTCPRACTX
    {
        /// <summary>
        /// 公司卡号	C(20)
        /// </summary>
        public string PSBNBR { get; set; }
        /// <summary>
        /// 初始密码	C(20)
        /// </summary>
        public string INIPWD { get; set; }
        /// <summary>
        /// 查询密码	C(20)
        /// </summary>
        public string QRYPWD { get; set; }
        /// <summary>
        /// 取款密码	C(20)
        /// </summary>
        public string PRCPWD { get; set; }
    }
}
