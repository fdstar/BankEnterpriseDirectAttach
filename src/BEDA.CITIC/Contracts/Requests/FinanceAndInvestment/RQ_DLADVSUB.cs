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
    /// 定期转活期经办请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLADVSUB : RqBase<RS_DLADVSUB>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLADVSUB"; set { } }
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
        /// 定期账号char(19),由定期存款查询返回
        /// </summary>
        [XmlElement("fixAccNo")]
        public string FixAccNo { get; set; }
        /// <summary>
        /// 交易金额 decimal（15，2）
        /// </summary>
        [XmlElement("tranAmt")]
        public decimal TranAmt { get; set; }
        /// <summary>
        /// 支取方式 char(1)  0：普通支取；1：结清; 当活期账户和定期账户为中信银行（国际）-香港客户时，支付方式取值为：2:到期结清；3:提前结清
        /// </summary>
        [XmlElement("drawType")]
        public int DrawType { get; set; }
        /// <summary>
        /// 备注 varchar(60)，可空
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }
        /// <summary>
        /// 结清日期 char(8)，活期账号为中信银行（国际）-香港账户时，选输；活期账号非中信银行（国际）-香港账户时，不需上送该字段; 格式：YYYYMMDD 
        /// </summary>
        [XmlIgnore]
        public DateTime? EftDate { get; set; }
        /// <summary>
        /// 结清日期 char(8) 格式YYYYMMDD, 对应<see cref="EftDate"/>
        /// </summary>
        [XmlElement("eftDate")]
        public string EftDateStr
        {
            get
            {
                return this.EftDate?.ToString("yyyyMMdd");
            }
            set
            {
                this.EftDate = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EftDate = tmp;
                }
            }
        }
    }
}
