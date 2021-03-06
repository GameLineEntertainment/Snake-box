﻿using System;

namespace Snake_box
{
    public sealed class TurretPlant
    {
        #region Fields

        private TurretData _turretData;

        #endregion


        #region ClassLifeCycle

        public TurretPlant(TurretData turretData) => _turretData = turretData;

        #endregion


        #region Methods

        public TurretBaseAbs AddCannonTurret() => AddAndReturn(typeof(CannonTurret));

        public TurretBaseAbs AddMachineGunTurret() => AddAndReturn(typeof(MachineGunTurret));

        public TurretBaseAbs AddFrostGunTurret() => AddAndReturn(typeof(FrostGunTurret));

        public TurretBaseAbs AddLaserTurret() => AddAndReturn(typeof(LaserTurret));

        public TurretBaseAbs AddPlasmaTurret() => AddAndReturn(typeof(PlasmaTurret));

        public TurretBaseAbs AddShotgunTurret() => AddAndReturn(typeof(ShotgunTurret));

        public TurretBaseAbs AddFrostTurret() => AddAndReturn(typeof(FrostTurret));

        public TurretBaseAbs AddAirWaveTurret() => AddAndReturn(typeof(AirWaveTurret));

        private TurretBaseAbs AddAndReturn(Type turretType)
        {
            TurretBaseAbs newTurret;

            if (turretType == typeof(MachineGunTurret))
                newTurret = new MachineGunTurret().Build(_turretData.MachineGunTurret);
            else if (turretType == typeof(FrostGunTurret))
                newTurret = new FrostGunTurret().Build(_turretData.FrostGunTurret);
            else if (turretType == typeof(LaserTurret))
                newTurret = new LaserTurret().Build(_turretData.LaserTurret);
            else if (turretType == typeof(PlasmaTurret))
                newTurret = new PlasmaTurret().Build(_turretData.PlasmaTurret);
            else if (turretType == typeof(ShotgunTurret))
                newTurret = new ShotgunTurret().Build(_turretData.ShotgunTurret);
            else if (turretType == typeof(FrostTurret))
                newTurret = new FrostTurret().Build(_turretData.FrostTurret);
            else if (turretType == typeof(AirWaveTurret))
                newTurret = new AirWaveTurret().Build(_turretData.AirWaveTurret);
            else
                newTurret = new CannonTurret().Build(_turretData.CannonTurret);

            _turretData.TurretList.Add(newTurret);

            return newTurret;
        }

        #endregion
    }
}