using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.12.5.4定活互转智能通知存款撤销响应主体
    /// </summary>
    public class V1_ICCANCELTRNRS : IResponse
    {
        /// <summary>
        /// 3.12.5.4定活互转智能通知存款撤销响应主体
        /// </summary>
        public ICCANCELTRNRS ICCANCELTRNRS { get; set; }
    }
    /// <summary>
    /// 3.12.5.4定活互转智能通知存款撤销响应主体
    /// </summary>
    public class ICCANCELTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.12.5.4定活互转智能通知存款撤销响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public ICCANCELTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.12.5.4定活互转智能通知存款撤销响应内容
    /// </summary>
    public class ICCANCELTRN_RSBODY : XFERPRCSTS_RSBODY
    {
    }
}
