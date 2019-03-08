using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.23.1生成批量余额对账指令响应主体
    /// </summary>
    public class V1_BATCHCHECKTRNRS : IResponse
    {
        /// <summary>
        /// 3.23.1生成批量余额对账指令响应主体
        /// </summary>
        public BATCHCHECKTRNRS BATCHCHECKTRNRS { get; set; }
    }
    /// <summary>
    /// 3.23.1生成批量余额对账指令响应主体
    /// </summary>
    public class BATCHCHECKTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.23.1生成批量余额对账指令响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public BATCHCHECKTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.23.1生成批量余额对账指令响应内容
    /// </summary>
    public class BATCHCHECKTRN_RSBODY
    {
        /// <summary>
        /// 对账单账期	必回
        /// </summary>
        [XmlElement(Order = 1)]
        public string PAYMENTDAYS { get; set; }
        /// <summary>
        /// 对账结果	必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string RECONCILERESULT { get; set; }
    }
}
