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
    /// 3.12.6.5定活互转结构性存款支取请求主体
    /// </summary>
    public class V1_STRUCTTODEMANDTRNRQ : IRequest<V1_STRUCTTODEMANDTRNRS>
    {
        /// <summary>
        /// 3.12.6.5定活互转结构性存款支取请求主体
        /// </summary>
        public STRUCTTODEMANDTRNRQ STRUCTTODEMANDTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.12.6.5定活互转结构性存款支取请求主体
    /// </summary>
    public class STRUCTTODEMANDTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.12.6.5定活互转结构性存款支取请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public STRUCTTODEMANDTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.12.6.5定活互转结构性存款支取请求内容
    /// </summary>
    public class STRUCTTODEMANDTRN_RQBODY
    {
        /// <summary>
        /// 上网登记的人民币活期账号	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string DEMANDACCT { get; set; }
        /// <summary>
        /// 结构性存款账号	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string STRUCTACCT { get; set; }
        /// <summary>
        /// 结构性存款开放式产品序号	必输
        /// </summary>
        [XmlElement(Order = 3)]
        public string PRODUCTNO { get; set; }
        /// <summary>
        /// 支取金额，decimal(17,2)	必输
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal AMOUNT { get; set; }
    }
}
