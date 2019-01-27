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
    /// 3.12.2定期转活期请求主体
    /// </summary>
    public class V1_TIME2DEMANDTRNRQ : IRequest<V1_FINANCINGTRNRS>
    {
        /// <summary>
        /// 3.12.2定期转活期请求主体
        /// </summary>
        public TIME2DEMANDTRNRQ TIME2DEMANDTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.12.2定期转活期请求主体
    /// </summary>
    public class TIME2DEMANDTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.12.2定期转活期请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public TIME2DEMANDINFO TIME2DEMANDINFO { get; set; }
    }
    /// <summary>
    /// 3.12.2定期转活期请求内容
    /// </summary>
    public class TIME2DEMANDINFO
    {
        /// <summary>
        /// 定期账户代号18位	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string TIMEACCT { get; set; }
    }
}
