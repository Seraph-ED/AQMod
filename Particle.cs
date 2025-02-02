﻿using AQMod.Common.Graphics.Particles;
using AQMod.Common.Graphics.Particles.Rendering;
using System.Collections.Generic;

namespace AQMod
{
    public static class Particle
    {
        public static readonly ParticleLayer<ParticleType> PreDrawProjectiles = new ParticleLayer<ParticleType>();
        public static readonly ParticleLayer<ParticleType> PostDrawPlayers = new ParticleLayer<ParticleType>();

        internal static void UpdateParticles<T>(List<T> particles) where T : ParticleType
        {
            for (int i = 0; i < particles.Count; i++)
            {
                if (!particles[i].Update())
                {
                    particles.RemoveAt(i);
                    i--;
                }
            }
        }

        internal static void DrawParticles<T>(List<T> particles) where T : ParticleType
        {
            for (int i = 0; i < particles.Count; i++)
            {
                particles[i].Draw();
            }
        }
    }
}