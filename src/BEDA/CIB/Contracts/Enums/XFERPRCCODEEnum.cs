using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BEDA.CIB.Contracts
{
    /// <summary>
    /// 指令状态编码，小于100为中间值，大于100为最终值
    /// </summary>
    public enum XFERPRCCODEEnum
    {
        /// <summary>
        /// 中间值  已提交成功
        /// </summary>
        SUBMIT_SUCC = 0,
        /// <summary>
        /// 中间值	指令审核中
        /// 当设置二级或二级以上流程（即银企代理服务软件的配置参数EnableSign=NO）时，需由企业登录企业网银进行复核及授权后，才能继续完成交易。
        /// </summary>
        AUDITING = 1,
        /// <summary>
        /// 中间值	指令已审核
        /// 当转账报文中 DTDUE 节点“期望转账日”大于当前日期时返回。到了设定的期望转账日，银行系统将自动执行指令，无需客户另外干预。
        /// </summary>
        AUDITED = 2,
        /// <summary>
        /// 中间值	指令状态未知
        /// 指令状态未知，请等待15分钟后再次发起查询，与银行系统进行对账。
        /// </summary>
        PENDING = 3,
        /// <summary>
        /// 中间值	等待银行端审核
        /// 当贷款户转账金额超过限额时出现，需要账户行审核后才能继续完成交易。如果在提交指令半个工作日后，状态仍未发生变化，请及时联系账户行审核。
        /// </summary>
        WAIT_FOR_AUDIT = 4,
        /// <summary>
        /// 中间值	后台处理中
        /// 异步交易，后台处理中
        /// </summary>
        PROCESSING = 5,
        /// <summary>
        /// 中间值	退回经办
        /// 提交的指令被授权人员退回
        /// </summary>
        SEND_BACK = 6,
        /// <summary>
        /// 最终值	指令已撤销
        /// </summary>
        CANCEL = 100,
        /// <summary>
        /// 最终值	指令过期
        /// </summary>
        EXPIRED = 101,
        /// <summary>
        /// 最终值	交易失败
        /// </summary>
        FAIL = 102,
        /// <summary>
        /// 最终值	交易成功/登记成功
        /// </summary>
        PAYOUT = 103,
        /// <summary>
        /// 最终值	部分支付成功	
        /// 当批量转账时出现；非批量转账的情况下，不会出现该状态。
        /// </summary>
        PART_PAYOUT = 104,
    }
}
