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
    /// 17.14.批量新增虚拟户响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS17_14 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTDMABAD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDMABAD";
        /// <summary>
        /// 17.14.批量新增虚拟户响应集合
        /// 只有经办失败，此接口才有数据；经办成功此接口不返回
        /// </summary>
        [XmlElement("NTDMABADZ1")]
        public List<NTDMABADZ1> List { get; set; }
    }
    /// <summary>
    /// 17.14.批量新增虚拟户响应内容
    /// </summary>
    public class NTDMABADZ1
    {
        /// <summary>
        /// 虚拟户编号	C(20)
        /// </summary>
        public string DMANBR { get; set; }
        /// <summary>
        /// 业务处理结果	C(1)
        /// </summary>
        public string RTNSTS { get; set; }
        /// <summary>
        /// 错误码	C(7)
        /// </summary>
        public string ERRCOD { get; set; }
        /// <summary>
        /// 错误文本	Z(192)
        /// </summary>
        public string ERRTXT { get; set; }
    }
}
