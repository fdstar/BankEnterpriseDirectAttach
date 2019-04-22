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
    /// 8.8.1.银证转账经办请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_8_1 : CMBBase<RQINFO>, IRequest<RS8_8_1>
    {
        /// <summary>
        /// NTSECOPR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTSECOPR";
        /// <summary>
        /// 8.8.1.银证转账经办请求内容
        /// </summary>
        public NTSECOPRX NTSECOPRX { get; set; }
        /// <summary>
        /// 8.8.1.银证转账经办请求内容
        /// </summary>
        public NTSECOPRX1 NTSECOPRX1 { get; set; }
    }
    /// <summary>
    /// 8.8.1.银证转账经办请求内容
    /// </summary>
    public class NTSECOPRX
    {
        /// <summary>
        /// 业务模式	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 资金分行号	C(2)
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
        /// <summary>
        /// 转帐金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 交易类型	C(4)    银转证：8110 证转银：8111
        /// </summary>
        public string TRSCOD { get; set; }
        /// <summary>
        /// 券商密码	C(8)    证转银必输
        /// </summary>
        public string STKPWD { get; set; }
        /// <summary>
        /// 预约流水号	C(20)
        /// </summary>
        public string APPSEL { get; set; }
    }
    /// <summary>
    /// 8.8.1.银证转账经办请求内容
    /// </summary>
    public class NTSECOPRX1
    {
        /// <summary>
        /// 证券公司编号	C(6)
        /// </summary>
        public string CNVNBR { get; set; }
        /// <summary>
        /// 保证金账号	C(30)
        /// </summary>
        public string CPRACT { get; set; }
    }
}
