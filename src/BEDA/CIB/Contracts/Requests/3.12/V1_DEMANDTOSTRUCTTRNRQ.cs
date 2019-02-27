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
    /// 3.12.6.2定活互转结构性存款开户请求主体
    /// </summary>
    public class V1_DEMANDTOSTRUCTTRNRQ : IRequest<V1_DEMANDTOSTRUCTTRNRS>
    {
        /// <summary>
        /// 3.12.6.2定活互转结构性存款开户请求主体
        /// </summary>
        public DEMANDTOSTRUCTTRNRQ DEMANDTOSTRUCTTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.12.6.2定活互转结构性存款开户请求主体
    /// </summary>
    public class DEMANDTOSTRUCTTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.12.6.2定活互转结构性存款开户请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public DEMANDTOSTRUCTTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.12.6.2定活互转结构性存款开户请求内容
    /// </summary>
    public class DEMANDTOSTRUCTTRN_RQBODY
    {
        /// <summary>
        /// 上网登记的人民币活期账号	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string DEMANDACCT { get; set; }
        /// <summary>
        /// 结构性存款产品序号	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string PRODUCTNO { get; set; }
        /// <summary>
        /// 结构性存款产品名称	必输
        /// </summary>
        [XmlElement(Order = 3)]
        public string PRODUCTNAME { get; set; }
        /// <summary>
        /// 开户金额，decimal(17,2) 	必输
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal AMOUNT { get; set; }
    }
}
