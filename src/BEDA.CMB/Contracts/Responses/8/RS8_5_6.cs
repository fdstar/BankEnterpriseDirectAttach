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
    /// 8.5.6.智能定期业务申请明细查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_5_6 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTTCADTL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTTCADTL";
        /// <summary>
        /// 8.5.6.智能定期业务申请明细查询响应内容
        /// </summary>
        public NTTCADTLZ1 NTTCADTLZ1 { get; set; }
    }
    /// <summary>
    /// 8.5.6.智能定期业务申请明细查询响应内容
    /// </summary>
    public class NTTCADTLZ1
    {
        /// <summary>
        /// 业务类型	C(6)
        /// </summary>
        public string BUSCOD { get; set; }
        /// <summary>
        /// 业务模式	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 操作类型	C(3)	CTA-活期转智能定期存款 ATC-智能定期存款转活期
        /// </summary>
        public string OPRTYP { get; set; }
        /// <summary>
        /// 分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 活期帐号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 分行号	C(2)
        /// </summary>
        public string FIXBBK { get; set; }
        /// <summary>
        /// 定期帐号	C(35)
        /// </summary>
        public string FIXACC { get; set; }
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 交易金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 客户类别	C(1)    C-普通企业客户 O-离岸客户 F-同业客户
        /// </summary>
        public string CLTTYP { get; set; }
        /// <summary>
        /// 存期	C(6)
        /// </summary>
        public string TERDUM { get; set; }
        /// <summary>
        /// 自动转存标志	C(1)    1-不转存 2-本息转存 3-本金转存，利息转活期
        /// </summary>
        public string ATOFLG { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 错误描述	Z(92)
        /// </summary>
        public string ERRTXT { get; set; }
    }
}
