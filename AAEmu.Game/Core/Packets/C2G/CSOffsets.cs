﻿namespace AAEmu.Game.Core.Packets.C2G
{
    public static class CSOffsets
    {
        // All opcodes here are updated for version client_17_r236100
        public const ushort X2EnterWorldPacket = 0x00;
        // double _01_&_05_
        public const ushort CSResturnAddrsPacket = 0x056;     // level = 1
        public const ushort CSResturnAddrs_05_Packet = 0x056; // level = 5
        public const ushort CSHgResponsePacket = 0x049;       // level = 1
        public const ushort CSHgResponse_05_Packet = 0x049;   // level = 5
        public const ushort CSAesXorKeyPacket = 0x0f7;        // level = 1
        public const ushort CSAesXorKey_05_Packet = 0x0f7;    // level = 5

        public const ushort CSTodayAssignmentPacket = 0x0d1;
        public const ushort CSUnknownPacket_0x12c = 0x12c;
        public const ushort CSUnknownPacket_0x02c = 0x02c;
        public const ushort CSMoveUnitPacket = 0x105;
        public const ushort CSCofferInteractionPacket = 0x003;
        public const ushort CSRemoveCommonFarmsPacket = 0x043;
        public const ushort CSPlaceCommonFarmPacket = 0x0c5;
        public const ushort CSRequestCommonFarmList = 0x025;
        public const ushort CSChallengeDuelPacket = 0x02d;
        public const ushort CSStartDuelPacket = 0x0fe;
        public const ushort CSConvertItemLookPacket = 0x05d;
        public const ushort CSUnknownPacket_0x028 = 0x028;
        public const ushort CSSetPingPosPacket = 0x084;
        public const ushort CSICSMoneyRequestPacket = 0x129;
        public const ushort CSChangeMateNamePacket = 0x015;
        public const ushort CSRankCharacterPacket = 0x018;
        public const ushort CSRankSnapshotPacket = 0x065;
        public const ushort CSRequestSecondPasswordKeyTablesPacket = 0x02f;
        public const ushort CSCreateSecondPasswordPacket = 0x080;
        public const ushort CSChangeSecondPasswordPacket = 0x11c;
        public const ushort CSClearSecondPasswordPacket = 0x05e;
        public const ushort CSCheckSecondPasswordPacket = 0x031;
        public const ushort CSReplyImprisonOrTrialPacket = 0x02b;
        public const ushort CSSkipFinalStatementPacket = 0x0c2;
        public const ushort CSReplyInviteJuryPacket = 0x042;
        public const ushort CSJurySummonedPacket = 0x0e3;
        public const ushort CSJuryEndTestimonyPacket = 0x007;
        public const ushort CSCancelTrialPacket = 0x0d2;
        public const ushort CSJuryVerdictPacket = 0x062;
        public const ushort CSReportCrimePacket = 0x102;
        public const ushort CSRequestJuryWaitingNumberPacket = 0x0b7;
        public const ushort CSRequestSetBountyMoneyPacket = 0x145;
        public const ushort CSUpdateBountyPacket = 0x11f;
        public const ushort CSUnknownPacket_0x0ae = 0x0ae;
        public const ushort CSSendUserMusicPacket = 0x0bb;
        public const ushort CSSaveUserMusicNotesPacket = 0x020;
        public const ushort CSRequestMusicNotesPacket = 0x092;
        public const ushort CSPauseUserMusicPacket = 0x060;
        public const ushort CSSkillControllerStatePacket = 0x0cf;
        public const ushort CSMountMatePacket = 0x0af;
        public const ushort CSLeaveWorldPacket = 0x006;
        public const ushort CSCancelLeaveWorldPacket = 0x141;
        public const ushort CSIdleStatusPacket = 0x056;
        public const ushort CSUnknownPacket_0x0ac = 0x0ac;
        public const ushort CSCompletedCinemaPacket = 0x05c;
        public const ushort CSCheckDemoModePacket = 0x131;
        public const ushort CSResetDemoCharPacket = 0x0ea;
        public const ushort CSConsoleCmdUsedPacket = 0x051;
        public const ushort CSEditorGameModePacket = 0x017;
        public const ushort CSEditorRemoveGimmickPacket = 0x0d6;
        public const ushort CSInteractGimmickPacket = 0x13e;
        public const ushort CSEditorAddGimmickPacket = 0x114;
        public const ushort CSWorldRayCastingPacket = 0x0a5;
        public const ushort CSRefreshInCharacterListPacket = 0x010;
        public const ushort CSDeleteCharacterPacket = 0x0c1;
        public const ushort CSCancelCharacterDeletePacket = 0x040;
        public const ushort CSSelectCharacterPacket = 0x09b;
        public const ushort CSNotifyInGamePacket = 0x0cd;
        public const ushort CSNotifyInGameCompletedPacket = 0x0b6;
        public const ushort CSChangeTargetPacket = 0x03b;
        public const ushort CSResurrectCharacterPacket = 0x0be;
        public const ushort CSCriminalLockedPacket = 0x099;
        public const ushort CSExpressEmotionPacket = 0x09f;
        public const ushort CSUnhangPacket = 0x04e;
        public const ushort CSChangeAppellationPacket = 0x0f8;
        public const ushort CSStartedCinemaPacket = 0x09a;
        public const ushort CSHSResponsePacket = 0x096;
        public const ushort CSBroadcastVisualOptionPacket = 0x012;
        public const ushort CSRestrictCheckPacket = 0x0fd;
        public const ushort CSICSMenuListPacket = 0x13f;
        public const ushort CSICSGoodsListPacket = 0x04d;
        public const ushort CSICSBuyGoodPacket = 0x0a0;
        public const ushort CSPremiumServiceBuyPacket = 0x0a9;
        public const ushort CSPremiumServieceMsgPacket = 0x091;
        public const ushort CSUnknownPacket_0x0a3 = 0x0a3;
        public const ushort CSUnknownPacket_0x035 = 0x035;
        public const ushort CSICSBuyAAPointPacket = 0x117;
        public const ushort CSRequestTencentFatigueInfoPacke = 0x0ce;
        public const ushort CSPremiumServiceListPacket = 0x086;
        public const ushort CSUnknownPacket_0x13d = 0x13d;
        public const ushort CSUnknownPacket_0x093 = 0x093;
        public const ushort CSUnknownPacket_0x050 = 0x050;
        public const ushort CSSpawnCharacterPacket = 0x0c3;
        public const ushort CSCreateCharacterPacket = 0x0cb;
        public const ushort CSEditCharacterPacket = 0x0ef;
        public const ushort CSTeleportEndedPacket = 0x075;
        public const ushort CSNotifySubZonePacket = 0x0e6;
        public const ushort CSSaveTutorialPacket = 0x041;
        public const ushort CSRequestUIDataPacket = 0x098;
        public const ushort CSSaveUIDataPacket = 0x073;
        public const ushort CSBeautyshopDataPacket = 0x03a;
        public const ushort CSUpdateDominionTaxRatePacket = 0x06e;
        public const ushort CSUpdateNationalTaxRatePacket = 0x0e7;
        public const ushort CSRequestCharBriefPacket = 0x014;
        public const ushort CSCreateExpeditionPacket = 0x053;
        public const ushort CSChangeExpeditionRolePolicyPacket = 0x0bf;
        public const ushort CSChangeExpeditionMemberRolePacket = 0x00f;
        public const ushort CSChangeExpeditionOwnerPacket = 0x03c;
        public const ushort CSRenameExpeditionPacket = 0x0a1;
        public const ushort CSDismissExpeditionPacket = 0x0df;
        public const ushort CSInviteToExpeditionPacket = 0x029;
        public const ushort CSLeaveExpeditionPacket = 0x08c;
        public const ushort CSKickFromExpeditionPacket = 0x0f0;
        public const ushort ChangeCVarPacket = 0x01f;
        public const ushort CSFactionImmigrationInvitePacket = 0x06c;
        public const ushort CSFactionImmigrationInviteReplyPacket = 0x100;
        public const ushort CSFactionImmigrateToOriginPacket = 0x04b;
        public const ushort CSFactionKickToOriginPacket = 0x08f;
        public const ushort CSFactionDeclareHostilePacket = 0x106;
        public const ushort CSFamilyKickPacket = 0x0f1;
        public const ushort CSFamilyInviteMemberPacket = 0x11a;
        public const ushort CSFamilyLeavePacket = 0x085;
        //public const ushort CSFamilyKickPacket = 0x038;
        public const ushort CSFamilyChangeTitlePacket = 0x070;
        public const ushort CSFamilyChangeOwnerPacket = 0x149;
        public const ushort CSFamilyReplyInvitationPacket = 0x05a;
        public const ushort CSAddFriendPacket = 0x063;
        public const ushort CSDeleteFriendPacket = 0x06b;
        public const ushort CSAddBlockedUserPacket = 0x08b;
        public const ushort CSDeleteBlockedUserPacket = 0x101;
        public const ushort CSInviteAreaToTeamPacket = 0x011;
        public const ushort CSInviteToTeamPacket = 0x0ca;
        public const ushort CSReplyToJoinTeamPacket = 0x066;
        public const ushort CSLeaveTeamPacket = 0x0e0;
        public const ushort CSKickTeamMemberPacket = 0x083;
        public const ushort CSMakeTeamOwnerPacket = 0x120;
        public const ushort CSConvertToRaidTeamPacket = 0x01d;
        public const ushort CSMoveTeamMemberPacket = 0x0b8;
        public const ushort CSDismissTeamPacket = 0x147;
        public const ushort CSSetTeamMemberRolePacket = 0x137;
        public const ushort CSSetOverHeadMarkerPacket = 0x07c;
        public const ushort CSAskRiskyTeamActionPacket = 0x0ff;
        public const ushort CSChangeLootingRulePacket = 0x12f;
        public const ushort CSUnknownPacket_0x0db = 0x0db;
        public const ushort CSUpdateActionSlotPacket = 0x016;
        public const ushort CSUsePortalPacket = 0x122;
        public const ushort CSUpgradeExpertLimitPacket = 0x0a4;
        public const ushort CSDowngradeExpertLimitPacket = 0x090;
        public const ushort CSExpandExpertPacket = 0x127;
        public const ushort CSUnknownPacket_0x06d = 0x06d;
        public const ushort CSCreateShipyardPacket = 0x071;
        public const ushort CSCreateHousePacket = 0x107;
        public const ushort CSUnknownPacket_0x01c = 0x01c;
        public const ushort CSConstructHouseTaxPacket = 0x022;
        public const ushort CSChangeHouseNamePacket = 0x027;
        public const ushort CSChangeHousePermissionPacket = 0x076;
        public const ushort CSRequestHouseTaxPacket = 0x0f5;
        public const ushort CSUnknownPacket_0x0b4 = 0x0b4;
        public const ushort CSSellHouseCancelPacket = 0x045;
        public const ushort CSDecorateHousePacket = 0x046;
        public const ushort CSSellHousePacket = 0x01b;
        public const ushort CSBuyHousePacket = 0x07d;
        public const ushort CSRemoveMatePacket = 0x00b;
        public const ushort CSChangeMateTargetPacket = 0x111;
        public const ushort CSChangeMateUserStatePacket = 0x047;
        public const ushort CSSpawnSlavePacket = 0x0a6;
        public const ushort CSDespawnSlavePacket = 0x001;
        public const ushort CSDestroySlavePacket = 0x121;
        public const ushort CSBindSlavePacket = 0x119;
        public const ushort CSDiscardSlavePacket = 0x034;
        public const ushort CSUnknownPacket_0x133 = 0x133;
        public const ushort CSUnknownPacket_0x013 = 0x013;
        public const ushort CSBoardingTransferPacket = 0x088;
        public const ushort CSTurretStatePacket = 0x0dc;
        public const ushort CSCreateSkillControllerPacket = 0x005;
        public const ushort CSJoinTrialAudiencePacket = 0x04c;
        public const ushort CSLeaveTrialAudiencePacket = 0x0f9;
        public const ushort CSUnMountMatePacket = 0x09d;
        public const ushort CSUnbondDoodadPacket = 0x10a;
        public const ushort CSInstanceLoadedPacket = 0x036;
        public const ushort CSApplyToInstantGamePacket = 0x07b;
        public const ushort CSCancelInstantGamePacket = 0x12e;
        public const ushort CSJoinInstantGamePacket = 0x023;
        public const ushort CSEnteredInstantGameWorldPacket = 0x03f;
        public const ushort CSLeaveInstantGamePacket = 0x118;
        public const ushort CSQuestUnkPacket = 0x0d9;
        public const ushort CSStartQuestContextPacket = 0x10e;
        public const ushort CSCompleteQuestContextPacket = 0x136;
        public const ushort CSDropQuestContextPacket = 0x021;
        public const ushort CSQuestTalkMadePacket = 0x077;
        public const ushort CSQuestStartWithPacket = 0x11e;
        public const ushort CSTryQuestCompleteAsLetItDonePacket = 0x110;
        public const ushort CSRestartMainQuestPacket = 0x134;
        public const ushort CSUnknownPacket_0x057 = 0x057;
        public const ushort CSUnknownPacket_0x0f4 = 0x0f4;
        public const ushort CSLearnSkillPacket = 0x052;
        public const ushort CSLearnBuffPacket = 0x0e8;
        public const ushort CSResetSkillsPacket = 0x0b2;
        public const ushort CSSwapAbilityPacket = 0x0d5;
        public const ushort CSRemoveBuffPacket = 0x104;
        public const ushort CSStopCastingPacket = 0x079;
        public const ushort CSDeletePortalPacket = 0x089;
        public const ushort CSUnknownPacket_0x078 = 0x078;
        public const ushort CSSetForceAttackPacket = 0x0e4;
        public const ushort CSStartSkillPacket = 0x05b;
        public const ushort CSCreateDoodadPacket = 0x0bc;
        public const ushort CSNaviTeleportPacket = 0x08e;
        public const ushort CSNaviOpenPortalPacket = 0x10d;
        public const ushort CSNaviOpenBountyPacket = 0x054;
        public const ushort CSSetLogicD = 0x032;
        public const ushort CSCleanupLogicLinkPacket = 0x0d7;
        public const ushort CSSelectInteractionExPacket = 0x00d;
        public const ushort CSChangeDoodadDataPacket = 0x113;
        public const ushort SetGameTypePacket = 0x03e;
        public const ushort CSBuyCoinItemPacket = 0x0ad;
        public const ushort CSChangeDoodadPhasePacket = 0x08d;
        public const ushort CSHangPacket = 0x132;
        public const ushort CSInteractNPCPacket = 0x0d4;
        public const ushort CSInteractNPCEndPacket = 0x0b0;
        public const ushort CSStartInteractionPacket = 0x00c;
        public const ushort CSSpecialtyRatioPacket = 0x058;
        public const ushort CSListSpecialtyGoodsPacket = 0x087;
        public const ushort CSUnknownPacket_0x082 = 0x082;
        public const ushort CSJoinUserChatChannelPacket = 0x06f;
        public const ushort CSLeaveChatChannelPacket = 0x0b5;
        public const ushort CSSendChatMessagePacket = 0x0b3;
        public const ushort CSRollDicePacket = 0x0d0;
        public const ushort CSSendMailPacket = 0x13c;
        public const ushort CSUnknownPacket_0x0ed = 0x0ed;
        public const ushort CSUnknownPacket_0x0fa = 0x0fa;
        public const ushort CSReadMailPacket = 0x0fb;
        public const ushort CSTakeAttachmentMoneyPacket = 0x00a;
        public const ushort CSTakeAllSelectedAttachmentPacket = 0x00e;
        public const ushort CSPayChargeMoneyPacket = 0x140;
        public const ushort CSDeleteMailPacket = 0x04f;
        public const ushort CSReportSpamPacket = 0x12a;
        public const ushort CSTakeAllAttachmentItemPacket = 0x059;
        public const ushort CSTakeAttachmentItemPacket = 0x095;
        public const ushort CSUnknownPacket_0x0c0 = 0x0c0;
        public const ushort CSRepairSlaveItemsPacket = 0x0c7;
        public const ushort CSRepairPetItemsPacket = 0x112;
        public const ushort CSAllowHousingRecoverPacket = 0x0c6;
        public const ushort CSUnknownPacket_0x0da = 0x0da;
        public const ushort CSUnknownPacket_0x0c8 = 0x0c8;
        public const ushort CSBuyPriestBuffPacket = 0x0b1;
        public const ushort CSChangeSlaveNamePacket = 0x0e5;
        public const ushort CSUseTeleportPacket = 0x10f;
        public const ushort CSAuctionPostPacket = 0x07a;
        public const ushort CSAuctionSearchPacket = 0x0c9;
        public const ushort CSAuctionMyBidListPacket = 0x0ee;
        public const ushort CSAuctionLowestPricePacket = 0x048;
        public const ushort CSCancelAuctionPacket = 0x0e9;
        public const ushort CSAuctionBidPacket = 0x13b;
        public const ushort CSExecuteCraftPacket = 0x04a;
        public const ushort CSSetLpManageCharacterPacket = 0x074;
        public const ushort CSChangeItemLookPacket = 0x094;
        public const ushort CSDestroyItemPacket = 0x12b;
        public const ushort CSSplitBagItemPacket = 0x02e;
        public const ushort CSSwapItemsPacket = 0x139;
        public const ushort CSSplitCofferItemPacket = 0x10c;
        public const ushort CSSwapCofferItemsPacket = 0x009;
        public const ushort CSExpandSlotsPacket = 0x0f3;
        public const ushort CSDepositMoneyPacket = 0x03d;
        public const ushort CSWithdrawMoneyPacket = 0x08a;
        public const ushort CSItemSecurePacket = 0x12d;
        public const ushort CSItemUnsecurePacket = 0x044;
        public const ushort CSEquipmentsSecurePacket = 0x116;
        public const ushort CSEquipmentsUnsecurePacket = 0x0b9;
        public const ushort CSRepairSingleEquipmentPacket = 0x0a8;
        public const ushort CSRepairAllEquipmentsPacket = 0x126;
        public const ushort CSChangeAutoUseAAPointPacket = 0x09c;
        public const ushort CSThisTimeUnpackItemPacket = 0x109;
        //public const ushort CSPremiumServiceBuyPacket = 0x068;
        public const ushort CSChangeMateEquipmentPacket = 0x0e1;
        public const ushort CSChangeSlaveEquipmentPacket = 0x0ec;
        public const ushort CSItemUccPacket = 0xfff;
        public const ushort CSLootOpenBagPacket = 0x067;
        public const ushort CSLootItemPacket = 0x10b;
        public const ushort CSLootCloseBagPacket = 0x0f6;
        public const ushort CSLootDicePacket = 0x037;
        public const ushort CSSellBackpackGoodsPacket = 0x07f;
        public const ushort CSSellItemsPacket = 0x0d8;
        public const ushort CSListSoldItemPacket = 0x081;
        public const ushort CSUnknownPacket_0x125 = 0x125;
        public const ushort CSStartTradePacket = 0x0e2;
        public const ushort CSCanStartTradePacket = 0x0f2;
        public const ushort CSCannotStartTradePacket = 0x061;
        public const ushort CSCancelTradePacket = 0x072;
        public const ushort CSPutupTradeItemPacket = 0x142;
        public const ushort CSTakedownTradeItemPacket = 0x01e;
        public const ushort CSTradeLockPacket = 0x0eb;
        public const ushort CSTradeOkPacket = 0x07e;
        public const ushort CSPutupTradeMoneyPacket = 0x143;
        public const ushort CSUnknownPacket_0x09e = 0x09e;
        // no such Packet
        public const ushort CSSetCraftingPayPacket = 0xfff;
        public const ushort CSReplyExpeditionInvitationPacket = 0xfff;
        public const ushort CSResetQuestContextPacket = 0xfff;
        public const ushort CSReturnMailPacket = 0xfff;
        public const ushort CSSaveDoodadUccStringPacket = 0xfff;
        public const ushort CSSearchListPacket = 0xfff;
        public const ushort CSSetLogicDoodadPacket = 0xfff;
        public const ushort CSSetTeamOfficerPacket = 0xfff;
        public const ushort CSTakeAttachmentSequentiallyPacket = 0xfff;
        public const ushort CSSpecialtyRecordLoadPacket = 0xfff;
        public const ushort CSAcceptCheatQuestContextPacket = 0xfff;
        public const ushort CSBidAuctionPacket = 0xfff;
        public const ushort CSBuyItemsPacket = 0xfff;
        public const ushort CSBuySpecialtyItemPacket = 0xfff;
        public const ushort CSChangeExpeditionSponsorPacket = 0xfff;
        public const ushort CSChangeSlaveTargetPacket = 0xfff;
        public const ushort CSCharDetailPacket = 0xfff;
        public const ushort CSSetupSecondPasswordPacket = 0xfff;
        public const ushort CSListCharacterPacket = 0xfff;
        public const ushort CSActiveWeaponChangedPacket = 0xfff;
        public const ushort CSListMailPacket = 0xfff;
        public const ushort CSListMailContinuePacket = 0xfff;
        public const ushort CSChangeHousePayPacket = 0xfff;
    }
}
