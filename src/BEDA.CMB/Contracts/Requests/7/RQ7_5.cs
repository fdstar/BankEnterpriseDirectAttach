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
    /// 7.5.查询待确认委托贷款业务请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ7_5 : CMBBase<RQINFO>, IRequest<RS7_5>
    {
        /// <summary>
        /// NTWAKALN
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTWAKALN";
        /// <summary>
        /// 7.5.查询待确认委托贷款业务请求内容
        /// </summary>
        public NTWAKALNX NTWAKALNX { get; set; }
    }
    /// <summary>
    /// 7.5.查询待确认委托贷款业务请求内容
    /// </summary>
    public class NTWAKALNX
    {
        /// <summary>
        /// 业务类型	C(6)	N04030：委托贷款
        /// </summary>
        public string BUSCOD { get; set; }
        /// <summary>
        /// 业务模式	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 分行号	C(2,2)	附录A.1
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 客户编号	C(10)
        /// </summary>
        public string CLTNBR { get; set; }
    }
}
