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
    /// 8.8.3.查询券商保证金余额请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_8_3 : CMBBase<RQINFO>, IRequest<RS8_8_3>
    {
        /// <summary>
        /// NTSECBAL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTSECBAL";
        /// <summary>
        /// 8.8.3.查询券商保证金余额请求内容
        /// </summary>
        public NTSECBALX NTSECBALX { get; set; }
        /// <summary>
        /// 8.8.3.查询券商保证金余额请求内容
        /// </summary>
        public NTSECOPRX1 NTSECOPRX1 { get; set; }
    }
    /// <summary>
    /// 8.8.3.查询券商保证金余额请求内容
    /// </summary>
    public class NTSECBALX
    {
        /// <summary>
        /// 银行帐号	C(36)   请在银行账号前加上2位分行号
        /// </summary>
        public string BNKACC { get; set; }
        /// <summary>
        /// 货币代码	C(2)	A.3 货币代码表
        /// </summary>
        public string CCYCOD { get; set; }
    }
}
