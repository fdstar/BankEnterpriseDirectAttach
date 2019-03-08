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
    /// 3.20.5进口信用证修改通知查询响应主体
    /// </summary>
    public class V1_LCAMENDNOTICEQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 3.20.5进口信用证修改通知查询响应主体
        /// </summary>
        public LCAMENDNOTICEQUERYTRNRS LCAMENDNOTICEQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.20.5进口信用证修改通知查询响应主体
    /// </summary>
    public class LCAMENDNOTICEQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.20.5进口信用证修改通知查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public LCAMENDNOTICEQUERYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.20.5进口信用证修改通知查询响应内容
    /// </summary>
    public class LCAMENDNOTICEQUERYTRN_RSBODY
    {
        /// <summary>
        /// 是否有下一页，Y有，N无
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 3.20.5进口信用证修改通知查询响应集合
        /// </summary>
        [XmlElement("CONTENT", Order = 1)]
        public List<LCAMENDNOTICEQUERYTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.20.5进口信用证修改通知查询响应明细
    /// </summary>
    public class LCAMENDNOTICEQUERYTRN_CONTENT
    {
        /// <summary>
        /// 地区机构
        /// </summary>
        [XmlElement(Order = 0)]
        public string BRANCHNO { get; set; }
        /// <summary>
        /// sender's reference	必回
        /// </summary>
        [XmlElement(Order = 1)]
        public string SENDERREFNO { get; set; }
        /// <summary>
        /// receiver's reference
        /// </summary>
        [XmlElement(Order = 2)]
        public string RECEIVERREFNO { get; set; }
        /// <summary>
        /// issuing bank's reference	必回
        /// </summary>
        [XmlElement(Order = 3)]
        public string ISSUINGBANKREFNO { get; set; }
        /// <summary>
        /// amendment number
        /// </summary>
        [XmlElement(Order = 4)]
        public string AMENDNO { get; set; }
        /// <summary>
        /// date of amendment YYYY-MM-DD 
        /// </summary>
        [XmlIgnore]
        public DateTime AMENDDATE { get; set; }
        /// <summary>
        /// date of amendment YYYY-MM-DD, 对应<see cref="AMENDDATE"/>	
        /// </summary>
        [XmlElement("AMENDDATE", Order = 5)]
        public string AMENDDATEStr
        {
            get
            {
                return this.AMENDDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.AMENDDATE = tmp;
                }
            }
        }
        /// <summary>
        /// date of issue YYYY-MM-DD 
        /// </summary>
        [XmlIgnore]
        public DateTime ISSUEDATE { get; set; }
        /// <summary>
        /// date of issue YYYY-MM-DD, 对应<see cref="ISSUEDATE"/>	
        /// </summary>
        [XmlElement("ISSUEDATE", Order = 6)]
        public string ISSUEDATEStr
        {
            get
            {
                return this.ISSUEDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ISSUEDATE = tmp;
                }
            }
        }
        /// <summary>
        /// new expiry date YYYY-MM-DD 
        /// </summary>
        [XmlIgnore]
        public DateTime? NEWLCEXPIRYDATE { get; set; }
        /// <summary>
        /// new expiry date YYYY-MM-DD, 对应<see cref="NEWLCEXPIRYDATE"/>	
        /// </summary>
        [XmlElement("NEWLCEXPIRYDATE", Order = 7)]
        public string NEWLCEXPIRYDATEStr
        {
            get
            {
                return this.NEWLCEXPIRYDATE?.ToString("yyyy-MM-dd");
            }
            set
            {
                this.NEWLCEXPIRYDATE = null;
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.NEWLCEXPIRYDATE = tmp;
                }
            }
        }
        /// <summary>
        /// increase of document credit amount
        /// </summary>
        [XmlElement(Order = 8)]
        public string INCREASEDOCMAT { get; set; }
        /// <summary>
        /// decrease of document credit amount
        /// </summary>
        [XmlElement(Order = 9)]
        public string DECREASEDOCAMT { get; set; }
        /// <summary>
        /// new document credit amount after amendment
        /// </summary>
        [XmlElement(Order = 10)]
        public string NEWDOCAMT { get; set; }
        /// <summary>
        /// percentage credit amount tolerance
        /// </summary>
        [XmlElement(Order = 11)]
        public string AMTTOLERANCEPCT { get; set; }
        /// <summary>
        /// maximum credit amount，币种+金额
        /// </summary>
        [XmlElement(Order = 12)]
        public string MAXCREDITAMT { get; set; }
        /// <summary>
        /// additional amount covered
        /// </summary>
        [XmlElement(Order = 13)]
        public string ADDAMTCOVERED { get; set; }
        /// <summary>
        /// Place of Taking in Charge/Dispatch from ,,,/Place of Receipt 长度：1*65	非必回
        /// </summary>
        [XmlElement(Order = 14)]
        public string DISPATCHPLACE { get; set; }
        /// <summary>
        /// Port of loading/Airport of Departure 长度：1*65	非必回
        /// </summary>
        [XmlElement(Order = 15)]
        public string LOADPORT { get; set; }
        /// <summary>
        /// Port of Discharge/Airport of Destination 长度：1*65	非必回
        /// </summary>
        [XmlElement(Order = 16)]
        public string DISCHARGEPORT { get; set; }
        /// <summary>
        /// Place of Final Destination/For Transportation to …/Place of Delivery 长度：1*65	非必回
        /// </summary>
        [XmlElement(Order = 17)]
        public string FINALDESTPLACE { get; set; }
        /// <summary>
        /// new latest shipemnt date, YYYY-MM-DD 
        /// </summary>
        [XmlIgnore]
        public DateTime? NEWLASTESTSHIPMENTDATE { get; set; }
        /// <summary>
        /// new latest shipemnt date, YYYY-MM-DD, 对应<see cref="NEWLASTESTSHIPMENTDATE"/>	
        /// </summary>
        [XmlElement("NEWLASTESTSHIPMENTDATE", Order = 18)]
        public string NEWLASTESTSHIPMENTDATEStr
        {
            get
            {
                return this.NEWLASTESTSHIPMENTDATE?.ToString("yyyy-MM-dd");
            }
            set
            {
                this.NEWLASTESTSHIPMENTDATE = null;
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.NEWLASTESTSHIPMENTDATE = tmp;
                }
            }
        }
        /// <summary>
        /// Shipment period 长度：6*65	非必回
        /// </summary>
        [XmlElement(Order = 19)]
        public string SHIPMENTPERIOD { get; set; }
        /// <summary>
        /// Beneficiary 长度：5*35
        /// </summary>
        [XmlElement(Order = 20)]
        public string BENEFICIARY { get; set; }
        /// <summary>
        /// Narrative 长度：35*50
        /// </summary>
        [XmlElement(Order = 21)]
        public string NARRATIVE { get; set; }
        /// <summary>
        /// sender to receiver information 长度：6*35
        /// </summary>
        [XmlElement(Order = 22)]
        public string TORECEIVERINFOR { get; set; }
        /// <summary>
        /// 业务日期,YYYY-MM-DD
        /// </summary>
        [XmlIgnore]
        public DateTime BIZCREDATE { get; set; }
        /// <summary>
        /// 业务日期YYYY-MM-DD, 对应<see cref="BIZCREDATE"/>
        /// </summary>
        [XmlElement("BIZCREDATE", Order = 43)]
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
        /// 系统关联业务编号	必回
        /// </summary>
        [XmlElement(Order = 44)]
        public string XTREFERENCE { get; set; }
        /// <summary>
        /// 通知接收到的日期，格式yyyy-MM-dd HH:mm:ss  必回
        /// </summary>
        [XmlIgnore]
        public DateTime CREATETIME { get; set; }
        /// <summary>
        /// 通知接收到的日期，格式yyyy-MM-dd HH:mm:ss, 对应<see cref="CREATETIME"/>  必回
        /// </summary>
        [XmlElement("CREATETIME", Order = 45)]
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
