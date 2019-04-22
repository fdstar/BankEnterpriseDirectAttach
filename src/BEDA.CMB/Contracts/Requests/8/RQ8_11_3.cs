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
    /// 8.11.3.查询保证金余额请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_11_3 : CMBBase<RQINFO>, IRequest<RS8_11_3>
    {
        /// <summary>
        /// NTBTFBAL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTBTFBAL";
        /// <summary>
        /// 8.11.3.查询保证金余额请求内容
        /// </summary>
        public NTSECBALX1 NTSECBALX1 { get; set; }
        /// <summary>
        /// 8.11.3.查询保证金余额请求内容
        /// </summary>
        public NTBTFOPRX1 NTBTFOPRX1 { get; set; }
    }
    /// <summary>
    /// 8.11.3.查询保证金余额请求内容
    /// </summary>
    public class NTSECBALX1
    {
        /// <summary>
        /// 资金分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 银行帐号	C(36)
        /// </summary>
        public string BNKACC { get; set; }
        /// <summary>
        /// 货币代码	C(2)	A.3 货币代码表
        /// </summary>
        public string CCYCOD { get; set; }
    }
}
