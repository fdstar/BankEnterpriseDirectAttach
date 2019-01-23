using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.6.5虚拟子帐户对外支付响应主体
    /// </summary>
    public class V1_VATTRNRS : IResponse
    {
        /// <summary>
        /// 3.6.5虚拟子帐户对外支付响应主体
        /// </summary>
        public VATTRNRS VATTRNRS { get; set; }
    }
    /// <summary>
    /// 3.6.5虚拟子帐户对外支付响应主体
    /// </summary>
    public class VATTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.6.5虚拟子帐户对外支付响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public VATRS VATRS { get; set; }
    }
    /// <summary>
    /// 3.6.5虚拟子帐户对外支付响应内容
    /// </summary>
    public class VATRS
    {
        /// <summary>
        /// 支付类型：1－虚拟子账户对外支付	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public int VATTYPE { get; set; } = 1;
        /// <summary>
        /// 实体扣款账户，最大18位	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string MAINACCT { get; set; }
        /// <summary>
        /// 虚拟小序号, 最大6位	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string SUBACCT { get; set; }
        /// <summary>
        /// 对外支付处理信息返回
        /// </summary>
        [XmlElement(Order = 3)]
        public XFERRS XFERRS { get; set; }
    }
}
