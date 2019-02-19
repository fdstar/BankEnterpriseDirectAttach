using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.9.1.1电子商业汇票票据交易明细查询响应主体
    /// </summary>
    public class V1_EBSTMTQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 3.9.1.1电子商业汇票票据交易明细查询响应主体
        /// </summary>
        public EBSTMTQUERYTRNRS EBSTMTQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.9.1.1电子商业汇票票据交易明细查询响应主体
    /// </summary>
    public class EBSTMTQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.9.1.1电子商业汇票票据交易明细查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBSTMTQUERYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.9.1.1电子商业汇票票据交易明细查询响应内容
    /// </summary>
    public class EBSTMTQUERYTRN_RSBODY
    {
        /// <summary>
        /// MORE是否有下一页，Y有，N无
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 3.9.1.1电子商业汇票票据交易明细查询响应集合
        /// </summary>
        [XmlElement("CONTENT", Order = 0)]
        public List<EBSTMTQUERYTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.9.1.1电子商业汇票票据交易明细查询响应明细
    /// </summary>
    public class EBSTMTQUERYTRN_CONTENT
    {
        /// <summary>
        /// 业务标识码, 2位 见文档:附录-电子票据汇票系统业务类型对照表
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
        [XmlElement(Order = 0)]
        public string BUSINESSTYPE { get; set; }
        /// <summary>
        /// 发起方标志 01:发起方/02接收方/03:持票人/04:全部
        /// </summary>
        [XmlElement(Order = 1)]
        public string OPERTYPE { get; set; }
        /// <summary>
        /// 票据号码,30位
        /// </summary>
        [XmlElement(Order = 2)]
        public string BILLCODE { get; set; }
        /// <summary>
        /// 票据类型(AC01:银票,AC02:商票)
        /// </summary>
        [XmlElement(Order = 3)]
        public string BILLTYPE { get; set; }
        /// <summary>
        /// 票据金额,17位(15整数位,2小数位)
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal BILLAMT { get; set; }
        /// <summary>
        /// 出票日期 YYYY-MM-DD
        /// </summary>
        [XmlIgnore]
        public DateTime DRAWDATE { get; set; }
        /// <summary>
        /// 出票日期，格式yyyy-MM-dd ,对应<see cref="DRAWDATE"/>
        /// </summary>
        [XmlElement("DRAWDATE", Order = 5)]
        public string DRAWDATEStr
        {
            get
            {
                return this.DRAWDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DRAWDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 票据到期日 YYYY-MM-DD
        /// </summary>
        [XmlIgnore]
        public DateTime DUEDATE { get; set; }
        /// <summary>
        /// 票据到期日，格式yyyy-MM-dd ,对应<see cref="DUEDATE"/>
        /// </summary>
        [XmlElement("DUEDATE", Order = 6)]
        public string DUEDATEStr
        {
            get
            {
                return this.DUEDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DUEDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 出票人信息
        /// </summary>
        [XmlElement(Order = 7)]
        public ORGACCT DRAWER { get; set; }
        /// <summary>
        /// 承兑人信息
        /// </summary>
        [XmlElement(Order = 8)]
        public ORGACCT ACPTR { get; set; }
        /// <summary>
        /// 发送方信息
        /// </summary>
        [XmlElement(Order = 9)]
        public ACCT ACCTFROM { get; set; }
        /// <summary>
        /// 接收方信息
        /// </summary>
        [XmlElement(Order = 10)]
        public ACCT ACCTTO { get; set; }
        /// <summary>
        /// 票据状态,6位见文档附录3:票据状态表
        /// </summary>
        [XmlElement(Order = 11)]
        public string BILLSTATUS { get; set; }
        /// <summary>
        /// 交易日期 YYYY-MM-DD
        /// </summary>
        [XmlIgnore]
        public DateTime DTTRN { get; set; }
        /// <summary>
        /// 交易日期，格式yyyy-MM-dd ,对应<see cref="DTTRN"/>
        /// </summary>
        [XmlElement("DTTRN", Order = 12)]
        public string DTTRNStr
        {
            get
            {
                return this.DTTRN.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DTTRN = tmp;
                }
            }
        }
        /// <summary>
        /// 申请人备注	非必回
        /// </summary>
        [XmlElement(Order = 13)]
        public string APPLYMEMO { get; set; }
        /// <summary>
        /// 签收人备注	非必回
        /// </summary>
        [XmlElement(Order = 14)]
        public string RECEIVEMEMO { get; set; }
        /// <summary>
        /// 处理结果 非必回
        /// 对于发送方：
        /// 01-已录入
        /// 02-已发送
        /// 03-发送已确认(已收到ECDS应答)
        /// 04-发送已确认失败
        /// 05-已签收
        /// 06-已拒绝
        /// 07-已清算
        /// 08-已清算失败
        /// 对于接收方：
        /// 01-未签收
        /// 02-已签收
        /// 03-已拒绝
        /// 04-已确认
        /// 05-驳回已确认
        /// 06-已清算
        /// 07-已清算失败
        /// 08-已清分失败
        /// </summary>
        [XmlElement(Order = 15)]
        public string DEALSTATUS { get; set; }
    }
    /// <summary>
    /// 组织人员信息
    /// </summary>
    public class ORGACCT
    {
        /// <summary>
        /// 客户类型
        /// </summary>
        [XmlElement(Order = 0)]
        public string CUSTTYPE { get; set; }
        /// <summary>
        /// 账户代号,最大32位
        /// </summary>
        [XmlElement(Order = 1)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 账户名称,最大60位
        /// </summary>
        [XmlElement(Order = 2)]
        public string NAME { get; set; }
        /// <summary>
        /// 开户行行号,最大12位
        /// </summary>
        [XmlElement(Order = 3)]
        public string BANKNUM { get; set; }
        /// <summary>
        /// 组织机构代码,最小1位,最大10位
        /// </summary>
        [XmlElement(Order = 4)]
        public string ORGID { get; set; }
    }
}
