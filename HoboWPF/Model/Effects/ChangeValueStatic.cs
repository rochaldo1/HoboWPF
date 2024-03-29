﻿using HoboConsole.Model.Items;
using HoboConsolePrjct.Model.CheckValues;
using HoboConsolePrjct.Model.Hobo;
using HoboConsolePrjct.Model.Events;

namespace HoboConsolePrjct.Model.Effects
{
    public static class ChangeValueStatic
    {
        public static void EmotionalChange(IHobo hobo, IEntity entity)
        {
            if (entity is Food food)
            {
                hobo.EmotionalState += food.Pleasure;
                CheckValueStatic.EmotionalCheck(hobo);
            }
            if (entity is Drugs drugs)
            {
                hobo.EmotionalState += drugs.Pleasure;
                CheckValueStatic.EmotionalCheck(hobo);
            }
            if (entity is Medicine medicine)
            {
                hobo.EmotionalState += medicine.Pleasure;
                CheckValueStatic.EmotionalCheck(hobo);
            }
            if (entity is RealEstate estate)
            {
                hobo.EmotionalState += estate.Pleasure;
                CheckValueStatic.EmotionalCheck(hobo);
            }
            if (entity is Clothes clothes)
            {
                hobo.EmotionalState += clothes.Pleasure;
                CheckValueStatic.EmotionalCheck(hobo);
            }
            if (entity is Garbage garbage)
            {
                hobo.EmotionalState += garbage.Pleasure;
                CheckValueStatic.EmotionalCheck(hobo);
            }
            if (entity is EventHobo eventHobo)
            {
                hobo.EmotionalState += eventHobo.Pleasure;
                CheckValueStatic.EmotionalCheck (hobo);
            }
        }
        public static void EnergyChange(IHobo hobo, IEntity entity)
        {
            if (entity is Food food)
            {
                hobo.Energy += food.EnergyBoost;
                CheckValueStatic.EnergyCheck(hobo);
            }
            if (entity is Drugs drugs)
            {
                hobo.Energy += drugs.EnergyBoost;
                CheckValueStatic.EnergyCheck(hobo);
            }
            if (entity is Medicine medicine)
            {
                hobo.Energy += medicine.EnergyBoost;
                CheckValueStatic.EnergyCheck(hobo);
            }
            if (entity is EventHobo eventHobo)
            {
                hobo.Energy += eventHobo.EnergyBoost;
                CheckValueStatic.EnergyCheck(hobo);
            }
        }

        public static void HealthChange(IHobo hobo, IEntity entity)
        {
            if (entity is Food food)
            {
                hobo.Health += food.Healthy;
                CheckValueStatic.HealthCheck(hobo);
            }
            if (entity is Drugs drugs)
            {
                hobo.Health += drugs.Healthy;
                CheckValueStatic.HealthCheck(hobo);
            }
            if (entity is Medicine medicine)
            {
                hobo.Health += medicine.Healthy;
                CheckValueStatic.HealthCheck(hobo);
            }
            if (entity is Garbage garbage)
            {
                hobo.Health += garbage.Healthy;
                CheckValueStatic.HealthCheck(hobo);
            }
            if (entity is EventHobo eventHobo)
            {
                if((hobo.Energy < 20)) 
                {
                    eventHobo.HealthyCheap = 2 * eventHobo.Healthy;
                    hobo.Health += eventHobo.HealthyCheap;
                }
                if ((hobo.Satiation < 15))
                {
                    eventHobo.HealthyCheap = 2 * eventHobo.Healthy;
                    hobo.Health += eventHobo.HealthyCheap;
                }
                if ((hobo.EmotionalState < 10))
                {
                    eventHobo.HealthyCheap = 3 * eventHobo.Healthy;
                    hobo.Health += eventHobo.HealthyCheap;
                }
                else
                {
                    eventHobo.HealthyCheap = eventHobo.Healthy;
                    hobo.Health += eventHobo.Healthy;
                }
                CheckValueStatic.HealthCheck(hobo);
            }
        }

        public static void SatiationChange(IHobo hobo, IEntity entity)
        {
            if (entity is Food food)
            {
                hobo.Satiation += food.Nutrition;
                CheckValueStatic.SatiationCheck(hobo);
            }
            if (entity is EventHobo eventHobo)
            {
                hobo.Satiation += eventHobo.Nutrition;
                CheckValueStatic.SatiationCheck(hobo);
            }
        }
    }
}
