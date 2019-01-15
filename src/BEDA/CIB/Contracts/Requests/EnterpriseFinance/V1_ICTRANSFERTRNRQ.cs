using BEDA.CIB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 快速转账支付及其指令查询（不采用工作流）请求主体
    /// </summary>
    public class V1_ICTRANSFERTRNRQ : IRequest<V1_ICTRANSFERTRNRS>
    {
        /// <summary>
        /// 快速转账支付及其指令查询（不采用工作流）
        /// </summary>
        public ICTRANSFERTRNRQ ICTRANSFERTRNRQ { get; set; }
    }
    /// <summary>
    /// 快速转账支付及其指令查询（不采用工作流）
    /// </summary>
    public class ICTRANSFERTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 请求支付信息节点,如果不输则为查询客户端交易流水号（TRNUID）的交易情况
        /// </summary>
        [XmlElement("XMPTRQ", Order = 1)]
        public XMPTRQ<RQACCT> XMPTRQ { get; set; }
    }
    /// <summary>
    /// 请求支付信息节点,如果不输则为查询客户端交易流水号（TRNUID）的交易情况
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class XMPTRQ<T>
    {
        /// <summary>
        /// 内部账户信息，内部账号，18位，非必输可不填
        /// </summary>
        [XmlElement(Order = 0)]
        public T FUNDACCT { get; set; }
        /// <summary>
        /// 转账必要信息  必输
        /// </summary>
        [XmlElement(Order = 1)]
        public XFERINFO XFERINFO { get; set; }
    }
}
