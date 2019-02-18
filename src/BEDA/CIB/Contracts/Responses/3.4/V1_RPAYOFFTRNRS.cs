using BEDA.CIB.Contracts.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.4.3工资发放指令提交响应主体
    /// </summary>
    public class V1_RPAYOFFTRNRS : IResponse
    {
        /// <summary>
        /// 3.4.3工资发放指令提交响应
        /// </summary>
        public RPAYOFFTRNRS RPAYOFFTRNRS { get; set; }
    }
    /// <summary>
    /// 3.4.3工资发放指令提交响应
    /// </summary>
    public class RPAYOFFTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 如果客户端发送COOKIE，同步的历史记录不包括原有的CLTCOOKIE	非必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string CLTCOOKIE { get; set; }
        /// <summary>
        /// 3.4.3生成工资指令响应
        /// </summary>
        [XmlElement(Order = 3)]
        public RPAYOFFRS RPAYOFFRS { get; set; }
    }
    /// <summary>
    /// 生成工资指令响应
    /// </summary>
    public class RPAYOFFRS
    {
        /// <summary>
        /// 服务器该笔交易的唯一标识	可选
        /// </summary>
        [XmlElement(Order = 0)]
        public string SRVRID { get; set; }
        /// <summary>
        /// 工资发放指令	必回
        /// </summary>
        [XmlElement("RPAYOFFINFO", Order = 1)]
        public RPAYOFFINFO<RPAYOFFR> RPAYOFFINFO { get; set; }
        /// <summary>
        /// 指令处理状态	必回
        /// </summary>
        [XmlElement(Order = 99999)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
    /// <summary>
    /// 工资指令执行结果
    /// </summary>
    public class RPAYOFFR : RPAYOFF
    {
        /// <summary>
        /// 核心交易处理结果	必回  
        /// STATUS与ERRMSG对应描述如下
        /// -1	未处理
        /// 23	执行成功
        /// 40	异地账户
        /// 41	卡号不存在
        /// 42	账号不存在
        /// 43	账号已删除
        /// 44	账号已销户
        /// 45	账号已冻结
        /// 46	账户余额余额不足
        /// 47	起存金额金额不足
        /// 48	客户编码不存在
        /// 49	户名不符
        /// 50	证件不符
        /// 51	证件重复
        /// 52	非正常卡号或账号
        /// 53	交易金额非法
        /// 54	收款人姓名错
        /// 59	其他错误
        /// 60	校验成功
        /// 90	异步处理中
        /// 3885	同步状态失败
        /// </summary>
        [XmlElement(Order = 4)]
        public int STATUS { get; set; }
        /// <summary>
        /// 核心交易处理结果信息，详见：工资发放核心交易处理结果对照表	必回
        /// </summary>
        [XmlElement(Order = 5)]
        public string ERRMSG { get; set; }
        /// <summary>
        /// 当前处理状态，对应<see cref="STATUS"/>
        /// </summary>
        [XmlIgnore]
        public PayoffStatusEnum Status
        {
            get
            {
                return (PayoffStatusEnum)this.STATUS;
            }
            set
            {
                this.STATUS = (int)value;
            }
        }
    }
}
