
/*
	该文件由生成器自动生成,请勿手动修改!
	生成时间:2018-12-28 11:54:29.5768432 +0800 CST m=+0.050619401
	Author : fox
*/

public enum ErrType{
	
	﻿Err_NoError = 0 , //没有错误
	
	Err_ServerError = 500 , //服务器内部错误
	
	Err_MysqlDisconnect = 501 , //mysql断开
	
	Err_NoUploadImgReqInfo = 502 , //没有上传图片的请求信息
	
	Err_UploadImgDataErr = 503 , //上传图片数据有误
	
	Err_UploadToOSSErr = 504 , //存储图片错误
	
	Err_ConfigError = 505 , //配置错误
	
	Err_MsgDataError = 506 , //通信数据错误
	
	Err_ResourceNoEnough = 507 , //资源不足
	
	Err_NotExists = 508 , //资源不存在
	
	Err_NoReachCondition = 509 , //条件不满足
	
	Err_SexError = 510 , //性别不符合
	
	Err_LevError = 511 , //等级不符合
	
	Err_TimeError = 512 , //时间未到
	
	Err_AccountUnknowCode = 1000 , //未知错误
	
	Err_AccountAlreadyExist = 1001 , //账号已存在
	
	Err_AccountServerErr = 1002 , //服务器内部错误
	
	Err_AccountPwdErr = 1003 , //密码不匹配
	
	Err_AccountNotExist = 1004 , //账号不存在
	
	Err_AccountFrozen = 1005 , //账号被锁定
	
	Err_User_Logout = 1006 , //玩家已经离线
	
	Err_DiamondNotEnough = 1007 , //钻石不够
	
	Err_SilverNotEnough = 1008 , //银两不够
	
	Err_PayDiamond = 1009 , //扣除钻石失败
	
	Err_InviteCodeErr = 1010 , //邀请码错误
	
	Err_DirtyWord = 1011 , //文本中含有敏感关键字
	
	Err_RepeatNickName = 1012 , //重复名字
	
	Err_PlayerNotExists = 1013 , //玩家不存在
	
	Err_NeedAccountRelogin = 1016 , //账号信息错误，请重新登录
	
	Err_AccountRegRule = 1017 , //注册的账号不符合规则
	
	Err_PlayerExists = 1018 , //已创建角色
	
	Err_AccountSessionExpired = 1019 , //登陆信息过期
	
	Err_VC_ReqTimeLimit = 1101 , //验证码申请时间限制
	
	Err_VC_ReqError = 1102 , //获取验证码失败，请重试
	
	Err_VC_NotPhone = 1103 , //获取验证码失败，手机号码不正确
	
	Err_VC_Expiry = 1104 , //验证码已失效
	
	Err_TaskCfg_NotExists = 1201 , //任务配置不存在
	
	Err_Task_NotExists = 1202 , //任务不存在
	
	Err_Task_Unfinish = 1203 , //任务未完成
	
	Err_RefreshHeroCount = 2001 , //刷新英雄数量错误
	
	Err_RecruitHero_NotExists = 2002 , //招募的英雄不存在
	
	Err_AwardHeroFailed = 2003 , //招募的英雄获取失败
	
	Err_LimitXiSuiCount = 2004 , //洗髓次数不足
	
	Err_CantUpGestPhase = 2005 , //不能突破
	
	Err_HeroNoExists = 2006 , //英雄不存在
	
	Err_EquipUpLevFailed = 2101 , //强化失败
	
	Err_EquipNotExist = 2102 , //装备不存在失败
	
	Err_EquipCantIdentify = 2103 , //该装备不能鉴定
	
	Err_EquipMaxRandAttr = 2104 , //该装备隐藏属性达到上限,不能鉴定
	
	Err_EquipNoCfg = 2105 , //装备数据异常。
	
	Err_EquipCantUpStage = 2106 , //该装备不能进化
	
	Err_EquipCantRandGetAttr = 2107 , //该装备不能洗练
	
	Err_EquipNoReplaceRandAttr = 2108 , //装备没有可替换的洗练属性
	
	Err_EquipPosAlreadyEquip = 2109 , //该位置已经有装备
	
	Err_GestPosAlreadyEquip = 2110 , //该位置已经有武功
	
	Err_NoExistItem = 2201 , //物品不存在
	
	Err_NoEnoughItem = 2202 , //物品数量不够
	
	Err_AwardItemFailed = 2203 , //获得物品失败
	
	Err_GestNoExist = 2204 , //武功不存在
	
	Err_StageFlowErr = 2301 , //关卡流程错误
	
	Err_MaxStageBattle = 2302 , //关卡挑战上限
	
