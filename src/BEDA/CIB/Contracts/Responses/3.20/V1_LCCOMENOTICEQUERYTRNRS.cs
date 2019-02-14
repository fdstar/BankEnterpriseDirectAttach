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
    /// 3.20.10出口信用证来证通知查询响应主体
    /// </summary>
    public class V1_LCCOMENOTICEQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 3.20.10出口信用证来证通知查询响应主体
        /// </summary>
        public LCCOMENOTICEQUERYTRNRS LCCOMENOTICEQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.20.10出口信用证来证通知查询响应主体
    /// </summary>
    public class LCCOMENOTICEQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.20.10出口信用证来证通知查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public LCCOMENOTICEQUERYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.20.10出口信用证来证通知查询响应内容
    /// </summary>
    public class LCCOMENOTICEQUERYTRN_RSBODY
    {
        /// <summary>
        /// 是否有下一页，Y有，N无
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 3.20.10出口信用证来证通知查询响应集合
        /// </summary>
        [XmlElement("CONTENT", Order = 1)]
        public List<LCCOMENOTICEQUERYTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.20.10出口信用证来证通知查询响应明细
    /// </summary>
    public class LCCOMENOTICEQUERYTRN_CONTENT
    {
        /// <summary>
        /// Initial Code，5位地区机构号	必回
        /// </summary>
        [XmlElement(Order = 0)]
        public string INITIALCODE { get; set; }
        /// <summary>
        /// Reference，信用证号	必回
        /// </summary>
        [XmlElement(Order = 1)]
        public string LCREFERENCENO { get; set; }
        /// <summary>
        /// issuing bank's reference
        /// </summary>
        [XmlElement(Order = 2)]
        public string ISSUINGBANKREFNO { get; set; }
        /// <summary>
        /// preadvice date, 日期yyyy-MM-dd	非必回 
        /// </summary>
        [XmlIgnore]
        public DateTime? PREADVICEDATE { get; set; }
        /// <summary>
        /// preadvice date, 日期yyyy-MM-dd, 对应<see cref="PREADVICEDATE"/>	非必回 
        /// </summary>
        [XmlElement("PREADVICEDATE", Order = 3)]
        public string PREADVICEDATEStr
        {
            get
            {
                return this.PREADVICEDATE?.ToString("yyyy-MM-dd");
            }
            set
            {
                this.PREADVICEDATE = null;
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.PREADVICEDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 申请人 长度：4*35	必回
        /// </summary>
        [XmlElement(Order = 4)]
        public string APPLICANT { get; set; }
        /// <summary>
        /// 受益人 长度：4*35	必回
        /// </summary>
        [XmlElement(Order = 5)]
        public string BENEFICIARY { get; set; }
        /// <summary>
        /// L/C Issued on ,日期yyyy-MM-dd 必回
        /// </summary>
        [XmlIgnore]
        public DateTime LCISSUEDDATE { get; set; }
        /// <summary>
        /// L/C Issued on  YYYY-MM-DD, 对应<see cref="LCISSUEDDATE"/> 必回
        /// </summary>
        [XmlElement("LCISSUEDDATE", Order = 6)]
        public string LCISSUEDDATEStr
        {
            get
            {
                return this.LCISSUEDDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.LCISSUEDDATE = tmp;
                }
            }
        }
        /// <summary>
        /// L/C Expiring on ,日期yyyy-MM-dd 必回
        /// </summary>
        [XmlIgnore]
        public DateTime LCEXPIRYDATE { get; set; }
        /// <summary>
        /// L/C Expiring on  YYYY-MM-DD, 对应<see cref="LCEXPIRYDATE"/> 必回
        /// </summary>
        [XmlElement("LCEXPIRYDATE", Order = 7)]
        public string LCEXPIRYDATEStr
        {
            get
            {
                return this.LCEXPIRYDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.LCEXPIRYDATE = tmp;
                }
            }
        }
        /// <summary>
        /// In（place）/counters of 长度：29	 必回
        /// </summary>
        [XmlElement(Order = 8)]
        public string EXPIRYPLACE { get; set; }
        /// <summary>
        /// Nominal amount	 必回
        /// </summary>
        [XmlElement(Order = 9)]
        public string NOMINALAMT { get; set; }
        /// <summary>
        /// percentage credit amount tolerance
        /// </summary>
        [XmlElement(Order = 10)]
        public string AMTTOLERANCEPCT { get; set; }
        /// <summary>
        /// maximum credit amount 币别+金额 非必回
        /// </summary>
        [XmlElement(Order = 11)]
        public string MAXCREDITAMT { get; set; }
        /// <summary>
        /// additional amount covered
        /// </summary>
        [XmlElement(Order = 12)]
        public string ADDAMTCOVERED { get; set; }
        /// <summary>
        /// form of document credit   必回
        /// I.IRREVOCABLE
        /// IT.IRREVOCABLE TRANSFERABLE
        /// </summary>
        [XmlElement(Order = 13)]
        public string LCFORMTYPE { get; set; }
        /// <summary>
        /// Applicable rules 目前仅支持：UCP LATEST VERSION 长度：30	 必回
        /// </summary>
        [XmlElement(Order = 14)]
        public string APPLICABLERULES { get; set; }
        /// <summary>
        /// Available with bank（41A） 长度：6*35	必回
        /// </summary>
        [XmlElement(Order = 15)]
        public string AVBLWITHBANK41A { get; set; }
        /// <summary>
        /// Available with bank（41D）长度：6*35	必回
        /// </summary>
        [XmlElement(Order = 16)]
        public string AVBLWITHBANK41D { get; set; }
        /// <summary>
        /// Drawee(42A)	非必回
        /// </summary>
        [XmlElement(Order = 17)]
        public string DRAWEE42A { get; set; }
        /// <summary>
        /// Drafts at 长度：4*35	非必回
        /// </summary>
        [XmlElement(Order = 18)]
        public string DRAFTESAT { get; set; }
        /// <summary>
        /// Drawee(42D) 长度：4*35	非必回
        /// </summary>
        [XmlElement(Order = 19)]
        public string DRAWEE42D { get; set; }
        /// <summary>
        /// Mixed Payment Details 长度：4*35	非必回
        /// </summary>
        [XmlElement(Order = 20)]
        public string MIXEDPYMTDTL { get; set; }
        /// <summary>
        /// Def.Payment Details 长度：4*35	非必回
        /// </summary>
        [XmlElement(Order = 21)]
        public string DEFPYMTDTL { get; set; }
        /// <summary>
        /// Patial Shipment    非必回
        /// N:NOT ALLOWED
        /// Y:ALLOWED
        /// </summary>
        [XmlElement(Order = 22)]
        public string PATIALSHIPMENT { get; set; }
        /// <summary>
        /// Transshipment    非必回
        /// N:NOT ALLOWED
        /// Y:ALLOWED
        /// </summary>
        [XmlElement(Order = 23)]
        public string TRANSSHIPMENT { get; set; }
        /// <summary>
        /// Latest Shipment Date, 日期yyyy-MM-dd	非必回 
        /// </summary>
        [XmlIgnore]
        public DateTime? LASTESTSHIPMENTDATE { get; set; }
        /// <summary>
        /// Latest Shipment Date, 日期yyyy-MM-dd, 对应<see cref="LASTESTSHIPMENTDATE"/>	非必回 
        /// </summary>
        [XmlElement("LASTESTSHIPMENTDATE", Order = 24)]
        public string LASTESTSHIPMENTDATEStr
        {
            get
            {
                return this.LASTESTSHIPMENTDATE?.ToString("yyyy-MM-dd");
            }
            set
            {
                this.LASTESTSHIPMENTDATE = null;
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.LASTESTSHIPMENTDATE = tmp;
                }
            }
        }
        /// <summary>
        /// Shipment period 长度：6*65	非必回
        /// </summary>
        [XmlElement(Order = 25)]
        public string SHIPMENTPERIOD { get; set; }
        /// <summary>
        /// Place of Taking in Charge/Dispatch from ,,,/Place of Receipt 长度：1*65	非必回
        /// </summary>
        [XmlElement(Order = 26)]
        public string DISPATCHPLACE { get; set; }
        /// <summary>
        /// Port of loading/Airport of Departure 长度：1*65	非必回
        /// </summary>
        [XmlElement(Order = 27)]
        public string LOADPORT { get; set; }
        /// <summary>
        /// Port of Discharge/Airport of Destination 长度：1*65	非必回
        /// </summary>
        [XmlElement(Order = 28)]
        public string DISCHARGEPORT { get; set; }
        /// <summary>
        /// Place of Final Destination/For Transportation to …/Place of Delivery 长度：1*65	非必回
        /// </summary>
        [XmlElement(Order = 29)]
        public string FINALDESTPLACE { get; set; }
        /// <summary>
        /// Goods(45A) 长度：150*65	 必回
        /// </summary>
        [XmlElement(Order = 30)]
        public string GOODSDESC45A { get; set; }
        /// <summary>
        /// Goods(45B) 长度：150*65	 必回
        /// </summary>
        [XmlElement(Order = 31)]
        public string GOODSDESC45B { get; set; }
        /// <summary>
        /// Documents(46A) 长度：150*65	 必回
        /// </summary>
        [XmlElement(Order = 32)]
        public string DOCUMENTS46A { get; set; }
        /// <summary>
        /// Documents(46B) 长度：150*65	 必回
        /// </summary>
        [XmlElement(Order = 33)]
        public string DOCUMENTS46B { get; set; }
        /// <summary>
        /// additional conditions(47A) 长度：150*65	 必回
        /// </summary>
        [XmlElement(Order = 34)]
        public string ADDCONDITIONS47A { get; set; }
        /// <summary>
        /// additional conditions(47B) 长度：150*65	 必回
        /// </summary>
        [XmlElement(Order = 35)]
        public string ADDCONDITIONS47B { get; set; }
        /// <summary>
        /// Applicant Bank 长度：5*35	非必回
        /// </summary>
        [XmlElement(Order = 36)]
        public string APPLICANTBANK { get; set; }
        /// <summary>
        /// Details of Charges 长度：6*35	非必回
        /// </summary>
        [XmlElement(Order = 37)]
        public string CHARGEDTL { get; set; }
        /// <summary>
        /// Presentation Period 长度：4*35	非必回
        /// </summary>
        [XmlElement(Order = 38)]
        public string PRESENTATIONPERIOD { get; set; }
        /// <summary>
        /// Confirm.Instructions  必回
        /// A:MAY ADD
        /// C:CONFIRM
        /// W:WITHOUT
        /// </summary>
        [XmlElement(Order = 39)]
        public string CONFIRMINSTRCTION { get; set; }
        /// <summary>
        /// reimbursement bank 长度：6*35	非必回
        /// </summary>
        [XmlElement(Order = 40)]
        public string REIMBURSEBANK { get; set; }
        /// <summary>
        /// inst/paying/accept/negotiate bank 长度：12*65
        /// </summary>
        [XmlElement(Order = 41)]
        public string PAYBANK { get; set; }
        /// <summary>
        /// Advising Bank 长度：5*35	 必回
        /// </summary>
        [XmlElement(Order = 42)]
        public string ADVISINGBANK { get; set; }
        /// <summary>
        /// sender to receiver information 长度：6*35
        /// </summary>
        [XmlElement(Order = 43)]
        public string TORECEIVERINFOR { get; set; }
        /// <summary>
        /// correspondent bank 长度：5*35	 必回
        /// </summary>
        [XmlElement(Order = 44)]
        public string CORRESPONDENTBANK { get; set; }
        /// <summary>
        /// 业务日期,YYYY-MM-DD
        /// </summary>
        [XmlIgnore]
        public DateTime BIZCREDATE { get; set; }
        /// <summary>
        /// 业务日期YYYY-MM-DD, 对应<see cref="BIZCREDATE"/>
        /// </summary>
        [XmlElement("BIZCREDATE", Order = 45)]
        public string BIZCREDATEStr
        {
            get
            {
                return this.BIZCREDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.BIZCREDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 系统关联业务编号	非必回
        /// </summary>
        [XmlElement(Order = 46)]
        public string XTREFERENCE { get; set; }
        /// <summary>
        /// 通知接收到的日期，格式yyyy-MM-dd HH:mm:ss  必回
        /// </summary>
        [XmlIgnore]
        public DateTime CREATETIME { get; set; }
        /// <summary>
        /// 通知接收到的日期，格式yyyy-MM-dd HH:mm:ss, 对应<see cref="CREATETIME"/>  必回
        /// </summary>
        [XmlElement("CREATETIME", Order = 47)]
        public string CREATETIMEStr
        {
            get
            {
                return this.CREATETIME.ToString("yyyy-MM-dd HH:mm:ss");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd HH:mm:ss", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.CREATETIME = tmp;
                }
            }
        }
    }
}
