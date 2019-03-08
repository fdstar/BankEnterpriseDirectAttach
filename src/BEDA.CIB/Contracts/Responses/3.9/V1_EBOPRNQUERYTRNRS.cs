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
    /// 3.9.1.2电子商业汇票可操作票据查询响应主体
    /// </summary>
    public class V1_EBOPRNQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 3.9.1.2电子商业汇票可操作票据查询响应主体
        /// </summary>
        public EBOPRNQUERYTRNRS EBOPRNQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.9.1.2电子商业汇票可操作票据查询响应主体
    /// </summary>
    public class EBOPRNQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.9.1.2电子商业汇票可操作票据查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBOPRNQUERYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.9.1.2电子商业汇票可操作票据查询响应内容
    /// </summary>
    public class EBOPRNQUERYTRN_RSBODY
    {
        /// <summary>
        /// 是否有下一页，Y有，N无
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 3.9.1.2电子商业汇票可操作票据查询响应集合
        /// </summary>
        [XmlElement("CONTENT", Order = 1)]
        public List<EBOPRNQUERYTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.9.1.2电子商业汇票可操作票据查询响应明细
    /// </summary>
    public class EBOPRNQUERYTRN_CONTENT
    {
        /// <summary>
        /// 业务标识号，35位
        /// </summary>
        [XmlElement(Order = 0)]
        public string BIZFLAG { get; set; }
        /// <summary>
        /// 票据号码,30位
        /// </summary>
        [XmlElement(Order = 1)]
        public string BILLCODE { get; set; }
        /// <summary>
        /// 票据类型 (AC01:银票,AC02:商票)
        /// </summary>
        [XmlElement(Order = 2)]
        public string BILLTYPE { get; set; }
        /// <summary>
        /// 票据金额
        /// </summary>
        [XmlElement(Order = 3)]
        public decimal BILLAMT { get; set; }
        /// <summary>
        /// 出票日 YYYY-MM-DD
        /// </summary>
        [XmlIgnore]
        public DateTime DRAWDATE { get; set; }
        /// <summary>
        /// 出票日 YYYY-MM-DD, 对应<see cref="DRAWDATE"/>
        /// </summary>
        [XmlElement("DRAWDATE", Order = 4)]
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
        /// 票据到期日 YYYY-MM-DD, 对应<see cref="DUEDATE"/>
        /// </summary>
        [XmlElement("DUEDATE", Order = 5)]
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
        /// 转让标识 4位(EM00:可再转让,EM01:不可再转让)
        /// </summary>
        [XmlElement(Order = 6)]
        public string NEGTBL { get; set; }
        /// <summary>
        /// 出票人信息 注意不返回BANKDESC
        /// </summary>
        [XmlElement(Order = 7)]
        public CORRELATEACCT DRAWERACCT { get; set; }
        /// <summary>
        /// 承兑人账户信息 注意不返回BANKDESC
        /// </summary>
        [XmlElement(Order = 8)]
        public CORRELATEACCT ACPTRACCT { get; set; }
        /// <summary>
        /// 收款人信息 注意不返回BANKDESC
        /// </summary>
        [XmlElement(Order = 9)]
        public CORRELATEACCT PAYEEACCT { get; set; }
        /// <summary>
        /// 票据状态 ,6位见附录：票据状态表
        /// </summary>
        [XmlElement(Order = 10)]
        public string BILLSTATUS { get; set; }
        /// <summary>
        /// 业务申请日期 YYYY-MM-DD
        /// </summary>
        [XmlIgnore]
        public DateTime APPDATE { get; set; }
        /// <summary>
        /// 业务申请日期 YYYY-MM-DD, 对应<see cref="APPDATE"/>
        /// </summary>
        [XmlElement("APPDATE", Order = 11)]
        public string APPDATEStr
        {
            get
            {
                return this.APPDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.APPDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 业务流水号
        /// </summary>
        [XmlElement(Order = 12)]
        public string SEQ { get; set; }
    }
}
