﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MassEffect.Interfaces;

namespace MassEffect.GameObjects.Projectiles
{
    abstract class Projectile:IProjectile
    {
        protected Projectile(int damage)
        {
            this.Damage = damage;
        }
        public int Damage { get; set; }
        public virtual void Hit(IStarship ship)
        {
            ship.Health -= this.Damage;
        }
    }
}
