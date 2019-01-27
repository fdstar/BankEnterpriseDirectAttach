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
    /// 3.5.6第三方存管资金查询请求主体
    /// </summary>
    public class V1_TPFUNDQUERYTRNRQ : IRequest<V1_TPFUNDQUERYTRNRS>
    {
        /// <summary>
        /// 3.5.6第三方存管资金查询请求主体
        /// </summary>
        public TPFUNDQUERYTRNRQ TPFUNDQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.5.6第三方存管资金查询请求主体
    /// </summary>
    public class TPFUNDQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.5.6第三方存管资金查询请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public TPFUNDQUERYTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.5.6第三方存管资金查询请求内容
    /// </summary>
    public class TPFUNDQUERYTRN_RQBODY
    {
        /// <summary>
        /// 版本控制，非必输；用于兼容旧版本接口1.0 -- 旧版本, 2.0 -- 新版本,默认1.0版本	非必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string VERSION { get; set; }
        /// <summary>
        /// 券商编号 	非必输，2.0版本时必输，或是进行融资融券、银衍互转是必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string STCOKBRANCHCODE { get; set; }
        /// <summary>
        /// 非必输，默认普通存管 0-普通存管，1-融资融券 （不管版本号是否输入版本号，默认2.0）， 2-银衍互转 （不管版本号是否输入版本号，默认2.0） 	非必输，（当做融资融券、银衍互转是必输）
        /// </summary>
        [XmlElement(Order = 2)]
        public string TRUSTEETYPE { get; set; }
        /// <summary>
        /// 查询账户代号，最长32位	必输
        /// </summary>
        [XmlElement(Order = 10)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 资金台账密码，最长6位	必输
        /// </summary>
        [XmlElement(Order = 11)]
        public string PWD { get; set; }
    }
}
