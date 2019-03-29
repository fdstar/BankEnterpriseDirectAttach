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
    /// 10.9.基准利率维护历史查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS10_9 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// SDKNTLIRBLL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKNTLIRBLL";
        /// <summary>
        /// 10.9.基准利率维护历史查询响应集合
        /// </summary>
        [XmlElement("NTLIRBLLZ")]
        public List<NTLIRBLLZ> List { get; set; }
    }
    /// <summary>
    /// 10.9.基准利率维护历史查询响应内容
    /// </summary>
    public class NTLIRBLLZ
    {
        /// <summary>
        /// 协议编号	C(10)
        /// </summary>
        public string CRSCOD { get; set; }
        /// <summary>
        /// 维护前利率	I
        /// </summary>
        public decimal BFTINT { get; set; }
        /// <summary>
        /// 维护后利率	I
        /// </summary>
        public decimal AFTINT { get; set; }
        /// <summary>
        /// 维护方	C(3)	A.31 维护方
        /// </summary>
        public string MNTDPT { get; set; }
        /// <summary>
        /// 维护日期	D   日期最大一条记录即为当前利率值
        /// </summary>
        [XmlIgnore]
        public DateTime MNTDAT { get; set; }
        /// <summary>
        /// 维护日期	D, 对应<see cref="MNTDAT"/>
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
        /// 状态	C(1)
        /// </summary>
        public string STSCOD { get; set; }
        /// <summary>
        /// 保留字段	C(30)
        /// </summary>
        public string RSV30Z { get; set; }
    }
}
