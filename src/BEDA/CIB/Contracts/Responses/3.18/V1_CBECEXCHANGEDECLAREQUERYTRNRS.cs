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
    /// 3.18.7跨境电商结售汇还原报送查询响应主体
    /// </summary>
    public class V1_CBECEXCHANGEDECLAREQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 3.18.7跨境电商结售汇还原报送查询响应主体
        /// </summary>
        public CBECEXCHANGEDECLAREQUERYTRNRS CBECEXCHANGEDECLAREQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.18.7跨境电商结售汇还原报送查询响应主体
    /// </summary>
    public class CBECEXCHANGEDECLAREQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.18.7跨境电商结售汇还原报送查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public CBECEXCHANGEDECLAREQUERYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.18.7跨境电商结售汇还原报送查询响应内容
    /// </summary>
    public class CBECEXCHANGEDECLAREQUERYTRN_RSBODY
    {
        /// <summary>
        /// 是否有下一页，Y有，N无
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 3.18.7跨境电商结售汇还原报送查询响应集合
        /// </summary>
        [XmlElement("CONTENT", Order = 1)]
        public List<CBECEXCHANGEDECLAREQUERYTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.18.7跨境电商结售汇还原报送查询响应明细
    /// </summary>
    public class CBECEXCHANGEDECLAREQUERYTRN_CONTENT
    {
        /// <summary>
        /// 序号（从1开始递增）	必回
        /// </summary>
        [XmlElement(Order = 0)]
        public int SEQ { get; set; }
        /// <summary>
        /// 外管业务参号	非必回
        /// </summary>
        [XmlElement(Order = 1)]
        public string SAFE_BUSN_NO { get; set; }
        /// <summary>
        /// 交易时间 yyyy-MM-dd HH:mm:ss	必回
        /// </summary>
        [XmlIgnore]
        public DateTime TRSFR_TIME { get; set; }
        /// <summary>
        /// 交易时间 yyyy-MM-dd HH:mm:ss, 对应<see cref="TRSFR_TIME"/>	必回
        /// </summary>
        [XmlElement("TRSFR_TIME", Order = 2)]
        public string TRSFR_TIMEStr
        {
            get
            {
                return this.TRSFR_TIME.ToString("yyyy-MM-dd HH:mm:ss");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd HH:mm:ss", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.TRSFR_TIME = tmp;
                }
            }
        }
        /// <summary>
        /// 结售汇银行流水号	必回
        /// </summary>
        [XmlElement(Order = 3)]
        public string EXCHANGEBANKLSH { get; set; }
        /// <summary>
        /// 结售汇业务日期 yyyy-MM-dd	必回
        /// </summary>
        [XmlIgnore]
        public DateTime EXCHANGE_BIZ_DATE { get; set; }
        /// <summary>
        /// 结售汇业务日期 yyyy-MM-dd, 对应<see cref="EXCHANGE_BIZ_DATE"/>	必回
        /// </summary>
        [XmlElement("EXCHANGE_BIZ_DATE", Order = 4)]
        public string EXCHANGE_BIZ_DATEStr
        {
            get
            {
                return this.EXCHANGE_BIZ_DATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EXCHANGE_BIZ_DATE = tmp;
                }
            }
        }
        /// <summary>
        /// 证件类型代码(目前仅支持0值，表示身份证或组织机构代码)	必回
        /// </summary>
        [XmlElement(Order = 5)]
        public int ID_TYPE { get; set; }
        /// <summary>
        /// 证件号码 必回
        /// 1）身份证：长度18位，由全部数字或数字加最末一位大写英文字符组成。
        /// 2）组织机构代码：000000000“+支付机构组织机构代码
        /// </summary>
        [XmlElement(Order = 6)]
        public string ID_CODE { get; set; }
        /// <summary>
        /// 姓名	必回
        /// </summary>
        [XmlElement(Order = 7)]
        public string PERSON_NAME { get; set; }
        /// <summary>
        /// 交易类型:0-结汇,1-售汇	必回
        /// </summary>
        [XmlElement(Order = 8)]
        public int TRSFR_TYPE { get; set; }
        /// <summary>
        /// 外管操作类型:0-正常 1-补录	必回
        /// </summary>
        [XmlElement(Order = 9)]
        public int WYCZLX { get; set; }
        /// <summary>
        /// 外币币种	必回
        /// </summary>
        [XmlElement(Order = 10)]
        public string CURRENCY { get; set; }
        /// <summary>
        /// 外币金额, 大于0	必回
        /// </summary>
        [XmlElement(Order = 11)]
        public decimal AMT { get; set; }
        /// <summary>
        /// 备注	非必回
        /// </summary>
        [XmlElement(Order = 12)]
        public string MEMO { get; set; }
        /// <summary>
        /// 处理状态（0：未知 1：成功 2：失败）	必回
        /// </summary>
        [XmlElement(Order = 13)]
        public int STATUS { get; set; }
        /// <summary>
        /// 错误代码	非必回
        /// </summary>
        [XmlElement(Order = 14)]
        public string ERRCODE { get; set; }
        /// <summary>
        /// 错误信息	非必回
        /// </summary>
        [XmlElement(Order = 15)]
        public string ERRMSG { get; set; }
    }
}
