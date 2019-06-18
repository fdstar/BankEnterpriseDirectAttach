using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CITIC.Contracts.Responses
{
    /// <summary>
    /// 额度管理查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLEDGLQY : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<Quota> List { get; set; }
    }
    /// <summary>
    /// 额度管理
    /// </summary>
    public class Quota
    {
        /// <summary>
        /// 现金池ID char(8)
        /// </summary>
        [XmlElement("poolID")]
        public string PoolID { get; set; }
        /// <summary>
        /// 成员单位账号 char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 资金管理标志 char(1) 0：自身平衡；1：限额透支；2：全额透支；3：超归集下拨；4：看管；5：委存委贷
        /// </summary>
        [XmlElement("fundMgrFlg")]
        public int FundMgrFlg { get; set; }
        /// <summary>
        /// 集团分配透支额度decimal(15,2)
        /// </summary>
        [XmlElement("overAmt")]
        public decimal OverAmt { get; set; }
        /// <summary>
        /// 超归集下拨额度decimal(15,2)
        /// </summary>
        [XmlElement("beyondAmt")]
        public decimal BeyondAmt { get; set; }
        /// <summary>
        /// 集团看管额度 decimal(15,2)
        /// </summary>
        [XmlElement("guardAmt")]
        public decimal GuardAmt { get; set; }
        /// <summary>
        /// 交易金额 decimal(15,2)
        /// </summary>
        [XmlElement("tranAmt")]
        public decimal TranAmt { get; set; }
        /// <summary>
        /// 摘要 varchar(102)
        /// </summary>
        [XmlElement("abstract")]
        public string Abstract { get; set; }
        /// <summary>
        /// 备注 varchar(60)
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }
        /// <summary>
        /// 经办人姓名 varchar(62)
        /// </summary>
        [XmlElement("operatorNm")]
        public string OperatorNm { get; set; }
        /// <summary>
        /// 经办日期char(8) 格式：YYYYMMDD
        /// </summary>
        [XmlElement("operateDate")]
        public string OperateDate { get; set; }
        /// <summary>
        /// 经办时间 char(6)  格式：hhmmss
        /// </summary>
        [XmlElement("operateTime")]
        public string OperateTime { get; set; }
        /// <summary>
        /// 经办时间 由<see cref="OperateDate"/>和<see cref="OperateTime"/>组成
        /// </summary>
        [XmlIgnore]
        public DateTime? OperatingTime
        {
            get
            {
                if (DateTime.TryParseExact(string.Format("{0}{1}", this.OperateDate, this.OperateTime),
                   new string[] { "yyyyMMdd", "yyyyMMddHHmmss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    return tmp;
                }
                return null;
            }
        }
        /// <summary>
        /// 制单状态 varchar(2)  状态取值见附录4.2
        /// </summary>
        [XmlElement("stt")]
        public string Stt { get; set; }
    }
}
