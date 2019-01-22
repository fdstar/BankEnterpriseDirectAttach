using BEDA.CIB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 3.6.3虚拟子账户信息查询请求主体
    /// </summary>
    public class V1_VSASUBACCTINFOTRNRQ : IRequest<V1_VSASUBACCTINFOTRNRS>
    {
        /// <summary>
        /// 3.6.3虚拟子账户信息查询请求主体
        /// </summary>
        public VSASUBACCTINFOTRNRQ VSASUBACCTINFOTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.6.3虚拟子账户信息查询请求主体
    /// </summary>
    public class VSASUBACCTINFOTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.6.3虚拟子账户信息查询请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public INQUIRYINFO INQUIRYINFO { get; set; }
    }
    /// <summary>
    /// 3.6.3虚拟子账户信息查询请求内容
    /// </summary>
    public class INQUIRYINFO
    {
        /// <summary>
        /// 18位主账户	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string MAINACCT { get; set; }
        /// <summary>
        /// 子账户:ALL全部子账户 XXXX-具体子账户 默认ALL	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string SUBACCT { get; set; } = "ALL";
        /// <summary>
        /// 开始行，每行20笔，默认1	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public int STARTROW { get; set; } = 1;
        /// <summary>
        /// 查询模式，非必输
        /// 1-查询某个子账户详细信息，响应增加详细信息：利率代号、利率生效日期、利率比例浮动值、利率点数浮动值、执行利率、计息标识、结息标识、结息周期、首次结息日期、应加应减积数、未结利息、预算标识、预算额度、预算额度起始日期、预算额度到期日期、额度循环标志、透资额度、结算账号、主账户户名、主账户余额、子账户汇总余额
        /// </summary>
        [XmlElement(Order = 3)]
        public string PATTERN { get; set; }
    }
}
