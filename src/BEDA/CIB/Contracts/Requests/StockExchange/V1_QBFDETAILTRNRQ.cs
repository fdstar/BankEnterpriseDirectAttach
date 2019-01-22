using BEDA.CIB.Contracts.Responses;
using BEDA.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 3.5.9银期交易明细查询请求主体
    /// </summary>
    public class V1_QBFDETAILTRNRQ : IRequest<V1_QBFDETAILTRNRS>
    {
        /// <summary>
        /// 3.5.9银期交易明细查询请求主体
        /// </summary>
        public QBFDETAILTRNRQ QBFDETAILTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.5.9银期交易明细查询请求主体
    /// </summary>
    public class QBFDETAILTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.5.9银期交易明细查询请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public QBFDETAILTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.5.9银期交易明细查询请求内容
    /// </summary>
    public class QBFDETAILTRN_RQBODY
    {
        /// <summary>
        /// PAGE查询页码，每页100笔，不输默认第1页，必输
        /// </summary>
        [XmlAttribute]
        public int PAGE { get; set; } = 1;
        /// <summary>
        /// 账户代号，最长32位	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string ACCTNO { get; set; }
        /// <summary>
        /// 资金账户，最长32位	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string FUNDACCTNO { get; set; }
        /// <summary>
        /// 起始日期，yyyy-MM-dd，不能早于一年前，不能晚于今天或结束日期	必输
        /// </summary>
        [XmlIgnore]
        public DateTime STARTDATE { get; set; }
        /// <summary>
        /// 起始日期，yyyy-MM-dd，不能早于一年前，不能晚于今天或结束日期 ,对应<see cref="STARTDATE"/>	必输
        /// </summary>
        [XmlElement("STARTDATE", Order = 2)]
        public string STARTDATEStr
        {
            get
            {
                return this.STARTDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (value.TryParse(out DateTime tmp))
                {
                    this.STARTDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 结束日期，yyyy-MM-dd，不能早于一年前，不能晚于今天或结束日期	必输
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDATE { get; set; }
        /// <summary>
        /// 结束日期，yyyy-MM-dd，不能早于一年前，不能晚于今天或结束日期 ,对应<see cref="ENDDATE"/>	必输
        /// </summary>
        [XmlElement("ENDDATE", Order = 3)]
        public string ENDDATEStr
        {
            get
            {
                return this.ENDDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (value.TryParse(out DateTime tmp))
                {
                    this.ENDDATE = tmp;
                }
            }
        }
    }
}
