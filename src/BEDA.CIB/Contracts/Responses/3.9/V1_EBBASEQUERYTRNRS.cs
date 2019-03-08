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
    /// 3.9.1.5电子商业汇票票据基本信息查询响应主体
    /// </summary>
    public class V1_EBBASEQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 3.9.1.5电子商业汇票票据基本信息查询响应主体
        /// </summary>
        public EBBASEQUERYTRNRS EBBASEQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.9.1.5电子商业汇票票据基本信息查询响应主体
    /// </summary>
    public class EBBASEQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.9.1.5电子商业汇票票据基本信息查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBBASEQUERYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.9.1.5电子商业汇票票据基本信息查询响应内容
    /// </summary>
    public class EBBASEQUERYTRN_RSBODY
    {
        /// <summary>
        /// MORE是否有下一页，Y有，N无
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 3.9.1.5电子商业汇票票据基本信息查询响应集合
        /// </summary>
        [XmlElement("CONTENT", Order = 0)]
        public List<EBBASEQUERYTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.9.1.5电子商业汇票票据基本信息查询响应明细
    /// </summary>
    public class EBBASEQUERYTRN_CONTENT
    {
        /// <summary>
        /// 30位票据号码
        /// </summary>
        [XmlElement(Order = 1)]
        public string BILLCODE { get; set; }
        /// <summary>
        /// 票据类型,4位(AC01:银票,AC02:商票)
        /// </summary>
        [XmlElement(Order = 2)]
        public string BILLTYPE { get; set; }
        /// <summary>
        /// 票据金额,17位(15整数位,2小数位)
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
        /// 票据状态,6位见附录：票据状态表
        /// </summary>
        [XmlElement(Order = 7)]
        public string BILLSTATUS { get; set; }
        /// <summary>
        /// 交易合同号,最大30位
        /// </summary>
        [XmlElement(Order = 8)]
        public string CONTRACTID { get; set; }
        /// <summary>
        /// 到期无条件支付委托 CCOO
        /// </summary>
        [XmlElement(Order = 9)]
        public string ENTRSPAY { get; set; }
        /// <summary>
        /// 发票号码,最大30位
        /// </summary>
        [XmlElement(Order = 10)]
        public string INVCCODE { get; set; }
        /// <summary>
        /// 出票人信息
        /// </summary>
        [XmlElement(Order = 11)]
        public CREDITACCT DRAWERINFO { get; set; }
        /// <summary>
        /// 收款人信息 不返回 ORGID
        /// </summary>
        [XmlElement(Order = 12)]
        public ORGACCT PAYEEINFO { get; set; }
        /// <summary>
        /// 承兑人信息
        /// </summary>
        [XmlElement(Order = 13)]
        public CREDITACCT ACPTRINFO { get; set; }
        /// <summary>
        /// 出票人备注,最大256位
        /// </summary>
        [XmlElement(Order = 14)]
        public string DRAWMEMO { get; set; }
    }
}
