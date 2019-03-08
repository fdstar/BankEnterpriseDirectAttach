using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BEDA.CIB.Contracts
{
    /// <summary>
    /// 工资支付结果枚举
    /// </summary>
    public enum PayoffStatusEnum
    {
        /// <summary>
        /// 未处理
        /// </summary>
        NoDeal = -1,
        /// <summary>
        /// 执行成功
        /// </summary>
        Success = 23,
        /// <summary>
        /// 异地账户
        /// </summary>
        AllopatryAccount = 40,
        /// <summary>
        /// 卡号不存在
        /// </summary>
        NoCardNumber = 41,
        /// <summary>
        /// 账号不存在
        /// </summary>
        NoAccount = 42,
        /// <summary>
        /// 账号已删除
        /// </summary>
        AccountDeleted = 43,
        /// <summary>
        /// 账号已销户
        /// </summary>
        AccountCancellation = 44,
        /// <summary>
        /// 账号已冻结
        /// </summary>
        AccountFrozen = 45,
        /// <summary>
        /// 账户余额余额不足
        /// </summary>
        NoEnoughBalance = 46,
        /// <summary>
        /// 起存金额金额不足
        /// </summary>
        NoEnoughDeposit = 47,
        /// <summary>
        /// 客户编码不存在
        /// </summary>
        NoAccountIndex = 48,
        /// <summary>
        /// 户名不符
        /// </summary>
        NotEqualAccountName = 49,
        /// <summary>
        /// 证件不符
        /// </summary>
        NotEqualCertificate = 50,
        /// <summary>
        /// 证件重复
        /// </summary>
        DuplicateCertificate = 51,
        /// <summary>
        /// 非正常卡号或账号
        /// </summary>
        AbnormalCardOrAccount = 52,
        /// <summary>
        /// 交易金额非法
        /// </summary>
        IllegalAmount = 53,
        /// <summary>
        /// 收款人姓名错
        /// </summary>
        PayeeNameError = 54,
        /// <summary>
        /// 其他错误
        /// </summary>
        UnknowError = 59,
        /// <summary>
        /// 校验成功
        /// </summary>
        CheckSuccess = 60,
        /// <summary>
        /// 异步处理中
        /// </summary>
        AsyncDealing = 90,
        /// <summary>
        /// 同步状态失败
        /// </summary>
        SyncFailure = 3885,
    }
}
