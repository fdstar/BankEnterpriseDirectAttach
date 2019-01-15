using BEDA.CIB.Contracts.Responses;
using BEDA.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 交易概览请求主体
    /// </summary>
    public class V1_TRADEOVERVIEWTRNRQ : IRequest<V1_TRADEOVERVIEWTRNRS>
    {
        /// <summary>
        /// 交易概览
        /// </summary>
        public TRADEOVERVIEWTRNRQ TRADEOVERVIEWTRNRQ { get; set; }
    }
    /// <summary>
    /// 交易概览
    /// </summary>
    public class TRADEOVERVIEWTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 交易概览查询请求
        /// </summary>
        [XmlElement(Order = 1)]
        public TRADEOVERVIEWTRN_RQBODY TRADEOVERVIEWTRNRQBODY { get; set; }
    }
    /// <summary>
    /// 交易概览查询请求
    /// </summary>
    public class TRADEOVERVIEWTRN_RQBODY
    {
        /// <summary>
        /// PAGE查询页码，每页100笔，不输默认第1页，必输
        /// </summary>
        [XmlAttribute]
        public int PAGE { get; set; } = 1;
        /// <summary>
        /// 查询日期，yyyy-MM-dd，必输
        /// </summary>
        [XmlIgnore]
        public DateTime QUERYDATE { get; set; }
        /// <summary>
        /// 查询日期，yyyy-MM-dd ,对应<see cref="QUERYDATE"/>	必输
        /// </summary>
        [XmlElement("QUERYDATE")]
        public string DTENDStr
        {
            get
            {
                return this.QUERYDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (value.TryParse(out DateTime tmp))
                {
                    this.QUERYDATE = tmp;
                }
            }
        }
    }
}
