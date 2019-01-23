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
    /// 3.8.3理财产品信息查询请求主体
    /// </summary>
    public class V1_FPPRODTRNRQ : IRequest<V1_FPPRODTRNRS>
    {
        /// <summary>
        /// 3.8.3理财产品信息查询请求主体
        /// </summary>
        public FPPRODTRNRQ FPPRODTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.8.3理财产品信息查询请求主体
    /// </summary>
    public class FPPRODTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.8.3理财产品信息查询请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public FPPRODTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.8.3理财产品信息查询请求内容
    /// </summary>
    public class FPPRODTRN_RQBODY
    {
        /// <summary>
        /// PAGE查询页码，每页100笔，不输默认第1页，必输
        /// </summary>
        [XmlAttribute]
        public int PAGE { get; set; } = 1;
        /// <summary>
        /// 客户类型  2 公司  4 同业 默认2 必输
        /// </summary>
        [XmlElement(Order = 0)]
        public int CUSTTYPE { get; set; } = 2;
    }
}
