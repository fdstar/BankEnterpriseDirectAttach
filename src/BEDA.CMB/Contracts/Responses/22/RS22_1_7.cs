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
    /// 22.1.7.询价查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS22_1_7 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTBILIND
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTBILIND";
        /// <summary>
        /// 22.1.7.询价查询响应集合
        /// </summary>
        [XmlElement("NTBILINDZ1")]
        public List<NTBILINDZ1> List { get; set; }
    }
    /// <summary>
    /// 22.1.7.询价查询响应内容
    /// </summary>
    public class NTBILINDZ1
    {
        /// <summary>
        /// 票据号	C(30)
        /// </summary>
        public string BILNBR { get; set; }
        /// <summary>
        /// 纸票标志号	C(20)   银行产生的系统内纸票唯一标识，电票为空
        /// </summary>
        public string DPSNBR { get; set; }
        /// <summary>
        /// 票据种类	C(1)	‘0’ 银行承兑汇票 ‘1’   商业承兑汇票
        /// </summary>
        public string BILTYP { get; set; }
        /// <summary>
        /// 票据介质	C(1)	‘E’   电子商业汇票 ‘P’   纸质商业汇票
        /// </summary>
        public string BILSHP { get; set; }
        /// <summary>
        /// 票面金额	M
        /// </summary>
        public decimal BILAMT { get; set; }
        /// <summary>
        /// 出票日	D
        /// </summary>
        [XmlIgnore]
        public DateTime BILDAT { get; set; }
        /// <summary>
        /// 出票日	D, 对应<see cref="BILDAT"/>
        /// </summary>
        [XmlElement("BILDAT")]
        public string BILDATStr
        {
            get
            {
                return this.BILDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.BILDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 到期日	D
        /// </summary>
        [XmlIgnore]
        public DateTime DUEDAT { get; set; }
        /// <summary>
        /// 到期日	D, 对应<see cref="DUEDAT"/>
        /// </summary>
        [XmlElement("DUEDAT")]
        public string DUEDATStr
        {
            get
            {
                return this.DUEDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DUEDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 出票人名称	Z(62)
        /// </summary>
        public string DRWNAM { get; set; }
        /// <summary>
        /// 付款行行号	C(12)
        /// </summary>
        public string ACPBRD { get; set; }
        /// <summary>
        /// 付款行行名	Z(62)
        /// </summary>
        public string ACPBNK { get; set; }
        /// <summary>
        /// 付款人账号	C(35)
        /// </summary>
        public string DREEAC { get; set; }
        /// <summary>
        /// 收款人	Z(62)
        /// </summary>
        public string RCVNAM { get; set; }
        /// <summary>
        /// 收款人账号	C(35)
        /// </summary>
        public string RCVACC { get; set; }
        /// <summary>
        /// 期限天数	N(5)    指距离到期的天数
        /// </summary>
        public int? TERDAT { get; set; }
        /// <summary>
        /// 询价利率	F(5,2)  利率百分比，如返回4.33，则代表利率为4.33%
        /// </summary>
        public decimal? PRIRAT { get; set; }
    }
}
