using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.14.1实体主账户(3.14.2/3.14.3虚拟子账户)绑定的代理支付/查询响应主体
    /// </summary>
    public class V1_VAPMTTRNRS : IResponse
    {
        /// <summary>
        /// 3.14.1实体主账户(3.14.2/3.14.3虚拟子账户)绑定的代理支付/查询响应主体
        /// </summary>
        public VAPMTTRNRS VAPMTTRNRS { get; set; }
    }
    /// <summary>
    /// 3.14.1实体主账户(3.14.2/3.14.3虚拟子账户)绑定的代理支付/查询响应主体
    /// </summary>
    public class VAPMTTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 返回交易处理信息节点
        /// </summary>
        [XmlElement(Order = 3)]
        public VAXFERRS VAXFERRS { get; set; }
    }
    /// <summary>
    /// 3.14.1实体主账户(3.14.2/3.14.3虚拟子账户)绑定的代理支付/查询响应内容
    /// </summary>
    public class VAXFERRS
    {
        /// <summary>
        /// 企业虚账户对应的实体兴业账户	必回
        /// </summary>
        [XmlElement(Order = 1)]
        public string FUNDACCT { get; set; }
        /// <summary>
        /// 转账处理信息返回
        /// </summary>
        [XmlElement(Order = 2)]
        public XFERRS XFERRS { get; set; }
    }
}
