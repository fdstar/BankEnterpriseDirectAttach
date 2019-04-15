using BEDA.CMB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Requests
{
    /// <summary>
    /// 22.1.5.直连查询票据库存请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ22_1_5 : CMBBase<RQINFO>, IRequest<RS22_1_5>
    {
        /// <summary>
        /// NTBLEIND
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTBLEIND";
        /// <summary>
        /// 22.1.5.直连查询票据库存请求内容
        /// </summary>
        public NTBLEINDY1 NTBLEINDY1 { get; set; }
    }
    /// <summary>
    /// 22.1.5.直连查询票据库存请求内容
    /// </summary>
    public class NTBLEINDY1
    {
        /// <summary>
        /// 查询分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 查询账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 票据介质	C(1)	‘E’   电子商业汇票 ‘P’   纸质商业汇票 ‘*’   电子+纸质
        /// </summary>
        public string BILSHP { get; set; }
        /// <summary>
        /// 票据种类	C(1)	‘0’ 银行承兑汇票 ‘1’   商业承兑汇票 ‘*’ 银承+商承
        /// </summary>
        public string BILTYP { get; set; }
        /// <summary>
        /// 到期日期起	D
        /// </summary>
        [XmlIgnore]
        public DateTime? ENDMIN { get; set; }
        /// <summary>
        /// 到期日期起	D, 对应<see cref="ENDMIN"/>
        /// </summary>
        [XmlElement("ENDMIN")]
        public string ENDMINStr
        {
            get
            {
                return this.ENDMIN?.ToString("yyyyMMdd");
            }
            set
            {
                this.ENDMIN = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ENDMIN = tmp;
                }
            }
        }
        /// <summary>
        /// 到期日期止	D
        /// </summary>
        [XmlIgnore]
        public DateTime? ENDMAX { get; set; }
        /// <summary>
        /// 到期日期止	D, 对应<see cref="ENDMAX"/>
        /// </summary>
        [XmlElement("ENDMAX")]
        public string ENDMAXStr
        {
            get
            {
                return this.ENDMAX?.ToString("yyyyMMdd");
            }
            set
            {
                this.ENDMAX = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ENDMAX = tmp;
                }
            }
        }
        /// <summary>
        /// 金额低限	M
        /// </summary>
        public decimal? AMTMIN { get; set; }
        /// <summary>
        /// 金额高限	M
        /// </summary>
        public decimal? AMTMAX { get; set; }
    }
}
