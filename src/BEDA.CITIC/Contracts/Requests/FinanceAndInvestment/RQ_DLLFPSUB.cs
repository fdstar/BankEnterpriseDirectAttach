using BEDA.CITIC.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CITIC.Contracts.Requests
{
    /// <summary>
    /// 活期转定期经办请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLFIXSUB : RqBase<RS_DLFIXSUB>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLFIXSUB"; set { } }
        /// <summary>
        /// 客户流水号 varchar(20)
        /// </summary>
        [XmlElement("clientID")]
        public string ClientID { get; set; }
        /// <summary>
        /// 活期账号 char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 存期char(3) M03：三个月；M06：六个月；Y01：一年
        /// </summary>
        [XmlElement("perd")]
        public string Perd { get; set; }
        /// <summary>
        /// 备注 varchar(60)，可空
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }
        /// <summary>
        /// 交易金额 decimal（15，2）
        /// </summary>
        [XmlElement("tranAmt")]
        public decimal TranAmt { get; set; }
        /// <summary>
        /// 结转方式 char(1)，0：自动结转；1：不自动结转；当活期账号为中信银行（国际）-香港账户时，结转方式取值为：A: 本金及利息自动转结、O: 本金及利息保留在定期帐户，允许手动转存
        /// </summary>
        [XmlElement("wdtp")]
        public string Wdtp { get; set; }
        /// <summary>
        /// 币种 char(2), 活期账号为中信银行（国际）-香港账户时，必输；付款账号非中信银行（国际）-香港账户时，不需上送该字段
        /// </summary>
        [XmlElement("cryType")]
        public string CryType { get; set; }
        /// <summary>
        /// 起始日期char(8), 活期账号为中信银行（国际）-香港账户时必输; 付款账号非中信银行（国际）-香港账户时，不需上送该字段；格式: YYYYMMDD 
        /// </summary>
        [XmlIgnore]
        public DateTime? SDate { get; set; }
        /// <summary>
        /// 起始日期char(8) 格式YYYYMMDD, 对应<see cref="SDate"/>
        /// </summary>
        [XmlElement("sDate")]
        public string SDateStr
        {
            get
            {
                return this.SDate?.ToString("yyyyMMdd");
            }
            set
            {
                this.SDate = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.SDate = tmp;
                }
            }
        }
        /// <summary>
        /// 到期日char(8), 活期账号为中信银行（国际）-香港账户时，必输；付款账号非中信银行（国际）-香港账户时，不需上送该字段；格式: YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime? MDate { get; set; }
        /// <summary>
        /// 到期日char(8) 格式YYYYMMDD, 对应<see cref="MDate"/>
        /// </summary>
        [XmlElement("mDate")]
        public string MDateStr
        {
            get
            {
                return this.MDate?.ToString("yyyyMMdd");
            }
            set
            {
                this.MDate = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.MDate = tmp;
                }
            }
        }
        /// <summary>
        /// 利率 decimal（18,8），活期账号为中信银行（国际）-香港账户时，选输；活期账号非中信银行（国际）-香港账户时，不需上送该字段
        /// </summary>
        [XmlElement("rate")]
        public decimal? Rate { get; set; }
    }
}
