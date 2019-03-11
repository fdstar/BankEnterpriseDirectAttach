using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Responses
{
    /// <summary>
    /// 招商银行响应头信息
    /// </summary>
    public class RSINFO : INFO
    {
        /// <summary>
        /// 服务端响应报文
        /// </summary>
        [XmlIgnore]
        public string ResponseContent { get; internal set; }
        /// <summary>
        /// 返回代码
        /// 0	成功
        /// -1	提交主机失败
        /// -2	执行失败
        /// -3	数据格式错误
        /// -4	尚未登录系统
        /// -5	请求太频繁
        /// -6	不是证书卡用户
        /// -7	用户取消操作
        /// -9	其它错误
        /// 空  表示响应或反序列化失败（非招商返回错误）
        /// </summary>
        public string RETCOD { get; set; }
        /// <summary>
        /// 是否响应成功
        /// </summary>
        [XmlIgnore]
        public bool IsSuccess { get { return this.RETCOD == "0"; } }
        /// <summary>
        /// 错误信息
        /// </summary>
        public string ERRMSG { get; set; }
    }
}
