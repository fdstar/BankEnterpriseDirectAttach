using BEDA.CIB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 3.19.14跨境资金池国内、国际主账户互转交易查询请求主体
    /// </summary>
    public class V1_CBCPMAINTRADEQUERYTRNRQ : IRequest<V1_CBCPMAINTRADEQUERYTRNRS>
    {
        /// <summary>
        /// 3.19.14跨境资金池国内、国际主账户互转交易查询请求主体
        /// </summary>
        public CBCPMAINTRADEQUERYTRNRQ CBCPMAINTRADEQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.19.14跨境资金池国内、国际主账户互转交易查询请求主体
    /// </summary>
    public class CBCPMAINTRADEQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.19.14跨境资金池国内、国际主账户互转交易查询请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public CBCPMAINTRADEQUERYTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.19.14跨境资金池国内、国际主账户互转交易查询请求内容
    /// </summary>
    public class CBCPMAINTRADEQUERYTRN_RQBODY
    {
        /// <summary>
        /// 查询页数默认为1
        /// </summary>
        [XmlAttribute]
        public int PAGE { get; set; } = 1;
        /// <summary>
        /// 查询类型 必输
        /// 1：外债明细台账
        /// 2：对外放款明细台账
        /// </summary>
        [XmlElement(Order = 2)]
        public int QUERYTYPE { get; set; }
        /// <summary>
        /// 国内主账号	必输
        /// </summary>
        [XmlElement(Order = 3)]
        public string MAINACCTNO { get; set; }
        /// <summary>
        /// 批件号	非必输
        /// </summary>
        [XmlElement(Order = 4)]
        public string APPROVEDDOCNO { get; set; }
        /// <summary>
        /// 结清状态 必输
        /// 0：未结清
        /// 1：已结清
        /// </summary>
        [XmlElement(Order = 5)]
        public int SETTLESTATUS { get; set; }
        /// <summary>
        /// 起始时间，格式yyyy-MM-dd	必输
        /// </summary>
        [XmlIgnore]
        public DateTime STARTDATE { get; set; }
        /// <summary>
        /// 起始时间，格式yyyy-MM-dd, 对应<see cref="STARTDATE"/>	必输 
        /// </summary>
        [XmlElement("STARTDATE", Order = 6)]
        public string STARTDATEStr
        {
            get
            {
                return this.STARTDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.STARTDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 结束时间，格式yyyy-MM-dd 起始和结束日期不得超过1年 必输
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDATE { get; set; }
        /// <summary>
        /// 结束时间，格式yyyy-MM-dd 起始和结束日期不得超过1年, 对应<see cref="ENDDATE"/>	必输 
        /// </summary>
        [XmlElement("ENDDATE", Order = 7)]
        public string ENDDATEStr
        {
            get
            {
                return this.ENDDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ENDDATE = tmp;
                }
            }
        }
    }
}
