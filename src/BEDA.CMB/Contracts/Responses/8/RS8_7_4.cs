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
    /// 8.7.4.归集存款协议明细查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_7_4 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTCMCINF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCMCINF";
        /// <summary>
        /// 8.7.4.归集存款协议明细查询响应内容
        /// </summary>
        public NTCMCINFZ1 NTCMCINFZ1 { get; set; }
        /// <summary>
        /// 8.7.4.归集存款协议明细查询响应集合
        /// </summary>
        [XmlElement("NTCMCINFZ2")]
        public List<NTCMCINFZ2> List { get; set; }
    }
    /// <summary>
    /// 8.7.4.归集存款协议明细查询响应内容
    /// </summary>
    public class NTCMCINFZ1
    {
        /// <summary>
        /// 协议编号	C(8)
        /// </summary>
        public string CSTNBR { get; set; }
        /// <summary>
        /// 客户号	C(10)
        /// </summary>
        public string CLTNBR { get; set; }
        /// <summary>
        /// 币种	C(2)	附录A.3
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 活期留存金额	F(17,2)
        /// </summary>
        public decimal RSVMIN { get; set; }
        /// <summary>
        /// 增值账户保持余额	F(17,2)
        /// </summary>
        public decimal LFTMIN { get; set; }
        /// <summary>
        /// 连续违约最大天数	N(5)
        /// </summary>
        public int LFTDRE { get; set; }
        /// <summary>
        /// 累计违约最大天数	N(5)
        /// </summary>
        public int LFTDYS { get; set; }
        /// <summary>
        /// 连续违约天数	N(5)
        /// </summary>
        public int BRKDRE { get; set; }
        /// <summary>
        /// 累计违约天数	N(5)
        /// </summary>
        public int BRKDYS { get; set; }
        /// <summary>
        /// 透支额度	F(17,2)
        /// </summary>
        public decimal OVRLMT { get; set; }
        /// <summary>
        /// 协议生效日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime BEGDAT { get; set; }
        /// <summary>
        /// 协议生效日期	D, 对应<see cref="BEGDAT"/>
        /// </summary>
        [XmlElement("BEGDAT")]
        public string BEGDATStr
        {
            get
            {
                return this.BEGDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.BEGDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 协议失效日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDAT { get; set; }
        /// <summary>
        /// 协议失效日期	D, 对应<see cref="ENDDAT"/>
        /// </summary>
        [XmlElement("ENDDAT")]
        public string ENDDATStr
        {
            get
            {
                return this.ENDDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ENDDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 协议签订日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime SUBDAT { get; set; }
        /// <summary>
        /// 协议签订日期	D, 对应<see cref="SUBDAT"/>
        /// </summary>
        [XmlElement("SUBDAT")]
        public string SUBDATStr
        {
            get
            {
                return this.SUBDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.SUBDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 备注	Z(50)
        /// </summary>
        public string CSTREM { get; set; }
        /// <summary>
        /// 协议状态	C(1)	A：正常； B：暂停 D：失效 W：申请关闭
        /// </summary>
        public string STSCOD { get; set; }
        /// <summary>
        /// 维护日期	D
        /// </summary>
        public string MNTDAT { get; set; }
        /// <summary>
        /// 维护时间	T
        /// </summary>
        public string MNTTIM { get; set; }
        /// <summary>
        /// 维护时间 由<see cref="MNTDAT"/>和<see cref="MNTTIM"/>组成
        /// </summary>
        [XmlIgnore]
        public DateTime? MaintainedTime
        {
            get
            {
                if (DateTime.TryParseExact(string.Format("{0}{1}", this.MNTDAT, this.MNTTIM),
                   new string[] { "yyyyMMdd", "yyyyMMddHHmmss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    return tmp;
                }
                return null;
            }
        }
        /// <summary>
        /// 维护用户	C(6)
        /// </summary>
        public string MNTUSR { get; set; }
        /// <summary>
        /// 联机余额	F(17,2)
        /// </summary>
        public decimal ONLBAL { get; set; }
        /// <summary>
        /// 综合户余额	F(17,2) 活期户与增值账户余额总和
        /// </summary>
        public decimal TTLBAL { get; set; }
    }
    /// <summary>
    /// 8.7.4.归集存款协议明细查询响应内容
    /// </summary>
    public class NTCMCINFZ2
    {
        /// <summary>
        /// 协议编号	C(8)
        /// </summary>
        public string CSTNBR { get; set; }
        /// <summary>
        /// 利率档次下限金额	F(17,2)
        /// </summary>
        public decimal BALBAS { get; set; }
        /// <summary>
        /// 利率档次上限金额	F(17,2)
        /// </summary>
        public decimal BALTOP { get; set; }
        /// <summary>
        /// 季度利率基准存期	C(6)    季度利率基准存期	C(6)
        /// </summary>
        public string QUTITC { get; set; }
        /// <summary>
        /// 季度结息利率类型	C(1)	1:起息日,固定利率; 2:起息日,基于央行三个月定期基准,按点数浮; 3:起息日,基于央行三个月定期基准,按比例浮; 4:起息日,央行三个月期定存基准利率; 5:计息日,央行活期存款基准利率; 6:计息日,招行活期存款挂牌利率; 7:计息日,央行 7 天通知存款基准利率; 8:计息日,招行 7 天通知存款挂牌利率; 9:起息日,招行三个月期定存挂牌利率;
        /// </summary>
        public string QUTITP { get; set; }
        /// <summary>
        /// 季度结息适用利率	F(11,7)	季度结息时使用的利率配置 利率类型为1时为利率值 利率类型为2时为利率浮动值 利率类型为3时为利率浮动比例 其他利率类型利率值返回0
        /// 利率以%为单位，即如果返回字段值为0.3500000，则表示利率为0.35%
        /// </summary>
        public decimal QUTRAT { get; set; }
        /// <summary>
        /// 年度利率基准存期	C(6)    档期利率所参考的存款周期
        /// </summary>
        public string YERITC { get; set; }
        /// <summary>
        /// 年度结息利率类型	C(1)	1:起息日,固定利率; 2:起息日,基于央行一年期基准利率,按点数浮; 3:起息日,基于央行一年基准利率,按比例浮动; 4:起息日,央行一年期定存基准利率; 5:计息日,央行活期存款基准利率; 6:计息日,招行活期存款挂牌利率; 7:计息日,央行7天通知存款基准利率; 8:计息日,招行7天通知存款挂牌利率; 9:起息日,招行一年期定存挂牌利率;
        /// </summary>
        public string YERITP { get; set; }
        /// <summary>
        /// 年度结息适用利率	F(11,7)	年度结息时使用的利率配置 利率类型为1时为利率值 利率类型为2时为利率浮动值 利率类型为3时为利率浮动比例 其他利率类型利率值返回0
        /// 利率以%为单位，即如果返回字段值为0.3500000，则表示利率为0.35%
        /// </summary>
        public decimal YERRAT { get; set; }
    }
}
