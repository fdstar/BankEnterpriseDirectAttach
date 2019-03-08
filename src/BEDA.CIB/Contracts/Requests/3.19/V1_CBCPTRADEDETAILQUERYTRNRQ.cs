using BEDA.CIB.Contracts.Responses;
using BEDA.Utils;
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
    /// 3.19.9跨境资金池账户交易明细查询请求主体
    /// </summary>
    public class V1_CBCPTRADEDETAILQUERYTRNRQ : IRequest<V1_CBCPTRADEDETAILQUERYTRNRS>
    {
        /// <summary>
        /// 3.19.9跨境资金池账户交易明细查询请求主体
        /// </summary>
        public CBCPTRADEDETAILQUERYTRNRQ CBCPTRADEDETAILQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.19.9跨境资金池账户交易明细查询请求主体
    /// </summary>
    public class CBCPTRADEDETAILQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.19.9跨境资金池账户交易明细查询请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public CBCPTRADEDETAILQUERYTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.19.9跨境资金池账户交易明细查询请求内容
    /// </summary>
    public class CBCPTRADEDETAILQUERYTRN_RQBODY
    {
        /// <summary>
        /// 查询页数默认为1
        /// </summary>
        [XmlAttribute]
        public int PAGE { get; set; } = 1;
        /// <summary>
        /// 交易类型 必输
        /// 0- 国内、国际主账户互转交易
        /// 1- 资金归集/下拨
        /// 2- 内部计价
        /// 3- 集中收付汇
        /// 4- 集中结汇
        /// </summary>
        [XmlElement(Order = 2)]
        public int TRADETYPE { get; set; }
        /// <summary>
        /// 币种	必输
        /// </summary>
        [XmlElement(Order = 3)]
        public string CURRENCY { get; set; }
        /// <summary>
        /// 账号，18位	必输
        /// </summary>
        [XmlElement(Order = 4)]
        public string ACCTNO { get; set; }
        /// <summary>
        /// 起始时间 YYYY-MM-DD	必输
        /// </summary>
        [XmlIgnore]
        public DateTime STARTDATE { get; set; }
        /// <summary>
        /// 起始时间 YYYY-MM-DD, 对应<see cref="STARTDATE"/>	必输 
        /// </summary>
        [XmlElement("STARTDATE", Order = 5)]
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
        /// 结束时间 YYYY-MM-DD	必输
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDATE { get; set; }
        /// <summary>
        /// 结束时间 YYYY-MM-DD, 对应<see cref="ENDDATE"/>	必输 
        /// </summary>
        [XmlElement("ENDDATE", Order = 6)]
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
        /// <summary>
        /// 最小金额	非必输
        /// </summary>
        [XmlIgnore]
        public decimal? MINAMOUNT { get; set; }
        /// <summary>
        /// 最小金额, 对应<see cref="MINAMOUNT"/>	非必输 
        /// </summary>
        [XmlElement("MINAMOUNT", Order = 7)]
        public string MINAMOUNTStr
        {
            get
            {
                return this.MINAMOUNT?.ToString();
            }
            set
            {
                this.MINAMOUNT = value.TryConvert<decimal>();
            }
        }
        /// <summary>
        /// 最大金额	非必输
        /// </summary>
        [XmlIgnore]
        public decimal? MAXAMOUNT { get; set; }
        /// <summary>
        /// 最大金额, 对应<see cref="MAXAMOUNT"/>	非必输 
        /// </summary>
        [XmlElement("MAXAMOUNT", Order = 8)]
        public string MAXAMOUNTStr
        {
            get
            {
                return this.MAXAMOUNT?.ToString();
            }
            set
            {
                this.MAXAMOUNT = value.TryConvert<decimal>();
            }
        }
        /// <summary>
        /// 借贷方向 1-借方 2-贷方 必输
        /// </summary>
        [XmlElement(Order = 9)]
        public int DCDIRECTOR { get; set; }
    }
}
