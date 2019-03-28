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
    /// 9.6.交易查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS9_6 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTNETDZT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTNETDZT";
        /// <summary>
        /// 9.6.交易查询响应集合
        /// </summary>
        [XmlElement("NTNETDZTZ1")]
        public List<NTNETDZTZ1> List { get; set; }
    }
    /// <summary>
    /// 9.6.交易查询响应内容
    /// </summary>
    public class NTNETDZTZ1
    {
        /// <summary>
        /// 交易日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime TRSDTE { get; set; }
        /// <summary>
        /// 交易日期	D, 对应<see cref="TRSDTE"/>
        /// </summary>
        [XmlElement("TRSDTE")]
        public string TRSDTEStr
        {
            get
            {
                return this.TRSDTE.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.TRSDTE = tmp;
                }
            }
        }
        /// <summary>
        /// 交易流水号	C(10)
        /// </summary>
        public string TRSNUM { get; set; }
        /// <summary>
        /// 交易套号	C(10)
        /// </summary>
        public string TRSSET { get; set; }
        /// <summary>
        /// 传票日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime VCRDTE { get; set; }
        /// <summary>
        /// 传票日期	D, 对应<see cref="VCRDTE"/>
        /// </summary>
        [XmlElement("VCRDTE")]
        public string VCRDTEStr
        {
            get
            {
                return this.VCRDTE.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.VCRDTE = tmp;
                }
            }
        }
        /// <summary>
        /// 传票套号	C(10)
        /// </summary>
        public string VCRSET { get; set; }
        /// <summary>
        /// 套录代码	C(4)
        /// </summary>
        public string VCRCOD { get; set; }
        /// <summary>
        /// 交易代码	C(4)	A.15 交易代码
        /// </summary>
        public string TRSCOD { get; set; }
        /// <summary>
        /// 业务编号	C(10)
        /// </summary>
        public string BUSNUM { get; set; }
        /// <summary>
        /// 产品类别	C(8)	附录A.49信用管理产品类别
        /// </summary>
        public string BUSTYP { get; set; }
        /// <summary>
        /// 交易金额	F(17,2)
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 冲补帐标识	C(1)
        /// </summary>
        public string RVSSBL { get; set; }
        /// <summary>
        /// 交易金额1	F(17,2)
        /// </summary>
        public decimal TRSAM1 { get; set; }
        /// <summary>
        /// 金额1类别	C(6)
        /// </summary>
        public string AM1TYP { get; set; }
        /// <summary>
        /// 金额1说明	Z(42)
        /// </summary>
        public string AM1NAM { get; set; }
        /// <summary>
        /// 交易金额2	F(17,2)
        /// </summary>
        public decimal TRSAM2 { get; set; }
        /// <summary>
        /// 金额2类别	C(6)
        /// </summary>
        public string AM2TYP { get; set; }
        /// <summary>
        /// 金额2说明	Z(42)
        /// </summary>
        public string AM2NAM { get; set; }
        /// <summary>
        /// 交易金额3	F(17,2)
        /// </summary>
        public decimal TRSAM3 { get; set; }
        /// <summary>
        /// 金额3类别	C(6)
        /// </summary>
        public string AM3TYP { get; set; }
        /// <summary>
        /// 金额3说明	Z(42)
        /// </summary>
        public string AM3NAM { get; set; }
        /// <summary>
        /// 余额	F(17,2)
        /// </summary>
        public decimal BALAMT { get; set; }
        /// <summary>
        /// 分行号	C(3)
        /// </summary>
        public string BBKNUM { get; set; }
        /// <summary>
        /// 机构号	C(6)
        /// </summary>
        public string BRNNUM { get; set; }
        /// <summary>
        /// 企业代码	C(10)
        /// </summary>
        public string CLTCOD { get; set; }
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CRYNUM { get; set; }
        /// <summary>
        /// 特殊控制码	C(20)
        /// </summary>
        public string SPLC20 { get; set; }
        /// <summary>
        /// 记录码	C(1)
        /// </summary>
        public string STSCOD { get; set; }
        /// <summary>
        /// 备用字段	C(73)
        /// </summary>
        public string RSVFLD { get; set; }
    }
}
