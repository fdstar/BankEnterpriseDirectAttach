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
    /// 21.3.1.协议查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS21_3_3 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTQRYCBQ
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQRYCBQ";
        /// <summary>
        /// 21.3.1.协议查询响应集合
        /// </summary>
        [XmlElement("NTQRYCBQZ")]
        public List<NTQRYCBQZ> List { get; set; }
    }
    /// <summary>
    /// 21.3.1.协议查询响应内容
    /// </summary>
    public class NTQRYCBQZ
    {
        /// <summary>
        /// 内部协议号	C(10)   贷记协议只有内部协议号
        /// </summary>
        public string CNVNBR { get; set; }
        /// <summary>
        /// 人行协议号	C(60)
        /// </summary>
        public string PTCNBR { get; set; }
        /// <summary>
        /// 协议类型	C(2)
        /// 01:贷记协议
        /// 02:授权支付协议
        /// 03:查询协议
        /// </summary>
        public string PTCTYP { get; set; }
        /// <summary>
        /// 我行客户户口	C(35)
        /// </summary>
        public string CLTEAC { get; set; }
        /// <summary>
        /// 我行客户号	C(10)
        /// </summary>
        public string CLTNBR { get; set; }
        /// <summary>
        /// 处理机构	C(6)    行内系统机构
        /// </summary>
        public string SYSBRN { get; set; }
        /// <summary>
        /// 签约发起机构	C(12)
        /// </summary>
        public string BEGBRD { get; set; }
        /// <summary>
        /// 签约第三方客户号	C(60)
        /// </summary>
        public string OTHCLT { get; set; }
        /// <summary>
        /// 协议方账户类型	C(4)
        /// </summary>
        public string ACRTYP { get; set; }
        /// <summary>
        /// 协议方账号	C(35)
        /// </summary>
        public string PYREAC { get; set; }
        /// <summary>
        /// 协议方名称	Z(100)
        /// </summary>
        public string PYRNAM { get; set; }
        /// <summary>
        /// 协议方开户行名称	Z(100)
        /// </summary>
        public string BRDNAM { get; set; }
        /// <summary>
        /// 协议方开户行所属网银系统行号	C(12)
        /// </summary>
        public string PYRBRD { get; set; }
        /// <summary>
        /// 协议方联系电话	C(32)
        /// </summary>
        public string PYRTEL { get; set; }
        /// <summary>
        /// 关联方账号或客户号	C(35)
        /// </summary>
        public string PYEEAC { get; set; }
        /// <summary>
        /// 关联方名称	Z(100)
        /// </summary>
        public string PYENAM { get; set; }
        /// <summary>
        /// 关联方开户行名称	Z(200)
        /// </summary>
        public string EBDNAM { get; set; }
        /// <summary>
        /// 关联方网银系统行号	C(12)
        /// </summary>
        public string PYEBRD { get; set; }
        /// <summary>
        /// 客户服务号(收款人)	C(60)
        /// </summary>
        public string PYECLT { get; set; }
        /// <summary>
        /// 有权第三方机构	C(12)
        /// </summary>
        public string OTHBRD { get; set; }
        /// <summary>
        /// 签约业务种类	C(5)
        /// </summary>
        public string BUSTYP { get; set; }
        /// <summary>
        /// 币种	C(2)	附录 A.3
        /// </summary>
        public string LMTCCY { get; set; }
        /// <summary>
        /// 单笔支付限额	M
        /// </summary>
        public decimal? ONELMT { get; set; }
        /// <summary>
        /// 日支付限额	M
        /// </summary>
        public decimal? DAYLMT { get; set; }
        /// <summary>
        /// 日限额余额	M
        /// </summary>
        public decimal? DAYBAL { get; set; }
        /// <summary>
        /// 日累计业务笔数上限	N(8)
        /// </summary>
        public int? LMDCNT { get; set; }
        /// <summary>
        /// 月累计支付限额	M
        /// </summary>
        public decimal? MTHLMT { get; set; }
        /// <summary>
        /// 月限额余额	M
        /// </summary>
        public decimal? MTHBAL { get; set; }
        /// <summary>
        /// 月累计业务笔数上限	N(8)
        /// </summary>
        public int? LMMCNT { get; set; }
        /// <summary>
        /// 扩展支付限额一	M
        /// </summary>
        public decimal? EXOLMT { get; set; }
        /// <summary>
        /// 限额一余额	M
        /// </summary>
        public decimal? EXOBAL { get; set; }
        /// <summary>
        /// 扩展支付限额二	M
        /// </summary>
        public decimal? EXTLMT { get; set; }
        /// <summary>
        /// 限额二余额	M
        /// </summary>
        public decimal? EXTBAL { get; set; }
        /// <summary>
        /// 扩展支付限额三	M
        /// </summary>
        public decimal? EXRLMT { get; set; }
        /// <summary>
        /// 限额三余额	M
        /// </summary>
        public decimal? EXRBAL { get; set; }
        /// <summary>
        /// 签约日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime REQDAT { get; set; }
        /// <summary>
        /// 签约日期	D, 对应<see cref="REQDAT"/>
        /// </summary>
        [XmlElement("REQDAT")]
        public string REQDATStr
        {
            get
            {
                return this.REQDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.REQDAT = tmp;
                }
            }
        }
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
        /// 签约说明	Z(256)
        /// </summary>
        public string DSPCMT { get; set; }
        /// <summary>
        /// 协议状态	C(2)	冻结、生效、已撤销	 A=生效 H=冻结 C=已撤销
        /// </summary>
        public string STSCOD { get; set; }
        /// <summary>
        /// 保留字 50	C(50)
        /// </summary>
        public string RSV50AZ { get; set; }
    }
}
