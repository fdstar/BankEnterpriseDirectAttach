using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Responses
{
    /// <summary>
    /// 8.1.3.基金账户查询NTFNDACT响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_1_3 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTFNDACT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTFNDACT";
        /// <summary>
        /// 8.1.3.基金账户查询NTFNDACT响应集合
        /// </summary>
        [XmlElement("NTFNDACTZ")]
        public List<NTFNDACTZ> List { get; set; }
    }
    /// <summary>
    /// 8.1.3.基金账户查询NTFNDACT响应内容
    /// </summary>
    public class NTFNDACTZ
    {
        /// <summary>
        /// 账户状态	C(1)	A-正常，B-禁止，C-关户，N-开户中，U-关户中
        /// </summary>
        public string STSCOD { get; set; }
        /// <summary>
        /// 挂失标志	C(1)	Y/N
        /// </summary>
        public string LSTFLG { get; set; }
        /// <summary>
        /// 冻结标志	C(1)	Y/N
        /// </summary>
        public string HLDFLG { get; set; }
        /// <summary>
        /// TA简称	Z(42)
        /// </summary>
        public string TAAABR { get; set; }
        /// <summary>
        /// 登记机构	C(3)
        /// </summary>
        public string TAACOD { get; set; }
        /// <summary>
        /// 销售机构	C(3)
        /// </summary>
        public string SAACOD { get; set; }
        /// <summary>
        /// 协议编号	C(10)
        /// </summary>
        public string TACNBR { get; set; }
        /// <summary>
        /// 基金账号	C(35)
        /// </summary>
        public string RACNBR { get; set; }
        /// <summary>
        /// 交易账号	C(35)   少数基金公司在转托管时需要该号
        /// </summary>
        public string XACNBR { get; set; }
        /// <summary>
        /// 开户日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? OPNDAT { get; set; }
        /// <summary>
        /// 开户日期	D, 对应<see cref="OPNDAT"/>
        /// </summary>
        [XmlElement("OPNDAT")]
        public string OPNDATStr
        {
            get
            {
                return this.OPNDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.OPNDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OPNDAT = tmp;
                }
            }
        }
    }
}
