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
    /// 现金管理积数查询（历史）响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_CMCFINHS : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<CashProductHistory> List { get; set; }
    }
    /// <summary>
    /// 现金管理积数（历史）
    /// </summary>
    public class CashProductHistory : CashProduct
    {
        /// <summary>
        /// 结息日期 char(8)
        /// </summary>
        [XmlIgnore]
        public DateTime XSTRDT { get; set; }
        /// <summary>
        /// 结息日期 char(8), 对应<see cref="XSTRDT"/>
        /// </summary>
        [XmlElement("XSTRDT")]
        public string XSTRDTStr
        {
            get
            {
                return this.XSTRDT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.XSTRDT = tmp;
                }
            }
        }
        /// <summary>
        /// 资金管理标识 char(1) 0：自身平衡；1：限额透支；2：全额透支；3：超归集下拨；4：看管；5：委存委贷
        /// </summary>
        public int XSFLAG { get; set; }
    }
}
