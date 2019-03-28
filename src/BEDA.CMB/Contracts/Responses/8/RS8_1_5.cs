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
    /// 8.1.5.浏览基金信息NTFNDCOD响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_1_5 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTFNDCOD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTFNDCOD";
        /// <summary>
        /// 8.1.5.浏览基金信息NTFNDCOD响应集合
        /// </summary>
        [XmlElement("NTFNDCODZ")]
        public List<NTFNDCODZ> List { get; set; }
    }
    /// <summary>
    /// 8.1.5.浏览基金信息NTFNDCOD响应内容
    /// </summary>
    public class NTFNDCODZ
    {
        /// <summary>
        /// 基金代码	C(8)
        /// </summary>
        public string FNDCOD { get; set; }
        /// <summary>
        /// 基金类型标志	C(1)	A-开放式基金，B-集合理财
        /// </summary>
        public string CLSFLG { get; set; }
        /// <summary>
        /// 基金分类标志	C(1)	S-股票型，B-债券型，M-货币型，1-混合型
        /// </summary>
        public string STYFLG { get; set; }
        /// <summary>
        /// 基金类别标志	C(1)	A-货币基金，N/空格-普通基金
        /// </summary>
        public string CATFLG { get; set; }
        /// <summary>
        /// 份额明细展示标志	C(1)	Y-展示,N-不展示
        /// </summary>
        public string DTLFLG { get; set; }
        /// <summary>
        /// 基金类型	C(5)	附录A.7   返回基金分类定义的后面4位
        /// </summary>
        public string FNDTYP { get; set; }
        /// <summary>
        /// 基金分类	C(5)	
        /// C1：显示模式，
        /// N -普通基金，
        /// A-货币基金
        /// C2：备用，标签类型，
        /// H-热卖，
        /// N-保留给新增，
        /// 空格-无标签
        /// C3：持仓显示模式，
        /// F-公募，
        /// P-私募，
        /// S-固定收益率
        /// C4：份额明细展示标志；
        /// Y-展示、
        /// N-不展示；
        /// C5：产品是否展示标志；
        /// Y-展示、
        /// N-不展示
        /// </summary>
        public string FNDCLS { get; set; }
        /// <summary>
        /// 基金中文简称	Z(42)
        /// </summary>
        public string FNDNAM { get; set; }
        /// <summary>
        /// 结算货币	C(2)	基金结算货币，
        /// 10-人民币，
        /// 21-港币，
        /// 32-美元
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 基金状态	C(1)
        /// 0-可申购赎回
        /// 1-发行
        /// 4-停止申购赎回
        /// 5-停止申购
        /// 6-停止赎回
        /// 8-基金终止
        /// 9-基金封闭
        /// </summary>
        public string FNDSTS { get; set; }
        /// <summary>
        /// 净值日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? NAVDAT { get; set; }
        /// <summary>
        /// 净值日期	D, 对应<see cref="NAVDAT"/>
        /// </summary>
        [XmlElement("NAVDAT")]
        public string NAVDATStr
        {
            get
            {
                return this.NAVDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.NAVDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.NAVDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 基金净值	F(11,7)
        /// </summary>
        public decimal? NAVVAL { get; set; }
        /// <summary>
        /// 累计净值	F(11,7)
        /// </summary>
        public decimal? NAVCUM { get; set; }
        /// <summary>
        /// 赎回资金速度	F(3,0)  表示T＋n工作日到账
        /// </summary>
        public int? SELFCL { get; set; }
        /// <summary>
        /// 年费率	F(8,7)  单位为%，例如返回1.4000000表示年费率为1.4%
        /// </summary>
        public decimal? CHRBUY { get; set; }
        /// <summary>
        /// 次费率	F(8,7)  单位为%，例如返回1.4000000表示次费率为1.4%
        /// </summary>
        public decimal? CHRSEL { get; set; }
        /// <summary>
        /// 最近一月净值增长率	F(8,2)  单位为%，例如返回1.40表示增长率为1.4%
        /// </summary>
        public decimal? YLDD01 { get; set; }
        /// <summary>
        /// 最近三年净值增长率	F(8,2)  单位为%，例如返回1.40表示增长率为1.4%
        /// </summary>
        public decimal? YLDM01 { get; set; }
        /// <summary>
        /// 最近一年净值增长率	F(8,2)  单位为%，例如返回1.40表示增长率为1.4%
        /// </summary>
        public decimal? YLDY01 { get; set; }
        /// <summary>
        /// 登记机构	C(3)
        /// </summary>
        public string TAACOD { get; set; }
        /// <summary>
        /// 管理公司	C(3)
        /// </summary>
        public string CRPCOD { get; set; }
        /// <summary>
        /// 认购允许	C(1)	Y-允许，N-禁止
        /// </summary>
        public string SUBRUN { get; set; }
        /// <summary>
        /// 申购允许	C(1)	Y-允许，N-禁止
        /// </summary>
        public string BUYRUN { get; set; }
        /// <summary>
        /// 赎回允许	C(1)	Y-允许，N-禁止
        /// </summary>
        public string SELRUN { get; set; }
    }
}
