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
    /// 12.6.5.支付机构查询结售汇申请项下子业务明细响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS12_6_5 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTJSBQRT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTJSBQRT";
        /// <summary>
        /// 12.6.5.支付机构查询结售汇申请项下子业务明细响应内容
        /// </summary>
        public NTJSBQRTZ NTJSBQRTZ { get; set; }
        /// <summary>
        /// 12.6.5.支付机构查询结售汇申请项下子业务明细响应集合
        /// </summary>
        [XmlElement("NTBEXQRTZ")]
        public List<NTBEXQRTZ> NTBEXQRTZList { get; set; }
        /// <summary>
        /// 12.6.5.支付机构查询结售汇申请项下子业务明细响应集合
        /// </summary>
        [XmlElement("NTVENQRTZ")]
        public List<NTVENQRTZ> NTVENQRTZList { get; set; }
    }
    /// <summary>
    /// 12.6.5.支付机构查询结售汇申请项下子业务明细响应内容
    /// </summary>
    public class NTJSBQRTZ
    {
        /// <summary>
        /// 本轮次笔数	N(6)
        /// </summary>
        public int LODCNT { get; set; }
        /// <summary>
        /// 申请类型	C(4)    EXSL：结汇 EXBY：购汇
        /// </summary>
        public string JSHCOD { get; set; }
    }
    /// <summary>
    /// 12.6.5.支付机构查询结售汇申请项下子业务明细响应内容
    /// </summary>
    public class NTBEXQRTZ
    {
        /// <summary>
        /// 批次号 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 轮次序号	N(6)
        /// </summary>
        public int LODSEQ { get; set; }
        /// <summary>
        /// 交易唯一序号	C(22)
        /// </summary>
        public string EVTSEQ { get; set; }
        /// <summary>
        /// 客户属性	C(2)
        /// </summary>
        public string CLTPRO { get; set; }
        /// <summary>
        /// 结售汇属性	C(4)	A.7 结售汇属性表
        /// </summary>
        public string EXRPRO { get; set; }
        /// <summary>
        /// 居民标识	C(1)
        /// </summary>
        public string RESTYP { get; set; }
        /// <summary>
        /// 国别（地区）代码	C(3)	A.8国家地区代码表
        /// </summary>
        public string CNRCOD { get; set; }
        /// <summary>
        /// 证件类型	C(3)
        /// </summary>
        public string CIDTYP { get; set; }
        /// <summary>
        /// 证件号码	Z(30)
        /// </summary>
        public string CIDCOD { get; set; }
        /// <summary>
        /// 结汇资金属性	C(3)
        /// </summary>
        public string MNYPRO { get; set; }
        /// <summary>
        /// 姓名（收款人名称）	Z(62)
        /// </summary>
        public string BNFNAM { get; set; }
        /// <summary>
        /// 资金币种	C(3)
        /// </summary>
        public string TRSCCY { get; set; }
        /// <summary>
        /// 结汇金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 资金形态	C(1)
        /// </summary>
        public string MNYFOM { get; set; }
        /// <summary>
        /// 备注	Z(32)
        /// </summary>
        public string BEXRMK { get; set; }
        /// <summary>
        /// 补录编号	C(22)
        /// </summary>
        public string ADDNBR { get; set; }
        /// <summary>
        /// 错误码	C(7)
        /// </summary>
        public string MSGCOD { get; set; }
        /// <summary>
        /// 状态	C(1)
        /// </summary>
        public string STSCOD { get; set; }
        /// <summary>
        /// 最后维护日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime MNTDAT { get; set; }
        /// <summary>
        /// 最后维护日期	D, 对应<see cref="MNTDAT"/>
        /// </summary>
        [XmlElement("MNTDAT")]
        public string MNTDATStr
        {
            get
            {
                return this.MNTDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.MNTDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 支付机构代码	C(20)
        /// </summary>
        public string PAYBCD { get; set; }
    }
    /// <summary>
    /// 12.6.5.支付机构查询结售汇申请项下子业务明细响应内容
    /// </summary>
    public class NTVENQRTZ
    {
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 轮次序号	N(6)
        /// </summary>
        public int LODSEQ { get; set; }
        /// <summary>
        /// 交易唯一序号	C(22)
        /// </summary>
        public string EVTSEQ { get; set; }
        /// <summary>
        /// 客户属性	C(2)
        /// </summary>
        public string CLTPRO { get; set; }
        /// <summary>
        /// 结售汇属性	C(4)
        /// </summary>
        public string EXRPRO { get; set; }
        /// <summary>
        /// 身份证件号码	Z(30)
        /// </summary>
        public string CIDCOD { get; set; }
        /// <summary>
        /// 购汇种类	C(2)
        /// </summary>
        public string EXBTYP { get; set; }
        /// <summary>
        /// 姓名（购汇人名称）	Z(62)
        /// </summary>
        public string CLTNAM { get; set; }
        /// <summary>
        /// 前往国家（地区）代码	C(3)
        /// </summary>
        public string CNRCOD { get; set; }
        /// <summary>
        /// 资金币种	C(3)
        /// </summary>
        public string TRSCCY { get; set; }
        /// <summary>
        /// 购汇金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 购汇方式	C(1)
        /// </summary>
        public string EXBMED { get; set; }
        /// <summary>
        /// 提钞金额	M
        /// </summary>
        public decimal CSHAMT { get; set; }
        /// <summary>
        /// 备注	Z(32)
        /// </summary>
        public string VENRMK { get; set; }
        /// <summary>
        /// 补录编号	C(22)
        /// </summary>
        public string ADDNBR { get; set; }
        /// <summary>
        /// 错误码	C(7)
        /// </summary>
        public string MSGCOD { get; set; }
        /// <summary>
        /// 状态	C(1)
        /// </summary>
        public string STSCOD { get; set; }
        /// <summary>
        /// 最后维护日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime MNTDAT { get; set; }
        /// <summary>
        /// 最后维护日期	D, 对应<see cref="MNTDAT"/>
        /// </summary>
        [XmlElement("MNTDAT")]
        public string MNTDATStr
        {
            get
            {
                return this.MNTDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.MNTDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 支付机构代码	C(20)
        /// </summary>
        public string PAYBCD { get; set; }
    }
}
