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
    /// 7.2.查询委托贷款合同请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ7_2 : CMBBase<RQINFO>, IRequest<RS7_2>
    {
        /// <summary>
        /// GetALContract
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "GetALContract";
        /// <summary>
        /// 7.2.查询委托贷款合同请求内容
        /// </summary>
        public NCACRQRYX NCACRQRYX { get; set; }
    }
    /// <summary>
    /// 7.2.查询委托贷款合同请求内容
    /// </summary>
    public class NCACRQRYX
    {
        /// <summary>
        /// 分行号	C(2,2)	附录A.1
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 账户	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
    }
}
