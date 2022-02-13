﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnboundLib;
using UnboundLib.Cards;
using UnityEngine;

namespace SlipomaIsaacCards.Cards

{
    class EvasiveManeuvers : CustomCard
    {
        public override void SetupCard(CardInfo cardinfo, Gun gun, ApplyCardStats cardstats, CharacterStatModifiers statModifiers, Block block);
        block.forceToAdd = -10f;
            statModifiers.health = 1,2f;
            block.cdAdd = 0.25f;
    UnityEngine.Debug.Log($"[{SlipomaIsaacCards.ModInitials}][Card] {GetTitle()} has been setup."); 
    
    {

    }
    public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats);
    UnityEngine.Debug.Log($"[{SlipomaIsaacCards.ModInitials}][Card] {GetTitle()} has been added to player {player.playerID}."); 
    {

    }
    public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterstat);
    UnityEngine.Debug.Log($"[{SlipomaIsaacCards.ModInitials}][Card] {GetTitle()} has been removed from player {player.playerID}.");
    {

    }
    protected override string GetTitle()
    {
        return "Evasive Maneuvers";
    }
    protected override string GetDescription()
    {
        return "jump backward when u block ";
    }
    protected override GameObject GetCardArt()
    {
        return null;
    }
    protected override CardInfo.Rarity GetRarity()
    {
        return CardInfo.Rarity.Common;
    }
    protected override CardInfoStat[] GetStats()
    {
        return new CardInfoStat[]
        {
            new CardInfoStat[]
            {
                positive = true,
                stat = "Health",
                amount = "+20%",
                simepleAmount = CardInfoStat.SimpleAmount.notAssigned
            },
            new CardInfoStat[]
            {
                positive = false,
                stat = "Block Cooldown",
                amount = "+0,25s",
                simepleAmount = CardInfoStat.SimpleAmount.notAssigned
            }
        };
    }
    protected override CardThemeColor.CardThemeColorType GetTheme()
    {
        return CardThemeColor.CardThemeColorType.ColdBlue;
    }
    public override string GetModName()
    {
            return "SlipomaIsaacCards.ModInitials";
    }
  }
}