	Err_NoStage = 2303 , //关卡不存在
	
	Err_Gathering = 2304 , //资源采集中
	
	Err_BossNoPass = 2305 , //boss还没打过
	
	Err_QuestFinised = 2351 , //任务已交
	
	Err_QuestAcceptd = 2352 , //任务已接
	
	Err_ParentQuestNoFinished = 2353 , //前置任务未完成
	
	Err_NoQuest = 2354 , //没有该任务
	
	Err_NoWanted = 2355 , //没有通缉令任务
	
	Err_MaxWantedCount = 2356 , //今日已无新通缉令
	
	Err_UnfinishFriendEvent = 2360 , //未完成好友任务事件
	
	Err_NoFriendData = 2361 , //没有相关结交数据
	
	Err_FinishedFriendEvent = 2362 , //已经完成事件
	
	Err_ArenaRankLocked = 2370 , //排行榜位置被锁定，不能挑战
	
	Err_ArenaRankChange = 2371 , //排行榜发生变化
	
	Err_ArenaRankRewardAcquired = 2372 , //排名奖励已经领取
	
	Err_AlreadyTraining = 2380 , //已经在训练
	
	Err_AlreadyUnlockFurniture = 2381 , //家具位置已经解锁
	
	Err_AlreadyPutFurniture = 2382 , //家具已经摆出来
	
	Err_FurnitureStorageFull = 2383 , //家具仓库已满
	
	Err_FishingFailure = 2384 , //钓鱼失败(这仅仅是一个提示，不能作为一个错误来处理)
	
	Err_HerbalGardenFull = 2385 , //药圃已满
	
	Err_NoComposeData = 2386 , //没有找到数据
	
}


