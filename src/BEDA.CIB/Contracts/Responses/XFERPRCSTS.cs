using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 指令处理节点
    /// </summary>
    public class XFERPRCSTS
    {
        /// <summary>
        /// 指令状态编码
        /// </summary>
        [XmlElement(Order = 0)]
        public XFERPRCCODEEnum XFERPRCCODE { get; set; }
        /// <summary>
        /// 指令处理时间 yyyy-MM-dd HH:mm:ss格式 如：2014-11-19 15:02:28
        /// </summary>
        [XmlIgnore]
        public DateTime DTXFERPRC { get; set; }
        /// <summary>
        /// 服务端日期时间，yyyy-MM-dd HH:mm:ss ,对应<see cref="DTXFERPRC"/>
        /// </summary>
        [XmlElement("DTXFERPRC", Order = 1)]
        public string DTXFERPRCStr
        {
            get
            {
                return this.DTXFERPRC.ToString("yyyy-MM-dd HH:mm:ss");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd HH:mm:ss", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DTXFERPRC = tmp;
                }
            }
        }
        /// <summary>
        /// 指令处理信息（非必回）
        /// </summary>
        [XmlElement(Order = 2)]
        public string MESSAGE { get; set; }
        /// <summary>
        /// 业务是否已结束
        /// </summary>
        [XmlIgnore]
        public bool IsEnd => (int)this.XFERPRCCODE >= 100;
    }
}
