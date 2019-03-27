using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Responses
{
    /// <summary>
    /// 7.1.查询委托贷款业务控制信息响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS7_1 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTQALCTL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQALCTL";
        /// <summary>
        /// 7.1.查询委托贷款业务控制信息响应集合
        /// </summary>
        [XmlElement("NTQALACCZ")]
        public List<NTQALACCZ> List { get; set; }
    }
    /// <summary>
    /// 7.1.查询委托贷款业务控制信息响应内容
    /// </summary>
    public class NTQALACCZ
    {
        /// <summary>
        /// 分行号	C(2,2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 部门号	C(6)
        /// </summary>
        public string BRNNBR { get; set; }
        /// <summary>
        /// 账户注解	Z(62)
        /// </summary>
        public string ACCNAM { get; set; }
        /// <summary>
        /// 币种	C(2,2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 客户关系编号	C(10)
        /// </summary>
        public string RELNBR { get; set; }
        /// <summary>
        /// 客户编号	C(10,10)
        /// </summary>
        public string CLTNBR { get; set; }
        /// <summary>
        /// 保留字段（新系统机构号）	C(30)   前6位为新系统机构号
        /// </summary>
        public string RSV30Z { get; set; }
    }
}
