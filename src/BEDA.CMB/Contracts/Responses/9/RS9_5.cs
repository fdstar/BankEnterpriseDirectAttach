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
    /// 9.5.业务查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS9_5 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTNETDZB
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTNETDZB";
        /// <summary>
        /// 9.5.业务查询响应集合
        /// </summary>
        [XmlElement("NTNETDZBZ1")]
        public List<NTNETDZBZ1> List { get; set; }
    }
    /// <summary>
    /// 9.5.业务查询响应内容
    /// </summary>
    public class NTNETDZBZ1
    {
        /// <summary>
        /// 业务编号	C(10)
        /// </summary>
        public string BUSNUM { get; set; }
        /// <summary>
        /// 额度编号	C(10)
        /// </summary>
        public string CRLNUM { get; set; }
        /// <summary>
        /// 额度业务连接号	C(10)
        /// </summary>
        public string CRLBUS { get; set; }
        /// <summary>
        /// 放款形成开关	C(1)
        /// </summary>
        public string USDSWT { get; set; }
        /// <summary>
        /// 企业代码	C(10)
        /// </summary>
        public string CLTCOD { get; set; }
        /// <summary>
        /// 分行号	C(3)
        /// </summary>
        public string BBKNUM { get; set; }
        /// <summary>
        /// 机构号	C(6)
        /// </summary>
        public string BRNNUM { get; set; }
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CRYNUM { get; set; }
        /// <summary>
        /// 放款金额	F(17,2)
        /// </summary>
        public decimal USDAMT { get; set; }
        /// <summary>
        /// 余额	F(17,2)
        /// </summary>
        public decimal BALAMT { get; set; }
        /// <summary>
        /// 本金状态	C(4)	A.14 信用管理-本金状态
        /// </summary>
        public string CPTSTS { get; set; }
        /// <summary>
        /// 期限	N(3,0)
        /// </summary>
        public int MNHMNH { get; set; }
        /// <summary>
        /// 起始日	D
        /// </summary>
        [XmlIgnore]
        public DateTime STRDTE { get; set; }
        /// <summary>
        /// 起始日	D, 对应<see cref="STRDTE"/>
        /// </summary>
        [XmlElement("STRDTE")]
        public string STRDTEStr
        {
            get
            {
                return this.STRDTE.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.STRDTE = tmp;
                }
            }
        }
        /// <summary>
        /// 到期日	D
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDTE { get; set; }
        /// <summary>
        /// 到期日	D, 对应<see cref="ENDDTE"/>
        /// </summary>
        [XmlElement("ENDDTE")]
        public string ENDDTEStr
        {
            get
            {
                return this.ENDDTE.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ENDDTE = tmp;
                }
            }
        }
        /// <summary>
        /// 结息码	C(3)
        /// </summary>
        public string INTCOD { get; set; }
        /// <summary>
        /// 产品类别	C(8)
        /// </summary>
        public string BUSTYP { get; set; }
        /// <summary>
        /// 业务子类别	C(4)
        /// </summary>
        public string BUSTYS { get; set; }
        /// <summary>
        /// 产品编码	C(8)
        /// </summary>
        public string PRDCOD { get; set; }
        /// <summary>
        /// 是否银团贷款	C(1)
        /// </summary>
        public string PPLYON { get; set; }
        /// <summary>
        /// 主要担保方式	C(5)
        /// </summary>
        public string GRTTYP { get; set; }
        /// <summary>
        /// 附加担保方式开关	C(1)
        /// </summary>
        public string GRTYON { get; set; }
        /// <summary>
        /// 投向	C(5)
        /// </summary>
        public string IVTDRT { get; set; }
        /// <summary>
        /// 用途	C(5)	A.12 贷款用途
        /// </summary>
        public string USDPPS { get; set; }
        /// <summary>
        /// 基准利率类型	C(5)
        /// </summary>
        public string RATTYP { get; set; }
        /// <summary>
        /// 利率类型	C(2)
        /// </summary>
        public string RATMOD { get; set; }
        /// <summary>
        /// 利率浮动方式	C(4)
        /// </summary>
        public string FLTMOD { get; set; }
        /// <summary>
        /// 利率	I
        /// </summary>
        public decimal RATRAT { get; set; }
        /// <summary>
        /// 利率浮动	I
        /// </summary>
        public decimal RATFLT { get; set; }
        /// <summary>
        /// 利率公式	I
        /// </summary>
        public string RATFML { get; set; }
        /// <summary>
        /// 罚息率公式	C(4)
        /// </summary>
        public string RATFMF { get; set; }
        /// <summary>
        /// 合同号	C(10)
        /// </summary>
        public string LONNUM { get; set; }
        /// <summary>
        /// 企业代码	C(20)
        /// </summary>
        public string CTFIDC { get; set; }
        /// <summary>
        /// 企业名称	Z(200)
        /// </summary>
        public string CLTNAM { get; set; }
        /// <summary>
        /// 累计还息	F(17,2)
        /// </summary>
        public decimal PADINT { get; set; }
        /// <summary>
        /// 累计欠息	F(17,2)
        /// </summary>
        public decimal BALOIX { get; set; }
        /// <summary>
        /// 当前利息	F(17,2)
        /// </summary>
        public decimal BALINT { get; set; }
        /// <summary>
        /// 预期欠息	F(17,2)
        /// </summary>
        public decimal EXTINT { get; set; }
        /// <summary>
        /// 起息日	D
        /// </summary>
        [XmlIgnore]
        public DateTime? VLDDTB { get; set; }
        /// <summary>
        /// 起息日	D, 对应<see cref="VLDDTB"/>
        /// </summary>
        [XmlElement("VLDDTB")]
        public string VLDDTBStr
        {
            get
            {
                return this.VLDDTB?.ToString("yyyyMMdd");
            }
            set
            {
                this.VLDDTB = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.VLDDTB = tmp;
                }
            }
        }
        /// <summary>
        /// 止息日	D
        /// </summary>
        [XmlIgnore]
        public DateTime? VLDDTE { get; set; }
        /// <summary>
        /// 止息日	D, 对应<see cref="VLDDTE"/>
        /// </summary>
        [XmlElement("VLDDTE")]
        public string VLDDTEStr
        {
            get
            {
                return this.VLDDTE?.ToString("yyyyMMdd");
            }
            set
            {
                this.VLDDTE = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.VLDDTE = tmp;
                }
            }
        }
        /// <summary>
        /// 委托人代码	C(20)   委托贷款
        /// </summary>
        public string CTFID2 { get; set; }
        /// <summary>
        /// 委托人名称	Z(200)  委托贷款
        /// </summary>
        public string CLTNM2 { get; set; }
        /// <summary>
        /// 备用字段	C(90)
        /// </summary>
        public string RSVFLD { get; set; }
    }
}
