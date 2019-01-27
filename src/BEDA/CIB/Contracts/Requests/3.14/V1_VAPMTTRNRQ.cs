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
    /// 3.14.1实体主账户(3.14.2/3.14.3虚拟子账户)绑定的代理支付/查询请求主体
    /// </summary>
    public class V1_VAPMTTRNRQ : IRequest<V1_VAPMTTRNRS>
    {
        /// <summary>
        /// 3.14.1实体主账户(3.14.2/3.14.3虚拟子账户)绑定的代理支付/查询请求主体
        /// </summary>
        public VAPMTTRNRQ VAPMTTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.14.1实体主账户(3.14.2/3.14.3虚拟子账户)绑定的代理支付/查询请求主体
    /// </summary>
    public class VAPMTTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 请求支付信息节点,如果不输则为查询客户端交易流水（TRNUID）的交易情况	非必输
        /// </summary>
        [XmlElement(Order = 1)]
        public VAXFERRQ VAXFERRQ { get; set; }
    }
    /// <summary>
    /// 3.14.1实体主账户(3.14.2/3.14.3虚拟子账户)绑定的代理支付/查询请求内容
    /// </summary>
    public class VAXFERRQ
    {
        /// <summary>
        /// 账户信息(财务公司在本行开立的银行实体账户),18位，一个企业网银客户号下只能登记一个财务公司实体账户	非必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string FUNDACCT { get; set; }
        /// <summary>
        /// 转账必要信息	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public XFERINFO XFERINFO { get; set; }
    }
}
