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
    /// 8.11.4.查询保证金账户请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_11_4 : CMBBase<RQINFO>, IRequest<RS8_11_4>
    {
        /// <summary>
        /// NTBTFQFU
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTBTFQFU";
        /// <summary>
        /// 8.11.4.查询保证金账户请求内容
        /// </summary>
        public NTBTFQFUX NTBTFQFUX { get; set; }
    }
    /// <summary>
    /// 8.11.4.查询保证金账户请求内容
    /// </summary>
    public class NTBTFQFUX
    {
        /// <summary>
        /// 业务模式	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 银行帐号	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 货币代码	C(2)	A.3 货币代码表
        /// </summary>
        public string CCYNBR { get; set; }
    }
}
