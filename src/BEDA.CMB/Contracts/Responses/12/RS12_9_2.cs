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
    /// 12.9.2.企业货物贸易收支名录情况查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS12_9_2 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTTBLQRY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTTBLQRY";
        /// <summary>
        /// 12.9.2.企业货物贸易收支名录情况查询响应内容
        /// </summary>
        public NTTBLQRYZ1 NTTBLQRYZ1 { get; set; }
    }
    /// <summary>
    /// 12.9.2.企业货物贸易收支名录情况查询响应内容
    /// </summary>
    public class NTTBLQRYZ1
    {
        /// <summary>
        /// 查询日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime QRYDAT { get; set; }
        /// <summary>
        /// 查询日期	D, 对应<see cref="QRYDAT"/>
        /// </summary>
        [XmlElement("QRYDAT")]
        public string QRYDATStr
        {
            get
            {
                return this.QRYDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.QRYDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 企业代码         	C(9)
        /// </summary>
        public string CUSCOD { get; set; }
        /// <summary>
        /// 分类结果         	C(1) 	2:无需关注;3:关注类
        /// </summary>
        public string TYPCOD { get; set; }
        /// <summary>
        /// 保留字30	C(30)
        /// </summary>
        public string RSV30Z { get; set; }
    }
}
