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
    /// 8.3.2.理财产品信息查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_3_2 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTQDILST
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQDILST";
        /// <summary>
        /// 8.3.2.理财产品信息查询响应集合
        /// </summary>
        [XmlElement("NTQDILSTZ")]
        public List<NTQDILSTZ> List { get; set; }
    }
    /// <summary>
    /// 8.3.2.理财产品信息查询响应内容
    /// </summary>
    public class NTQDILSTZ
    {
        /// <summary>
        /// 产品代码	C(8)
        /// </summary>
        public string RIPCOD { get; set; }
        /// <summary>
        /// 产品简称	Z(22)
        /// </summary>
        public string NAMSNM { get; set; }
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 代理机构	C(3)
        /// </summary>
        public string MAACOD { get; set; }
        /// <summary>
        /// 挂牌日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime BEGDAT { get; set; }
        /// <summary>
        /// 挂牌日期	D, 对应<see cref="BEGDAT"/>
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
        /// 截止日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDAT { get; set; }
        /// <summary>
        /// 截止日期	D, 对应<see cref="ENDDAT"/>
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
        /// 赎回控制	C(1)	Y=可以 N=不可以
        /// </summary>
        public string REDCTL { get; set; }
        /// <summary>
        /// 申购控制	C(1)	Y=允许 N=不允许
        /// </summary>
        public string PURCTL { get; set; }
        /// <summary>
        /// 认购控制	C(1)	Y=允许 N=不允许
        /// </summary>
        public string SBSCTL { get; set; }
        /// <summary>
        /// 分红控制	C(1)	Y=允许 N=不允许
        /// </summary>
        public string BNSCTL { get; set; }
        /// <summary>
        /// 风险级别	C(1)
        /// </summary>
        public string RSKLVL { get; set; }
        /// <summary>
        /// 价格	F(11,7)
        /// </summary>
        public decimal NAVNTV { get; set; }
        /// <summary>
        /// 产品剩余公开额度	M
        /// </summary>
        public decimal RIPPOS { get; set; }
        /// <summary>
        /// 价格日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime NAVDAT { get; set; }
        /// <summary>
        /// 价格日期	D, 对应<see cref="NAVDAT"/>
        /// </summary>
        [XmlElement("NAVDAT")]
        public string NAVDATStr
        {
            get
            {
                return this.NAVDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.NAVDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 认购期标记	C(1)    Y表示当前时间可购买，N表示不可购买
        /// </summary>
        public string TERCOD { get; set; }
        /// <summary>
        /// 预期收益率	F(11,7) 日日金、岁月流金取最新收益率 普通产品取预期收益率，无预期收益率返回0 步步为赢产品返回0
        /// </summary>
        public decimal? PRFRAT { get; set; }
        /// <summary>
        /// 产品期限信息	Z(26)
        /// 日日金：“-” 步步为赢：“-”
        /// 普通产品：1.有期限信息返回期限信息 例如7天滚动 2. 无期限信息返回产品周期
        /// 岁月流金：固定周期 产品周期和固定周期返回天数 例如90天
        /// </summary>
        public string TERDAY { get; set; }
        /// <summary>
        /// 产品类型	C(5)    第1位为“I”表示步步为赢
        /// </summary>
        public string RIPTYP { get; set; }
    }
}