public static class ErrorCodeManager{
	public static string ErrorCode(int errCode){
		switch(errCode){
			
			case (int)ErrType.﻿Err_NoError: return "没有错误";
			
			case (int)ErrType.Err_ServerError: return "服务器内部错误";
			
			case (int)ErrType.Err_MysqlDisconnect: return "mysql断开";
			
			case (int)ErrType.Err_NoUploadImgReqInfo: return "没有上传图片的请求信息";
			
			case (int)ErrType.Err_UploadImgDataErr: return "上传图片数据有误";
			
			case (int)ErrType.Err_UploadToOSSErr: return "存储图片错误";
			
			case (int)ErrType.Err_ConfigError: return "配置错误";
			
			case (int)ErrType.Err_MsgDataError: return "通信数据错误";
			
			case (int)ErrType.Err_ResourceNoEnough: return "资源不足";
			
			case (int)ErrType.Err_NotExists: return "资源不存在";
			
			case (int)ErrType.Err_NoReachCondition: return "条件不满足";
			
			case (int)ErrType.Err_SexError: return "性别不符合";
			
			case (int)ErrType.Err_LevError: return "等级不符合";
			
			case (int)ErrType.Err_TimeError: return "时间未到";
			
			case (int)ErrType.Err_AccountUnknowCode: return "未知错误";
			
			case (int)ErrType.Err_AccountAlreadyExist: return "账号已存在";
			
			case (int)ErrType.Err_AccountServerErr: return "服务器内部错误";
			
			case (int)ErrType.Err_AccountPwdErr: return "密码不匹配";
			
			case (int)ErrType.Err_AccountNotExist: return "账号不存在";
			
			case (int)ErrType.Err_AccountFrozen: return "账号被锁定";
			
			case (int)ErrType.Err_User_Logout: return "玩家已经离线";
			
			case (int)ErrType.Err_DiamondNotEnough: return "钻石不够";
			
			case (int)ErrType.Err_SilverNotEnough: return "银两不够";
			
			case (int)ErrType.Err_PayDiamond: return "扣除钻石失败";
			
			case (int)ErrType.Err_InviteCodeErr: return "邀请码错误";
			
			case (int)ErrType.Err_DirtyWord: return "文本中含有敏感关键字";
			
			case (int)ErrType.Err_RepeatNickName: return "重复名字";
			
			case (int)ErrType.Err_PlayerNotExists: return "玩家不存在";
			
			case (int)ErrType.Err_NeedAccountRelogin: return "账号信息错误，请重新登录";
			
			case (int)ErrType.Err_AccountRegRule: return "注册的账号不符合规则";
			
			case (int)ErrType.Err_PlayerExists: return "已创建角色";
			
			case (int)ErrType.Err_AccountSessionExpired: return "登陆信息过期";
			
			case (int)ErrType.Err_VC_ReqTimeLimit: return "验证码申请时间限制";
			
			case (int)ErrType.Err_VC_ReqError: return "获取验证码失败，请重试";
			
			case (int)ErrType.Err_VC_NotPhone: return "获取验证码失败，手机号码不正确";
			
			case (int)ErrType.Err_VC_Expiry: return "验证码已失效";
			
			case (int)ErrType.Err_TaskCfg_NotExists: return "任务配置不存在";
			
			case (int)ErrType.Err_Task_NotExists: return "任务不存在";
			
			case (int)ErrType.Err_Task_Unfinish: return "任务未完成";
			
			case (int)ErrType.Err_RefreshHeroCount: return "刷新英雄数量错误";
			
			case (int)ErrType.Err_RecruitHero_NotExists: return "招募的英雄不存在";
			
			case (int)ErrType.Err_AwardHeroFailed: return "招募的英雄获取失败";
			
			case (int)ErrType.Err_LimitXiSuiCount: return "洗髓次数不足";
			
			case (int)ErrType.Err_CantUpGestPhase: return "不能突破";
			
			case (int)ErrType.Err_HeroNoExists: return "英雄不存在";
			
			case (int)ErrType.Err_EquipUpLevFailed: return "强化失败";
			
			case (int)ErrType.Err_EquipNotExist: return "装备不存在失败";
			
			case (int)ErrType.Err_EquipCantIdentify: return "该装备不能鉴定";
			
			case (int)ErrType.Err_EquipMaxRandAttr: return "该装备隐藏属性达到上限,不能鉴定";
			
			case (int)ErrType.Err_EquipNoCfg: return "装备数据异常。";
			
			case (int)ErrType.Err_EquipCantUpStage: return "该装备不能进化";
			
			case (int)ErrType.Err_EquipCantRandGetAttr: return "该装备不能洗练";
			
			case (int)ErrType.Err_EquipNoReplaceRandAttr: return "装备没有可替换的洗练属性";
			
			case (int)ErrType.Err_EquipPosAlreadyEquip: return "该位置已经有装备";
			
			case (int)ErrType.Err_GestPosAlreadyEquip: return "该位置已经有武功";
			
			case (int)ErrType.Err_NoExistItem: return "物品不存在";
			
			case (int)ErrType.Err_NoEnoughItem: return "物品数量不够";
			
			case (int)ErrType.Err_AwardItemFailed: return "获得物品失败";
			
			case (int)ErrType.Err_GestNoExist: return "武功不存在";
			
			case (int)ErrType.Err_StageFlowErr: return "关卡流程错误";
			
			case (int)ErrType.Err_MaxStageBattle: return "关卡挑战上限";
			
			case (int)ErrType.Err_NoStage: return "关卡不存在";
			
			case (int)ErrType.Err_Gathering: return "资源采集中";
			
			case (int)ErrType.Err_BossNoPass: return "boss还没打过";
			
			case (int)ErrType.Err_QuestFinised: return "任务已交";
			
			case (int)ErrType.Err_QuestAcceptd: return "任务已接";
			
			case (int)ErrType.Err_ParentQuestNoFinished: return "前置任务未完成";
			
			case (int)ErrType.Err_NoQuest: return "没有该任务";
			
			case (int)ErrType.Err_NoWanted: return "没有通缉令任务";
			
			case (int)ErrType.Err_MaxWantedCount: return "今日已无新通缉令";
			
			case (int)ErrType.Err_UnfinishFriendEvent: return "未完成好友任务事件";
			
			case (int)ErrType.Err_NoFriendData: return "没有相关结交数据";
			
			case (int)ErrType.Err_FinishedFriendEvent: return "已经完成事件";
			
			case (int)ErrType.Err_ArenaRankLocked: return "排行榜位置被锁定，不能挑战";
			
			case (int)ErrType.Err_ArenaRankChange: return "排行榜发生变化";
			
			case (int)ErrType.Err_ArenaRankRewardAcquired: return "排名奖励已经领取";
			
			case (int)ErrType.Err_AlreadyTraining: return "已经在训练";
			
			case (int)ErrType.Err_AlreadyUnlockFurniture: return "家具位置已经解锁";
			
			case (int)ErrType.Err_AlreadyPutFurniture: return "家具已经摆出来";
			
			case (int)ErrType.Err_FurnitureStorageFull: return "家具仓库已满";
			
			case (int)ErrType.Err_FishingFailure: return "钓鱼失败(这仅仅是一个提示，不能作为一个错误来处理)";
			
			case (int)ErrType.Err_HerbalGardenFull: return "药圃已满";
			
			case (int)ErrType.Err_NoComposeData: return "没有找到数据";
			
			}
			return "没有该错误码对应信息! errCode:" + errCode;
		}
	}
}