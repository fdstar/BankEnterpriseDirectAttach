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
    /// 8.5.7.智能定期业务成功交易查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_5_7 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTTCATRX
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTTCATRX";
        /// <summary>
        /// 8.5.7.智能定期业务成功交易查询响应内容
        /// </summary>
        public NTTCATRXZ1 NTTCATRXZ1 { get; set; }
    }
    /// <summary>
    /// 8.5.7.智能定期业务成功交易查询响应内容
    /// </summary>
    public class NTTCATRXZ1
    {
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 操作类型	C(3)	CTA-活期转智能定期存款 ATC-智能定期存款转活期
        /// </summary>
        public string OPRTYP { get; set; }
        /// <summary>
        /// 分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 活期帐号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 帐号名称	Z(62)
        /// </summary>
        public string ACCNAM { get; set; }
        /// <summary>
        /// 客户名称	Z(62)
        /// </summary>
        public string CLTNAM { get; set; }
        /// <summary>
        /// 分行号	C(2)
        /// </summary>
        public string FIXBBK { get; set; }
        /// <summary>
        /// 定期帐号	C(35)
        /// </summary>
        public string FIXACC { get; set; }
        /// <summary>
        /// 开户行名称	Z(62)
        /// </summary>
        public string BRNNAM { get; set; }
        /// <summary>
        /// 客户类别	C(1)    C-普通企业客户 O-离岸客户 F-同业客户
        /// </summary>
        public string CLTTYP { get; set; }
        /// <summary>
        /// 存期	C(6)
        /// </summary>
        public string TERDUM { get; set; }
        /// <summary>
        /// 自动转存标志	C(1)    1-不转存 2-本息转存 3-本金转存，利息转活期
        /// </summary>
        public string ATOFLG { get; set; }
        /// <summary>
        /// 起息日	D
        /// </summary>
        [XmlIgnore]
        public DateTime INTDAT { get; set; }
        /// <summary>
        /// 起息日	D, 对应<see cref="INTDAT"/>
        /// </summary>
        [XmlElement("INTDAT")]
        public string INTDATStr
        {
            get
            {
                return this.INTDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.INTDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 到期日	D
        /// </summary>
        [XmlIgnore]
        public DateTime EXPDAT { get; set; }
        /// <summary>
        /// 到期日	D, 对应<see cref="EXPDAT"/>
        /// </summary>
        [XmlElement("EXPDAT")]
        public string EXPDATStr
        {
            get
            {
                return this.EXPDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EXPDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 利率	F(11,7)
        /// </summary>
        public decimal INTRAT { get; set; }
        /// <summary>
        /// 利息金额	M
        /// </summary>
        public decimal INTAMT { get; set; }
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 交易金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 经办日	D
        /// </summary>
        [XmlIgnore]
        public DateTime OPRDAT { get; set; }
        /// <summary>
        /// 经办日	D, 对应<see cref="OPRDAT"/>
        /// </summary>
        [XmlElement("OPRDAT")]
        public string OPRDATStr
        {
            get
            {
                return this.OPRDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OPRDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
    }
}
