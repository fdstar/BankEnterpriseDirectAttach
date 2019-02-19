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
    /// 3.9.1.3电子商业汇票待签收票据查询响应主体
    /// </summary>
    public class V1_EBSIGNQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 3.9.1.3电子商业汇票待签收票据查询响应主体
        /// </summary>
        public EBSIGNQUERYTRNRS EBSIGNQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.9.1.3电子商业汇票待签收票据查询响应主体
    /// </summary>
    public class EBSIGNQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.9.1.3电子商业汇票待签收票据查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBSIGNQUERYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.9.1.3电子商业汇票待签收票据查询响应内容
    /// </summary>
    public class EBSIGNQUERYTRN_RSBODY
    {
        /// <summary>
        /// 是否有下一页，Y有，N无
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 3.9.1.3电子商业汇票待签收票据查询响应集合
        /// </summary>
        [XmlElement("CONTENT", Order = 1)]
        public List<EBSIGNQUERYTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.9.1.3电子商业汇票待签收票据查询响应明细
    /// </summary>
    public class EBSIGNQUERYTRN_CONTENT
    {
        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement(Order = 0)]
        public string BUSINESSTYPE { get; set; }
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
        /// 出票人账户信息 不返回 CUSTTYPE
        /// </summary>
        [XmlElement(Order = 8)]
        public ORGACCT DRAWERACCT { get; set; }
        /// <summary>
        /// 承兑人账户信息 注意不返回BANKDESC
        /// </summary>
        [XmlElement(Order = 9)]
        public CORRELATEACCT ACPTRACCT { get; set; }
        /// <summary>
        /// 收款人账户信息 注意不返回BANKDESC
        /// </summary>
        [XmlElement(Order = 10)]
        public CORRELATEACCT PAYEEACCT { get; set; }
        /// <summary>
        /// 商票系统业务标识号
        /// </summary>
        [XmlElement(Order = 11)]
        public string BIZFLAG { get; set; }
        /// <summary>
        /// 到期无条件支付委托
        /// </summary>
        [XmlElement(Order = 12)]
        public string ENTRSPAY { get; set; }
        /// <summary>
        /// 业务申请日期 YYYY-MM-DD
        /// </summary>
        [XmlIgnore]
        public DateTime APPDATE { get; set; }
        /// <summary>
        /// 业务申请日期 YYYY-MM-DD, 对应<see cref="APPDATE"/>
        /// </summary>
        [XmlElement("APPDATE", Order = 13)]
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
        /// 业务申请人信息
        /// </summary>
        [XmlElement(Order = 14)]
        public ORGACCT PROPSRINFO { get; set; }
        /// <summary>
        /// 业务接收人信息
        /// </summary>
        [XmlElement(Order = 15)]
        public ORGACCT RCVRRINFO { get; set; }
        /// <summary>
        /// 贴现类型,4位(RM00:买断式,RM01回购式)
        /// </summary>
        [XmlElement(Order = 16)]
        public string DISCNTTYPE { get; set; }
        /// <summary>
        /// 贴现利率,7位百分数不含百分号 (2位整数,5位小数)
        /// </summary>
        [XmlElement(Order = 17)]
        public decimal? DISCNTINTRSTRATE { get; set; }
        /// <summary>
        /// 实付金额,17位(15整数位,2小数位)
        /// </summary>
        [XmlElement(Order = 18)]
        public decimal? REALPAYAMT { get; set; }
        /// <summary>
        /// 回购日期范围
        /// </summary>
        [XmlElement(Order = 19)]
        public Requests.DATERANGE REDMDATE { get; set; }
        /// <summary>
        /// 赎回利率,7位百分数不含百分号(2位整数,5位小数)
        /// </summary>
        [XmlElement(Order = 20)]
        public decimal? REDMINTRSTRATE { get; set; }
        /// <summary>
        /// 赎回实付金额,17位(15整数位,2小数位)
        /// </summary>
        [XmlElement(Order = 21)]
        public decimal? REDMREALPAYAMT { get; set; }
        /// <summary>
        /// 清算模式,4位 (SM00:线上清算,SM01:线下清算)
        /// </summary>
        [XmlElement(Order = 22)]
        public string LQMODE { get; set; }
        /// <summary>
        /// 拒付理由,4位见附录:拒付理由/拒签理由
        /// </summary>
        [XmlElement(Order = 23)]
        public string REPDTRSN { get; set; }
        /// <summary>
        /// 拒付备注,最大256位,拒付理由为DC09时必回
        /// </summary>
        [XmlElement(Order = 24)]
        public string REPDTMEMO { get; set; }
        /// <summary>
        /// 追索日期 YYYY-MM-DD
        /// </summary>
        [XmlIgnore]
        public DateTime? RECRSDATE { get; set; }
        /// <summary>
        /// 追索日期，格式yyyy-MM-dd ,对应<see cref="RECRSDATE"/>
        /// </summary>
        [XmlElement("RECRSDATE", Order = 25)]
        public string RECRSDATEStr
        {
            get
            {
                return this.RECRSDATE?.ToString("yyyy-MM-dd");
            }
            set
            {
                this.RECRSDATE = null;
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.RECRSDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 追索金额,17位(15整数位,2小数位)
        /// </summary>
        [XmlElement(Order = 26)]
        public decimal? RECRSAMT { get; set; }
        /// <summary>
        /// 同意清偿日期 YYYY-MM-DD
        /// </summary>
        [XmlIgnore]
        public DateTime? DISCHGDATE { get; set; }
        /// <summary>
        /// 同意清偿日期，格式yyyy-MM-dd ,对应<see cref="DISCHGDATE"/>
        /// </summary>
        [XmlElement("DISCHGDATE", Order = 27)]
        public string DISCHGDATEStr
        {
            get
            {
                return this.DISCHGDATE?.ToString("yyyy-MM-dd");
            }
            set
            {
                this.DISCHGDATE = null;
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DISCHGDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 同意清偿金额,17位(15整数位,2小数位)
        /// </summary>
        [XmlElement(Order = 28)]
        public decimal? DISCHGAMT { get; set; }
        /// <summary>
        /// 业务接收日期 YYYY-MM-DD
        /// </summary>
        [XmlIgnore]
        public DateTime RCVRDATE { get; set; }
        /// <summary>
        /// 业务接收日期，格式yyyy-MM-dd ,对应<see cref="RCVRDATE"/>
        /// </summary>
        [XmlElement("RCVRDATE", Order = 29)]
        public string RCVRDATEStr
        {
            get
            {
                return this.RCVRDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.RCVRDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 备注,最大256位
        /// </summary>
        [XmlElement(Order = 30)]
        public string MEMO { get; set; }
        /// <summary>
        /// 逾期原因	非必回
        /// </summary>
        [XmlElement(Order = 31)]
        public string OVERDUEREASON { get; set; }
        /// <summary>
        /// 交易合同号	非必回
        /// </summary>
        [XmlElement(Order = 32)]
        public string TRANSCONTRACENO { get; set; }
    }
}
