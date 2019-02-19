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
    /// 3.9.1.1电子商业汇票票据交易明细查询请求主体
    /// </summary>
    public class V1_EBSTMTQUERYTRNRQ : IRequest<V1_EBSTMTQUERYTRNRS>
    {
        /// <summary>
        /// 3.9.1.1电子商业汇票票据交易明细查询请求主体
        /// </summary>
        public EBSTMTQUERYTRNRQ EBSTMTQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.9.1.1电子商业汇票票据交易明细查询请求主体
    /// </summary>
    public class EBSTMTQUERYTRNRQ:BIZRQBASE
    {
        /// <summary>
        /// 3.9.1.1电子商业汇票票据交易明细查询请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public EBSTMTQUERYTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.9.1.1电子商业汇票票据交易明细查询请求内容
    /// </summary>
    public class EBSTMTQUERYTRN_RQBODY
    {
        /// <summary>
        /// PAGE查询页码，每页100笔，不输默认第1页，必输
        /// </summary>
        [XmlAttribute]
        public int PAGE { get; set; } = 1;
        /// <summary>
        /// 发起方标志 01:发起方/02接收方/03:持票人/04:全部 必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string OPERTYPE { get; set; }
        /// <summary>
        /// 32位操作员账户代号	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 业务标识码,2位,见文档:附录3-业务类型对照表	必输
        /// 01-信息登记
        /// 02-出票保证
        /// 03-提示承兑
        /// 04-承兑保证
        /// 05-提示收票
        /// 06-撤票
        /// 07-背书转让
        /// 08-背书保证
        /// 09-贴现
        /// 10-回购式贴现赎回
        /// 11-转贴现
        /// 12-回购式转贴现赎回
        /// 13-再贴现
        /// 14-回购式再贴现赎回
        /// 15-质押
        /// 16-解除质押
        /// 17-提示付款
        /// 18-逾期提示付款
        /// 19-拒付追索
        /// 20-非拒付追索
        /// 21-追索同意清偿
        /// 22-提示承兑撤销
        /// 23-提示收票撤销
        /// 24-背书撤销
        /// 25-贴现撤销
        /// 26-回购式贴现赎回撤销
        /// 27-转贴现撤销
        /// 28-回购式转贴现赎回撤销
        /// 29-再贴现撤销
        /// 30-背书保证撤销
        /// 31-承兑保证撤销
        /// 32-出票保证撤销
        /// 33-质押撤销
        /// 34-质押解除撤销
        /// 35-提示付款撤销
        /// 36-逾期提示付款撤销
        /// 37-追索同意清偿请求撤销
        /// 38-追索申请撤销
        /// 94-撤票业务通知
        /// 95-保证业务通知
        /// 96-追索业务通知
        /// 97-央行卖出商业汇票
        /// 98-保证业务
        /// 99-全部（指全部可撤销）
        /// </summary>
        [XmlElement(Order = 2)]
        public string BUSINESSTYPE { get; set; }
        /// <summary>
        /// 票据类型(AC01:银票,AC02:商票)	非必输
        /// </summary>
        [XmlElement(Order = 3)]
        public string BILLTYPE { get; set; }
        /// <summary>
        /// 票据号码,30位	非必输
        /// </summary>
        [XmlElement(Order = 4)]
        public string BILLCODE { get; set; }
        /// <summary>
        /// 起始日期，格式yyyy-MM-dd 必输
        /// </summary>
        [XmlIgnore]
        public DateTime DTSTART { get; set; }
        /// <summary>
        /// 起始日期，格式yyyy-MM-dd ,对应<see cref="DTSTART"/> 必输
        /// </summary>
        [XmlElement("DTSTART", Order = 5)]
        public string DTSTARTStr
        {
            get
            {
                return this.DTSTART.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DTSTART = tmp;
                }
            }
        }
        /// <summary>
        /// 截止日期，格式yyyy-MM-dd 必输
        /// </summary>
        [XmlIgnore]
        public DateTime DTEND { get; set; }
        /// <summary>
        /// 截止日期，格式yyyy-MM-dd ,对应<see cref="DTEND"/> 必输
        /// </summary>
        [XmlElement("DTEND", Order = 6)]
        public string DTENDStr
        {
            get
            {
                return this.DTEND.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DTEND = tmp;
                }
            }
        }
        /// <summary>
        /// 票据金额范围	非必输
        /// </summary>
        [XmlElement(Order = 7)]
        public AMTRANGE BILLAMT { get; set; }
    }
    /// <summary>
    /// 票据金额范围
    /// </summary>
    public class AMTRANGE
    {
        /// <summary>
        /// 最小金额,17位(15整数位,2小数位)	非必输
        /// </summary>
        [XmlIgnore]
        public decimal? MINAMT { get; set; }
        /// <summary>
        /// 最小金额,17位(15整数位,2小数位) 对应<see cref="MINAMT"/>	非必输
        /// </summary>
        [XmlElement("MINAMT", Order = 0)]
        public string MINAMTStr
        {
            get
            {
                return this.MINAMT?.ToString();
            }
            set
            {
                this.MINAMT = value.TryConvert<decimal>();
            }
        }
        /// <summary>
        /// 最大金额,17位(15整数位,2小数位)	非必输
        /// </summary>
        [XmlIgnore]
        public decimal? MAXAMT { get; set; }
        /// <summary>
        /// 最大金额,17位(15整数位,2小数位) 对应<see cref="MAXAMT"/>	非必输
        /// </summary>
        [XmlElement("MAXAMT", Order = 1)]
        public string MAXAMTStr
        {
            get
            {
                return this.MAXAMT?.ToString();
            }
            set
            {
                this.MAXAMT = value.TryConvert<decimal>();
            }
        }
    }
}
